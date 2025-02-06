using KafKafProject.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace KafKafProject.PageObject
{
    public class ContactUsFormPage
    {
        public IWebDriver driver;
        public ContactUsFormPage()
        {
            driver = BaseTest.driver;
        }

        private IWebElement scrollToFooter => driver.FindElement(By.LinkText("Contact"));
        private IWebElement contactButton => driver.FindElement(By.XPath("//a[normalize-space()='Contact']"));
        private IWebElement firstAssertion => driver.FindElement(By.XPath("//h1[normalize-space()='Get In Touch']"));
        private IWebElement scrollToForm => driver.FindElement(By.ClassName("uagb-ifb-title"));
        private IWebElement userNames => driver.FindElement(By.Name("name-1"));
        private IWebElement userEmail => driver.FindElement(By.XPath("//*[@type='email']"));
        private IWebElement subjectDropdown => driver.FindElement(By.XPath("//select[@data-placeholder='Subject']"));
        private IWebElement enterMessages => driver.FindElement(By.ClassName("forminator-textarea"));
        private IWebElement attachFile => driver.FindElement(By.XPath("//input[@type='file']"));
        private IWebElement sendButton => driver.FindElement(By.XPath("//button[normalize-space()='Send']"));
        private IWebElement successAssertion => driver.FindElement(By.XPath("//*[contains(text(), 'Your message has been sent successfully')]"));
        private IWebElement requireFieldAssertion => driver.FindElement(By.XPath("//span[contains(text(), 'Please input your name.')]"));
        private IWebElement invalidEmailAssertion => driver.FindElement(By.XPath("//span[contains(text(), 'This is not a valid email.')]"));


       //methods
        public void UserScrollsToFooter()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollToFooter);
        }

        public void ContactButtonClicked()
        {
            contactButton.Click();
        }

        public string UserIsRedirectedToContactUsPage()
        {
           return firstAssertion.Text;
        }

        public void UserScrollsToTheForm()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollToForm);
        }

        public void UserEntersFullName(string p0)
        {
            userNames.SendKeys(p0);
        }

        public void UserEntersEmailAddress(string p0)
        {
            userEmail.SendKeys(p0);
        }

        public void UserSelectSubjectFromDropdown()
        {
            SelectElement select = new SelectElement(subjectDropdown);
            select.SelectByValue("Product-Request");
        }

        public void UserEntersMessageInTheFieldProvided(string p0)
        {
            enterMessages.SendKeys(p0);
        }

        public void UserUploadFiles()
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            IWebElement element = driver.FindElement(By.ClassName("forminator-textarea"));
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);

             string filePath = Path.GetFullPath(@"C:\DigitalFresh\KafKafProject\Utilities\Kaffkaff project.txt");
             attachFile.SendKeys(filePath);
        }

        public void UserClicksOnSendButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement sendButton= wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//button[normalize-space()='Send']")));
            sendButton.Click();
        }

        public string AConfirmatoryMessageIsDisplayed()
        {
            try
            {
                if (!string.IsNullOrEmpty(successAssertion.Text))
                {
                    return successAssertion.Text;
                }
                else if (!string.IsNullOrEmpty(requireFieldAssertion.Text))
                {
                    return requireFieldAssertion.Text;
                }
                else if (!string.IsNullOrEmpty(invalidEmailAssertion.Text))
                {
                    return invalidEmailAssertion.Text;
                }
                else
                {
                    return "No confirmatory message is displayed.";
                }
            }
            catch (Exception ex)
            {
                // Log the exception (optional)
                Console.WriteLine($"An error occurred: {ex.Message}");

                // Fallback message if an exception occurs
                return "An unexpected error occurred while retrieving the confirmatory message.";
            }
        }

    }
}
