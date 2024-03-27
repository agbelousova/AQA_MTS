using OpenQA.Selenium;
using TestRailCore.Models;
using TestRailCore.Pages;
using TestRailCore.Pages.ProjectPages;

namespace TestRailCore.Steps;

public class NavigationSteps : BaseStep
{
    private LoginPage _loginPage;
    private DashboardPage _dashboardPage;
    private AddProjectPage _addProjectPage;

    public NavigationSteps(IWebDriver driver) : base(driver)
    {
        _loginPage = new LoginPage(driver);
        _dashboardPage = new DashboardPage(driver);
        _addProjectPage = new AddProjectPage(driver);
    }
    
    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage(Driver);
    }

    public DashboardPage NavigateToDashboardPage()
    {
        return new DashboardPage(Driver);
    }
    
    public AddProjectPage NavigateToAddProjectPage()
    {
        return new AddProjectPage(Driver);
    }
    
    public DashboardPage SuccessfulLogin(User user)
    {
        return Login<DashboardPage>(user);
    }

    public LoginPage IncorrectLogin(User user)
    {
        return Login<LoginPage>(user);
    }
    
    public T Login<T>(User user) where T : BasePage
    {
        _loginPage.EmailInput.SendKeys(user.Email);
        _loginPage.PswInput.SendKeys(user.Password);
        _loginPage.LoginInButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }
}