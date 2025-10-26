using NUnit.Framework;
using AppLib;
using System;

namespace Tests;

public class PricingTests
{
    // Red: tulis semua skenario sebagai test
    [TestCase(120000, true, 12000)]
    [TestCase(120000, false, 6000)]
    [TestCase(100000, true, 0)]
    [TestCase(50000, true, 0)]
    [TestCase(0, false, 0)]
    public void CalculateDiscount_ReturnsExpected(int total, bool isMember, int expectedDiscount)
    {
        var actual = Pricing.CalculateDiscount(total, isMember);
        Assert.That(actual, Is.EqualTo(expectedDiscount));
    }

    [Test]
    public void CalculateDiscount_Negative_Throws()
    {
        Assert.Throws<ArgumentException>(() => Pricing.CalculateDiscount(-1000, true));
    }
}
