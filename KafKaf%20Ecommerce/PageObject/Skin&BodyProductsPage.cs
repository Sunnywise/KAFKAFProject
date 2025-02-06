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
    public class Skin_BodyProductsPage
    {
        public IWebDriver driver;

        public Skin_BodyProductsPage()
        {
            driver = BaseTest.driver;
        }

        IWebElement catergoriesHovering => driver.FindElement(By.XPath("//li[@id='menu-item-5470']//a[@class='menu-link'][normalize-space()='Categories']"));
        IWebElement selectSkinBody => driver.FindElement(By.XPath("//li[@id='menu-item-5509']//a[@class='menu-link'][normalize-space()='Skin & Body']"));
        IWebElement skinBodyText => driver.FindElement(By.XPath("//h1[normalize-space()='Skin & Body']"));
        IWebElement firstPage => driver.FindElement(By.XPath("//span[@class='page-numbers current']"));
        IWebElement secondPage => driver.FindElement(By.XPath("//a[normalize-space()='2']"));
        IWebElement arrowNextPage => driver.FindElement(By.XPath("//a[contains(text(),'→')]"));
        IWebElement viewAllProduct => driver.FindElement(By.XPath("//h1[normalize-space()='Skin & Body']"));

        public void UserHoverOnCategories()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(catergoriesHovering).Perform();
        }

        public void UserClickOnSkinBody()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", selectSkinBody);
        }

        public string RedirectedToAssertPage()
        {
            return skinBodyText.Text;
        }

        public void UserScrollToProducts()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", firstPage);
        }

        public void UserSelectAnyPage()
        {
            if (secondPage != null)
                secondPage.Click();
            else if (arrowNextPage != null)
                arrowNextPage.Click();
        }

        public string ViewAllProduct()
        {
            return viewAllProduct.Text;
        }

        
        
            
        

       
        






    }
}