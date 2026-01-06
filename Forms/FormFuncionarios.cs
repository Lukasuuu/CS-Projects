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
    public partial class FormFuncionarios : Form
    {
        AppDbContext db = new AppDbContext();   
        BindingSource bs = new BindingSource();
        public FormFuncionarios()
        {
            InitializeComponent();
            db.Funcionarios.Load();
            bs.DataSource = db.Funcionarios.Local.ToBindingList();
            dgvFuncionarios.DataSource = bs;
            dgvFuncionarios.Columns["Id"]!.ReadOnly = true;
            dgvFuncionarios.Columns["Id"]!.Visible = false;
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            db.SaveChanges();
        }
    }
}
