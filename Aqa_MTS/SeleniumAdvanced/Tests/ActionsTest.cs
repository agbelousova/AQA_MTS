using System.Collections.ObjectModel;
using System.Reflection;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvanced.Tests;

public class ActionsTest : BaseTest
{
    [Test]
    public void HoverTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/hovers");

        var actions = new Actions(Driver);

        var targetElements = WaitsHelper.WaitForAllVisibleElementsLocatedBy(By.CssSelector(".figure"));
        actions
            .MoveToElement(targetElements[0], 10, 10)
            .Click(WaitsHelper.WaitForExists(By.CssSelector("[href='/users/1']")))
            .Build()
            .Perform();
        
        Assert.That(WaitsHelper.WaitForElementInvisible(targetElements[0]));
       /* Assert.Multiple(
        {
            Assert.That(WaitsHelper.WaitForElementInvisible(targetElements[0]));
            Assert.That(WaitsHelper.WaitForAllVisibleElementsLocatedBy(By.TagName("h1")).Text, Is.EqualTo("Not Found"));
        });*/
    }

    [Test]
    public void DragDropTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/drag_and_drop");

        var actions = new Actions(Driver);

        var targetElementsA = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("column-a"));
        var targetElementsB = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("column-b"));
        actions
            .DragAndDrop(targetElementsA, targetElementsB)
            .Pause(TimeSpan.FromSeconds(3))
            .Build()
            .Perform();
    }
    
    [Test]
    public void CheckboxTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/checkboxes");

        var actions = new Actions(Driver);

        var targetElementsA = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("#checkboxes input"));
        
        actions
            .MoveToElement(targetElementsA)
            .Click()
            .Pause(TimeSpan.FromSeconds(3))
            .Build()
            .Perform();
    }
    
    [Test]
    public void FileUploadTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");

        var fileUploadPath = WaitsHelper.WaitForExists(By.Id("file-upload"));
        // Получаем путь к исполняемому файлу (exe)
        string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        // Конструируем путь к файлу внутри проекта
        string filePath = Path.Combine(assemblyPath, "Resources", "download.jpeg");
        Console.WriteLine(filePath);
        
        fileUploadPath.SendKeys(filePath);
        
        WaitsHelper.WaitForExists(By.Id("file-submit")).Submit();
        Thread.Sleep(5000);
    }
}