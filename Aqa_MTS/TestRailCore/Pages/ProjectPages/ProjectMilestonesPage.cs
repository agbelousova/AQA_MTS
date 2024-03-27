using OpenQA.Selenium;

namespace TestRailCore.Pages.ProjectPages;

public class ProjectMilestonesPage : BasePage
{
    private static readonly By SuccessMessageBy = By.ClassName("message-success");
    public ProjectMilestonesPage(IWebDriver driver) : base(driver) { }

    public override bool IsPageOpened() => throw new NotImplementedException();
    protected override string GetEndpoint() => throw new NotImplementedException();
    
    public IWebElement SuccessMessage => WaitsHelper.WaitForExists(SuccessMessageBy);
}