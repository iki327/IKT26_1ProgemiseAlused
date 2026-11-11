namespace ForAsterisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta ridad arv: ");

            //tuleb kasutada for loopi
            //sisestan konsooli ridade arvu ja prindib vastavalt ridade arue tärne
            //kasutada for loopi
            //teha vooskeem
                int ridadeArv = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < ridadeArv; i++)
                {
                        Console.WriteLine("*");
                }
            }
        }
    }
