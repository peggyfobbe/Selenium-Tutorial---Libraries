using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace FirstTestCase.Selenium_Basics
{
    class WebElements
    {
 [Test]
        public void PracticeExercise1()
        {

            //http://toolsqa.com/selenium-webdriver/c-sharp/findelement-and-findelements-commands-in-c/
            //Practice Exercise 1 Practice Exercise 1
            //Launch new Browser
            //Open URL http://toolsqa.wpengine.com/automation-practice-form/
            //Type Name &Last Name(Use Name locator)
            //Click on Submit button (Use ID locator)

            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";
            driver.FindElement(By.Name("firstname")).SendKeys("Peggy");
            driver.FindElement(By.Name("lastname")).SendKeys("Fobbe");
            driver.FindElement(By.Id("submit")).Click();
        }

  [Test]
        public void PracticeExercise2()
        {

            //Launch new Browser

            IWebDriver browser = new ChromeDriver();

            //Open URL http://toolsqa.wpengine.com/automation-practice-form/

            browser.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            //Click on the Link “Partial Link Test” (Use ‘PatialLinkTest’ locator and search by ‘Partial’ word)

            browser.FindElement(By.PartialLinkText("Partial")).Click();

            //Identify Submit button with ‘TagName’, convert it in to string and print it on the console

            string button = browser.FindElements(By.TagName("button")).ToString();

            //Click on the Link “Link Test” (Use ‘LinkTest’ locator)

            browser.FindElement(By.LinkText("Link Test")).Click();



        }
          
    }
}
