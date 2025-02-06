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
    public class BeveragesAndInfusionsPage
    {
        public IWebDriver driver;
        public BeveragesAndInfusionsPage()
        {
            driver = BaseTest.driver;
        }

        private IWebElement categoryHovering => driver.FindElement(By.XPath("(//a[contains(text(), 'Categories')])[1]"));
        private IWebElement selectBevNdInf => driver.FindElement(By.XPath("(//*[contains(text(), 'Beverages & Infusions')])[1]"));
        private IWebElement assertBevInf => driver.FindElement(By.XPath("//h1[normalize-space()='Beverages & Infusions']"));
        private IWebElement scrollToView => driver.FindElement(By.XPath("//*[@id='main']/div/ul/li[7]/div[2]/a"));
        private IWebElement nextPage => driver.FindElement(By.XPath("//a[contains(text(),'→')]"));
        private IWebElement finalAssertion => driver.FindElement(By.XPath("//*[@id='main']/div/p"));



        public void UserHoversOnTheCategoriesButton()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(categoryHovering).Perform();
        }

        public void UserSelectsBeverageAndInfusion()
        {
            selectBevNdInf.Click();
        }

        public string BeveragesAndInfusionPageIsDisplayed()
        {
           return assertBevInf.Text;
        }

        public void UserScrollsToViewProductGrid()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollToView);
        }

        public void UserClicksNextArrowPage()
        {
            nextPage.Click();
        }

        public string UserViewsAllProductsLayout()
        {
          return  finalAssertion.Text;
        }

    }
}
