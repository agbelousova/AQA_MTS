using Wrappers.Elements;
using Wrappers.Helpers.Configuration;
using Wrappers.Pages.ProjectPages;

namespace Wrappers.Tests;

public class HomeWorkTest : BaseTest
{
    [Test]
    public void CheckboxTest()
    {
        UserSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
            .AddProjectButton.Click();

        AddProjectPage addProjectPage = new AddProjectPage(Driver);

        addProjectPage.ShowAnnouncementCheckbox.SetState(true);
        Assert.That(addProjectPage.ShowAnnouncementCheckbox.IsChecked);
    }

    [Test]
    public void DropDownTest()
    {
        UserSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        AddTestCasePage addTestCasePage = new AddTestCasePage(Driver, true);
        
        addTestCasePage.SectionDropDown.SelectText("Test Cases");
        addTestCasePage.TemplateDropDown.SelectText("Test Case (Text)");
        addTestCasePage.TypeDropDown.SelectText("Accessibility"); 
        addTestCasePage.PriorityDropDown.SelectIndex(1);
        addTestCasePage.AssignedToDropDown.SelectIndex(1);
        addTestCasePage.AutomationTypeDropDown.SelectText("Ranorex");
        
        Assert.Multiple(() =>
        {
            Assert.That(addTestCasePage.SectionDropDown.SelectedOption, Is.EqualTo("Test Cases"));
            Assert.That(addTestCasePage.TypeDropDown.SelectedOption, Is.EqualTo("Accessibility"));
            Assert.That(addTestCasePage.PriorityDropDown.SelectedOption, Is.EqualTo("High"));
            Assert.That(addTestCasePage.AssignedToDropDown.SelectedOption, Is.EqualTo("Me")); 
            Assert.That(addTestCasePage.AutomationTypeDropDown.SelectedOption, Is.EqualTo("Ranorex"));
            Assert.That(addTestCasePage.TemplateDropDown.SelectedOption, Is.EqualTo("Test Case (Text)"));
        });
    }
}