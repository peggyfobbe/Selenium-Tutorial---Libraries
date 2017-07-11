using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace FirstTestCase.Selenium_Basics
{
    class DriverCommands_2
    {
         [Test]

        public void DriverCommands2()
        { 
        IWebDriver driver = new ChromeDriver();

            // Launch the ToolsQA website

            driver.Url = "http://demoqa.com/frames-and-windows/";

            driver.FindElement(By.XPath(".//*[@id='tabs-1']/div/p/a")).Click();

            driver.Close();
        }
    }
}
