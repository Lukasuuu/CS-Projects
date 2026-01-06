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
    public partial class FormLinhasProcesso : Form
    {
        AppDbContext db = new AppDbContext();
        BindingSource bs = new BindingSource();
        public FormLinhasProcesso()
        {
            InitializeComponent();
            db.LinhaProcessos.Load();
            bs.DataSource = db.LinhaProcessos.Local.ToBindingList();

            dgvLinhasProcesso.DataSource = bs;

            dgvLinhasProcesso.Columns["Id"]!.ReadOnly = true;
          
            dgvLinhasProcesso.Columns["Id"]!.Visible = false;
        }

        private void btnLinhasProcesso_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            db.SaveChanges();

        }
    }
}
