using OpenQA.Selenium;
using TestRailCore.Elements;

namespace TestRailCore.Pages.ProjectPages;

public class AddTestCasePage : ProjectBasePage
{
    private static readonly By TitleInputBy = By.Id("title");
    private static readonly By SectionDropDownBy = By.Id("section_id_chzn");
    private static readonly By TemplateDropDownBy = By.Id("template_id_chzn");
    private static readonly By TypeDropDownBy = By.Id("type_id_chzn");
    private static readonly By PriorityDropDownBy = By.Id("priority_id_chzn");
    private static readonly By AssignedToDropDownBy = By.Id("assigned_to_id_chzn");
    private static readonly By StepsInputBy = By.Id("custom_steps_display");
    private static readonly By _addButtonBy = By.Id("accept");
    
    
    public AddTestCasePage(IWebDriver driver) : base(driver) { }
    protected override string GetEndpoint() => throw new NotImplementedException();
    public override bool IsPageOpened() => throw new NotImplementedException();
    
    public UIElement TitleInput => new(Driver, TitleInputBy);
    public DropDownMenu SectionDropDown => new DropDownMenu(Driver, SectionDropDownBy);
    public DropDownMenu TemplateDropDown => new DropDownMenu(Driver, TemplateDropDownBy);
    public DropDownMenu TypeDropDown => new DropDownMenu(Driver, TypeDropDownBy);
    public DropDownMenu PriorityDropDown => new DropDownMenu(Driver, PriorityDropDownBy);
    public DropDownMenu AssignedToDropDown => new DropDownMenu(Driver, AssignedToDropDownBy);
    public UIElement StepsInput => new(Driver, StepsInputBy);
    public Button AddButton => new(Driver, _addButtonBy);
    
    public AddTestCasePage InputTitle(string name)
    {
        TitleInput.SendKeys(name);
        return this;
    }
    
    public AddTestCasePage Section(int index)
    {
        SectionDropDown.SelectIndex(index);
        return this;
    }
    
    public AddTestCasePage Template(int index)
    {
        TemplateDropDown.SelectIndex(index);
        return this;
    }
    
    public AddTestCasePage Type(int index)
    {
        TypeDropDown.SelectIndex(index);
        return this;
    }
    
    public AddTestCasePage Priority(int index)
    {
        PriorityDropDown.SelectIndex(index);
        return this;
    }
    
    public AddTestCasePage Assigned(int index)
    {
        AssignedToDropDown.SelectIndex(index);
        return this;
    }
    
    public AddTestCasePage Steps(string name)
    {
        StepsInput.SendKeys(name);
        return this;
    }
    
    public ProjectTestCasePage ClickAddButton()
    {
        AddButton.Click();
        return new ProjectTestCasePage(Driver);
    }
}