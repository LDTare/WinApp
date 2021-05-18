
namespace WinApp.FD
{
    partial class Invitado
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
            this.Enseres = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Insidencias = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Edificios = new System.Windows.Forms.DataGridView();
            this.EspaciosLabel = new System.Windows.Forms.Label();
            this.Espacios = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Enseres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Insidencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edificios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Espacios)).BeginInit();
            this.SuspendLayout();
            // 
            // Enseres
            // 
            this.Enseres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Enseres.Location = new System.Drawing.Point(12, 30);
            this.Enseres.Name = "Enseres";
            this.Enseres.Size = new System.Drawing.Size(419, 177);
            this.Enseres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enseres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insidencias";
            // 
            // Insidencias
            // 
            this.Insidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Insidencias.Location = new System.Drawing.Point(437, 30);
            this.Insidencias.Name = "Insidencias";
            this.Insidencias.Size = new System.Drawing.Size(419, 177);
            this.Insidencias.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edificios";
            // 
            // Edificios
            // 
            this.Edificios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Edificios.Location = new System.Drawing.Point(12, 232);
            this.Edificios.Name = "Edificios";
            this.Edificios.Size = new System.Drawing.Size(419, 177);
            this.Edificios.TabIndex = 4;
            // 
            // EspaciosLabel
            // 
            this.EspaciosLabel.AutoSize = true;
            this.EspaciosLabel.Location = new System.Drawing.Point(440, 211);
            this.EspaciosLabel.Name = "EspaciosLabel";
            this.EspaciosLabel.Size = new System.Drawing.Size(56, 18);
            this.EspaciosLabel.TabIndex = 7;
            this.EspaciosLabel.Text = "Edificios";
            // 
            // Espacios
            // 
            this.Espacios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Espacios.Location = new System.Drawing.Point(440, 232);
            this.Espacios.Name = "Espacios";
            this.Espacios.Size = new System.Drawing.Size(419, 177);
            this.Espacios.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(329, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Invitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(869, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EspaciosLabel);
            this.Controls.Add(this.Espacios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Edificios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Insidencias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enseres);
            this.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Invitado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invitado";
            this.Load += new System.EventHandler(this.Invitado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Enseres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Insidencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edificios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Espacios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Enseres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Insidencias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Edificios;
        private System.Windows.Forms.Label EspaciosLabel;
        private System.Windows.Forms.DataGridView Espacios;
        private System.Windows.Forms.Button button1;
    }
}