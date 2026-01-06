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
    public partial class FormCategorias : Form
    {   
        AppDbContext db = new AppDbContext();
        BindingSource bs = new BindingSource();
        public FormCategorias()
        {
            InitializeComponent();
            db.Categorias.Load();
            bs.DataSource = db.Categorias.Local.ToBindingList();
            dgvCategorias.DataSource = bs;
            dgvCategorias.Columns["Id"]!.ReadOnly = true;
            //dgvCategorias.Columns["Id"]!.Visible = false;

        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            
            bs.EndEdit();
            db.SaveChanges();

        }
    }
}
