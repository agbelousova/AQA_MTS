using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaucedemoCore.Pages.CheckoutPages
{
    public class CheckoutOnePage : BasePage
    {
        private static string END_POINT = "checkout-step-one.html";

        public HeaderPage HeaderPage;

        // Описание элементов
        private static readonly By ContinueInputBy = By.Id("continue");
        private static readonly By FirstnameInputBy = By.Id("first-name");
        private static readonly By LastnameInputBy = By.Id("last-name");
        private static readonly By PostalCodeInputBy = By.Id("postal-code");
        private static readonly By ErrorButtonBy = By.CssSelector("[data-test=error]");

        // Инициализация класса
        public CheckoutOnePage(IWebDriver driver) : base(driver)
        {
            HeaderPage = new HeaderPage(Driver);
        }

        protected override string GetEndpoint() => END_POINT;

        public override bool IsPageOpened() => TitleClass.Text.Trim().Equals("Checkout: Your Information");

        public bool IsValidCustomerData() => !ErrorButton.Displayed;

        public IWebElement ContinueInput => WaitsHelper.WaitForExists(ContinueInputBy);
        public IWebElement FirstnameInput => WaitsHelper.WaitForExists(FirstnameInputBy);
        public IWebElement LastnameInput => WaitsHelper.WaitForExists(LastnameInputBy);
        public IWebElement PostalCodeInput => WaitsHelper.WaitForExists(PostalCodeInputBy);
        public IWebElement ErrorButton => WaitsHelper.WaitForExists(ErrorButtonBy);
    }
}