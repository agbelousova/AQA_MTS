using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaucedemoCore.Pages
{
    public class HeaderPage : BasePage
    {
        private static string END_POINT = "";

        private static readonly By HeaderClassBy = By.CssSelector("[class='primary_header']");
        private static readonly By CartVisualFailureClassBy = By.CssSelector("[class='shopping_cart_container visual_failure']");
        private static readonly By ShoppingCartClassBy = By.CssSelector("[class='shopping_cart_link']");
        private static readonly By ShoppingCartLinkBy = By.XPath("//a[@class='shopping_cart_link']");
        private static readonly By CountInShoppingCartClassBy = By.CssSelector("[class='shopping_cart_badge']");

        public HeaderPage(IWebDriver driver) : base(driver)
        {
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return HeaderClass.Displayed;
        }

        public string? EmptyCartText() => ShoppingCartLink.Text;
        public bool IsCartVisualFailureExisted() => CartVisualFailureClass.Displayed;

        public IWebElement HeaderClass => WaitsHelper.WaitForExists(HeaderClassBy);
        public IWebElement CartVisualFailureClass => WaitsHelper.WaitForExists(CartVisualFailureClassBy);
        public IWebElement ShoppingCartClass => WaitsHelper.WaitForExists(ShoppingCartClassBy);
        public IWebElement ShoppingCartLink => WaitsHelper.WaitForExists(ShoppingCartLinkBy);
        public IWebElement CountInShoppingCartClass => WaitsHelper.WaitForExists(CountInShoppingCartClassBy);
    }
}