using OpenQA.Selenium;
using SaucedemoCore.Pages.CheckoutPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaucedemoCore.Pages
{
    public class ShoppingCartPage : BasePage
    {
        private static string END_POINT = "cart.html";

        public HeaderPage HeaderPage;

        private static readonly By CheckoutButtonBy = By.Id("checkout");
        private static readonly By ItemInShoppingCartClassBy = By.CssSelector("[class=cart_item]");

        public ShoppingCartPage(IWebDriver driver) : base(driver)
        {
            HeaderPage = new HeaderPage(Driver);
        }

        protected override string GetEndpoint() => END_POINT;
        public override bool IsPageOpened() => TitleClass.Text.Trim().Equals("Your Cart");

        public string? EmptyShoppingCartText() => ItemInShoppingCartClass.Text;

        public IWebElement CheckoutButton => WaitsHelper.WaitForExists(CheckoutButtonBy);
        public IWebElement ItemInShoppingCartClass => WaitsHelper.WaitForExists(ItemInShoppingCartClassBy);
    }
}