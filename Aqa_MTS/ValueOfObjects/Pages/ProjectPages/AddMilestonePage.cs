using OpenQA.Selenium;
using ValueOfObjects.Elements;

namespace ValueOfObjects.Pages.ProjectPages;

public class AddMilestonePage : ProjectBasePage
{
    // private static string END_POINT = "index.php?/admin/projects/add";
    private static readonly By _nameInputBy = By.Id("name");
    private static readonly By _referenceInputBy = By.Id("reference");
    private static readonly By _parentDropDownBy = By.Id("show_announcement");
    private static readonly By _descriptionInputBy = By.Id("description_display");
    private static readonly By _isCompletedBy = By.Id("due_on");
    private static readonly By _addButtonBy = By.Id("accept");

    public AddMilestonePage(IWebDriver driver) : base(driver) { }
    protected override string GetEndpoint() => throw new NotImplementedException();
    public override bool IsPageOpened() => throw new NotImplementedException();
    public UIElement NameInput => new(Driver, _nameInputBy);
    public UIElement ReferenceInput => new(Driver, _referenceInputBy);
    public DropDownMenu ParentDropDown => new(Driver, _parentDropDownBy);
    public UIElement DescriptionInput => new(Driver, _descriptionInputBy);
    public Checkbox IsCompleted => new(Driver, _isCompletedBy);
    public Button AddButton => new(Driver, _addButtonBy);

    public AddMilestonePage InputName(string name)
    {
        NameInput.SendKeys(name);
        return this;
    }

    public AddMilestonePage InputReference(string reference)
    {
        ReferenceInput.SendKeys(reference);
        return this;
    }

    public AddMilestonePage ChooseParent(int index)
    {
        ParentDropDown.SelectIndex(index);
        return this;
    }

    public AddMilestonePage InputDescription(string description)
    {
        DescriptionInput.SendKeys(description);
        return this;
    }

    public AddMilestonePage CheckIsCompleted(bool value)
    {
        IsCompleted.SetState(value);
        return this;
    }

    public ProjectMilestonesPage ClickAddButton()
    {
        AddButton.Click();
        return new ProjectMilestonesPage(Driver);
    }
}