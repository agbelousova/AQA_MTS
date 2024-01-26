namespace NUnitProject;

[Description("Tests for Math Operations")]
[Author("Svist Anastasia", "agsvist@gmail.com")]
public class TestCase
{
    [TestCase(1, 2, 3)]
    [TestCase(-1, -2, -3)]
    [Order(2)]
    [Severity(SeverityLevel.Major)]
    [Category("Regression")]
    public void Sum1(int x, int y, int result)
    {
        Assert.That(Calc.Sum(x, y), Is.EqualTo(result));
    }

    [TestCase(1, 2, ExpectedResult = 3)]
    [TestCase(-1, -2, ExpectedResult = -3)]
    [Order(3)]
    [Severity(SeverityLevel.Major)]
    [Category("Regression")]
    public int Sum2(int x, int y)
    {
        return Calc.Sum(x, y);
    }
    
    [TestCaseSource(typeof(TestData), nameof(TestData.DivideCases))]
    [Order(1)]
    [Severity(SeverityLevel.Critical)]
    [Category("Smoke")]
    public void DivInt<var>(var n, var d, var q)
    {
        if (Convert.ToInt32(d) != 0)
           
        Assert.AreEqual( Calc.DivInt(Convert.ToInt32(n), Convert.ToInt32(d)), Convert.ToInt32(q));
        else
        {
            Console.WriteLine("Деление на 0!");
            Assert.Pass();
        }
    }
    
    [TestCaseSource(typeof(TestData), nameof(TestData.DivideCases))]
    [Order(4)]
    [Severity(SeverityLevel.Critical)]
    [Category("Smoke")]
    public void DivDouble(double n, double d, double q)
    {
        if (d!=0)
            Assert.That(Calc.DivDouble(n,d), Is.EqualTo(q));
        else
        {
            Console.WriteLine("Деление на 0!");
            Assert.Pass();
        }
    }
    
}