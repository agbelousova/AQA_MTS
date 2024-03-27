using OpenQA.Selenium;
using TestRailCore.Elements;

namespace TestRailCore.Pages.ProjectPages;

public class AddTestSuitePage : ProjectBasePage
{
    private static readonly By _nameInputBy = By.Id("name");
    private static readonly By _descriptionInputBy = By.Id("description_display");
    private static readonly By _addButtonBy = By.Id("accept");
    public AddTestSuitePage(IWebDriver driver) : base(driver) { }
    protected override string GetEndpoint() => throw new NotImplementedException();
    public override bool IsPageOpened() => throw new NotImplementedException();
    
    public UIElement NameInput => new(Driver, _nameInputBy);
    public UIElement DescriptionInput => new(Driver, _descriptionInputBy);
    public Button AddButton => new(Driver, _addButtonBy);
    
    public AddTestSuitePage InputName(string name)
    {
        NameInput.SendKeys(name);
        return this;
    }
    
    public AddTestSuitePage InputDescription(string description)
    {
        DescriptionInput.SendKeys(description);
        return this;
    }
    
    public ProjectTestSuitePage ClickAddButton()
    {
        AddButton.Click();
        return new ProjectTestSuitePage(Driver);
    }
}