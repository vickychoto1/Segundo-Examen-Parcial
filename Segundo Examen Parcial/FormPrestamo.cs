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
    public partial class FormPrestamo : Form
    {
        List<Lector> lectores = new List<Lector>();
        List<Prestamo> prestamos = new List<Prestamo>();
        List<Libro> libros = new List<Libro>();
        public FormPrestamo()
        {
            InitializeComponent();
        }
        private void mostrar()
        {
            PrestamoArch prestamoArch = new PrestamoArch();
            prestamos = prestamoArch.Leer("../../Prestamos.json");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = prestamos;
            dataGridView1.Refresh();
        }
        private void botonreporte_Click(object sender, EventArgs e)
        {
            this.Close();
            FormReporte formReporte = new FormReporte();
            formReporte.Show(Owner);
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Close();
            FormReporte formReporte = new FormReporte();
            formReporte.Show(Owner);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            prestamo.codigo = cmbCodigo.Text;
            prestamo.no_identificacion = cmbIdentificacion.Text;
            prestamo.fecha_prestamo = dateTimePicker1.Value;

            prestamos.Add(prestamo);

            PrestamoArch prestamoArch = new PrestamoArch();
            prestamoArch.Guardar("../../Prestamos.json", prestamos);
    }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void FormPrestamo_Load(object sender, EventArgs e)
        {
            LibroArch libroArch = new LibroArch();
            libros = libroArch.Leer("../../Libros.json");

            cmbCodigo.DataSource = libros;
            cmbCodigo.DisplayMember = "codigo";
            cmbCodigo.ValueMember = "codigo";

            LectorArch lectorArch = new LectorArch();
            lectores = lectorArch.Leer("../../Lectores.json");

            cmbIdentificacion.DataSource = lectores;
            cmbIdentificacion.DisplayMember = "no_identificacion";
            cmbIdentificacion.ValueMember = "no_identificacion";
        }
    }
}
