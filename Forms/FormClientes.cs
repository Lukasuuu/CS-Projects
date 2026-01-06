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
    public partial class FormClientes : Form
    {
        // Cria uma instância do contexto do Entity Framework.
        // É por aqui que a aplicação conversa com a base de dados.
        AppDbContext db = new AppDbContext();

        // Cria um BindingSource.
        // Ele funciona como um "intermediário" entre a base de dados e o DataGridView.
        BindingSource bs = new BindingSource();
        public FormClientes()
        {
            // Inicializa todos os componentes visuais do formulário
            // (DataGridView, botões, labels, etc.)
            InitializeComponent();

            // Carrega os dados da tabela Clientes da base de dados para a memória
            // usando o Entity Framework.
            db.Clientes.Load();

            // Define a fonte de dados do BindingSource.
            // Local -> dados que estão na memória
            // ToBindingList -> lista que suporta edição e notificação de mudanças
            bs.DataSource = db.Clientes.Local.ToBindingList();

            // Liga o DataGridView ao BindingSource.
            // Assim, qualquer alteração no grid reflete nos dados em memória.
            dgvClientes.DataSource = bs;

            // Define a coluna "Id" como somente leitura
            // (o utilizador não pode alterar o Id).
            dgvClientes.Columns["Id"]!.ReadOnly = true;

            // Oculta a coluna "Id" no DataGridView
            // (normalmente o Id não precisa ser exibido).
            dgvClientes.Columns["Id"]!.Visible = false;
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            // Finaliza qualquer edição pendente no BindingSource.
            // Garante que os dados editados no DataGridView
            // sejam enviados para o objeto Cliente em memória.
            bs.EndEdit();

            // Salva todas as alterações feitas nos dados em memória
            // (insert, update, delete) na base de dados.
            db.SaveChanges();
        }
    }
}
