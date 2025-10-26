using NUnit.Framework;
using AppLib;

namespace Tests;

public class FizzBuzzTests
{
    [Test]
    public void FizzBuzz_3_ReturnsFizz()
    {
        Assert.That(FizzBuzzUtil.FizzBuzz(3), Is.EqualTo("Fizz"));
    }

    [Test]
    public void FizzBuzz_5_ReturnsBuzz()
    {
        Assert.That(FizzBuzzUtil.FizzBuzz(5), Is.EqualTo("Buzz"));
    }

    [Test]
    public void FizzBuzz_15_ReturnsFizzBuzz()
    {
        Assert.That(FizzBuzzUtil.FizzBuzz(15), Is.EqualTo("FizzBuzz"));
    }

    [Test]
    public void FizzBuzz_7_Returns7()
    {
        Assert.That(FizzBuzzUtil.FizzBuzz(7), Is.EqualTo("7"));
    }
}
