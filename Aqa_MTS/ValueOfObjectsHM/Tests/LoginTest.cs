using ValueOfObjectsHM.Helpers.Configuration;
using ValueOfObjectsHM.Pages;

namespace ValueOfObjectsHM.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        Assert.That(_navigationSteps.SuccessfulLogin(Admin).SidebarProjectsAddButton.Displayed);
    }
}