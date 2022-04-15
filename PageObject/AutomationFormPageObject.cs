using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyTutorTraining.PageObject
{
    class AutomationFormPageObject
    {
        public IWebDriver driver;

        public AutomationFormPageObject()
        {
            driver = BaseTest.driver;
        }

        private By singleLineText = By.XPath("//*[@id='nf-field-135']");
        private By selectOneTwoThree = By.CssSelector("#nf-field-136");
        private By emailAddress = By.XPath("//*[@id='nf-field-135']");
        private By passWord = By.CssSelector("#nf-field-144");
        private By multiSelect123 = By.XPath("//*[@id='nf-field-137']");
        private By RadioButton = By.CssSelector("#nf-label-class-field-138-0");
        private By CheckBox = By.CssSelector("#nf-label-field-139-0");
        private By SelectCountry = By.CssSelector("#nf-field-140");
        private By CalendarDate = By.XPath("//*[@id='nf-field-141-wrap']/div[2]/div/input[2]");
        private By SingleCheckBox = By.CssSelector("#nf-label-field-142");
        private By ParagraphText = By.CssSelector("#nf-field-143");
        private By SubmitButton = By.CssSelector("#nf-field-133");
        private By successMessage = By.CssSelector("#nf-form-9-cont > div > div.nf-response-msg > p:nth-child(1)");
        private By ErrorMessage = By.CssSelector("#nf-form-errors-9 > nf-errors > nf-section > div");

        public void EnterSingleLineText(string text)
        {
            driver.FindElement(singleLineText).SendKeys(text);
        }

        public void SelectOneFromOneTwoThree()
        {
            SelectElement select = new SelectElement(driver.FindElement(selectOneTwoThree));
            select.SelectByValue("one");
        }

        public void EnterEmailAddress(string email)
        {
            driver.FindElement(emailAddress).SendKeys(email);
        }

        public void EnterPassword(string psw)
        {
            driver.FindElement(passWord).SendKeys(psw);
        }

        public void SelectMultiSelector()
        {
            SelectElement multiselect = new SelectElement(driver.FindElement(multiSelect123));
            multiselect.SelectByText("Two");
            multiselect.SelectByText("Three");
        }

        public void SelectOneFromRadioButton()
        {
            driver.FindElement(RadioButton).Click();
        }

        public void ClickOneFromCheckBoxButton()
        {
            driver.FindElement(CheckBox).Click();
        }

        public void SelectUnitedKingdomAsCountry()
        {
            SelectElement select = new SelectElement(driver.FindElement(SelectCountry));
            select.SelectByValue("GB");            
        }

        public void EnterCalendarDate(string date)
        {
            driver.FindElement(CalendarDate).SendKeys(date);
        }

        public void ClickSingleCheckBox()
        {
            driver.FindElement(SingleCheckBox).Click();
        }

        public void EnterParagraphText(string text)
        {
            driver.FindElement(ParagraphText).SendKeys(text);
        }

        public void ClickSubmitButton()
        {
            driver.FindElement(SubmitButton).Click();
        }

        public bool ThenSuccessfulMessageIsDisplayed()
        {
            return driver.FindElement(successMessage).Displayed;
        }

    

        public bool ThenErrorMessageIsDisplayed()
        {
            return driver.FindElement(ErrorMessage).Displayed;
        }


    }
}
