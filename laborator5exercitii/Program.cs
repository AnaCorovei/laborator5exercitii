using System;

namespace laborator5exercitii
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            //Ex7();
        }

        static void Ex1()
        {
            /*Scrieti un program care va afisa pozitia unui substring intr-un string, ambele
            siruri de caractere fiind citite de la tastatura*/

            Console.WriteLine("Introduceti primul sir: ");
            string string1 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(string1))
            {
                Console.WriteLine("Nu ai introdus nimic, sau ai introdus un spatiu gol.  Reincearca");
                return;
            }
            Console.WriteLine("Introduceti al 2-lea sir: ");
            string string2 = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(string1))
            {
                Console.WriteLine("Nu ai introdus nimic, sau ai introdus un spatiu gol.  Reincearca");
                return;
            }
            int pozitie = string1.IndexOf(string2);
            if (pozitie == -1)
            {
                Console.WriteLine($"{string2} nu se gaseste deloc in { string1}");
            }
            else Console.WriteLine($"{string2} incepe de pe pozitia {pozitie} in { string1}");
        }

        static void Ex2()
            /*
             Scrieti un program care sa verifice daca un sir de caractere citit de la 
             tastatura este sau nu palindrom.
             */
    }
}
