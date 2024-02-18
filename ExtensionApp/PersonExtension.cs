using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionApp
{
    internal static class PersonExtension
    {
        public static void run (this Person person)
        {
            Console.WriteLine($"{person.Name} can be run");
        }
    }
}
