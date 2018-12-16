using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void tableroCuadrado_Click(object sender, EventArgs e)
        {
            tablero tableroCuadrado = new tablero();
            
            tableroCuadrado.Show();
            tableroCuadrado.Text = "Tablero Cuadrado";
        }

        private void tableroTriangulo_Click(object sender, EventArgs e)
        {
            tablero tableroTriangulo = new tablero();      
            tableroTriangulo.Show();
            tableroTriangulo.Text = "Tablero Triangulo";
            
        }

        private void tableroHexagono_Click(object sender, EventArgs e)
        {
            tablero tableroHexagono = new tablero();
            tableroHexagono.Show();
            tableroHexagono.Text = "Tablero Hexagonal";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonCuaduardo() {
            Button bc = tableroCuadrado;
            bc.GetType();
        }
    }
}
