using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;

namespace BlueSkyTutorTraining
{
    [Binding]
    public class BaseTest
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            //driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Minimize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
