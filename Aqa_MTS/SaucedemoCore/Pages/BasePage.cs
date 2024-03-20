using OpenQA.Selenium;
using SaucedemoCore.Helpers;
using SaucedemoCore.Helpers.Configuration;

namespace SaucedemoCore.Pages;

public abstract class BasePage
{
    private static readonly By TitleClassBy = By.CssSelector("[class=title]");

    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }

    public BasePage(IWebDriver driver, bool openPageByUrl = false)
    {
        Driver = driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        if (openPageByUrl)
        {
            OpenPageByURL();
        }
    }

    protected abstract string GetEndpoint();
    public abstract bool IsPageOpened();

    protected void OpenPageByURL()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + GetEndpoint());
    }

    public IWebElement TitleClass => WaitsHelper.WaitForExists(TitleClassBy);
}