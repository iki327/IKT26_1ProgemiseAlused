namespace IfAndElseHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta maja suurus ruutmeetrites: ");
            //Teha neli if-i ja else-i kontrolli, kus kontrollitakse majade ruutmeetrit.
            //Esimene kontroll on 0-40 ruutmeetri juures.
            //Teine kontroll on 41-90 ruutmeetrit,
            //kolmas kontroll on 91-130 ruutmeetrit
            //ja neljas on suuremad, kui 131 ruutmeetrit.
            //Kui mingi suurus on tuvastatud, siis konsool näitab 
            //teksti: Sinu maja suurus on (sisestatud suurus)

            string housesize = Console.ReadLine();
            int house = int.Parse(housesize);

            if (house >= 0 && house <= 40)
            {
                Console.WriteLine("Sinu maja suurus on 0-40 ruutmeetrit");
            }
            else if (house >= 41 && house <= 90)
            {
                Console.WriteLine("Sinu maja suurus on 41-90 ruutmeetrit");
            }
            else if (house >= 91 && house <= 130)
            {
                Console.WriteLine("Sinu maja suurus on 91-130 ruutmeetrit");
            }
            else
            {
                Console.WriteLine("Sinu maja on suurem, kui 131 ruutmeetrit");
            }
        }
    }
}
