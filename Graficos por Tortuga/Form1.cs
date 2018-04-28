using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficos_por_Tortuga
{
    public partial class Form1 : Form
    {
        Espacio camp = new Espacio();
        int pluma = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            camp.Avanzar(Convert.ToInt32(txtPasos.Text), pluma);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            txtImprimir.Text = camp.Mostar();
        }

        private void btnGirarD_Click(object sender, EventArgs e)
        {
            camp.GirarDerecha();
        }

        private void btnGirarI_Click(object sender, EventArgs e)
        {
            camp.GirarIzquierda();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pluma == 1)
            {
                pluma--;
                btnpluma.Text = "Plumba Arriba";
            }
            else if(pluma == 0)
            {
                pluma++;
                btnpluma.Text = "Pluma Abajo";
            }
        }
    }
}
