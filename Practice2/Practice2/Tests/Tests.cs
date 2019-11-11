using NUnit.Framework;
using OpenQA.Selenium;
using Practice2.BaseTest;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Tests
{
    class Tests : BaseClass
    {

        [Test]
        public static void Test1()
        {

            OpenPageRegisterClick();

        }

        [Test]
        public static void Test2()
        {

            EnterFirstLastName(By.Name("firstName"), ConfigurationManager.AppSettings.Get("FirstName"));
            EnterFirstLastName(By.Name("lastName"), ConfigurationManager.AppSettings.Get("LastName"));

            driver.FindElement(By.Name("register")).Click();
        }

    }
}
