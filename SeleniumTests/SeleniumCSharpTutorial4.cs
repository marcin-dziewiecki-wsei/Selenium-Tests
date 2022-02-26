using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTests
{
    [TestFixture]
    public class SeleniumCSharpTutorial4
    {
        [Test]
        [Author("Marcin Dziewięcki", "dziewieckimarcin@gmail.com")]
        [Description("Facebook ligin Verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test(String urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com/";
                driver.Url = urlName;

                // Accept cookie popup
                driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]")).Click();
                Thread.Sleep(500);

                var emailTextField = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[1]/input"));
                //var emailTextField = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[1]/abcd"));
                emailTextField.SendKeys("Selenium C#");

                driver.Quit();
            }
            catch (Exception ex)
            {
                var ts = driver as ITakesScreenshot;
                var screenshot = ts.GetScreenshot();
                var projectDir = $"{System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("file:\\", "")}/../../Screenshots/";
                screenshot.SaveAsFile($"{projectDir}screenshot-{DateTime.Now.ToString("s").Replace(":", "_")}.jpeg", ScreenshotImageFormat.Jpeg);

                Console.WriteLine(ex.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
            
        }

        static IList DataDrivenTesting()
        {
            var list = new ArrayList();
            list.Add("https://www.facebook.com/");
            //list.Add("https://www.youtube.com/");
            //list.Add("https://www.gmail.com/");

            return list;
        }

        //[Test]
        //[Author("Marcin Dziewięcki", "dziewieckimarcin@gmail.com")]
        //[Description("Facebook ligin Verify")]
        //public void Test2()
        //{
        //    var driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://www.facebook.com/";

        //    // Accept cookie popup
        //    driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]")).Click();
        //    Thread.Sleep(500);

        //    var emailTextField = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[1]/input"));
        //    emailTextField.SendKeys("Selenium C#");

        //    driver.Quit();
        //}
    }
}
