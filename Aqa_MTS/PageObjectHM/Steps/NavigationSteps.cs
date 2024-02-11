using OpenQA.Selenium;
using PageObjectHM.Pages;

namespace PageObjectHM.Steps;

public class NavigationSteps : BaseStep
{
    private LoginPage _loginPage;

    public NavigationSteps(IWebDriver driver) : base(driver)
    {
        _loginPage = new LoginPage(Driver);
    }
    
    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage(Driver);
        //return new LoginPage(Driver, true);
    }

    public DashboardPage NavigateToDashboardPage()
    {
        return new DashboardPage(Driver, true);
    }
    
   public DashboardPage SuccessfulLogin(string username, string psw)
   {
       _loginPage.IncorrectLogin(username, psw);
      //  Login(username, psw);
        return new DashboardPage(Driver);
    }

    public LoginPage IncorrectLogin(string username, string psw)
    {
        Login(username, psw);
        Thread.Sleep(2000);
        return _loginPage;
    }

    private void Login(string username, string psw)
    {
        _loginPage.LoginInput.SendKeys(username);
        _loginPage.PswInput.SendKeys(psw);
        _loginPage.LoginInButton.Click();
    }

}