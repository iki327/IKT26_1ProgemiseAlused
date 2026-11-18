namespace whileguessgame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretnumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            while (guess != secretnumber)
            {
                Console.Write("Paku number (1-100): ");
                int.TryParse(Console.ReadLine(), out guess);
                attempts++;

                if (guess < secretnumber)
                {
                    Console.WriteLine("Liiga väike!");
                }
                else if (guess > secretnumber)
                {
                    Console.WriteLine("Liiga suur!");
                }
            }

            Console.WriteLine("Õige! Arvasid ära " + attempts + " katsega.");
            Console.ReadLine();
        }
    }
}