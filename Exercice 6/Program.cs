/**
 * * Exercice 6
 * * Auteur: Mostaghfera Ahadi
 * * date: 01/10/2024
 */
using System;


namespace Exercice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float moyenne;

            Console.Write("Entrez votre moyenne = ");
            moyenne = float.Parse(Console.ReadLine());
            if (moyenne>=16)
            {
                Console.Write("très bien");
            }
            else
            {
                if (moyenne>=14)
                {
                    Console.Write("bien");
                }
                else
                {
                    if (moyenne>=12)
                    {
                        Console.Write("assez bien");
                    }
                    else
                    {
                        if (moyenne >=10)
                        {
                            Console.Write("passable");
                        }
                        else
                        {
                            if (moyenne < 10)
                            {
                                Console.Write("recalé");
                            }
                        }

                    }
                }
               
            }
            Console.ReadLine();
        }
    }
}
