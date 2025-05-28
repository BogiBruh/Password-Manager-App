using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_manager
{
    public partial class encryptionInputForm : Form
    {
        public static string json = "";
        public static byte[] encryptedToWrite;
        public encryptionInputForm()
        {
            InitializeComponent();
        }

        private void encryptionInputForm_Load(object sender, EventArgs e)
        {
            cnfButton.DialogResult = DialogResult.OK;
        }
        
        public void encryptOrDecrypt(string encDec, string jsonSerializedData)
        {
            switch (encDec)
            {
                case "encrypt":
                    json = jsonSerializedData;
                    label1.Text = "Please enter a phrase:\n(This is to ensure only you can use the backup.Do not share the phrase with anyone.\nDont forget the phrase, as the backup will be useless)";
                    cnfButton.Click += (sender, e) => encryptBtn(sender, e);
                    break;
                case "decrypt":
                    label1.Text = "Please enter the phrase you used to back up your profiles:";
                    cnfButton.Click += (sender, e) => decryptBtn(sender, e);
                    break;
                default:
                    MessageBox.Show("wow! all errors!");
                    break;
            }
        }

        private void encryptBtn(object sender, EventArgs e)
        {
            encryptedToWrite = backup.encryption(phraseTxtBox.Text, json);
            this.Close();
        }
        private void decryptBtn(object sender, EventArgs e)
        {
            //dunno if i have to do anything more?
            this.Close();
        }

        public byte[] getEncryptedData()
        {
            return encryptedToWrite;
        }

        public string getDecryptionKeyStr()
        {
            return phraseTxtBox.Text;
        }
    }
}
