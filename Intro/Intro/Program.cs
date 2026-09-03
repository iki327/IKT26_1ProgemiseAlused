namespace Intro  //See on projekti nimetus
{
    internal class Program // See on klassi nimetus
    {
        //meetotit ei saa panna namespacei, kuna see on klassi sees
        static void Main(string[] args) //See on peamine meetud, mis käivitatakse programmi käivitamisel
        {
            Console.WriteLine("Hello, World!"); // See on konsooli väljund, mis prindib "Hello, World!" ekraanile
            //Kui tahad topelt rida teha, siis vajuta Ctrl + D
            //Kui tahad kustutada rida, siis vajuta Ctrl + X
        }

        //Breakepointi saab panna koodirea vasakule poolele,
        //kus on hall ruut. Kui programm jõuab
        //selle koodirea juurde, siis eatub see ja võimaldab teil
        //uurida muutujate väärtusi ja programmi olekut.    
    }
}
