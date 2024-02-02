using OpenQA.Selenium;
using Locators_HM.Helpers.Configuration;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace Locators_HM.Tests;

public class LocatorsTest : BaseTest
{
    [Test]
    public void basicLocatorsTest()
    {
        Driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        // поиск по ID
        Driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
        // Fпоиск по Name
        Driver.FindElement(By.Name("password")).SendKeys("secret_sauce");
        Driver.FindElement(By.Id("login-button")).Click();
        // поиск по TagName
        IWebElement selectWebElement1 = Driver.FindElement(By.TagName("select"));
        selectWebElement1.Click();
        SelectElement selectWebElement = new SelectElement(selectWebElement1);
        selectWebElement.SelectByValue("za");
        // поиск по linkText
        Driver.FindElement(By.LinkText("Sauce Labs Onesie")).Click();
        // поиск по className
        Driver.FindElement(By.ClassName("inventory_details_back_button")).Click();
        // поиск по partiallinktext
        Driver.FindElement(By.PartialLinkText("Labs Backpack")).Click();
        
        Console.WriteLine($"{this} Finished...");
    }

    [Test]
    public void locatorsXPathTest()
    {
        Driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        //Поиск по атрибуту, например By.xpath("//tag[@attribute='value']");
        Driver.FindElement(By.XPath("//input[@id = 'user-name']")).SendKeys("standard_user");
        Driver.FindElement(By.XPath("//input[@id = 'password']")).SendKeys("secret_sauce");
        //Поиск по частичному совпадению атрибута, например By.xpath("//tag[contains(@attribute,'text')]");
        Driver.FindElement(By.XPath("//input[contains(@name,'button')]")).Click();
        //Поиск по тексту, например By.xpath("//tag[text()='text']");
        Driver.FindElement(By.XPath("//div[text() = 'Sauce Labs Backpack']")).Click();
        //Поиск по частичному совпадению текста, например By.xpath("//tag[contains(text(),'text')]");
        Driver.FindElement(By.XPath("//button[contains(text(), 'cart')]")).Click();
        //ancestor, например //*[text()='Enterprise Testing']//ancestor::div
        Driver.FindElement(By.XPath("//*[@id = 'back-to-products']//ancestor::button")).Click();
        //descendant
        Driver.FindElement(By.XPath("//div[@id = 'header_container']/descendant::div[@id = 'shopping_cart_container']")).Click();
        //following
        Driver.FindElement(By.XPath("//div[@class='cart_desc_label']/following::button[@id='remove-sauce-labs-backpack']")).Click();
        //preceding
        Driver.FindElement(By.XPath("//footer[@class='footer']/preceding::button[@id='continue-shopping']")).Click();
        //parent
        Driver.FindElement(By.XPath("//div[@class='inventory_item_name ']/parent::a[@id='item_4_title_link']")).Click();
        //поиск элемента с условием AND, например //input[@class='_2zrpKA _1dBPDZ' and @type='text']
        Driver.FindElement(By.XPath("//button[@id='back-to-products' and @name='back-to-products']")).Click();
            
        Console.WriteLine($"{this} Finished...");
    }

    [Test]
    public void locatorsCssTest()
    {
        Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        
        // .class
        Driver.FindElement(By.CssSelector("input"));
        //.class1.class2
        Driver.FindElement(By.CssSelector(".input_error.form_input")).SendKeys("standard_user");
        //.class1 .class2
        Driver.FindElement(By.CssSelector(".login_container .login_logo"));
        //#id
        Driver.FindElement(By.CssSelector("#password")).SendKeys("secret_sauce");;
        //tagname
        Driver.FindElement(By.CssSelector("input"));
        //tagname.class
        Driver.FindElement(By.CssSelector("div.form_group"));
        //[attribute=value]
        Driver.FindElement(By.CssSelector("[id='login-button']")).Click();
        //[attribute~=value]
        Driver.FindElement(By.CssSelector("button[name~='add-to-cart-sauce-labs-backpack']")).Click();
        //[attribute|=value]
        Driver.FindElement(By.CssSelector("button[name|='remove-sauce-labs-backpack']")).Click();
        //[attribute^=value]
        Driver.FindElement(By.CssSelector("select[class^='product_']"));
        //[attribute$=value]
        Driver.FindElement(By.CssSelector("a[class$='_cart_link']"));
        //[attribute*=value]
        Driver.FindElement(By.CssSelector("div[class*='_item_']"));

        Console.WriteLine($"{this} Finished...");
    }
}