using KafKafProject.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafKafProject.PageObject
{
    public class AccessoriesProductPage
    {
        public IWebDriver driver;
        public AccessoriesProductPage()
        {
            driver = BaseTest.driver;
        }

        private IWebElement categoryHovering => driver.FindElement(By.XPath("(//a[contains(text(), 'Categories')])[1]"));
        private IWebElement selectAccessories => driver.FindElement(By.XPath("(//*[contains(text(), 'Accessories')])[1]"));
        private IWebElement assertAccessories => driver.FindElement(By.XPath("//h1[normalize-space()='Accessories']"));
        private IWebElement scrollToView => driver.FindElement(By.XPath("//*[@id='main']/div/ul/li[7]/div[2]/a"));
        private IWebElement nextPage => driver.FindElement(By.XPath("//a[contains(text(),'→')]"));
        private IWebElement finalAssertion => driver.FindElement(By.XPath("//*[@id='main']/div/p"));



        public void UserHoversOnTheCategoriesButton()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(categoryHovering).Perform();
        }

        public void UserClicksAccessoriesButton()
        {
            selectAccessories.Click();
        }

        public string AccessoriesPageIsDisplayed()
        {
            return assertAccessories.Text;
        }

        public void ScrollingToViewProductGrid()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollToView);
        }

        public void UserClicksNextArrowPage()
        {
            nextPage.Click();
        }

        public string UserViewsAllProductsLayout()
        {
            return finalAssertion.Text;
        }
    }
}
