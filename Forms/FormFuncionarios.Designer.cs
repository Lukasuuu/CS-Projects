namespace AGP.Forms
{
    partial class FormFuncionarios
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
            dgvFuncionarios = new DataGridView();
            btnFuncionarios = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Location = new Point(291, 80);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.Size = new Size(497, 358);
            dgvFuncionarios.TabIndex = 2;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.Location = new Point(78, 235);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Size = new Size(132, 50);
            btnFuncionarios.TabIndex = 3;
            btnFuncionarios.Text = "Atualizar Dados";
            btnFuncionarios.UseVisualStyleBackColor = true;
            btnFuncionarios.Click += btnDados_Click;
            // 
            // FormFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFuncionarios);
            Controls.Add(dgvFuncionarios);
            Name = "FormFuncionarios";
            Text = "FormFuncionarios";
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFuncionarios;
        private Button btnFuncionarios;
    }
}