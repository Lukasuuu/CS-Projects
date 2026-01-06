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
    public partial class FormPrioridades : Form
    {
        AppDbContext db = new AppDbContext();
        BindingSource bs = new BindingSource(); 
        public FormPrioridades()
        {
            InitializeComponent();
            db.Prioridades.Load();
            bs.DataSource = db.Prioridades.Local.ToBindingList();
            dgvPrioridades.DataSource = bs;

            dgvPrioridades.Columns["Id"]!.ReadOnly = true;
            dgvPrioridades.Columns["Id"]!.Visible = false;
        }

        private void btnPrioridades_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            db.SaveChanges();
        }
    }
}
