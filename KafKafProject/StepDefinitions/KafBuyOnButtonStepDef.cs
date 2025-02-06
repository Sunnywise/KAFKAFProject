using KafKafProject.Hooks;
using OpenQA.Selenium;
using PurposeProjects.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PurposeProjects.StepDefinitions
{
    [Binding]
    public class KafBuyOnButtonStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        BuyOnButtonPgObj buyonbuttonpgobj = new BuyOnButtonPgObj();

        [Given(@"that I am on Kafkaf website ""([^""]*)""")]
        public void GivenThatIAmOnKafkafWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [When(@"I click on Herbalife button")]
        public void WhenIClickOnHerbalifeButton()
        {
            buyonbuttonpgobj.clickherbalifebutton();
        }

        [Then(@"then I should be directed to herbalife website")]
        public void ThenThenIShouldBeDirectedToHerbalifeWebsite()
        {
            buyonbuttonpgobj.DirectToHebalifeWebsite().Should().BeTrue();
        }

        [Then(@"I am on Kafkaf website ""([^""]*)""")]
        public void ThenIAmOnKafkafWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [When(@"I click on Buyonjuiceplus\+ button")]
        public void WhenIClickOnBuyonjuiceplusButton()
        {
            buyonbuttonpgobj.clickjuiceplusbutton();
        }

        [Then(@"I should be directed to Juiceplus website")]
        public void ThenIShouldBeDirectedToJuiceplusWebsite()
        {
            buyonbuttonpgobj.DirectToJuiceplusWebsite().Should().BeTrue();
        }

    }
}

