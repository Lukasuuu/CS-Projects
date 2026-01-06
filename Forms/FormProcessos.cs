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
    public partial class FormProcessos : Form
    {
        AppDbContext db = new AppDbContext();
        BindingSource bs = new BindingSource();
        public FormProcessos()
        {
            InitializeComponent();
            db.Processos.Load();
            bs.DataSource = db.Processos.Local.ToBindingList();
            dgvProcessos.DataSource = bs;

            dgvProcessos.Columns["Id"].Visible = false;
            dgvProcessos.Columns["Id"].ReadOnly = true;

        }

        private void btnProcessos_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            db.SaveChanges();
        }
    }
}
