using System;

namespace AppLib;

public static class Pricing
{
    /// <summary>
    /// Menghitung nilai diskon (bukan harga akhir).
    /// </summary>
    /// <param name="total">Total belanja (IDR)</param>
    /// <param name="isMember">Apakah pelanggan member</param>
    /// <returns>Nilai diskon dalam IDR</returns>
    /// <exception cref="ArgumentException">Jika total &lt; 0</exception>
    public static int CalculateDiscount(int total, bool isMember)
    {
        if (total < 0) throw new ArgumentException("total must be non-negative", nameof(total));
        if (total > 100_000)
        {
            if (isMember) return (int)Math.Round(total * 0.10, MidpointRounding.AwayFromZero);
            return (int)Math.Round(total * 0.05, MidpointRounding.AwayFromZero);
        }
        return 0;
    }
}
