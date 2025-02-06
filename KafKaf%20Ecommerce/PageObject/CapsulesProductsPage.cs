using KafKafProject.Hooks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafKafProject.PageObject
{
    public class CapsulesProductsPage
    {
        public IWebDriver driver;
        public CapsulesProductsPage()
        {
            driver = BaseTest.driver;
        }

        private IWebElement categoryHovering => driver.FindElement(By.XPath("(//a[contains(text(), 'Categories')])[1]"));
        private IWebElement selectCapsules => driver.FindElement(By.XPath("(//*[contains(text(), 'Capsules')])[1]"));
        private IWebElement assertCapsules => driver.FindElement(By.XPath("//h1[normalize-space()='Capsules']"));
        private IWebElement scrollToView => driver.FindElement(By.XPath("//*[@id='main']/div/ul/li[4]/div[2]/a"));


        public void UserHoversOnTheCapsulesButton()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(categoryHovering).Perform();
        }

        public void UserClicksCapsules()
        {
            selectCapsules.Click();
        }

        public string CapsulesPageIsDisplayed()
        {
            return assertCapsules.Text;
        }

        public void UserScrollsToViewProductGrid()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollToView);
        }
    }
}
