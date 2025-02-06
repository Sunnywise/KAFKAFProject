using KafKafProject.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KafKafProject.PageObject
{
    public class AllJuiceplusProductsPage
    {
        public IWebDriver driver;

        public AllJuiceplusProductsPage()
        {
            driver = BaseTest.driver;
        }

        IWebElement shopHovering => driver.FindElement(By.XPath("//li[@id='menu-item-5463']//a[@class='menu-link'][normalize-space()='Shop']"));
        IWebElement selectJuiceplus => driver.FindElement(By.XPath("//*[@id='ast-hf-menu-1']/li[1]/ul/li[2]/a"));
        IWebElement juiceplusText => driver.FindElement(By.XPath("//h1[normalize-space()='Juiceplus+']"));
        IWebElement firstPage => driver.FindElement(By.XPath("//span[@class='page-numbers current']"));
        IWebElement secondPage => driver.FindElement(By.XPath("//a[normalize-space()='2']"));
        IWebElement thirdPage => driver.FindElement(By.XPath("//a[normalize-space()='3']"));
        IWebElement arrowNextPage => driver.FindElement(By.XPath("//a[contains(text(),'→')]"));
        IWebElement viewAllProducts => driver.FindElement(By.XPath("//h1[normalize-space()='Juiceplus+']"));

        //Methods
        public void UserHoverOnTheShopButton()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(shopHovering).Perform();
        }

        public void UserClickOnJuicePlusButton()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", selectJuiceplus);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", selectJuiceplus);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        public string RedirectedToAssertPage()
        {
            return juiceplusText.Text;
        }

        public void UserScrollToProducts()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", firstPage);
        }

        public void UserSelectsAnyPage()
        {
            if (secondPage != null)
                secondPage.Click();
            else if (arrowNextPage != null)
                arrowNextPage.Click();
        }

        public string UserviewsAllProduct()
        {
            return viewAllProducts.Text;
        }
    }
}
