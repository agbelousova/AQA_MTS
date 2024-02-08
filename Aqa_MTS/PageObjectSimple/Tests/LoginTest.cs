using PageObjectSimple.Helpers.Configuration;
using PageObjectSimple.Pages;
using PageObjectSimple.Steps;

namespace PageObjectSimple.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessLoginTest()
    {
        /*var loginPage = new LoginPage(Driver);
        loginPage.EmailInput().SendKeys(Configurator.AppSettings.Username);
*/

        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.IsTrue(NavigationSteps.DashboardPage.IsPageOpened());
        
    }
}