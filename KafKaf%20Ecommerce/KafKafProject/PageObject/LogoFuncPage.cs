using KafKafProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurposeProjects.PageObjects
{
    public class PgObjects
    {
        public IWebDriver driver;

        private By clickJuice = By.XPath("//*[@id=\"post-3610\"]/div/div[3]/div/div[2]/ul/li[1]/div[1]/a/img");
        private By clickLogo = By.XPath("//*[@id=\"ast-desktop-header\"]/div/div/div/div/div[1]/div[1]/div/span/a/img");


        public PgObjects()
        {
            driver = BaseTest.driver;
        }


        public void ClickOnJuice()
        {
            driver.FindElement(clickJuice).Click();
        }

        public void ClickOnlogo()
        {
            driver.FindElement(clickLogo).Click();
        }

        public bool RedirectedToHomePage()
        {
            return driver.Url.Contains("https://kafkaf.reteicons.com/");
        }


    }
}
