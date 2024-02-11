using OpenQA.Selenium;
using PageObjectHM.Pages;

namespace PageObjectHM.Steps;

public class NavigationSteps : BaseStep
{
    public NavigationSteps(IWebDriver driver) : base(driver) { }
    
    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage(Driver);
        //return new LoginPage(Driver, true);
    }

    public DashboardPage NavigateToDashboardPage()
    {
        return new DashboardPage(Driver, true);
    }
    
   /* 
    public DashboardPage SuccessfulLogin(string username, string psw)
    {
        Login(username, psw);
        return DashboardPage;
    }

    public LoginPage IncorrectLogin(string username, string psw)
    {
        Login(username, psw);
        return LoginPage;
    }*/
/*
    private void Login(string username, string psw)
    {
        Pages.LoginPage.LoginInput().SendKeys(username);
        LoginPage.PswInput().SendKeys(psw);
        LoginPage.LoginInButton().Click();
    }
*/
}