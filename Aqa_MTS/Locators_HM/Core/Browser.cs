using OpenQA.Selenium;
using Locators_HM.Helpers.Configuration;
using Locators_HM.Core;

namespace Locators_HM.Core
{
    public class Browser
    {
        public IWebDriver? Driver { get; }

        public Browser()
        {
            Driver = Configurator.BrowserType?.ToLower() switch
            {
                "chrome" => new DriverFactory().GetChromeDriver(),
                "firefox" => new DriverFactory().GetFirefoxDriver(),
                _ => Driver
            } ?? throw new InvalidOperationException("Browser is not supported.");

            Driver.Manage().Window.Maximize();
            Driver.Manage().Cookies.DeleteAllCookies();
            //Driver!.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }
    }
}