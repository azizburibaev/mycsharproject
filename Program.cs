using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Project");
            int [] myInt = {1,2, 3}; 
            foreach (var item in myInt)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
