using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Examen_Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonlibros_Click(object sender, EventArgs e)
        {
            FormLibro formLibro = new FormLibro();
            formLibro.Show();
        }

        private void botonprestamos_Click(object sender, EventArgs e)
        {
            FormPrestamo formPrestamo = new FormPrestamo();
            formPrestamo.Show();
        }

        private void botonreporte_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.Show();
        }

        private void botonlectores_Click(object sender, EventArgs e)
        {
            FormLector formLector = new FormLector();
            formLector.Show();
        }
    }
}
