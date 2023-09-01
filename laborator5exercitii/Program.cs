using System;
using System.Linq;
using System.Text;

namespace laborator5exercitii
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex1();
            // Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
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

            if (string.IsNullOrWhiteSpace(string1))
            {
                Console.WriteLine("Nu ai introdus nimic, sau ai introdus un spatiu gol.  Reincearca");
                return;
            }
            int pozitie = string1.IndexOf(string2);
            if (pozitie == -1)
            {
                Console.WriteLine($"{string2} nu se gaseste deloc in {string1}");
            }
            else Console.WriteLine($"{string2} incepe de pe pozitia {pozitie} in {string1}");
        }

        static void Ex2()
        {
            /*
             Scrieti un program care sa verifice daca un sir de caractere citit de la 
             tastatura este sau nu palindrom.
             */
            Console.WriteLine("Introduceti un sir de caractere");
            var enterString = Console.ReadLine().Trim();
            var reverseString = "";

            for (var i = enterString.Length - 1; i >= 0; i--)
            {
                reverseString = reverseString + enterString[i];
            }
            if (enterString == reverseString)
            {
                Console.WriteLine($"sirul {enterString} este palindrom ");
            }
            else
            {
                Console.WriteLine($"sirul {enterString} nu  este palindrom ");
            }
        }

        static void Ex3()
        {
            /*
             Scrieti un program care va numara toate aparitiile unui caracter intr-un sir 
            de caractere. Atat caracterul cautat cat si sirul de caracter vor fi citite de la 
            tastatura
             */
            //prima metodda cu Linq
            //Console.WriteLine("Introduceti sirul : ");
            //var enterString = Console.ReadLine();
            //Console.WriteLine("Introduceti caracterul cautat: ");
            //var enterCharacter = Console.ReadLine().ToCharArray();

            //Console.WriteLine($"caracterul '{enterCharacter[0]}' apare de : {enterString.Where(c => c == enterString[0]).Count()} ori in sirul de caractere");


            // a 2-a metoda cu foreach
            Console.WriteLine("Introduceti sirul : ");
            string enterString = Console.ReadLine();
            Console.WriteLine("Introduceti caracterul cautat: ");
            char enterCharacter = char.Parse(Console.ReadLine());

            Console.WriteLine(CountChar(enterString, enterCharacter));
        }
    
        static int CountChar(string text, char c)
        {
            int countChar = 0;
            foreach (char letter in text)
            {
                if (c == letter)
                {
                    countChar++;
                }
            }
            return countChar;
        }

        static void Ex4()
        {
            /*
             Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr-un string citit
            de la tastatura, ignorand caseing-ul literelor.
            Exemplu:
            Input: Elena are mere
            Output: e apare de 5 ori
             */
            Console.WriteLine("Introduceti un sir de caractere:");
            var text = Console.ReadLine();
            Console.WriteLine("Introduceti caracterul: ");

            Console.WriteLine(CountLetter(text.ToLower()));
        }

        static string CountLetter(string text)
        {
            int[] letterNo = new int[255];
            int max = 0;
            char countLettter = ' ';
            for (int i = 0; i < text.Length; i++)
            {
                letterNo[text[i]]++;
                if (max < letterNo[text[i]])
                {
                    max = letterNo[text[i]];
                    countLettter = text[i];
                }
            }
            var result = $"Litera {countLettter} apare de {max} ori";
            return result;                 
         }

        static StringBuilder Ex5()
        {
            /*
            Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din 
            sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici.
            Exemplu: 
            Input: Ana ARE mErE
            Rezultat: Ana Are Mere
             */

            Console.WriteLine("Introduceti un sir de caractere:");
            string sir = Console.ReadLine();
            StringBuilder rezultat = new StringBuilder(sir.Length);

             bool isFirstCharacter = true;
           
            foreach (char ch in sir)
            {
                if (isFirstCharacter && Char.IsLetter(ch))
                {
                    rezultat.Append(char.ToUpper(ch));
                    isFirstCharacter = false;
                }
                else
                {
                    rezultat.Append(char.ToLower(ch));
                }
                if (char.IsWhiteSpace(ch))
                {
                    isFirstCharacter = true;
                }
            }

            Console.WriteLine("Sirul rezultat este: " + rezultat);
            return rezultat;
        }

        static void Ex6()
        {
            /*
             scrieti un program care va numara vocalele dintr-un sir de caractere citit de 
             la tastatura.
            */

            Console.WriteLine("Introduceti un sir de caractere: ");
            string sir = Console.ReadLine();

            int countVocale = 0;
            for (int i = 0; i< sir.Length; i++)
            {
                if (sir[i] == 'a' || sir[i] == 'e' || sir[i] == 'i' || sir[i] == 'o' || sir[i] == 'u')
                    countVocale++;
            }
            Console.WriteLine(countVocale);
        }


    }
}
