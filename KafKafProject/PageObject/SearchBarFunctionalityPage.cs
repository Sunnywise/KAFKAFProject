using KafKafProject.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafKafProject.PageObject
{
    public class SearchBarFunctionalityPage
    {
        public IWebDriver driver;
        public SearchBarFunctionalityPage()
        {
            driver = BaseTest.driver;
        }

        private IWebElement magnifyingLens => driver.FindElement(By.XPath("//a[contains(@class, 'dgwt-wcas-search-icon')]")); //(//*[@id="block-42"]/div/a)[1]
        private IWebElement enterText => driver.FindElement(By.XPath("//input[@placeholder='Search for products...']"));
        private IWebElement searchButton => driver.FindElement(By.XPath("(//*[name()='svg'][@class='dgwt-wcas-ico-magnifier'])[1]"));
        private IWebElement firstAssertion => driver.FindElement(By.CssSelector(".woocommerce-products-header__title.page-title"));
        private IWebElement noResult => driver.FindElement(By.XPath("//div[contains(@class, 'dgwt-wcas-suggestions-wrapp')]"));
        private IWebElement noProductsFound => driver.FindElement(By.XPath("//div[@class='woocommerce-info']"));
        private IWebElement xIconBtn => driver.FindElement(By.XPath("//div[@class='dgwt-wcas-preloader dgwt-wcas-close']"));
        private IWebElement textDeleted => driver.FindElement(By.XPath("//*[@id='dgwt-wcas-search-input-1']"));
        public void IClickOnMagnifyingGlass()
        {
            magnifyingLens.Click();
        }

        public void IEnterKeywordInField()
        {
            enterText.SendKeys(Keys.Enter);
            enterText.SendKeys("Juice");
        }

        public void IClickOnSearchIcon()
        {
            searchButton.Click();
        }
        public string AssertResult()
        {  
            return firstAssertion.Text;
        }

        public void IInputInvalidText()
        {
            enterText.SendKeys("In2va3lid4");
        }

        public string NoResultMessageIsDisplayed()
        {
            return noResult.Text;
        }

        public string NoProductsMatchSelection()
        {
           return noProductsFound.Text;
        }

        public void XCancelButton()
        {
            xIconBtn.Click();
        }

        public bool CharactersShouldBeDelete()
        {
           return textDeleted.Displayed;
        }

    }
}
