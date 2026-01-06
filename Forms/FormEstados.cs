using AGP.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AGP.Forms
{
    public partial class FormEstados : Form
    {
        AppDbContext db = new AppDbContext();
        BindingSource bs = new BindingSource();
        public FormEstados()
        {
            InitializeComponent();
            db.Estados.Load();
            bs.DataSource = db.Estados.Local.ToBindingList();

            dgvEstados.DataSource = bs;

            dgvEstados.Columns["Id"]!.ReadOnly = true;
          
            dgvEstados.Columns["Id"]!.Visible = false;
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            db.SaveChanges();

        }
    }
}
