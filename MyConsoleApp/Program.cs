namespace HelloWorldApp;

namespace HelloWorldApp;

namespace MyConsoleApp
{
    class Program
    /// <summary>
    /// Application entry point. Generates and prints five simple arithmetic equations (addition or subtraction)
    /// using two randomly selected integers and a randomly chosen operator.
    /// </summary>
    /// <param name="args">Command-line arguments (not used).</param>
    /// <remarks>
    /// Each equation is formed as "{num1} {operation} {num2}" where num1 and num2 are integers in the range [1, 99]
    /// and operation is either '+' or '-'. The current implementation creates multiple <see cref="System.Random"/>
    /// instances; consider using a single <see cref="System.Random"/> instance to avoid potential repetition
    /// caused by identical seeds when instantiated repeatedly in quick succession.
    /// </remarks>
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generate equations for addition and subtraction:");
            for (int i = 0; i < 5; i++)
            {
                int num1 = new Random().Next(1, 100);
                int num2 = new Random().Next(1, 100);
                char operation = new Random().Next(0, 2) == 0 ? '+' : '-';
                string equation = $"{num1} {operation} {num2}";
                Console.WriteLine(equation);
            }

        }
    }
}