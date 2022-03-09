using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploProductos
{
    public partial class Form1 : Form

    {
        ListaProductos listaProductos = new ListaProductos();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = mtxtNombre.Text;
            producto.Tamanio = cmbTamanio.SelectedItem.ToString();
            producto.Color = Color();
            producto.Estado = Estado();
            listaProductos.AnadirElemento(producto);
            MessageBox.Show("Producto Guardado");
        }
        public string Color()
        {
            string aux;
            if (chbBlanco.Checked)
            {
                aux = "Blanco";

            }
            else
            {
                aux = "Gris";
            }
            return aux;
        }
        public string Estado()
        {
            string aux;
            if(rbtnBueno.Checked)
            {
                aux = "Bueno";
            }
            else
            {
                aux = "Malo";
            }
            return aux;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.ListaProductos2 = listaProductos;
        }

        private void cmbTamanio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
