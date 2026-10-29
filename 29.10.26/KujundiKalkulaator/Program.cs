namespace Kujundikalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Ruudu sees asub ring. Ringi raadius on 3 ühikut.
            //Leia a väljasta ekraanile ruudu pindala ja ümbermõõt

            int roundRadius = 3;
            //raadius * 2
            int diameter = roundRadius * 2;
            //Ruudu pindala on a*a
            double squareArea = Math.Pow(diameter, 2);
            //double squareArea = diameter * diameter;

            //ümbermõõt = 4 * a
            double squarePerimeter = 4 * diameter;

            Console.WriteLine("Ruudu pindala: " + squareArea);
            Console.WriteLine("Ruudu ümbermõõt: " + squarePerimeter);

            //arvuta rinngi pindala ja ümbermõõt

            //ringi raadius tuleb panna ruutu
            double rounddiameter = Math.Pow(roundRadius, 2);

            double roundarea = rounddiameter * Math.PI;

            Console.WriteLine("Ringi pindala on: " + roundarea);

            //ringi ümbermõõt

            double roundPerimeter = 2 * Math.PI * roundRadius;

            Console.WriteLine("Ringi ümbermõõt: " + roundPerimeter);
        }
    }
}
