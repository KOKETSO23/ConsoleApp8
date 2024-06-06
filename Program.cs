namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first length");
            double firstLength = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second length");
            double secondLength = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height");
            double height = double.Parse(Console.ReadLine());

            Trapezium trapezium = new Trapezium(firstLength, secondLength, height);
            trapezium.Display();
        }
    }
}