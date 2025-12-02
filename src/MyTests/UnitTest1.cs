using NUnit.Framework;

public class MyAlgorithmsTests
{
    //ReverseInt
    [Test]
    public void ReverseInt_PositiveNumber()
    {
        Assert.AreEqual(321, MyAlgorithms.ReverseInt(123));
    }

    [Test]
    public void ReverseInt_NegativeNumber()
    {
        Assert.AreEqual(-321, MyAlgorithms.ReverseInt(-123));
    }

    [Test]
    public void ReverseInt_EndsWithZero()
    {
        Assert.AreEqual(-21, MyAlgorithms.ReverseInt(-120));
    }

    [Test]
    public void ReverseInt_OverflowCheck()
    {
        Assert.AreEqual(100000001, MyAlgorithms.ReverseInt(100000001));
    }

    //IntToRoman
    [Test]
    public void IntToRoman_SimpleCases()
    {
        Assert.AreEqual("IX", MyAlgorithms.IntToRoman(9));
    }

    [Test]
    public void IntToRoman_ComplexCases()
    {
        Assert.AreEqual("MCMXCIV", MyAlgorithms.IntToRoman(1994));
    }

    [Test]
    public void IntToRoman_BoundaryCase()
    {
        Assert.AreEqual("MMMCMXCIX", MyAlgorithms.IntToRoman(3999));
    }

    [Test]
    public void IntToRoman_AnotherCase()
    {
        Assert.AreEqual("C", MyAlgorithms.IntToRoman(100));
    }

    //Factorial
    [Test]
    public void Factorial_SmallValues()
    {
        Assert.AreEqual(1, MyAlgorithms.Factorial(0));
        Assert.AreEqual(1, MyAlgorithms.Factorial(1));
    }

    [Test]
    public void Factorial_NormalValues()
    {
        Assert.AreEqual(6, MyAlgorithms.Factorial(3));
        Assert.AreEqual(120, MyAlgorithms.Factorial(5));
    }

    //Fibonacci
    [Test]
    public void Fibonacci_SmallNumbers()
    {
        Assert.AreEqual(0, MyAlgorithms.Fibonacci(0));
        Assert.AreEqual(1, MyAlgorithms.Fibonacci(1));
    }

    [Test]
    public void Fibonacci_LargerNumbers()
    {
        Assert.AreEqual(13, MyAlgorithms.Fibonacci(7));
        Assert.AreEqual(21, MyAlgorithms.Fibonacci(8));
    }

    //IsPalindrome
    [Test]
    public void IsPalindrome_TrueCases()
    {
        Assert.IsTrue(MyAlgorithms.IsPalindrome(121));
        Assert.IsTrue(MyAlgorithms.IsPalindrome(12321));
    }

    [Test]
    public void IsPalindrome_FalseCases()
    {
        Assert.IsFalse(MyAlgorithms.IsPalindrome(123));
        Assert.IsFalse(MyAlgorithms.IsPalindrome(-121));
    }

    //IsPrime
    [Test]
    public void IsPrime_PrimeNumbers()
    {
        Assert.IsTrue(MyAlgorithms.IsPrime(2));
        Assert.IsTrue(MyAlgorithms.IsPrime(13));
    }

    [Test]
    public void IsPrime_NonPrimeNumbers()
    {
        Assert.IsFalse(MyAlgorithms.IsPrime(1));
        Assert.IsFalse(MyAlgorithms.IsPrime(100));
    }

    //SubstringIndex
    [Test]
    public void SubstringIndex_Found()
    {
        Assert.AreEqual(1, MyAlgorithms.SubstringIndex("hello", "he"));
        Assert.AreEqual(3, MyAlgorithms.SubstringIndex("hello", "llo"));
    }

    [Test]
    public void SubstringIndex_NotFound()
    {
        Assert.AreEqual(-1, MyAlgorithms.SubstringIndex("hello", "xyz"));
        Assert.AreEqual(-1, MyAlgorithms.SubstringIndex("abc", "d"));
    }

    //IsSorted
    [Test]
    public void IsSorted_All()
    {
        Assert.AreEqual(112, MyAlgorithms.SortDigits(121));
        Assert.AreEqual(123, MyAlgorithms.SortDigits(123));
        Assert.AreEqual(0, MyAlgorithms.SortDigits(0));
        Assert.AreEqual(1, MyAlgorithms.SortDigits(10));
    }
}
