using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowTestProject.Driver;

namespace SpecFlowTestProject;

[Binding]
public class SecondStepDefs
{
    private readonly Browser _browser;
    
    public SecondStepDefs(Browser browser)
    {
        _browser = browser;
    }

    [Given(@"открыт браузер")]
    public void OpenBrowser()
    {
        Console.WriteLine("Browser is started...");
        _browser.Driver = new ChromeDriver();
    }
}