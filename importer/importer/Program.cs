using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace importer
{
    class Program
    {
        static void Main(string[] args)
        {
            InjectionHelpers helpers = new InjectionHelpers();
            Console.WriteLine(helpers.CsvReader("DOTSC_GRIT_InjCrs1317.csv"));
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
