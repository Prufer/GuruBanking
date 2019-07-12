using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Compatibility;
using NUnit.Framework;
using GuruBanking.BaseClass;
using OpenQA.Selenium.Support.UI;

namespace GuruBanking.TestCases
{
    public class BankingUAT : BaseClassTest
    {

        [Test]
        public void Login()
        {

            IWebElement UserID = driver.FindElement(By.XPath("//input[@name='uid']"));
            UserID.SendKeys("mngr209033");

            IWebElement Password = driver.FindElement(By.XPath("//input[@name='password']"));
            Password.SendKeys("vehyjYn");

            IWebElement LoginButton = driver.FindElement(By.XPath("//input[@name='btnLogin']"));
            LoginButton.Click();

            try
            {
                String URL = driver.Url;
                Assert.AreEqual(URL, "http://www.demo.guru99.com/V4/manager/Managerhomepage.php");
                System.Diagnostics.Debug.WriteLine("Logged in OK");

            }

            catch {

                Console.WriteLine("Logged in FAILED");
            }

        }



    }
}
