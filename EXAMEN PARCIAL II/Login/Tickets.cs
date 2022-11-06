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
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Menu formulario = new Menu();
            Hide();
            formulario.Show();
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (preciotextBox.Text == String.Empty)
            {
                errorProvider1.SetError(preciotextBox, "Ingrese el precio");
                preciotextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            int datos, desc, total;

            datos = (int)(Convert.ToInt32(preciotextBox.Text) * (0.12));
            impuestotextBox.Text = Convert.ToString(datos);


            desc = (int)(Convert.ToInt32(preciotextBox.Text) * (0.05));
            descuentotextBox.Text = Convert.ToString(desc);

            total = (Convert.ToInt32(preciotextBox.Text) - (datos + desc));
            totaltextBox.Text = Convert.ToString(total);

        }

        private async void button3_Click(object sender, EventArgs e)
        {

            TicketDatos ticd = new TicketDatos();
            Ticket ticket = new Ticket();

            ticket = await ticd.GetPorTicket(Convert.ToInt32(usuariotextBox.Text));

            if (ticket.idTicket > 0)
            {
                descripcionrespuestatextBox.Text = ticket.Usuario;
                descripcionsolicitudtextBox.Text = ticket.Impuesto.ToString();
            }

        }
    }
}
