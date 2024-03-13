using OpenQA.Selenium;
using ValueOfObjectsHM.Elements;

namespace ValueOfObjectsHM.Pages;

public class ProjectsPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{
    private static string END_POINT = "index.php?/admin/projects/overview";

    // Описание элементов
    private static readonly By TitleLabelBy = By.ClassName("page_title");
    private static readonly By AddProjectButtonBy = By.XPath("//*[contains(text(), 'Add Project')]");
    private static readonly By ProjectsTableBy = By.CssSelector("table.grid");
    private static readonly By TitleBy = By.XPath("//*[contains(@class, 'page_title') and contains(text(), 'Projects')]");
    private static readonly By SuccessMessageBy = By.ClassName("message-success");

    // Инициализация класса
    protected override bool EvaluateLoadedStatus()
    {
        return Title.Displayed;
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    // Атомарные Методы
    public UIElement TitleLabel => new(Driver, TitleLabelBy);
    public Button AddProjectButton => new(Driver, AddProjectButtonBy);
    public Table ProjectsTable => new(Driver, ProjectsTableBy);
    public IWebElement Title => WaitsHelper.WaitForExists(TitleBy);
    public IWebElement SuccessMessage => WaitsHelper.WaitForExists(SuccessMessageBy);
}