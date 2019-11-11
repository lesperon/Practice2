using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace Practice2.BaseTest
{
    class BaseClass
    {
        public static string webaddress = ConfigurationManager.AppSettings.Get("url");
        public  static IWebDriver driver;

        public static void OpenPageRegisterClick ()
        {
            driver = new ChromeDriver();
            driver.Url = webaddress;

            driver.FindElement(By.LinkText("REGISTER")).Click();
        }

        public static void EnterFirstLastName (By by, string pstrText)
        {

            driver.FindElement(by).SendKeys(pstrText);

            
        }


    }
}
