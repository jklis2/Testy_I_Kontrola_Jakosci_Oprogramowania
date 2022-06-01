using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpTutorials.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            IWebElement passwordTextField = driver.FindElement(By.XPath(".//*[@id='pass']"));
            passwordTextField.SendKeys("Selenium C#");

            Thread.Sleep(2000);
            var cookieButton = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[1]"));
            cookieButton.Click();
            var button = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[5]/a"));
            button.Click();
            Thread.Sleep(2000);
            IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(1);
            element.SelectByText("mar");
            element.SelectByValue("6");
        }

        [Test, Category("Rehression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);
        }
    }
}
