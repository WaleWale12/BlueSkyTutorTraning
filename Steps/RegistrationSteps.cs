using BlueSkyTutorTraining.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyTutorTraining.Features
{
    [Binding]
    public class RegistrationSteps
    {

        public IWebDriver driver = BaseTest.driver;
        RegistrationPage _registrationpage = new RegistrationPage();



        [Given(@"I navigate to longrichway\.com")]
        public void GivenINavigateToLongrichway_Com()
        {
            driver.Navigate().GoToUrl(@"https://longrichway.com/");
        }
        
        [When(@"I click on Register button")]
        public void WhenIClickOnRegisterButton()
        {
            _registrationpage.ClickRegister();
        }
        
        [When(@"I enter First name ""(.*)""")]
        public void WhenIEnterFirstName(string name)
        {
            _registrationpage.EnterFirstName(name);
        }
        
        [When(@"I enter Last name ""(.*)""")]
        public void WhenIEnterLastName(string name)
        {
            _registrationpage.EnterLastName(name);
        }
        
        [When(@"I enter Email Address ""(.*)""")]
        public void WhenIEnterEmailAddress(string email)
        {
            _registrationpage.EnterEmailAddress(email);
        }
        
        [When(@"I enter Phone ""(.*)""")]
        public void WhenIEnterPhone(Decimal number)
        {
            _registrationpage.EnterPhone("07412121212");
        }
        
        [When(@"I enter Password ""(.*)""")]
        public void WhenIEnterPassword(string pwd)
        {
            _registrationpage.EnterPassword(pwd);
        }
        
        [When(@"I enter Confirm Password ""(.*)""")]
        public void WhenIEnterConfirmPassword(string confirmPwd)
        {
            _registrationpage.EnterConfirmPassword(confirmPwd);
        }
        
        [When(@"I enter Address ""(.*)""")]
        public void WhenIEnterAddress(string address)
        {
            _registrationpage.EnterAddress(address);
        }
        
        [When(@"I enter Town ""(.*)""")]
        public void WhenIEnterTown(string town)
        {
            _registrationpage.EnterTown(town);
        }
        
        [When(@"I enter State ""(.*)""")]
        public void WhenIEnterState(string state)
        {
            _registrationpage.EnterState(state);
        }
        
        [When(@"I click on create Account")]
        public void WhenIClickOnCreateAccount()
        {
            _registrationpage.ClickCreateAccountButton();
        }
        
        [Then(@"the message ""(.*)"" is displayed on the page")]
        public void ThenTheMessageIsDisplayedOnThePage(string message)
        {
            Assert.IsTrue(_registrationpage.ThenSuccessfulMessageDisplayed());
        }

        [Then(@"the Error message ""(.*)"" is displayed on the page")]
        public void ThenTheErrorMessageIsDisplayedOnThePage(string message)
        {
            Assert.IsTrue(_registrationpage.ThenErrorMessageIsDisplayed());
        }



    }
}
