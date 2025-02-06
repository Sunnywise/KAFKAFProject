using KafKafProject.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V129.Profiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafKafProject.PageObject
{
    public class OurPromiseToYouPage
    {
        public IWebDriver driver;
        public OurPromiseToYouPage()
        {
            driver = BaseTest.driver;
        }

        private IWebElement startBusinessBtn => driver.FindElement(By.XPath("(//a[@class='menu-link'][normalize-space()='Start Your Business'])[1]"));
        private IWebElement assertStartBusiness => driver.FindElement(By.XPath("//h1[normalize-space()='Start Your Business']"));
        private IWebElement scrollToElement => driver.FindElement(By.XPath("(//img[@class='wp-image-5893'])[1]"));
        private IWebElement assertSection => driver.FindElement(By.XPath("//strong[contains(text(),'Our promise to you​')]"));


        //Methods
        public void UserClicksOnStartBusinessButton()
        {
            startBusinessBtn.Click();   
        }

        public string AssertStartYourBusinessPage()
        {
            return assertStartBusiness.Text;
        }

        public void UserScrollsToSection()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollToElement);
        }

        public string AssertOnOurPromiseToYouPage()
        {
            return assertSection.Text;
        }

    }
}
