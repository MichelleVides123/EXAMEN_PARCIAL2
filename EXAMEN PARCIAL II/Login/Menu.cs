﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void tIPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipos tipos = new Tipos();
            Hide();
            tipos.Show();

        }

        private void tICKETSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets();
            Hide();
            tickets.Show();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
