namespace SwitchTestRuhm2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esimeses tehakse korutamine (Sisend küsitakse konsoolis)
            //Teises küsib sinu vanust ja kuvab tulemuse
            //kolmas kutsutakse meetod esile ja see kvab teksti Miau
            Console.WriteLine("Sisesta esimene number!");
            float firstNr = float.Parse(Console.ReadLine());

            Console.WriteLine("Korruta: *");
            string input = Console.ReadLine();

            Console.WriteLine("Sisesta teine number!");
            float secondNr = float.Parse(Console.ReadLine());


            switch (input)
            {
                case "Korrutamine":
                    Console.WriteLine($"Korrutamise tulemus: {firstNr} * {secondNr} = {firstNr * secondNr}");
                    break;

                case "vanus":
                    Console.WriteLine("Kui vana sa oled?");
                    break;

                case "Miau":
                    Miau();
                    break;

                default:
                    Console.WriteLine("Vale meetod");
                    break;
            }
        }

        static void Miau()
        {
            Console.WriteLine("Auh");
        }
    }
}