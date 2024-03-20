using OpenQA.Selenium;
using SaucedemoCore.Pages;
using SaucedemoCore.Pages.CheckoutPages;

namespace SaucedemoCore.Steps;

public class UserSteps : BaseSteps
{
    private LoginPage _loginPage;
    private CheckoutOnePage _userData;

    public UserSteps(IWebDriver driver) : base(driver)
    {
        _loginPage = new LoginPage(Driver);
        _userData = new CheckoutOnePage(Driver);
    }

    public ProductsPage SuccessfullLogin(string username, string password)
    {
        _loginPage.UsernameInput.SendKeys(username);
        _loginPage.PswInput.SendKeys(password);
        _loginPage.LoginInButton.Click();

        return new ProductsPage(Driver);
    }

    public LoginPage IncorrectLogin(string username, string password)
    {
        _loginPage.UsernameInput.SendKeys(username);
        _loginPage.PswInput.SendKeys(password);
        _loginPage.LoginInButton.Click();

        return _loginPage;
    }

    public void FillUserData(string firstname, string lastname, string postalCode)
    {
        _userData.FirstnameInput.SendKeys(firstname);
        _userData.LastnameInput.SendKeys(lastname);
        _userData.PostalCodeInput.SendKeys(postalCode);
    }

    public bool IsValidCustomerData()
    {
        return !_userData.ErrorButton.Displayed;
    }
}