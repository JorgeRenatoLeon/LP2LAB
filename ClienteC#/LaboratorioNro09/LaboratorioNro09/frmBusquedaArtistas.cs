﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioNro09
{
    public partial class frmBusquedaArtistas : Form
    {
        public frmBusquedaArtistas()
        {
            InitializeComponent();
            dgvArtistas.AutoGenerateColumns = false;
        }
    }
}