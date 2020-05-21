using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_names
{
    class Program
    {
        static void Main(string[] args)
        {
            Names n = new Names();

            n.DisplayNames();
            Console.WriteLine();

            n.Add("Czenk Ferenc");
            n.DisplayNames();

            Console.WriteLine();
        }
    }
}
