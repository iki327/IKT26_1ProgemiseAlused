namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //konsoolis sisestame numbri
            //see number savestatakse string andmetüüpi
            //toimub kontroll, kas sisestatud väärtus on number
            //kasutada if ja else lauseid
            string input = Console.ReadLine();

            // Loome muutuja, kuhu eduka kontrolli puhul arv salvestatakse
            int number;

            // Toimub kontroll, kas sisestatud väärtus on number
            // Kasutame if ja else lauseid
            if (int.TryParse(input, out number))
            {
                // KUI SISEND ON NUMBER, SIIS JÄTKAME KONTROLLIGA:
                Console.WriteLine($"\nÕige! Sisestatud väärtus '{number}' on number.");

                // 1. Kontrollime, kas number on positiivne, negatiivne või null
                if (number > 0)
                {
                    Console.WriteLine("-> See on positiivne number.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("-> See on negatiivne number.");
                }
                else
                {
                    Console.WriteLine("-> See number on null.");
                }

                // 2. Kontrollime, kas number on paaris või paaritu
                // Jäägi operaator % tagastab nulli, kui arv jagub kahega
                if (number % 2 == 0)
                {
                    Console.WriteLine("-> See on paarisarv.");
                }
                else
                {
                    Console.WriteLine("-> See on paaritu arv.");
                }
            }
            else
            {
                // KUI SISEND EI OLE NUMBER:
                Console.WriteLine($"\nViga! '{input}' ei ole korrektne täisarv.");
            }
        }
    }
}