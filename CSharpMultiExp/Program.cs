internal class Program
{
    static void Main(string[] args)
    {

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Red;

        Console.Clear();

        int num1, num2, result = 0;

        Console.Write("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.White;

        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < num2; i = i + 1)
        {
            result += num1;
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.White;


        Console.WriteLine("Multiplication Result: " + result);
        Console.Read();


    }

}