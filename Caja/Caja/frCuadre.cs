﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja
{
    public partial class frCuadre : Form
    {
        public frCuadre()
        {
            InitializeComponent();
        }

        private void Seleccionarbtn_Click(object sender, EventArgs e)
        {
            frMovimientos frMovimientos = new frMovimientos();
            frMovimientos.Show();
        }
    }
}
