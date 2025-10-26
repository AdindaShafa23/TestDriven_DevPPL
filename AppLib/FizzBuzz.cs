namespace AppLib;

public static class FizzBuzzUtil
{
    public static string FizzBuzz(int n)
    {
        bool fizz = n % 3 == 0;
        bool buzz = n % 5 == 0;
        if (fizz && buzz) return "FizzBuzz";
        if (fizz) return "Fizz";
        if (buzz) return "Buzz";
        return n.ToString();
    }
}
