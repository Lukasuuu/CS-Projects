using System;
using System.Linq;
using System.Windows.Forms;
using AGP.Data;
using AGP.Models;
using AGP.Forms;
using AGP;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace AGP.Forms
{
    public partial class MainForm : Form
    {
        // Cria uma instância do contexto do Entity Framework.
        AppDbContext db = new AppDbContext();


        public MainForm()
        {
            InitializeComponent();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir Formulario de Clientes
            FormClientes cliente = new FormClientes();

            //mostrar o formulario como uma janela modal
            cliente.ShowDialog();

        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir Formulario de Funcionarios
            FormFuncionarios funcionario = new FormFuncionarios();

            //mostrar o formulario como uma janela modal
            funcionario.ShowDialog();
        }
        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir Formulario de Estados
            FormEstados estado = new FormEstados();

            //mostrar o formulario como uma janela modal
            estado.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir Formulario de Categorias
            FormCategorias categoria = new FormCategorias();

            //mostrar o formulario como uma janela modal
            categoria.ShowDialog();
        }

        private void linhasProcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir Formulario de Linhas de Processo
            FormLinhasProcesso linhaProcesso = new FormLinhasProcesso();

            //mostrar o formulario como uma janela modal
            linhaProcesso.ShowDialog();

        }

        private void prioridadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir Formulario de Prioridades
            FormPrioridades prioridade = new FormPrioridades();

            //mostrar o formulario como uma janela modal
            prioridade.ShowDialog();
        }

        private void processosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir Formulario de Processos
            FormProcessos processo = new FormProcessos();

            //mostrar o formulario como uma janela modal
            processo.ShowDialog();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Criar BindingSource
            BindingSource bs = new BindingSource();

            // ESTADOS
            db.Estados.Load();
            lbxEstados.ValueMember = "Id";
            lbxEstados.DisplayMember = "Designacao";
            lbxEstados.DataSource = db.Estados.ToList();

            // CATEGORIAS
            db.Categorias.Load();
            lbxCategorias.ValueMember = "Id";
            lbxCategorias.DisplayMember = "Designacao";
            lbxCategorias.DataSource = db.Categorias.ToList();

            // CLIENTES
            db.Clientes.Load();
            lbxClientes.ValueMember = "Id";
            lbxClientes.DisplayMember = "NomeCliente";
            lbxClientes.DataSource = db.Clientes.ToList();

            // FUNCIONÁRIOS
            db.Funcionarios.Load();
            cmbFuncionarios.ValueMember = "Id";
            cmbFuncionarios.DisplayMember = "NomeFuncionario";
            cmbFuncionarios.DataSource = db.Funcionarios.ToList();

            // Após carregar os dados
            lbxClientes.SelectedValue = -1;
            lbxCategorias.SelectedValue = -1;
            lbxEstados.SelectedValue = -1;
            cmbFuncionarios.SelectedValue = -1;

            // Aplica o filtro automaticamente
            AplicarFiltroProcessos();

            //Finalizar edição e salvar alterações
            bs.EndEdit();
            db.SaveChanges();
        }


        private void btnProcessos1_Click(object sender, EventArgs e)
        {
            //Criar BindingSource
            BindingSource bs = new BindingSource();

            //Listar Processos no DataGridView
            db.Processos.Load();
            bs.DataSource = db.Processos.Local.ToBindingList();
            dgvMainForm.DataSource = bs.DataSource;

            //Mostrar o DataGridView
            dgvMainForm.Visible = true;
            dgvMainForm.Columns["Id"].Visible = false;
            dgvMainForm.Columns["Id"].ReadOnly = true;

            //Revelar os ListBox e ComboBox de Filtros
            lbxCategorias.Visible = true;
            lbxClientes.Visible = true;
            lbxEstados.Visible = true;
            cmbFuncionarios.Visible = true;


            bs.EndEdit();
            db.SaveChanges();
        }

        private void btnLinhaProcessoGrid_Click(object sender, EventArgs e)
        {
            //Criar BindingSource
            BindingSource bs = new BindingSource();

            //Listar Linhas de Processo no DataGridView
            db.LinhaProcessos.Load();
            bs.DataSource = db.LinhaProcessos.Local.ToBindingList();
            dgvLinhaDeProcessoGrid.DataSource = bs.DataSource;

            //Mostrar o DataGridView
            dgvLinhaDeProcessoGrid.Visible = true;
            dgvLinhaDeProcessoGrid.Columns["Id"].Visible = false;
            dgvLinhaDeProcessoGrid.Columns["Id"].ReadOnly = true;


            //Finalizar edição e salvar alterações
            bs.EndEdit(); 
            db.SaveChanges();


        }
        private void carregarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {





        }

        private void AplicarFiltroProcessos()
        {
            var query = db.Processos.AsQueryable();

            if (lbxClientes.SelectedValue is int clienteId)
                query = query.Where(p => p.ClienteId == clienteId);

            if (lbxCategorias.SelectedValue is int categoriaId)
                query = query.Where(p => p.CategoriaId == categoriaId);

            if (lbxEstados.SelectedValue is int estadoId)
                query = query.Where(p => p.Estado == estadoId);

            if (cmbFuncionarios.SelectedValue is int funcionarioId)
                query = query.Where(p => p.FuncionarioId == funcionarioId);

            dgvMainForm.DataSource = query.ToList();
        }

        private void lbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            AplicarFiltroProcessos();
        }

        private void lbxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltroProcessos();
        }

        private void lbxEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltroProcessos();
        }


        private void cmbFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltroProcessos();
        }

        private void dgvMainForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
