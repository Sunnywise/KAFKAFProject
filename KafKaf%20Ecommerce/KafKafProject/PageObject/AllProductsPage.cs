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
    public class AllProductsPage
    {
        public IWebDriver driver;
        public AllProductsPage()
        {
            driver = BaseTest.driver;
        }

        private IWebElement categoryHovering => driver.FindElement(By.XPath("(//a[contains(text(), 'Categories')])[1]"));
        private IWebElement selectAccessories => driver.FindElement(By.XPath("(//*[contains(text(), 'All Products')])[1]"));
        private IWebElement assertAllProducts => driver.FindElement(By.XPath("//h1[normalize-space()='All Products']"));
        private IWebElement scrollToView => driver.FindElement(By.XPath("//*[@id='main']/div/ul/li[7]/div[2]/a"));
        private IWebElement nextPage => driver.FindElement(By.XPath("//a[contains(text(),'→')]"));
        private IWebElement lastAssertion => driver.FindElement(By.XPath("//p[@class='woocommerce-result-count']"));



        public void UserHoversOnTheCategoriesButton()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(categoryHovering).Perform();
        }

        public void UserClicksAllProductsButton()
        {
            selectAccessories.Click();
        }

        public string AllProductsPageIsDisplayed()
        {
            return assertAllProducts.Text;
        }

        public void ScrollingToViewAllProductsLayout()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollToView);
        }

        public void UserClicksNextArrowPage()
        {
            nextPage.Click();
        }

        public string UserViewsAllProductsLayout()
        {
            return lastAssertion.Text;
        }

    }
}
