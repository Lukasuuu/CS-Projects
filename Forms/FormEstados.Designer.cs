namespace AGP.Forms
{
    partial class FormEstados
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
            dgvEstados = new DataGridView();
            btnEstados = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEstados).BeginInit();
            SuspendLayout();
            // 
            // dgvEstados
            // 
            dgvEstados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstados.Location = new Point(291, 80);
            dgvEstados.Name = "dgvEstados";
            dgvEstados.Size = new Size(497, 358);
            dgvEstados.TabIndex = 3;
            // 
            // btnEstados
            // 
            btnEstados.Location = new Point(77, 219);
            btnEstados.Name = "btnEstados";
            btnEstados.Size = new Size(132, 50);
            btnEstados.TabIndex = 4;
            btnEstados.Text = "Atualizar Dados";
            btnEstados.UseVisualStyleBackColor = true;
            btnEstados.Click += btnDados_Click;
            // 
            // FormEstados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEstados);
            Controls.Add(dgvEstados);
            Name = "FormEstados";
            Text = "FormEstados";
            ((System.ComponentModel.ISupportInitialize)dgvEstados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEstados;
        private Button btnEstados;
    }
}