﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFerreyraRegistroCompras
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)

        {


            frmRegistro frm = new frmRegistro();
            frm.ShowDialog();
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
