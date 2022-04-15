using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyTutorTraining.PageObject
{
    class RegistrationPage
    {
        public IWebDriver driver;

        public RegistrationPage()
        {
            driver = BaseTest.driver;
        }


        private By Register = By.XPath("//*[@id='header']/div[2]/div[1]/div/div[1]/div[2]/div[4]/div[2]/a/span");
        private By FirstName = By.XPath("//*[@id='firstname']");
        private By LastName = By.XPath("//*[@id='lastname']");
        private By EmailAddress = By.XPath("//*[@id='emailaddressreg']");
        private By Phone = By.XPath("//*[@id='telephone']");
        private By Password = By.XPath("//*[@id='passwordreg']");
        private By ConfirmPassword = By.XPath("//*[@id='cnpassword']");
        private By Address = By.CssSelector("#address");
        private By Town = By.XPath("//*[@id='city']");
        private By State = By.CssSelector("#state");
        private By CreateAccountButton = By.CssSelector("#btn_register");
        private By SuccessMessage = By.CssSelector("#modal_panel > button");
        private By ErrorMessage = By.XPath("//*[@id='dialoguetext']");

        public void ClickRegister()
        {
            driver.FindElement(Register).Click();
        }

        public void EnterFirstName(string name)
        {
            driver.FindElement(FirstName).SendKeys(name);
        }

        public void EnterLastName(string name)
        {
            driver.FindElement(LastName).SendKeys(name);
        }

        public void EnterEmailAddress(string email)
        {
            driver.FindElement(EmailAddress).SendKeys(email);
        }

        public void EnterPhone(string number)
        {
            driver.FindElement(Phone).SendKeys(number);
        }

        public void EnterPassword(string pwd)
        {
            driver.FindElement(Password).SendKeys(pwd);
        }

        public void EnterConfirmPassword(string confirmPwd)
        {
            driver.FindElement(ConfirmPassword).SendKeys(confirmPwd);
        }

        public void EnterAddress(string address)
        {
            driver.FindElement(Address).SendKeys(address);
        }

        public void EnterTown(string town)
        {
            driver.FindElement(Town).SendKeys(town);
        }

        public void EnterState(string state)
        {
            driver.FindElement(State).SendKeys(state);
        }

        public void ClickCreateAccountButton()
        {
            driver.FindElement(CreateAccountButton).Click();
        }

        public bool ThenSuccessfulMessageDisplayed()
        {
            return driver.FindElement(SuccessMessage).Displayed;
        }

        public bool ThenErrorMessageIsDisplayed()
        {
            return driver.FindElement(ErrorMessage).Displayed;
        }



    }
}
