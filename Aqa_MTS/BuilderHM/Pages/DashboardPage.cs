using BuilderHM.Elements;
using BuilderHM.Pages.ProjectPages;
using OpenQA.Selenium;

namespace BuilderHM.Pages;

public class DashboardPage : BasePage
{
    private static string END_POINT = "index.php?/dashboard";

    // Описание элементов
    private static readonly By TitleLabelBy = By.ClassName("page_title");
    private static readonly By SidebarProjectsAddButtonBy = By.Id("sidebar-projects-add");

    public DashboardPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl) { }
    public DashboardPage(IWebDriver driver) : base(driver) { }

    public override bool IsPageOpened()
    {
        try
        {
            return SidebarProjectsAddButton.Displayed && TitleLabel.Text.Trim().Equals("All Projects"); ;
        }
        catch (Exception)
        {
            return false;
        }
    }

    protected override string GetEndpoint() => END_POINT;

    public UIElement TitleLabel => new(Driver, TitleLabelBy);
    public Button SidebarProjectsAddButton => new(Driver, SidebarProjectsAddButtonBy);

    public AddProjectPage ClickSidebarProjectsAddButton()
    {
        SidebarProjectsAddButton.Click();
        return new AddProjectPage(Driver);
    }
}