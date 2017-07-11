using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Selenium_Tutorial.Libraries;
using System;
using System.Linq;
using System.Collections.Generic;


namespace FirstTestCase.Selenium_Basics
{
    class checkboxradionbtn
    {

        [Test]

        public void Challenge1()
        {

            //Open Tools SQA Practice Automation Form
            //Launch new browser


            CommonFunctions.OpenBrowser("CH", "http://toolsqa.wpengine.com/automation-practice-form/");
            //Challegene One - Select the deselected Radio Button (female) for category Sex (Use IsSelected Method)

            IList<IWebElement> RadioBtn = CommonFunctions.driver.FindElements(By.Name("sex"));

            //Create a boolean variable which will the value (True / False)

            bool bValue = false;

            //This statement will return True, in case of first Radio Button is selected

            bValue = RadioBtn.ElementAt(0).Selected;

            //This will check that if the bValue is True means if the frist radio button is selected

            if (bValue == true)

            {
                //This will select the Second Radio Button, if the first radio button is selected by default
                RadioBtn.ElementAt(0).Click();
            }
            else
            {
                // if the first radio button is not selected by default, the first will be selected

                RadioBtn.ElementAt(1).Click();

            }

        }

            [Test]

        public void Challenge2()
        {
            //Challenge Two - Select the Third radio button for category 'Years of Exp' (Use ID attribute to select radio button

            IWebElement RadioBtn_Exp = CommonFunctions.driver.FindElement(By.Id("exp-2"));
            RadioBtn_Exp.Click();

        }

        [Test]

        public void Challenge3()
        {
            //Challenge Three – Check the Check Box ‘Automation Tester’ for category ‘Profession'( Use Value attribute to match the selection)


            //Find the checkbox or radio button element by Name

            IList<IWebElement> chkbox_Profession = CommonFunctions.driver.FindElements(By.Name("profession"));

            //This will tell you the number of checkboxes that are present

            int iSize = chkbox_Profession.Count;

            //Start the loop from first checkbox to last checkbox
            for (int i = 0; i < iSize; i++)
            {
                string Value = chkbox_Profession.ElementAt(i).GetAttribute("value");

                if (Value.Equals("Automation Tester"))
                {
                    //Select the checkbox if the value of the checkbox is the same as what you are looking for
                    chkbox_Profession.ElementAt(i).Click();

                    //This will take the execution out of loop
                    break;
                }
            }TestTeardown.TearDown();
            
        }
     

    
    }
}
    

    
    





