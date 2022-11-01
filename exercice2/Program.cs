using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int max = 8;
            int[] tab = new int[max];

            tab[0] = 0;
            tab[1] = 2;
            tab[2] = 4;
            tab[3] = 17;
            tab[4] = 50;
            tab[5] = 78;
            tab[6] = 199;
            tab[7] = 200;

            Console.WriteLine("le premier tableau");

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(" - " + tab[i]);
            }
            Console.WriteLine(" \n Entrer un nombre");
            num = Convert.ToInt32(Console.ReadLine());

            Array.Resize<int>(ref tab, tab.Length + 1);
            
            for (int i = 0; i < tab.Length; i++)
            {
                if ( tab [i] >= num )
                {
                    int d = tab [i];
                    tab [i] = num;
                    
                    break;
                }
                
            }
            for (int i = 0; i < tab.Length +1; i++)
            {
                Console.Write(" - " + tab[i]);
            }

        }

    }
}
