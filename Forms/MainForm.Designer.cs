namespace AGP.Forms
{
    partial class MainForm :Form
    {
        private System.ComponentModel.IContainer components = null;
        

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            funcionáriosToolStripMenuItem = new ToolStripMenuItem();
            estadosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            linhasProcessoToolStripMenuItem = new ToolStripMenuItem();
            prioridadesToolStripMenuItem = new ToolStripMenuItem();
            processosToolStripMenuItem = new ToolStripMenuItem();
            carregarDadosToolStripMenuItem = new ToolStripMenuItem();
            dgvMainForm = new DataGridView();
            btnProcessos1 = new Button();
            btnLinhaProcessoGrid = new Button();
            dgvLinhaDeProcessoGrid = new DataGridView();
            lbxClientes = new ListBox();
            lbxCategorias = new ListBox();
            lbxEstados = new ListBox();
            Cliente = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbFuncionarios = new ComboBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMainForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLinhaDeProcessoGrid).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, funcionáriosToolStripMenuItem, estadosToolStripMenuItem, categoriasToolStripMenuItem, linhasProcessoToolStripMenuItem, prioridadesToolStripMenuItem, processosToolStripMenuItem, carregarDadosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1603, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // funcionáriosToolStripMenuItem
            // 
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.Size = new Size(87, 20);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            funcionáriosToolStripMenuItem.Click += funcionáriosToolStripMenuItem_Click;
            // 
            // estadosToolStripMenuItem
            // 
            estadosToolStripMenuItem.Name = "estadosToolStripMenuItem";
            estadosToolStripMenuItem.Size = new Size(59, 20);
            estadosToolStripMenuItem.Text = "Estados";
            estadosToolStripMenuItem.Click += estadosToolStripMenuItem_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(75, 20);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // linhasProcessoToolStripMenuItem
            // 
            linhasProcessoToolStripMenuItem.Name = "linhasProcessoToolStripMenuItem";
            linhasProcessoToolStripMenuItem.Size = new Size(100, 20);
            linhasProcessoToolStripMenuItem.Text = "LinhasProcesso";
            linhasProcessoToolStripMenuItem.Click += linhasProcessoToolStripMenuItem_Click;
            // 
            // prioridadesToolStripMenuItem
            // 
            prioridadesToolStripMenuItem.Name = "prioridadesToolStripMenuItem";
            prioridadesToolStripMenuItem.Size = new Size(78, 20);
            prioridadesToolStripMenuItem.Text = "Prioridades";
            prioridadesToolStripMenuItem.Click += prioridadesToolStripMenuItem_Click;
            // 
            // processosToolStripMenuItem
            // 
            processosToolStripMenuItem.Name = "processosToolStripMenuItem";
            processosToolStripMenuItem.Size = new Size(71, 20);
            processosToolStripMenuItem.Text = "Processos";
            processosToolStripMenuItem.Click += processosToolStripMenuItem_Click;
            // 
            // carregarDadosToolStripMenuItem
            // 
            carregarDadosToolStripMenuItem.Name = "carregarDadosToolStripMenuItem";
            carregarDadosToolStripMenuItem.Size = new Size(100, 20);
            carregarDadosToolStripMenuItem.Text = "Carregar Dados";
            carregarDadosToolStripMenuItem.Click += carregarDadosToolStripMenuItem_Click;
            // 
            // dgvMainForm
            // 
            dgvMainForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMainForm.Location = new Point(12, 87);
            dgvMainForm.Name = "dgvMainForm";
            dgvMainForm.Size = new Size(1189, 435);
            dgvMainForm.TabIndex = 6;
            dgvMainForm.CellContentClick += dgvMainForm_CellContentClick;
            // 
            // btnProcessos1
            // 
            btnProcessos1.Location = new Point(12, 47);
            btnProcessos1.Name = "btnProcessos1";
            btnProcessos1.Size = new Size(269, 23);
            btnProcessos1.TabIndex = 7;
            btnProcessos1.Text = "Carrega os Processos pra Grid";
            btnProcessos1.UseVisualStyleBackColor = true;
            btnProcessos1.Click += btnProcessos1_Click;
            // 
            // btnLinhaProcessoGrid
            // 
            btnLinhaProcessoGrid.Location = new Point(319, 47);
            btnLinhaProcessoGrid.Name = "btnLinhaProcessoGrid";
            btnLinhaProcessoGrid.Size = new Size(269, 23);
            btnLinhaProcessoGrid.TabIndex = 8;
            btnLinhaProcessoGrid.Text = "Carrega as Linhas de Processo pra outra Grid";
            btnLinhaProcessoGrid.UseVisualStyleBackColor = true;
            btnLinhaProcessoGrid.Click += btnLinhaProcessoGrid_Click;
            // 
            // dgvLinhaDeProcessoGrid
            // 
            dgvLinhaDeProcessoGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLinhaDeProcessoGrid.Location = new Point(22, 554);
            dgvLinhaDeProcessoGrid.Name = "dgvLinhaDeProcessoGrid";
            dgvLinhaDeProcessoGrid.Size = new Size(881, 140);
            dgvLinhaDeProcessoGrid.TabIndex = 9;
            // 
            // lbxClientes
            // 
            lbxClientes.FormattingEnabled = true;
            lbxClientes.Location = new Point(1207, 92);
            lbxClientes.Name = "lbxClientes";
            lbxClientes.Size = new Size(364, 169);
            lbxClientes.TabIndex = 10;
            lbxClientes.SelectedIndexChanged += lbxClientes_SelectedIndexChanged;
            // 
            // lbxCategorias
            // 
            lbxCategorias.FormattingEnabled = true;
            lbxCategorias.Location = new Point(1207, 299);
            lbxCategorias.Name = "lbxCategorias";
            lbxCategorias.Size = new Size(364, 184);
            lbxCategorias.TabIndex = 11;
            lbxCategorias.SelectedIndexChanged += lbxCategorias_SelectedIndexChanged;
            // 
            // lbxEstados
            // 
            lbxEstados.FormattingEnabled = true;
            lbxEstados.Location = new Point(1207, 525);
            lbxEstados.Name = "lbxEstados";
            lbxEstados.Size = new Size(364, 169);
            lbxEstados.TabIndex = 12;
            lbxEstados.SelectedIndexChanged += lbxEstados_SelectedIndexChanged;
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Location = new Point(1207, 74);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(52, 15);
            Cliente.TabIndex = 13;
            Cliente.Text = "Clientes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1207, 281);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 14;
            label2.Text = "Categorias:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1207, 507);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 15;
            label3.Text = "Estados:";
            // 
            // cmbFuncionarios
            // 
            cmbFuncionarios.FormattingEnabled = true;
            cmbFuncionarios.Location = new Point(682, 47);
            cmbFuncionarios.Name = "cmbFuncionarios";
            cmbFuncionarios.Size = new Size(121, 23);
            cmbFuncionarios.TabIndex = 16;
            cmbFuncionarios.SelectedIndexChanged += cmbFuncionarios_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(682, 29);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 17;
            label1.Text = "Funcionarios:";
            // 
            // MainForm
            // 
            ClientSize = new Size(1603, 719);
            Controls.Add(label1);
            Controls.Add(cmbFuncionarios);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Cliente);
            Controls.Add(lbxEstados);
            Controls.Add(lbxCategorias);
            Controls.Add(lbxClientes);
            Controls.Add(dgvLinhaDeProcessoGrid);
            Controls.Add(btnLinhaProcessoGrid);
            Controls.Add(btnProcessos1);
            Controls.Add(dgvMainForm);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Clientes";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMainForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLinhaDeProcessoGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem estadosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem linhasProcessoToolStripMenuItem;
        private ToolStripMenuItem prioridadesToolStripMenuItem;
        private ToolStripMenuItem processosToolStripMenuItem;
        private DataGridView dgvMainForm;
        private Button btnProcessos1;
        private Button btnLinhaProcessoGrid;
        private DataGridView dgvLinhaDeProcessoGrid;
        private ListBox lbxClientes;
        private ListBox lbxCategorias;
        private ListBox lbxEstados;
        private ToolStripMenuItem carregarDadosToolStripMenuItem;
        private Label Cliente;
        private Label label2;
        private Label label3;
        private ComboBox cmbFuncionarios;
        private Label label1;
    }
}
