using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10names_arrayRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
      
            string[] names = { "Peter", "Miles", "Bruce", "Erik", "Logan", "Tony", "Scott", "T'Challa", "Orro", "Jean" };


            for (int i = 0; i <300; i++)
            {
                Console.WriteLine(names[i%names.Length]);
            }
            Console.ReadKey();
        }
    }
}
