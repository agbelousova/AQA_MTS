using OpenQA.Selenium;
using PageObjectHM.Helpers;
using PageObjectHM.Helpers.Configuration;

namespace PageObjectHM.Pages;

public abstract class BasePage
{
    protected IWebDriver Driver;
    protected WaitsHelper WaitsHelper { get; private set; }

    public BasePage(IWebDriver driver, bool openPageByUrl)
    {
        Driver = driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
        
        if (openPageByUrl)
        {
            OpenPageByUrl();
        }
    }
    
    public BasePage(IWebDriver driver) : this(driver, false)
    {
    }
    

    public abstract bool IsPageOpened();
    protected abstract string GetEndpoint();

    private void OpenPageByUrl()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + GetEndpoint());
    }
}