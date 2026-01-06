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

            //Listar Estados no ListBox
            db.Estados.Load();
            bs.DataSource = db.Estados.Local.ToBindingList();
            lbxEstados.DataSource = bs.DataSource;

            //Mostrar a Designacao do Estado no ListBox
            lbxEstados.DisplayMember = "Designacao";

            //Listar Categorias no ListBox
            db.Categorias.Load();
            bs.DataSource = db.Categorias.Local.ToBindingList();
            lbxCategorias.DataSource = bs.DataSource;

            //Mostrar a Designacao da Categoria no ListBox
            lbxCategorias.DisplayMember = "Designacao";
            lbxCategorias.ValueMember = "Id";
            
            //Listar Clientes no ListBox
            db.Clientes.Load();
            bs.DataSource = db.Clientes.Local.ToBindingList();
            lbxClientes.DataSource = bs.DataSource;

            //Mostrar o Nome do Cliente no ListBox
            lbxClientes.DisplayMember = "NomeCliente";
            lbxClientes.ValueMember = "Id";

            //Listar Funcionarios no ComboBox
            db.Funcionarios.Load();
            bs.DataSource = db.Funcionarios.Local.ToBindingList();
            cmbFuncionarios.DataSource = bs.DataSource;

            //Mostrar o Nome do Funcionario no ComboBox
            cmbFuncionarios.DisplayMember = "NomeFuncionario";
            cmbFuncionarios.ValueMember = "Id";

            //Mostrar o Estado 
            lbxEstados.DisplayMember = "Designacao";
            lbxEstados.ValueMember = "Id";


            //Finalizar edição e salvar alterações
            bs.EndEdit();
            db.SaveChanges();

        }


        private void btnProcessos1_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            db.Processos.Load();
            bs.DataSource = db.Processos.Local.ToBindingList();
            dgvMainForm.DataSource = bs.DataSource;

            dgvMainForm.Visible = true;

            dgvMainForm.AutoGenerateColumns = true; // se estiver usando autogeração
            dgvMainForm.Columns["Id"].Visible = false;
            dgvMainForm.Columns["Id"].ReadOnly = true;


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

            lbxCategorias.SelectedIndex = -1;
            lbxClientes.SelectedIndex = -1;
            lbxEstados.SelectedIndex = -1; 
            cmbFuncionarios.SelectedIndex = -1;


            //Finalizar edição e salvar alterações
            bs.EndEdit(); db.SaveChanges();

        }
        private void carregarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {





        }

        private void AplicarFiltroProcessos()
        {
            int idCategoria = (int)lbxCategorias.SelectedItem!;
            int idCliente = (int)lbxClientes.SelectedItem!;
            int idEstado = (int)lbxEstados.SelectedItem!;
            int idFuncionario = (int)cmbFuncionarios.SelectedItem!;

            var query = db.Processos.Where(p => p.FuncionarioId == idFuncionario);

            if (lbxCategorias.SelectedItem != null)
            {
                query = query.Where(p => p.CategoriaId == idCategoria);
            }
            if (lbxClientes.SelectedItem != null)
            {
                query = query.Where(p => p.ClienteId == idCliente);
            }
            if (lbxEstados.SelectedItem != null)
            {
                query = query.Where(p => p.Estado == idEstado);
            }
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

        private void dgvMainForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
