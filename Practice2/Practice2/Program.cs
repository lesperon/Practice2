﻿using OpenQA.Selenium;
using Practice2.BaseTest;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program : BaseClass
    {
        static void Main(string[] args)
        {

            OpenPageRegisterClick();


            EnterFirstLastName(By.Name("firstName"), ConfigurationManager.AppSettings.Get("FirstName"));
            EnterFirstLastName(By.Name("lastName"), ConfigurationManager.AppSettings.Get("LastName"));

            driver.FindElement(By.Name("register")).Click();
        }
    }
}
