using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;

namespace password_manager
{
    class logoScraper
    {
        public static void scrapeLogo(string inputString) {
            //Clipboard.SetText($"\"{filePath.getRootPath()}\\python scraper\\scraper.py\" \"{inputString}\"");
            var psi = new ProcessStartInfo
            {
                FileName = "python", 
                //Arguments = $"\"C:\\Users\\Intel\\source\\repos\\password manager\\password manager\\python scraper\\scraper.py\" \"{inputString}\"", // pass inputString as an arg
                Arguments = $"\"{filePath.getRootPath()}\\python scraper\\scraper.py\" \"{inputString}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            using (var process = Process.Start(psi))
            {
                string output = process.StandardOutput.ReadToEnd();
                string errors = process.StandardError.ReadToEnd();

                process.WaitForExit();

                Console.WriteLine("Python output: " + output);
                if (!string.IsNullOrEmpty(errors))
                {
                    Console.WriteLine("Python errors: " + errors);
                }
            }
        }

        public static Task scrapeLogoAsync(string inputString)
        {
            return Task.Run(() =>
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "python",
                    //Arguments = $"\"C:\\Users\\Intel\\source\\repos\\password manager\\password manager\\python scraper\\scraper.py\" \"{inputString}\"", // pass inputString as an arg
                    Arguments = $"\"{filePath.getRootPath()}\\python scraper\\scraper.py\" \"{inputString}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (var process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string errors = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    Console.WriteLine("Python output: " + output);
                    if (!string.IsNullOrEmpty(errors))
                    {
                        Console.WriteLine("Python errors: " + errors);
                    }
                }
            });
        }
    }
}
