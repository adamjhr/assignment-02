namespace Assignment2;

public static class Delegates {
    public delegate void ReverseString(string arg);

    public static void PrintReverse(string arg) {
        var reverse = new ReverseString(
            delegate (string arg)
            {
                var stringAsCharArray = arg.ToCharArray();
                for (int i = stringAsCharArray.Length - 1; i >= 0; i--) {
                    Console.Write(stringAsCharArray[i]);
                }
                Console.WriteLine();
            }
        );

        reverse(arg);
    }

    public delegate double GetProduct(double a, double b);

    public static double ProductOfTwoNumbers(double a, double b) {
        var del = new GetProduct(
            delegate (double a, double b) {
                return a * b;
            }
        );

        return del(a,b);
    }

    public delegate bool NumericallyEquivalent(int a, string b);

    public static bool NumericallyEqualStringAndInteger(int a, string b) {
        var del = new NumericallyEquivalent(
            delegate (int a, string b) {
                try {
                    return a == Int32.Parse(b);
                } catch (FormatException) {
                    return false;
                }
                
            }
        );

        return del(a, b);
    }
}