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
    public partial class tablero : Form
    {
        public tablero()
        {
            InitializeComponent();
        }

        PaintEventArgs p;
        private PictureBox pictureBox1 = new PictureBox();

        private void tablero_Load(object sender, EventArgs e)
        {
            triangulo t = new triangulo();
            //t.picGrid_Paint(sender, System.Windows.Forms.PaintEventHandler(pictureBox1));
        }

        private void PintarTriangulo(object sender, PaintEventArgs pintar) {
            p = pintar;
            triangulo t = new triangulo();
            t.picGrid_Paint(sender, p);
        }



        
    }
}
