using AGP.Data;
using AGP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AGP.Forms
{
    public partial class FormLixo : Form

    {
        
        //AppDbContext db = new AppDbContext();
        public FormLixo()
        {
            InitializeComponent();
            LoadClientes();
        }

        private void LoadClientes()
        {
            AppDbContext db = new AppDbContext();
            dgvClientes.DataSource = db.Clientes.ToList();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //o cliente que está na caixa é adicionado à grid:
            AppDbContext db = new AppDbContext();

            var cliente = new Cliente { NomeCliente = txtAdd.Text, Referencia = txtReferencia.Text };

            db.Clientes.Add(cliente); //adiciona o nome e referencia a tabela
            db.SaveChanges();//atualizar a base de dados
            LoadClientes();//recarregar a grid a partir da base de dados
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            //o cliente que está na caixa de texto é removido da grid:

            if (dgvClientes.CurrentRow == null) return;
            int id = (int)dgvClientes.CurrentRow.Cells["Id"].Value;

            var cliente = db.Clientes.Find(id);
            if (cliente != null)
            {
                db.Clientes.Remove(cliente);
                db.SaveChanges();
                LoadClientes();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            Cliente c = new Cliente();
            
            int id = Convert.ToInt16(dgvClientes.CurrentRow.Cells["Id"].Value);

            c.Id = id;
            c.NomeCliente = Convert.ToString(dgvClientes.CurrentRow.Cells["NomeCliente"].Value);
            c.Referencia = Convert.ToString(dgvClientes.CurrentRow.Cells["Referencia"].Value);
            
            db.Clientes.Update(c);
            db.SaveChanges();
            LoadClientes();

        }
    }
}
