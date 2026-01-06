namespace AGP.Forms
{
    partial class FormCategorias
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
            btnCategorias = new Button();
            dgvCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // btnCategorias
            // 
            btnCategorias.Location = new Point(60, 194);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(132, 50);
            btnCategorias.TabIndex = 0;
            btnCategorias.Text = "Atualizar dados";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnDados_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(291, 80);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(497, 358);
            dgvCategorias.TabIndex = 1;
            // 
            // FormCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCategorias);
            Controls.Add(btnCategorias);
            Name = "FormCategorias";
            Text = "FormCategorias";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCategorias;
        private DataGridView dgvCategorias;
    }
}