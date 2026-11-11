namespace ForLoopEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //teha for loopiga lõputu tsükkel,
            //mis prindib konsooli i väärus on: number

            //kui i väärtus on 10, siis tsükkel lõppeb
            //for loopi tingimus peab olemas tühjaks jäetud, et see oleks lõputu
            short i = 1;

            for (; ; )
            {
                Console.WriteLine("i väärtus on: " + i);
                i++;
                if (i > 10)
                {
                    break;
                }
            }
        }
    }
}
