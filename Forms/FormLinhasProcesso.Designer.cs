namespace AGP.Forms
{
    partial class FormLinhasProcesso
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
            dgvLinhasProcesso = new DataGridView();
            btnLinhasProcesso = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLinhasProcesso).BeginInit();
            SuspendLayout();
            // 
            // dgvLinhasProcesso
            // 
            dgvLinhasProcesso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLinhasProcesso.Location = new Point(291, 80);
            dgvLinhasProcesso.Name = "dgvLinhasProcesso";
            dgvLinhasProcesso.Size = new Size(497, 358);
            dgvLinhasProcesso.TabIndex = 4;
            // 
            // btnLinhasProcesso
            // 
            btnLinhasProcesso.Location = new Point(111, 238);
            btnLinhasProcesso.Name = "btnLinhasProcesso";
            btnLinhasProcesso.Size = new Size(132, 50);
            btnLinhasProcesso.TabIndex = 5;
            btnLinhasProcesso.Text = "Atualizar Dados";
            btnLinhasProcesso.UseVisualStyleBackColor = true;
            btnLinhasProcesso.Click += btnLinhasProcesso_Click;
            // 
            // FormLinhasProcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLinhasProcesso);
            Controls.Add(dgvLinhasProcesso);
            Name = "FormLinhasProcesso";
            Text = "FormLinhasProcesso";
            ((System.ComponentModel.ISupportInitialize)dgvLinhasProcesso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLinhasProcesso;
        private Button btnLinhasProcesso;
    }
}