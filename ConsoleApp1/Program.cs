using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введите y: ");
        double y = double.Parse(Console.ReadLine());

        Solution solution = new(x, y);

        if (y >= 0 && y <= 1) Console.WriteLine(solution.GetTopSolution());
        else if (y <= 0 && y >= -1) Console.WriteLine(solution.GetBottomSolution());
        else Console.WriteLine(solution.GetZeroSolution());
    }
}