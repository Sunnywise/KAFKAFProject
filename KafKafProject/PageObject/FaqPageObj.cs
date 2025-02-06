using KafKafProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafKafProject.PageObject
{
    public class FaqPageObj
    {
        public IWebDriver driver;

        private By clickFaq = By.XPath("//*[@id=\"block-27\"]/ul/li[3]/mark/a");
        private By clickChoiceQuestion = By.XPath("//*[@id=\"post-5244\"]/div/div/div[3]/div[1]/span[3]");

        public FaqPageObj()
        {
            driver = BaseTest.driver;
        }

        public void UserClickOnFaq()
        {
            driver.FindElement(clickFaq).Click();
        }

        public void UserClickonChoiceQuestion()
        {
            driver.FindElement(clickChoiceQuestion).Click();
        }

        public bool AnswerReveal()
        {
            return driver.Url.Contains("https://kafkaf.reteicons.com/faq/");
        }

    }
}
