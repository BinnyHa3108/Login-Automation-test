using Docker.DotNet.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
   public class Login : BaseTests
    {
       
        [Test]
        public void VerifyValidLogin()
        {
            // Open Login Page 

            driver.Url = "https://the-internet.herokuapp.com/login";
            //Enter username and password
            driver.FindElement(By.Id("username")).SendKeys("tomsmith");
            driver.FindElement(By.Id("password")).SendKeys("SuperSecretPassword!");
            driver.FindElement(By.XPath("//*[@class='radius']")).Click();
            driver.Navigate().Forward();

        }

        [Test]
        public void VerifyInvalid_username()
        {
            // Open Login Page 

            driver.Url = "https://the-internet.herokuapp.com/login";
            //Enter username and password
            driver.FindElement(By.Id("username")).SendKeys("tomsm");
            driver.FindElement(By.Id("password")).SendKeys("SuperSecretPassword!");
            driver.FindElement(By.XPath("//*[@class='radius']")).Click();
            Assert.That(driver.FindElement(By.Id("username")), Is.Not.EqualTo("tomsmith"));
            Console.WriteLine("Your username is invalid!");
        }
        [Test]
        public void VerifyInvalid_password()
        {
            // Open Login Page 

            driver.Url = "https://the-internet.herokuapp.com/login";
            //Enter username and password
            driver.FindElement(By.Id("username")).SendKeys("tomsmith");
            driver.FindElement(By.Id("password")).SendKeys("SuperSecr");
            driver.FindElement(By.XPath("//*[@class='radius']")).Click();
            Assert.That(driver.FindElement(By.Id("password")), Is.Not.EqualTo("SuperSecretPassword!"));
            Console.WriteLine("Your password is invalid!");
        }
        [Test]
        public void VerifyEmpty()
        {
            // Open Login Page 

            driver.Url = "https://the-internet.herokuapp.com/login";
            //Enter username and password
            driver.FindElement(By.Id("username")).SendKeys("");
            driver.FindElement(By.Id("password")).SendKeys("");
            driver.FindElement(By.XPath("//*[@class='radius']")).Click();
            Assert.That(driver.FindElement(By.Id("username")), Is.Not.EqualTo("tomsmith"));
            Assert.That(driver.FindElement(By.Id("password")), Is.Not.EqualTo("SuperSecretPassword!"));
            Console.WriteLine("Your username is invalid!");
        }

    }
}
