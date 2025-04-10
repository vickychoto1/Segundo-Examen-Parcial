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
    public partial class FormLector : Form
    {
        List<Lector> lectores = new List<Lector>();
        public FormLector()
        {
            InitializeComponent();
        }
        private void mostrar()
        {
            LectorArch lectorArch = new LectorArch();
            lectores = lectorArch.Leer("../../Lectores.json");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lectores;
            dataGridView1.Refresh();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Lector lector = new Lector();
            lector.no_identificacion = txtIdentificacion.Text;
            lector.nombre_lector = txtNombre.Text;

            lectores.Add(lector);

            LectorArch lectorArch = new LectorArch();
            lectorArch.Guardar("../../Lectores.json", lectores);

            txtNombre.Clear();
            txtIdentificacion.Clear();
        }
    }
}
