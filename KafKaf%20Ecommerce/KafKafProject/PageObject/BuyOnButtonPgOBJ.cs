using KafKafProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurposeProjects.PageObjects
{
    public class BuyOnButtonPgObj
    {
        public IWebDriver driver;

        private By clickHerbalifeButton = By.XPath("//*[@id=\"post-3610\"]/div/div[1]/div/div[2]/div[2]/div/div[1]/div/a/div");
        private By clickJuiceplusButton = By.XPath("//*[@id=\"post-3610\"]/div/div[1]/div/div[2]/div[2]/div/div[2]/div/a/div/strong");


        public BuyOnButtonPgObj()
        {
            driver = BaseTest.driver;
        }

        public void clickherbalifebutton()
        {
            driver.FindElement(clickHerbalifeButton).Click();
        }

        public bool DirectToHebalifeWebsite()
        {
            return driver.Url.Contains("https://kafkaf.herbalife.com/en-gb/u");
        }

        public void clickjuiceplusbutton()
        {
            driver.FindElement(clickJuiceplusButton).Click();
        }

        public bool DirectToJuiceplusWebsite()
        {
            return driver.Url.Contains("https://uk.juiceplus.com/");
        }
    }
}
