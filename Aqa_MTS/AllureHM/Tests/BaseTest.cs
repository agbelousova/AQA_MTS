using System.Text;
using Allure.Net.Commons;
using OpenQA.Selenium;
using AllureHM.Core;
using AllureHM.Helpers;
using AllureHM.Helpers.Configuration;
using AllureHM.Steps;
using NUnit.Allure.Core;

namespace AllureHM.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
[AllureNUnit]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }

    protected NavigationSteps NavigationSteps;
    
    public void TakeScreenshot(string name)
    {
        Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
        byte[] screenshotBytes = screenshot.AsByteArray;

        AllureApi.Step(name);
        AllureApi.AddAttachment($"{name}", "image/png", screenshotBytes);
    }

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
        
        // Инициализация Steps
        NavigationSteps = new NavigationSteps(Driver);
        
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        try
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                byte[] screenshotBytes = screenshot.AsByteArray;
                
                AllureLifecycle.Instance.AddAttachment("Screenshot", "image/png", screenshotBytes);

                AllureApi.AddAttachment(
                    "data.txt",
                    "text/plain",
                    Encoding.UTF8.GetBytes("This is the file content.")
                );
                AllureApi.AddAttachment(
                    "Screenshot",
                    "image/png",
                    screenshotBytes
                );
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        Driver.Quit();
    }
}