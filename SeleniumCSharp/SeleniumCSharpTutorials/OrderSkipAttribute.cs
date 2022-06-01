using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpTutorials.BaseClass;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class OrderSkipAttribute
    {

        [Test, Order(2), Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            Assert.Ignore("Defect1234");

            IWebDriver driver = new EdgeDriver();

            driver.Url = "https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.Id(".//[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            emailTextField.Submit();
            driver.Close();


        }
        [Test, Order(1), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();

        }
        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();

        }
    }
}