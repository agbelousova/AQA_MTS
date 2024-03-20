using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaucedemoCore.Pages.CheckoutPages
{
    public class CheckoutThirdPage : BasePage
    {
        private static string END_POINT = "checkout-step-two.html";

        public HeaderPage HeaderPage;

        // Описание элементов
        private static readonly By CompleteTextClassBy = By.CssSelector("[class=complete-header]");

        // Инициализация класса
        public CheckoutThirdPage(IWebDriver driver) : base(driver)
        {
            HeaderPage = new HeaderPage(Driver);
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return TitleClass.Text.Trim().Equals("Checkout: Complete!");
        }

        public string OrderCompletedText() => CompleteTextClass.Text.Trim();

        public IWebElement CompleteTextClass => WaitsHelper.WaitForExists(CompleteTextClassBy);
    }
}