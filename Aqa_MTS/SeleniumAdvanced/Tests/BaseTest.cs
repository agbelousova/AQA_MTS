﻿using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAdvanced.Core;
using SeleniumAdvanced.Helpers;
using SeleniumAdvanced.Helpers.Configuration;

namespace SeleniumAdvanced.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; set; }
    protected WaitsHelper WaitsHelper { get; private set; }
    
    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver!;
       // Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}