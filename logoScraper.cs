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
            /*IWebDriver webDriving = new ChromeDriver();
            string linkForImage = "https://duckduckgo.com/?q=" + inputString + "-logo-png";
            webDriving.Navigate().GoToUrl(linkForImage);
            WebDriverWait wait = new WebDriverWait(webDriving, TimeSpan.FromSeconds(10)); //system("pause")
            //imgLink = webDriving.find_element(By.XPATH, "//img[@loading = 'lazy']")
            IWebElement imgLink = webDriving.FindElement(By.XPath("//img[@loading = 'lazy']"));
            
            string imgSrc = imgLink.GetAttribute("src");

            using (HttpClient otherClient = new HttpClient())
            {
                byte[] data = await otherClient.GetByteArrayAsync(imgSrc);
                File.WriteAllBytes(Path.Combine(Application.StartupPath, "img", "icons", inputString + ".png"), data);
            }

            webDriving.Quit();*/

            var psi = new ProcessStartInfo
            {
                FileName = "python", // or full path to python.exe
                Arguments = $"\"C:\\Users\\Intel\\source\\repos\\password manager\\password manager\\python scraper\\scraper.py\" \"{inputString}\"", // pass inputString as an arg
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
                    Console.WriteLine("Python errors: " + errors);
            }
        }

    }
}
