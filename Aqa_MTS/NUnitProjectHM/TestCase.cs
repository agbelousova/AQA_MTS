namespace NUnitProject;

[Description("Tests for Math Operations")]
[Author("Svist Anastasia", "agsvist@gmail.com")]
[TestFixture]
public class TestCase
{
    [TestCase(1, 2, 3)]
    [TestCase(-1, -2, -3)]
    [Order(1)]
    [Severity(SeverityLevel.Major)]
    [Category("Positive")]
    public void Sum1(int x, int y, int result)
    {
        Assert.That(Calc.Sum(x, y), Is.EqualTo(result));
    }

    [TestCase(1, 2, ExpectedResult = 3)]
    [TestCase(-1, -2, ExpectedResult = -3)]
    [Order(2)]
    [Severity(SeverityLevel.Major)]
    [Category("Positive")]
    public int Sum2(int x, int y)
    {
        return Calc.Sum(x, y);
    }
    
    [Order(3)]
    [Severity(SeverityLevel.Critical)]
    [Category("Positive")]
    [Description("Позитивная проверка деления int")]
    [TestCase(12, 2, ExpectedResult = 6)]
    [TestCase(20, 4, ExpectedResult = 5)]
    public int DivTestInt(int x, int y)
    {
        return Calc.Div(x, y);
    }
    
    [Order(4)]
    [Severity(SeverityLevel.Critical)]
    [Category("Negative")]
    [Description("Негативная проверка деления int")]
    [TestCase(10,0)]
    public void DivIntTestNegative(int x, int y)
    {
        Assert.Throws<DivideByZeroException>(() => Calc.Div(x, y));
    }
    
    [Order(5)]
    [Severity(SeverityLevel.Critical)]
    [Category("Positive")]
    [Description("Позитивная проверка деления double")]
    [Repeat(2)]
    [TestCase(10.0, 2.5, ExpectedResult = 4.0)]
    [TestCase(15.0, 2.0, ExpectedResult = 7.5)]
    public double DivTestDoule(double x, double y)
    {
        return Calc.Div(x, y);
    }
    
    [Order(5)]
    [Severity(SeverityLevel.Critical)]
    [Category("Negative")]
    [Description("Негативная проверка деления double")]
    [TestCase(5.5, 0)]
    public void DivTestDoubleN(double x, double y)
    {
        if (double.IsNaN(x/y))
            Assert.Fail();
        else
            Assert.Pass();
    }
    
    [TestCaseSource(typeof(TestData), nameof(TestData.DivideCases))]
    [Order(4)]
    [Severity(SeverityLevel.Minor)]
    [Ignore("Для примера")]
    [TestCase(6, 2, ExpectedResult = 3)]
    public int DivDoubleTest(int x, int y)
    {
        if (x != y)
            return Calc.Div(x, y);
        else return Calc.Sum(x, y);
    }
    
    private int i = 0;
    [Order(4)]
    [Severity(SeverityLevel.Minor)]
    [Retry(3)]
    public void RetryTest()
    {
        Console.WriteLine($"Для примера использования {this}: RetryTest... {++i}");
        if (i == 3) Assert.Pass();
        else Assert.Fail();
    }
    
}