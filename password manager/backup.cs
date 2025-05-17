using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;

namespace password_manager
{
    class backup
    {
        private static List<byte[]> keygen(string backupUserString)
        {
            List<byte[]> returnList = new List<byte[]>();
            byte[] pbkSalt = new byte[16];
            byte[] keyPass;
            int runs = 100000;

            using(var byteRng = RandomNumberGenerator.Create()) //generates exactly pbkSalt.lenght bytes, and disposes byteRng from memory as soon as its done
            {
                byteRng.GetBytes(pbkSalt);
            }
           // MessageBox.Show(Convert.ToBase64String(pbkSalt));
            using(var pbk = new Rfc2898DeriveBytes(backupUserString, pbkSalt, runs, HashAlgorithmName.SHA256))
            {
                /*fuck me in the ass if i understood this right, the backupUserString is being used to create a key to
                 * actually encrypt the data. Salt protects against "rainbow attacks", and runs is how many times this will run
                 * who knew cybersecurity would be so fucked :)
                 */
                keyPass = pbk.GetBytes(32);

               // MessageBox.Show($"Generated key: {Convert.ToBase64String(keyPass)}| Generated from string:{backupUserString}");
            }

            returnList.Add(pbkSalt);
            returnList.Add(keyPass);
            return returnList;
        }

        public static byte[] encryption(string userBackupStr, string passwordList)
        {
            /* as far as i understand, all the nested usings are handling the bytes in streams, both normal memory streams and
             * cryptographic memory streams(from aes?) to encode the data.
             * TODO: understand and explain it better
             */

            List<byte[]> dataList = keygen(userBackupStr);
            byte[] iv = new byte[16]; //initialization vector - thats as far as i understand it
            byte[] salt = dataList[0];
            byte[] key = dataList[1];
            byte[] memStreamArray;

            using(var byteRng = RandomNumberGenerator.Create())
            {
                byteRng.GetBytes(iv);
            }

            using(var aesEncryption = Aes.Create())
            {
                aesEncryption.Key = key;
                aesEncryption.IV = iv;


                using(var memStream = new MemoryStream())
                {
                    using(var encryptor = aesEncryption.CreateEncryptor())
                    {
                        using(var cryptoStrim = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
                        {
                            using(var strimWriter = new StreamWriter(cryptoStrim))
                            {
                                strimWriter.Write(passwordList);
                                strimWriter.Close();
                                memStreamArray = memStream.ToArray();

                                //MessageBox.Show("StreamWriter output: " + Convert.ToBase64String(memStreamArray));
                            }
                        }
                    }
                }
            }

            byte[] returnByteArray = salt.Concat(iv).Concat(memStreamArray).ToArray();
            return returnByteArray;
        }

        public static string decryption(string userBackupString, byte[] encryptedData)
        {
            /* (same as encryption comment, just backwards) */
            byte[] salt = new byte[16];
            byte[] iv = new byte[16];
            byte[] decryptPls = new byte[encryptedData.Length - 32];
            int runs = 100000;

            Buffer.BlockCopy(encryptedData, 0, salt, 0, 16);
            Buffer.BlockCopy(encryptedData, 16, iv, 0, 16);
            Buffer.BlockCopy(encryptedData, 32, decryptPls, 0, decryptPls.Length);

            var key = new Rfc2898DeriveBytes(userBackupString, salt, runs, HashAlgorithmName.SHA256).GetBytes(32);


            using (var aesEncryption = Aes.Create())
            {
                aesEncryption.Key = key;
                aesEncryption.IV = iv;


                using (var memStream = new MemoryStream(decryptPls))
                {
                    using (var decryptor = aesEncryption.CreateDecryptor())
                    {
                        using (var cryptoStrim = new CryptoStream(memStream, decryptor, CryptoStreamMode.Read))
                        {
                            using (var strimReader = new StreamReader(cryptoStrim))
                            {
                                return strimReader.ReadToEnd();
                            }
                        }
                    }
                }
            }
        }
    }
}
