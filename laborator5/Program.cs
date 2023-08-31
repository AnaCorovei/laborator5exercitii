using System;

namespace laborator5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Scrieti o functie care va calcula numarul de caractere goale dintr-un string
            */
            //string sir = string.Empty;
            Console.WriteLine(" introduceti un sir de caractere:");
            string sir = Console.ReadLine();
            Console.WriteLine(" nr de spatii este :" + GetWhiteSpacesNo(sir));
       }
        static int GetWhiteSpacesNo(string sir)
        {
            if (string.IsNullOrWhiteSpace(sir) )
            {
                return 0;
            }
            int whiteSpaces = 0;
            for (int i = 0; i< sir.Length; i++)
            {
                if (char.IsWhiteSpace(sir[i]))
                {
                    whiteSpaces++;
                }
            }
            return whiteSpaces;
        }
    }
}
