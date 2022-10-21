public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ShowCharacter("Hello World", 7));
        Console.WriteLine($"Retail Price is {CalculateRetail(3.75, 100)}");
        for (int i = 80; i <= 100; i++)
        {
            double convertTemp = Celsius(i);
            Console.WriteLine($"{i} degrees Fahrenheit is, {Math.Round(convertTemp, 2)} degrees Celsius");
        }

        int number = 52;
        bool answer = IsPrime(number);
        Console.WriteLine($"Is the {number} prime?: {answer}");
    }

    //Show Message
    static char ShowCharacter(string input, int num)
    {
        //Displays the character at the index position(for a "normal" person)
        return input[num - 1];
    }

    //Retail Price
    static string CalculateRetail(double wCost, double mPercent)
    {
        mPercent = mPercent / 100;
        var total = (wCost * mPercent) + wCost;
        return total.ToString("C");

    }

    //Temperature Table
    static double Celsius(int temp)
    {
        var temperature = ((5 * (temp - 32.0)) / 9);
        //var temperature = ((5 / 9) * (temp - 32.0));
        return temperature;
    }

    //Prime Numbers
    static bool IsPrime(int num)
    {
        //Checks if the square root of num is an int
        var sqRt = Math.Sqrt(num);
        int roundSqRt = (int)sqRt;

        if (roundSqRt == sqRt)
        {
            return false;
        }

        //Checks every number from rounded sqrt of num to 1
        for (int i = roundSqRt; i >= 2; i = i - 1)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        //No number can evenly divide into the num
        return true;
    }
}