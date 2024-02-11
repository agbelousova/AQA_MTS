using OpenQA.Selenium;

namespace PageObjectHM.Pages
{
    public class LoginPage : BasePage
    {
        private static string END_POINT = "";
        
        // Описание элементов
        private static readonly By LoginInputBy = By.Id("user-name");
        private static readonly By PswInputBy = By.Id("password");
        private static readonly By LoginInButtonBy = By.Id("login-button");
        private static readonly By ErrorLabelBy = By.CssSelector("[data-test='error']");
        
        // Инициализация класса
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        
        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return LoginInButton.Displayed && LoginInput.Displayed;
        }

        // Методы
        public IWebElement LoginInput => WaitsHelper.WaitForExists(LoginInputBy);  
        public IWebElement ErrorLabel => WaitsHelper.WaitForExists(ErrorLabelBy);  
        public IWebElement PswInput => WaitsHelper.WaitForExists(PswInputBy);
        public IWebElement LoginInButton => WaitsHelper.WaitForExists(LoginInButtonBy);

        // Комплексные
        public DashboardPage SuccessFulLogin(string username, string password)
        {
            LoginInput.SendKeys(username);
            PswInput.SendKeys(password);
            LoginInButton.Click();

            return new DashboardPage(Driver);
        }

        public LoginPage IncorrectLogin(string username, string password)
        {
            LoginInput.SendKeys(username);
            PswInput.SendKeys(password);
            LoginInButton.Click();

            return this;
        }
    }
}