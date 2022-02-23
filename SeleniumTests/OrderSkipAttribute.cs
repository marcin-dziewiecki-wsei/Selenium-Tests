// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace SeleniumTests
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        [Test, Order(2), Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            Assert.Ignore("Defect 1234");

            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";

            // Accept cookie popup
            driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]")).Click();
            Thread.Sleep(500);

            var emailTextField = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[1]/input"));
            emailTextField.SendKeys("Selenium C#");

            driver.Close();
            //Thread.Sleep(2000);
        }

        [Test, Order(1), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            var driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";

            // Accept cookie popup
            driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]")).Click();
            Thread.Sleep(500);

            var emailTextField = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[1]/input"));
            emailTextField.SendKeys("Selenium C#");

            driver.Close();
            //Thread.Sleep(2000);
        }

        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            var options = new EdgeOptions();
            options.BinaryLocation = @"./msedgedriver.exe";

            var driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";

            //Accept cookie popup
            driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]")).Click();
            Thread.Sleep(500);

            var emailTextField = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[1]/input"));
            emailTextField.SendKeys("Selenium C#");

            driver.Close();
            //Thread.Sleep(2000);
        }
    }
}
