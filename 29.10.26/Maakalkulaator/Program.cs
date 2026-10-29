namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Meil on münt, mille diameeter on 25.75 mm
            //Arvutada välja Maa ümbermõõt ja mitu münti
            //mahub järjestikku ümber maa
            //Arvutuses tohib kasutada ainult mündi diameetrit ja Maa raadiust

            double coinDiameter = 25.75; //mm
            double earthRadius = 6378000000;

            double earthCircumference = 2.0 * Math.PI * earthRadius;
            double coinsCount = earthCircumference / coinDiameter;

            Console.WriteLine("Maa ümbermõõt = " + earthCircumference);
            Console.WriteLine("Müntide arv ümber Maa {0:0} ", coinsCount);
        }
    }
}