using BlueSkyTutorTraining.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BlueSkyTutorTraining.Steps
{
    [Binding]
    public class AutomationformSteps
    {
        public IWebDriver driver = BaseTest.driver;
        AutomationFormPageObject _automationFormPageObject = new AutomationFormPageObject();

        [Given(@"I Navigate to BlueSky Testing Form")]
        public void GivenINavigateToBlueSkyTestingForm()
        {
            driver.Navigate().GoToUrl(@"https://blueskycitadel.com/automation-testing-form/");
        }
        
        [When(@"I Enter the single line text ""(.*)""")]
        public void WhenIEnterTheSingleLineText(string text)
        {
            Thread.Sleep(5000);
            _automationFormPageObject.EnterSingleLineText(text);
        }
        
        [When(@"I Select one in the Select box page")]
        public void WhenISelectOneInTheSelectBoxPage()
        {
            _automationFormPageObject.SelectOneFromOneTwoThree();
        }
        
        [When(@"I Enter email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            _automationFormPageObject.EnterEmailAddress(email);
        }
        
        [When(@"I Enter the password ""(.*)""")]
        public void WhenIEnterThePassword(string psw)
        {
            _automationFormPageObject.EnterPassword(psw);
        }
        
        [When(@"I Select Multi-Select")]
        public void WhenISelectMulti_Select()
        {
            _automationFormPageObject.SelectMultiSelector();
        }
        
        [When(@"I Select Radio list")]
        public void WhenISelectRadioList()
        {
            _automationFormPageObject.SelectOneFromRadioButton();
        }
        
        [When(@"I Select Checkbox list")]
        public void WhenISelectCheckboxList()
        {
            _automationFormPageObject.ClickOneFromCheckBoxButton();
        }
        
        [When(@"I Select United States as my Country")]
        public void WhenISelectUnitedStatesAsMyCountry()
        {
            _automationFormPageObject.SelectUnitedKingdomAsCountry();
        }
        
        [When(@"I Enter the date ""(.*)""")]
        public void WhenIEnterTheDate(string date)
        {
            _automationFormPageObject.EnterCalendarDate(date);
        }
        
        [When(@"I Click on the Single Checkbox")]
        public void WhenIClickOnTheSingleCheckbox()
        {
            _automationFormPageObject.ClickSingleCheckBox();
        }
        
        [When(@"I Enter the Paragraph Text ""(.*)""")]
        public void WhenIEnterTheParagraphText(string text)
        {
            _automationFormPageObject.EnterParagraphText(text);
        }
        
        [When(@"I click on the submit button")]
        public void WhenIClickOnTheSubmitButton()
        {
            _automationFormPageObject.ClickSubmitButton();
        }
        
        [Then(@"the messsage ""(.*)"" is displayed on the form page")]
        public void ThenTheMesssageIsDisplayedOnTheFormPage(string message)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(_automationFormPageObject.ThenSuccessfulMessageIsDisplayed());
        }

       

        [Then(@"the Error messsage ""(.*)"" is displayed on the form page")]
        public void ThenTheErrorMesssageIsDisplayedOnTheFormPage(string message)
        {
            Assert.IsTrue(_automationFormPageObject.ThenErrorMessageIsDisplayed());
        }





    


    }
}
