namespace Forkillkoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //eelnevaid teadmisi kasutades kirjuta programm mis väljastaks:
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //for loopi sees peab olema for loop
            //peab saama sisestada arvu, mitu korda soovib välundit korrata

            //iga kord kui hakkab väljundit kordama, siis näitab rea numbrit.
            int ridadeArv = int.Parse(Console.ReadLine());

            for (int i = 1; i <= ridadeArv; i++)
            {
                Console.WriteLine("See on rida nr {0}", i);
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("kill - koll");
                }
                Console.WriteLine("killadi - koll");
            }
        }
    }
}
