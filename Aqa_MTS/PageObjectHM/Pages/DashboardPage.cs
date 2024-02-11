using OpenQA.Selenium;
using PageObjectHM.Helpers;
using PageObjectHM.Helpers.Configuration;

namespace PageObjectHM.Pages
{
    public class DashboardPage : BasePage
    {
        private static string END_POINT = "/inventory.html";
        
        // Описание элементов
        private static readonly By AddProductButtonBy = By.Id("add-to-cart-sauce-labs-backpack");
        private static readonly By BasketBy = By.ClassName("shopping_cart_badge");
       // private static readonly By PswInputBy = By.Id("password");
        //private static readonly By LoginInButtonBy = By.Id("login-button");
        
        public DashboardPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public DashboardPage(IWebDriver driver) : base(driver)
        {
           // Driver.Navigate().GoToUrl("https://www.saucedemo.com/inventory.html");
        }

        public override bool IsPageOpened()
        {
            try
            {
                return AddProductButton.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public IWebElement AddProductButton => WaitsHelper.WaitForExists(AddProductButtonBy);
        public IWebElement Basket => WaitsHelper.WaitForExists(BasketBy);
        public DashboardPage AddProduct()
        {
            AddProductButton.Click();
            return this;
        }
    }
}