using System;
using System.Linq;
using System.Windows.Forms;
using AGP.Data;
using AGP.Models;
using Microsoft.EntityFrameworkCore;

namespace AGP.Forms
{
    public partial class MainForm : Form
    {
        AppDbContext db = new AppDbContext();

        public MainForm()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes cliente = new FormClientes();
            cliente.ShowDialog();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionarios funcionario = new FormFuncionarios();
            funcionario.ShowDialog();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstados estado = new FormEstados();
            estado.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategorias categoria = new FormCategorias();
            categoria.ShowDialog();
        }

        private void linhasProcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLinhasProcesso linhaProcesso = new FormLinhasProcesso();
            linhaProcesso.ShowDialog();
        }

        private void prioridadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrioridades prioridade = new FormPrioridades();
            prioridade.ShowDialog();
        }

        private void processosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProcessos processo = new FormProcessos();
            processo.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // ESTADOS
            db.Estados.Load();
            lbxEstados.DisplayMember = "Designacao";
            lbxEstados.ValueMember = "Id";
            lbxEstados.DataSource = db.Estados.ToList();

            // CATEGORIAS
            db.Categorias.Load();
            lbxCategorias.DisplayMember = "Designacao";
            lbxCategorias.ValueMember = "Id";
            lbxCategorias.DataSource = db.Categorias.ToList();

            // CLIENTES
            db.Clientes.Load();
            lbxClientes.DisplayMember = "NomeCliente";
            lbxClientes.ValueMember = "Id";
            lbxClientes.DataSource = db.Clientes.ToList();

            // FUNCIONÁRIOS
            db.Funcionarios.Load();
            cmbFuncionarios.DisplayMember = "NomeFuncionario";
            cmbFuncionarios.ValueMember = "Id";
            cmbFuncionarios.DataSource = db.Funcionarios.ToList();

            AplicarFiltroProcessos();
        }

        private void btnProcessos1_Click(object sender, EventArgs e)
        {
            db.Processos.Load();
            dgvMainForm.DataSource = db.Processos.Local.ToBindingList();

            dgvMainForm.Visible = true;
            dgvMainForm.Columns["Id"].Visible = false;
            dgvMainForm.Columns["Id"].ReadOnly = true;
            dgvMainForm.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            lbxCategorias.Visible = true;
            lbxClientes.Visible = true;
            lbxEstados.Visible = true;
            cmbFuncionarios.Visible = true;
        }

        private void btnLinhaProcessoGrid_Click(object sender, EventArgs e)
        {
            db.LinhaProcessos.Load();
            dgvLinhaDeProcessoGrid.DataSource = db.LinhaProcessos.Local.ToBindingList();

            dgvLinhaDeProcessoGrid.Visible = true;
            dgvLinhaDeProcessoGrid.Columns["Id"].Visible = false;
            dgvLinhaDeProcessoGrid.Columns["Id"].ReadOnly = true;
        }

        // -----------------------------
        // FILTRO PROGRESSIVO CORRIGIDO
        // -----------------------------
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