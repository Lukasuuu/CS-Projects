namespace AGP.Forms
{
    partial class FormLixo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvClientes = new DataGridView();
            btnOk = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            txtAdd = new TextBox();
            txtReferencia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(425, 73);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(570, 347);
            dgvClientes.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(294, 73);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 1;
            btnOk.Tag = "atualiza os dados";
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(39, 206);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete (Linha Corrente)";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(39, 235);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(146, 23);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit (Linha Corrente)";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(39, 52);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(227, 23);
            txtAdd.TabIndex = 4;
            txtAdd.Tag = "insira o nome do cliente";
            txtAdd.Text = "Cliente";
            // 
            // txtReferencia
            // 
            txtReferencia.Location = new Point(39, 99);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(227, 23);
            txtReferencia.TabIndex = 7;
            txtReferencia.Tag = "insira o endereço";
            txtReferencia.Text = "Endereço";
            // 
            // FormLixo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 527);
            Controls.Add(txtReferencia);
            Controls.Add(txtAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnOk);
            Controls.Add(dgvClientes);
            Name = "FormLixo";
            Text = "FormLixo";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnOk;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtAdd;
        private TextBox txtReferencia;
    }
}