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
    public partial class FormLibro : Form
    {
        List<Libro> libros = new List<Libro>();
        public FormLibro()
        {
            InitializeComponent();
        }

        private void mostrar()
        {
            LibroArch libroArch = new LibroArch();
            libros = libroArch.Leer("../../Libros.json");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = libros;
            dataGridView1.Refresh();
        } 
        private void botonmostrar_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void botonguardar_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();

            libro.codigo = txtCodigo.Text;
            libro.nombre_libro = txtNombre.Text;
            libro.autor = txtAutor.Text;

            libros.Add(libro);

            LibroArch libroArch = new LibroArch();
            libroArch.Guardar("../../Libros.json", libros);

            txtNombre.Clear();
            txtAutor.Clear();
            txtCodigo.Clear();
        }
    }
}
