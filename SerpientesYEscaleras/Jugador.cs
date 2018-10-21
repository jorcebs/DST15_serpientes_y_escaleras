using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesYEscaleras
{
    class Jugador
    {
        public string nombre { private set; get; }
        public int casilla { private set; get; }


        public Jugador(string nombre)
        {
            this.nombre = nombre;
            casilla = 0;
        }

        public int lanzarDado(Dado dado)
        {
            return dado.lanzar();
        }

        public void avanzar(int cantidad)
        {
            casilla += cantidad;
        }
    }
}