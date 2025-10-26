using NUnit.Framework;
using AppLib;

namespace Tests;

public class PrimeTests
{
    // Langkah 1 - RED: Tulis test dulu (contoh kasus awal)
    [TestCase(2, true)]
    [TestCase(4, false)]
    [TestCase(7, true)]
    public void IsPrime_BasicCases(int n, bool expected)
    {
        var actual = NumberUtils.IsPrime(n);
        Assert.That(actual, Is.EqualTo(expected));
    }

    // Langkah 4 - Tambah test cakupan lebih luas
    [TestCase(1, false)]
    [TestCase(13, true)]
    [TestCase(15, false)]
    [TestCase(0, false)]
    [TestCase(-5, false)]
    public void IsPrime_ExtraCoverage(int n, bool expected)
    {
        var actual = NumberUtils.IsPrime(n);
        Assert.That(actual, Is.EqualTo(expected));
    }
}
