using KafKafProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafKafProject.PageObject
{
    public class YourBusinessYourWayPage
    {
        public IWebDriver driver;

        public YourBusinessYourWayPage()
        {
            driver = BaseTest.driver;
        }

        IWebElement clickOnStartYourBusiness => driver.FindElement(By.XPath("//li[@id='menu-item-6077']//a[@class='menu-link'][normalize-space()='Start Your Business']"));
        IWebElement assertStartYourBusinessPage => driver.FindElement(By.XPath("//h1[normalize-space()='Start Your Business']"));
        IWebElement scrollToElement => driver.FindElement(By.XPath("//h2[normalize-space()='Your business, your way']"));
        IWebElement assertYourBusinessYourWaySection => driver.FindElement(By.XPath("//h2[normalize-space()='Your business, your way']"));


        public void UserClickOnStartYourBusiness()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", clickOnStartYourBusiness);
        }

        public string AssertStartYourBusinessPage()
        {
            return assertStartYourBusinessPage.Text;
        }

        public void ScrollToElement()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollToElement);
        }

        public string AssertYourBusinessYourWaySection()
        {
            return assertYourBusinessYourWaySection.Text;
        }
    }
}
