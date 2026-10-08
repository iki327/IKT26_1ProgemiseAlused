using System.Diagnostics;

namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täringu viskamise mäng");

            //Random genereerib iga kord suvalise numbri 1-st kuni 6-ni
            int cube = new Random().Next(1, 6);

            //kasuta switchi ja iga juhtum tuleb ära printida, mis number tuli

            switch (cube)
            {
                case 1:
                    Console.WriteLine("Veeretasid number 1");
                    break;
                case 2:
                    Console.WriteLine("Veeretasid number 2");
                    break;
                case 3:
                    Console.WriteLine("Veeretasid number 3");
                    break;
                case 4:
                    Console.WriteLine("Veeretasid number 4");
                    break;
                case 5:
                    Console.WriteLine("Veeretasid number 5");
                    break;
                case 6:
                    Console.WriteLine("Veeretasid number 6");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }

        }
    }
}
