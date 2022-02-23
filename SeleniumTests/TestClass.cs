// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTests.BaseClass;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTests
{
    [TestFixture]
    public class TestClass: BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            var emailTextField = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[1]/input"));
            emailTextField.SendKeys("Selenium C#");
            //Thread.Sleep(2000);
        }

        [Test]
        public void TestMethod2()
        {
            var emailTextField = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[1]/input"));
            emailTextField.SendKeys("Selenium C#");
            //Thread.Sleep(2000);
        }

        [Test]
        public void TestMethod3()
        {
            var emailTextField = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[1]/input"));
            emailTextField.SendKeys("Selenium C#");
            //Thread.Sleep(2000);
        }
    }
}
