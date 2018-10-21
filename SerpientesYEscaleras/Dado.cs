using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesYEscaleras
{
    class Dado
    {
        static private Random dado;

        public Dado()
        {
            dado = new Random();
        }

        public int lanzar()
        {
            return dado.Next(1,7);
        }
    }
}