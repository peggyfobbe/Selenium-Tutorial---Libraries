using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;


namespace FirstTestCase.Selenium_Basics
{
    class DriverCommands
    {
        [Test]
         public void Test()
        {
        IWebDriver driver = new ChromeDriver();

            // Launch ToolsQA Website

            driver.Url = "http://www.store.demoqa.com";
            String title = driver.Title;
            int titleLength = driver.Title.Length;

            Console.WriteLine("The title of the page is "+title);
            Console.WriteLine("The length of the page is "+titleLength);

            String pageUrl = driver.Url;
            int UrlLenth = pageUrl.Length;

            Console.WriteLine("The page url is "+pageUrl);
            Console.WriteLine("The length of the page url is "+UrlLenth);

            string pageSource = driver.PageSource;
            int sourceLength = pageSource.Length;

            Console.WriteLine("The page source is "+pageSource);
            Console.WriteLine("The length of the page source is "+sourceLength);

            driver.Close();

            // http://toolsqa.com/selenium-webdriver/c-sharp/iwebdriver-browser-commands-in-c-sharp/
        }
    }
}
