using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class BaseTests
    {
        
            public IWebDriver driver;

            [SetUp]
            public void startBrowser()
            {
           

                driver = new ChromeDriver("C:\\Users\\HaThiBi\\Downloads\\chromedriver_win32");
            }

          

            [TearDown]
             public void closeBrowser()

            {
                System.Threading.Thread.Sleep(4000);
                driver.Close();
            }

        }
    }


