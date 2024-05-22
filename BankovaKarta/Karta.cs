using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BankovaKarta
{
    internal class Karta
    {
        private string ime;
        private string familiq;
        private int nomerkarta;

        public static string Ime { get; set; }
        public static string Familiq { get; set; }
        public static int NomerKarta { get; set; }
        public static void Izhod()
        {
            Console.WriteLine($"{Ime}");
        }
        




    }
}
