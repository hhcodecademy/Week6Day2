using ExtensionApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtenstionApp2
{
    internal static class PersonExtenstion
    {
        public static void run(this Person item, float speed) {
            Console.WriteLine( $"{item.Name} can be run with {speed}");
        }
    }
}
