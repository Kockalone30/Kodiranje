using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DrugiSeleniumTest
{
    public class Program
    {
        IWebDriver drive = new ChromeDriver();
        static void Main(string[] args)
        {
         

                       
        }
        [SetUp]
        public void Inicijalizacija()
        {
            drive.Navigate().GoToUrl("https://www.saucedemo.com/");
            drive.Manage().Window.Maximize();
        }
        [Test]

        public void Test1()

        {
            IWebElement userName = drive.FindElement(By.Id("user-name"));
            userName.SendKeys("standard_user");

            IWebElement password = drive.FindElement(By.Id("password"));
            password.SendKeys("secret_sauce");

            IWebElement loginButton = drive.FindElement(By.Id("login-button"));
            loginButton.Submit();


        }

        [TearDown]
        public void Close()
        {
            drive.Close();
        }
    }
}
