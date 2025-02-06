using KafKafProject.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafKafProject.PageObject
{
    public class ContactJuiceplusDistributionForm1Page
    {
        public IWebDriver driver;
        public ContactJuiceplusDistributionForm1Page()
        {
            driver = BaseTest.driver;
        }

        private IWebElement startYourBusiness => driver.FindElement(By.XPath("//a[1][@class='menu-link'][normalize-space()='Start Your Business']"));
        private IWebElement assertSYBPage => driver.FindElement(By.XPath("//h1[normalize-space()='Start Your Business']"));
        private IWebElement startTodayWithJuiceplus => driver.FindElement(By.XPath("//a[normalize-space()='Start Today with JuicePlus+']"));
        private IWebElement assertCHDPage => driver.FindElement(By.XPath("//h1[normalize-space()='Contact Juiceplus+ Distributor']"));
        private IWebElement emailField => driver.FindElement(By.XPath("//input[@type='email']"));
        private IWebElement firstName => driver.FindElement(By.XPath("//input[@name='name-1-first-name']"));
        private IWebElement lastName => driver.FindElement(By.XPath("//input[@name='name-1-last-name']"));
        private IWebElement mobileNumber => driver.FindElement(By.XPath("//input[@name='phone-1']"));
        private IWebElement textMessage => driver.FindElement(By.XPath("//*[@name='textarea-1']"));
        private IWebElement checkBoxTick => driver.FindElement(By.XPath("//span[@class='forminator-checkbox-box']"));
        private IWebElement submitButton => driver.FindElement(By.XPath("//button[normalize-space()='Submit']"));
        private IWebElement responseMessage => driver.FindElement(By.XPath("//*[@class='forminator-response-message forminator-show forminator-success']"));
        private IWebElement errorMessage => driver.FindElement(By.XPath("//*[contains(text(), 'This is not a valid email.')]"));
        private IWebElement messageErrorText => driver.FindElement(By.XPath("//*[contains(text(), 'This is not a valid email.')]"));

        //methods
        public void UserClickOnStartYourBusinessButton()
        {
            startYourBusiness.Click();
        }

        public string UserIsDirectedToStartYourBusinessPage()
        {
            return assertSYBPage.Text;
        }

        public void UserClicksOnStartTodayWithJuiceplus()
        {
            startTodayWithJuiceplus.Click();
        }

        public string RedirectedToDistributionPage()
        {
            return assertCHDPage.Text;
        }

        public void UserEntersEmail(string p0)
        {
            emailField.SendKeys(p0);
        }

        public void UserEntersFirstName(string p0)
        {
            firstName.SendKeys(p0);
        }

        public void UserEntersLastName(string p0)
        {
            lastName.SendKeys(p0);
        }
        public void UserEntersMobileDigits(string p0)
        {
            mobileNumber.Clear();
            mobileNumber.SendKeys(p0);
        }

        public void UserEntersMessage(string p0)
        {
            textMessage.SendKeys(p0);
        }

        public void UserClicksCheckBox()
        {
            checkBoxTick.Click();
        }

        public void UserClicksOnSubmitButton()
        {
            submitButton.Click();
        }

        public string YourResponseMessage()
        {
            try
            {
                Random random = new Random();
                int choice = random.Next(3); // Generates a number between 0 and 2

                switch (choice)
                {
                    case 0:
                        return responseMessage.Text;
                    case 1:
                        return errorMessage.Text;
                    case 2:
                        return messageErrorText.Text;
                    default:
                        return string.Empty; // Just in case something goes wrong, return an empty string
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"An error occurred: {ex.Message}");
                return "An error occurred while processing the message."; // Return a default error message
            }
        }

    }
}
