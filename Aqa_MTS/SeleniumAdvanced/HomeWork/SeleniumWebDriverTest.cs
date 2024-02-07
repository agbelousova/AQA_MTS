using System.Reflection;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumAdvanced.Tests;

namespace SeleniumAdvanced.HomeWork;

public class SeleniumWebDriverTest : BaseTest
{
    /*
     * Задание 1: Добавить тест для страницы Context Menu
Правый клик по элементу
Валидация текста на алерте
Закрытие алерта
     */
    [Test]
    [Description("Context Menu")]
    public void ContextMenuTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/context_menu");
        IWebElement hotSpot = WaitsHelper.FluentWaitForElement(By.Id("hot-spot"));
        var actions = new Actions(Driver);
        actions
            .MoveToElement(hotSpot, 10, 10)
            .ContextClick()
            .Build()
            .Perform();

        IAlert alert = Driver.SwitchTo().Alert();

        Assert.That(alert.Text, Is.EqualTo("You selected a context menu"));
        alert.Accept();
    }
    
   /* Задание 2: Добавить тест для страницы Dynamic Controls
    Нажать на кнопку Remove около чекбокса
    Дождаться надписи “It’s gone”
    Проверить, что чекбокса нет
        Найти инпут
        Проверить, что он disabled
    Нажать на кнопку
        Дождаться надписи “It's enabled!”
    Проверить, что инпут enabled
    */
   [Test]
   [Description("Dynamic Controls")]
   public void DynamicControlsTest()
   {
       Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_controls");
       IWebElement removeButton = Driver.FindElement(By.XPath("//button[. = 'Remove']"));
       IWebElement checkboxElement = Driver.FindElement(By.Id("checkbox"));
       removeButton.Click();
       IWebElement messageRemoveElement = WaitsHelper.FluentWaitForElement(By.XPath("//form[@id='checkbox-example']/p"));
       
       Assert.Multiple(() =>
       {
           Assert.That(messageRemoveElement.Text, Is.EqualTo("It's gone!"));
           Assert.That(WaitsHelper.WaitForElementInvisible(checkboxElement));
       });
       
       IWebElement elementInput = Driver.FindElement(By.XPath("//form[@id='input-example']/input"));
       Assert.That(!elementInput.Enabled);
       IWebElement inputButton = Driver.FindElement(By.XPath("//form[@id='input-example']/button"));
       inputButton.Click();
       IWebElement messageInputElement = WaitsHelper.FluentWaitForElement(By.XPath("//form[@id='input-example']/p[@id='message']"));
       Assert.Multiple(() =>
       {
           Assert.That(messageInputElement.Text, Is.EqualTo("It's enabled!"));
           Assert.That(elementInput.Enabled);
       });
   }
   /*
        Задание 3: Добавить тест для страницы File Upload
    Загрузить файл
    Проверить, что имя файла на странице совпадает с именем загруженного файла
    */
   [Test]
   [Description("File Upload")]
   public void FileUploadTest()
   {
       Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");
       var fileUploadPath = WaitsHelper.WaitForExists(By.Id("file-upload"));

       string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
       string filePath = Path.Combine(assemblyPath, "Resources", "download.jpeg");

       fileUploadPath.SendKeys(filePath);

       WaitsHelper.WaitForExists(By.Id("file-submit")).Submit();
       Thread.Sleep(2000);//чтоб успеть увидеть результат
       Assert.That(WaitsHelper.WaitForExists(By.Id("uploaded-files")).Text, Is.EqualTo("download.jpeg"));
   }
   /*
    Задание 4: Добавить тест для страницы Frames
        Открыть iFrame
        Проверить, что текст внутри параграфа равен “Your content goes here.”
    */
   [Test]
   [Description("Frames")]
   public void FramesTest()
   {
       Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/frames");
       Driver.FindElement(By.LinkText("iFrame")).Click();
       Driver.SwitchTo().Frame("mce_0_ifr");
       Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.XPath("//*[@id='tinymce']/p")).Text, Is.EqualTo("Your content goes here."));
   }
}