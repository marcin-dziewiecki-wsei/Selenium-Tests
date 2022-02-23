using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";

            // Accept cookie popup
            driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]")).Click();
        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
