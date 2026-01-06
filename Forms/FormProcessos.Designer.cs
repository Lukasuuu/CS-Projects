namespace AGP.Forms
{
    partial class FormProcessos
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
            dgvProcessos = new DataGridView();
            btnProcessos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProcessos).BeginInit();
            SuspendLayout();
            // 
            // dgvProcessos
            // 
            dgvProcessos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcessos.Location = new Point(150, 12);
            dgvProcessos.Name = "dgvProcessos";
            dgvProcessos.Size = new Size(1140, 629);
            dgvProcessos.TabIndex = 5;
            // 
            // btnProcessos
            // 
            btnProcessos.Location = new Point(12, 294);
            btnProcessos.Name = "btnProcessos";
            btnProcessos.Size = new Size(132, 50);
            btnProcessos.TabIndex = 6;
            btnProcessos.Text = "Atualizar Dados";
            btnProcessos.UseVisualStyleBackColor = true;
            btnProcessos.Click += btnProcessos_Click;
            // 
            // FormProcessos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 653);
            Controls.Add(btnProcessos);
            Controls.Add(dgvProcessos);
            Name = "FormProcessos";
            Text = "FormProcessos";
            ((System.ComponentModel.ISupportInitialize)dgvProcessos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProcessos;
        private Button btnProcessos;
    }
}