using OpenQA.Selenium;
using PageObjectSteps.Pages;

namespace PageObjectSteps.Steps;

public class NavigationSteps : BaseStep
{
    public NavigationSteps(IWebDriver driver) : base(driver) { }
    
    public DashboardPage SuccessfulLogin(string username, string psw)
    {
        return Login<Pages.DashboardPage>(username, psw);
    }

    public LoginPage IncorrectLogin(string username, string psw)
    {
        
        return Login<Pages.LoginPage>(username, psw);
    }

    private T Login<T>(string username, string psw) where T:BasePage
    {
       // LoginPage = new LoginPage(Driver);
        LoginPage.EmailInput().SendKeys(username);
        LoginPage.PswInput().SendKeys(psw);
        LoginPage.LoginInButton().Click();
        
        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }

}