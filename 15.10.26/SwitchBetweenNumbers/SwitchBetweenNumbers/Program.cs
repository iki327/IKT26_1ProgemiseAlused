namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");
            //esimese koondtulemuse puhul on number vahemikus 0 kuni 100
            //Teise puhul 101 kuni 200
            //kolmanda puhul 201 kuni 300
            //kasuta switchi

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("Esimene koondtuemus on 0-100");
                    break;

                case >= 101 and <= 200:
                    Console.WriteLine("Teine koondtulemus on 101-200");
                    break;

                case >= 201 and <= 300:
                    Console.WriteLine("Teine koondtulemus on 201-300");
                    break;

                default:
                    Console.WriteLine("Tundmatu numbrivahemik: " + input);
                    break;
            }
        }
    }
}
