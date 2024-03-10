using OpenQA.Selenium;
using Wrappers.Elements;

namespace Wrappers.Pages.ProjectPages;

public class AddTestCasePage : BasePage
{
    private static string END_POINT = "index.php?/cases/add/1";

    private static readonly By PageTitleBy = By.ClassName("page_title");
    private static readonly By SectionDropDownBy = By.Id("section_id_chzn");
    private static readonly By TemplateDropDownBy = By.Id("template_id_chzn");
    private static readonly By TypeDropDownBy = By.Id("type_id_chzn");
    private static readonly By PriorityDropDownBy = By.Id("priority_id_chzn");
    private static readonly By AssignedToDropDownBy = By.Id("assigned_to_id_chzn");
    private static readonly By AutomationTypeDropDownBy = By.Id("custom_automation_type_chzn");

    public AddTestCasePage(IWebDriver driver) : base(driver) { }
    public AddTestCasePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

    public UIElement PageTitle => new(Driver, PageTitleBy);
    public DropDownMenu SectionDropDown => new DropDownMenu(Driver, SectionDropDownBy);
    public DropDownMenu TemplateDropDown => new DropDownMenu(Driver, TemplateDropDownBy);
    public DropDownMenu TypeDropDown => new DropDownMenu(Driver, TypeDropDownBy);
    public DropDownMenu PriorityDropDown => new DropDownMenu(Driver, PriorityDropDownBy);
    public DropDownMenu AssignedToDropDown => new DropDownMenu(Driver, AssignedToDropDownBy);
    public DropDownMenu AutomationTypeDropDown => new DropDownMenu(Driver, AutomationTypeDropDownBy);

    protected override string GetEndpoint() => END_POINT;

    public override bool IsPageOpened()
    {
        try
        {
            return PageTitle.Text.Trim() == "Products";
        }
        catch (Exception)
        {
            return false;
        }
    }
}