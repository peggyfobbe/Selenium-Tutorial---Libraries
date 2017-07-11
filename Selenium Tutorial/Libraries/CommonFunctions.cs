using System;
using System.Linq;
using System.Net;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using NUnit.Framework;
using NUnit.Framework.Internal;

/* include this line in the using section of the script
  using Selenium_Tutorial.Libraries;
 */

namespace Selenium_Tutorial.Libraries
{
    class CommonFunctions
    {
      
        public static IWebDriver driver;

        /*This function will launch the browser you specify and go to the url you specify
         BrowserName = "CH" for Chrome, "FF" for Firefox, "IE" for Internet Explorer, "Safari" for Safari
         Example syntax:  CommonFunctions.OpenBrowser("CH","http://demoqa.com");
         */

public static IWebDriver OpenBrowser(string BrowserName, string url)

        {
            fn_LaunchBrowser(BrowserName);
            fn_OpenUrl(url);


            return driver;
        }
        public static void fn_OpenUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }
        public static IWebDriver fn_LaunchBrowser(string BrowserName)
        {

            if (BrowserName.Equals ("CH"))
            {
                System.Environment.SetEnvironmentVariable("webriver.chrome.driver", "C:\\Users\\peggy\\Documents\\Visual Studio 2015\\Projects\\Selenium Tutorial\\packages\\Selenium.WebDriver.ChromeDriver.2.26.0\\driver\\win32\\chromedriver.exe");
                driver = new ChromeDriver();

            }
            else if (BrowserName.Equals("FF"))
            {
                driver = new FirefoxDriver();

            }
            else if (BrowserName.Equals("IE"))
            {
                driver = new InternetExplorerDriver();
            }
            else if (BrowserName.Equals("Safari"))
            {
                driver = new SafariDriver();
            }
            return driver;
        }
}
    //    /* This function allows you to take screenshots for analysing failures
    //     */

    //    public static String fn_TakeSnapshot(WebDriver driver, String DestFilePath) throws IOException
    //    {
    //        String TS=fn_GetTimeStamp();
    //        TakesScreenshot tss=(TakesScreenshot) driver;
    //        File srcfileObj= tss.getScreenshotAs(OutputType.FILE);
    //        DestFilePath=DestFilePath+TS+".png";
    //        File DestFileObj=new File(DestFilePath);
    //    FileUtils.copyFile(srcfileObj, DestFileObj);
    //return DestFilePath;
    //}

    //public static String fn_GetTimeStamp()
    //    {
    //        DateFormat DF = DateFormat.getDateTimeInstance();
    //        Date dte = new Date();
    //        String DateValue = DF.format(dte);
    //        DateValue = DateValue.replaceAll(":", "_");
    //        DateValue = DateValue.replaceAll(",", "");
    //        return DateValue;
    //    }

    ////select the dropdown using "select by visible text", so pass VisibleText as 'Yellow' to funtion
    //public static void fn_Select(IWebElement WE, String VisibleText)
    //{
    //    Select selObj = new Select(WE);
    //    selObj.selectByVisibleText(VisibleText);
    //}

    ////select the dropdown using "select by index", so pass IndexValue as '2'
    //public static void fn_Select(IWebElement WE, int IndexValue)
    //{
    //    Select selObj = new PLSelect(WE);
    //    selObj.selectByIndex(IndexValue);
    //}

    ////select the dropdown using "select by value", so pass Value as 'thirdcolor'
    //public static void fn_Select(IWebElement WE, String Value)
    //{
    //    Select selObj = new Select(WE);
    //    selObj.selectByValue(Value);
    
   
}
