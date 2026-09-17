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

            int x = 12;
            if (x == 12)
            {
                Console.WriteLine("X võrdub 12");
            }
            else if (x > 20)
            {
                if (x == 32)
                {
                    Console.WriteLine("Y võrdub 32");
                }
                else
                {
                    Console.WriteLine("Y on tundmatu number");
                }
            }
            else
            {
                Console.WriteLine("Mingusugused kahtlased väärtused!");
            }
        }
    }
}
