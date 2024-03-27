using OpenQA.Selenium;
using TestRailCore.Elements;

namespace TestRailCore.Pages.ProjectPages;

public class ProjectTestCasePage : ProjectBasePage
{
    private static readonly By SuccessMessageBy = By.ClassName("message-success");
    public ProjectTestCasePage(IWebDriver driver) : base(driver) { }
    protected override string GetEndpoint() => throw new NotImplementedException();
    public override bool IsPageOpened() => throw new NotImplementedException();

    public IWebElement SuccessMessage => WaitsHelper.WaitForExists(SuccessMessageBy);
   
}