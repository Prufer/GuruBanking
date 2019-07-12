using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuruBanking.BaseClass
{
   public  class BaseClassTest
    {

        public IWebDriver driver;
        [OneTimeSetUp]

        public void Open()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.demo.guru99.com/V4";


        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }


    }
}
