namespace IfAndElseNesting3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha üks if ja else nestimine iseseivaslt");
            Console.WriteLine("Teise else if-i sisse panna if ja else nestimine");
            //konsool küsib numbrit
            //if võrdub 12
            //else if ja siia sisse omakorda teha if ning else. Else if tingimus on, et 
            //muutuja on suurem kui 20
            //else ja seal väljastab konsool teksti: mingisugused kahtlased väärtused.

            int number = 12;
            if (number == 12)
            {
                Console.WriteLine("Number on 12");
            }
            else if (number > 20)
            {
                if (number == 32)
                {
                    Console.WriteLine("Number on 32");
                }
                else
                {
                    Console.WriteLine("See on tundmatu number");
                }
            }
            else
            {
                Console.WriteLine("Mingusugused kahtlased väärtused!");
            }
        }
    }
}
