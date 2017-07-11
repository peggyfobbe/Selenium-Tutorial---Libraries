using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium_Tutorial.Libraries;

namespace Selenium_Tutorial.Libraries
{
    class TestTeardown
    {
     
        public static void TearDown()
        {
            CommonFunctions.driver.Close();
        }
            
    }
}
