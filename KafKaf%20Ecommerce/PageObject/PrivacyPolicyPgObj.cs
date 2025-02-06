using KafKafProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurposeProjects.PageObjects
{
    public class PrivacyPolPgObj
    {
        public IWebDriver driver;

        private By clickPricavyPolicyButton = By.XPath("//*[@id=\"menu-item-3781\"]/a ");


        public PrivacyPolPgObj()
        {
            driver = BaseTest.driver;
        }

        public void UserClickPrivacyPolicyButton()
        {
            driver.FindElement(clickPricavyPolicyButton).Click();
        }

        public bool UserDirectedToPrivacyPolicyPage()
        {
            return driver.Url.Contains("https://kafkaf.reteicons.com/privacy-policy/");
        }
    }
}
