using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Selenium_Tutorial.Libraries;


namespace FirstTestCase.Selenium_Basics
{
    class BrowserCommands
    {
        [Test]
        public void BrowserCommand()
        {
            
            CommonFunctions.OpenBrowser("CH","http://demoqa.com");
            CommonFunctions.OpenBrowser("IE", "http://demoqa.com");
            CommonFunctions.OpenBrowser("FF", "http://demoqa.com");
            CommonFunctions.OpenBrowser("Safari", "http://demoqa.com");

            //IWebDriver driver = new ChromeDriver();

            //Open DemoQA.com Website

            //driver.Navigate().GoToUrl("http://demoqa.com");

            //driver.FindElement(By.XPath(".//*[@id='menu-item-374']/a")).Click();
            //driver.Navigate().Back();
            //driver.Navigate().Forward();
            //driver.Navigate().GoToUrl("http://demoqa.com");
            //driver.Navigate().Refresh();
            //driver.Close();

        }
        

        



    }
}
