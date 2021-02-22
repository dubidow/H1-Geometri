using System;

namespace Geometri
{
    public class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(laengde: 5000);
            Console.WriteLine(square.Omkreds());

            square.SetSide(laengde: 250);
            Console.WriteLine(square.Omkreds());
            Console.ReadKey();
        }
    }
}
