using OpenQA.Selenium;
using ValueOfObjectsHM.Elements;

namespace ValueOfObjectsHM.Pages.ProjectPages;

public class AddProjectPage(IWebDriver? driver, bool openByURL = false) : ProjectBasePage(driver, openByURL)
{
    private static string END_POINT = "index.php?/admin/projects/add";

    private static readonly By _nameInputBy = By.Id("name");
    private static readonly By _announcementInputBy = By.Id("announcement_display");
    private static readonly By _showAnnouncementCheckboxBy = By.Id("show_announcement");
    private static readonly By _projectTypeRadioBy = By.Name("suite_mode");
    private static readonly By _caseApprovalsCheckboxBy = By.Id("case_statuses_enabled");
    private static readonly By _addButtonBy = By.Id("accept");

    protected override string GetEndpoint()
    {
        return END_POINT;
    }
    
    protected override bool EvaluateLoadedStatus()
    {
        return WaitsHelper.WaitForVisibilityLocatedBy(_addButtonBy).Displayed;
    }
    public UIElement NameInput => new(Driver, _nameInputBy);
    public UIElement AnnouncementInput => new(Driver, _announcementInputBy);
    public Checkbox ShowAnnouncementCheckbox => new(Driver, _showAnnouncementCheckboxBy);
    public RadioButton ProjectTypeRadio => new(Driver, _projectTypeRadioBy);
    public Checkbox CaseApprovalsCheckbox => new(Driver, _caseApprovalsCheckboxBy);
    public Button AddButton => new(Driver, _addButtonBy);
}