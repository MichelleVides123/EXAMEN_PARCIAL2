using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Tipos : Form
    {
        public Tipos()
        {
            InitializeComponent();
        }

        ProductoDatos proDatos = new ProductoDatos();
        Producto producto = new Producto();

        private void Tipos_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Menu formulario = new Menu();
            Hide();
            formulario.Show();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (descripciontextBox.Text == String.Empty)
            {
                errorProvider1.SetError(descripciontextBox, "Ingrese una descripcion");
                descripciontextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (registrotextBox.Text == String.Empty)
            {
                errorProvider1.SetError(registrotextBox, "Ingrese un registro");
                registrotextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (UStextBox.Text == String.Empty)
            {
                errorProvider1.SetError(UStextBox, "Ingrese un usuario");
                UStextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (existenciatextBox.Text == String.Empty)
            {
                errorProvider1.SetError(existenciatextBox, "Ingrese una cantidad");
                existenciatextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (preciotextBox.Text == String.Empty)
            {
                errorProvider1.SetError(preciotextBox, "Ingrese un precio");
                preciotextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            int total;

            total = Convert.ToInt32(existenciatextBox.Text) * Convert.ToInt32(preciotextBox.Text);

            totaltextBox.Text = Convert.ToString(total);

            producto.Descripcion = descripciontextBox.Text;
            producto.Registro = registrotextBox.Text;
            producto.Usuario = UStextBox.Text;
            producto.Precio = Convert.ToUInt32(totaltextBox.Text);
            producto.Fecha = dateTimePicker1.Value;

            bool inserto = await proDatos.InsertarAsync(producto);
            MessageBox.Show("Registros Guardados", "", MessageBoxButtons.OK);

        }

    }
}
