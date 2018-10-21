using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesYEscaleras
{
    class Tablero
    {
        public int[] casillas { private set; get; }

        public Tablero()
        {
            casillas = new int[101];
            crearTablero();
        }

        private void crearTablero()
        {
            // serpientes
            casillas[11] = -8;  // 3
            casillas[20] = -18; // 2
            casillas[26] = -17; // 9
            casillas[38] = -15; // 23
            casillas[46] = -14; // 32
            casillas[57] = -25; // 32
            casillas[72] = -11; // 61
            casillas[81] = -6;  // 75
            casillas[84] = -7;  // 77
            casillas[97] = -21; // 76

            // escaleras
            casillas[5] = 9;    // 14
            casillas[13] = 21;  // 34
            casillas[18] = 6;   // 24
            casillas[21] = 13;  // 34
            casillas[36] = 14;  // 50
            casillas[44] = 9;   // 53
            casillas[58] = 22;  // 80
            casillas[66] = 8;   // 74
            casillas[73] = 23;  // 96
            casillas[89] = 5;   // 94
        }
    }
}