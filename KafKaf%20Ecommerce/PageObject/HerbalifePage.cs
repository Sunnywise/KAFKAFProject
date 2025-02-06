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
    public class HerbalifePage
    {
        public IWebDriver driver;
        public HerbalifePage()
        {
            driver = BaseTest.driver;
        }

        IWebElement shopButton => driver.FindElement(By.XPath("//*[@id='menu-item-5463']/a"));
        IWebElement hiddenHerbalife => driver.FindElement(By.CssSelector("li[id='menu-item-5465'] a[class='menu-link']"));


        public void UserClickOnShopButton()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(shopButton).Perform();// Perform the hover action
            System.Threading.Thread.Sleep(5000);// (Optional) Pause to see the hover effect
        }

        public bool UserViewHerbalifeDropdown()
        {
            return driver.Url.Contains("https://kafkaf.reteicons.com/");
        }
    }
}
