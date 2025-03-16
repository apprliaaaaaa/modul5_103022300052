using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300052
{
    class HaloGeneric
    {
        public static void SapaUser<T>(T nama)
        {
            Console.WriteLine($"Halo user {nama}");
        }
    }
}
