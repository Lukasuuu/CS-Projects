namespace AGP.Forms
{
    partial class FormPrioridades
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
            dgvPrioridades = new DataGridView();
            btnPrioridades = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrioridades).BeginInit();
            SuspendLayout();
            // 
            // dgvPrioridades
            // 
            dgvPrioridades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrioridades.Location = new Point(291, 80);
            dgvPrioridades.Name = "dgvPrioridades";
            dgvPrioridades.Size = new Size(497, 358);
            dgvPrioridades.TabIndex = 4;
            // 
            // btnPrioridades
            // 
            btnPrioridades.Location = new Point(108, 225);
            btnPrioridades.Name = "btnPrioridades";
            btnPrioridades.Size = new Size(132, 50);
            btnPrioridades.TabIndex = 5;
            btnPrioridades.Text = "Atualizar Dados";
            btnPrioridades.UseVisualStyleBackColor = true;
            btnPrioridades.Click += btnPrioridades_Click;
            // 
            // FormPrioridades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrioridades);
            Controls.Add(dgvPrioridades);
            Name = "FormPrioridades";
            Text = "FormPrioridades";
            ((System.ComponentModel.ISupportInitialize)dgvPrioridades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPrioridades;
        private Button btnPrioridades;
    }
}