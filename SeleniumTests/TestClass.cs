// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumTests.BaseClass;
using System.Threading;

namespace SeleniumTests
{
    [TestFixture]
    public class TestClass: BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            var emailTextField = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div[2]/div/div/div[1]/form/div[1]/div[2]/div/div[1]/input"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(500);

            var monthDropdownList = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div[2]/div/div/div[1]/form/div[1]/div[5]/div[2]/span/span/select[2]"));
            var element = new SelectElement(monthDropdownList);
            element.SelectByIndex(4);
            element.SelectByText("gru");
            element.SelectByValue("7");

            //Thread.Sleep(2000);
        }

        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            var emailTextField = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div[2]/div/div/div[1]/form/div[1]/div[2]/div/div[1]/input"));
            emailTextField.SendKeys("Selenium C#");
            //Thread.Sleep(2000);
        }

        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            var emailTextField = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div[2]/div/div/div[1]/form/div[1]/div[2]/div/div[1]/input"));
            emailTextField.SendKeys("Selenium C#");
            //Thread.Sleep(2000);
        }
    }
}
