using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerpientesYEscaleras
{
    public partial class Form1 : Form
    {
        private Tablero tablero;
        private Jugador jugador1;
        private Jugador jugador2;
        private Dado dado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            tablero = new Tablero();
            dado = new Dado();
            jugador1 = new Jugador("Marco");
            jugador2 = new Jugador("Polo");

            txtJuego.Clear();

            while (jugador1.casilla < 100 && jugador2.casilla < 100)
            {
                jugar(jugador1);
                if (jugador1.casilla < 100)
                    jugar(jugador2);

                txtJuego.Text += Environment.NewLine;
            }
        }

        private void jugar(Jugador jugador)
        {
            int num = jugador.lanzarDado(dado);
            jugador.avanzar(num);

            txtJuego.Text += jugador.nombre + " lanza el dado y obtiene " + num.ToString() + Environment.NewLine;

            if (jugador.casilla < 100)
            {
                txtJuego.Text += jugador.nombre + " se encuentra en la casilla " + jugador.casilla.ToString() + Environment.NewLine;
                num = tablero.casillas[jugador.casilla]; //duda, entendimiento o rendimiento?

                if (num > 0)
                {
                    txtJuego.Text += jugador.nombre + " encuentra una escalera y avanza a la casilla " + (jugador.casilla + num).ToString() + Environment.NewLine;
                }
                else if (num < 0)
                {
                    txtJuego.Text += jugador.nombre + " encuentra una serpiente y retrocede a la casilla " + (jugador.casilla + num).ToString() + Environment.NewLine;
                }

                jugador.avanzar(num); //duda, entendimiento o rendimiento?
            }
            else
            {
                txtJuego.Text += "¡¡¡" + jugador.nombre + " ha alcanzado la meta!!!";
            }
        }
    }
}