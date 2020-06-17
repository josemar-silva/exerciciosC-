namespace TrabalhandoDateTime
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoriaAplicada = new System.Windows.Forms.Label();
            this.btnCalcularCategoria = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(12, 52);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblNascimento.TabIndex = 1;
            this.lblNascimento.Text = "Data de Nascimento:";
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDataAtual.Enabled = false;
            this.lblDataAtual.Location = new System.Drawing.Point(334, 46);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(150, 20);
            this.lblDataAtual.TabIndex = 2;
            this.lblDataAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(197, 85);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtCategoriaAplicada
            // 
            this.txtCategoriaAplicada.BackColor = System.Drawing.Color.Yellow;
            this.txtCategoriaAplicada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCategoriaAplicada.Location = new System.Drawing.Point(268, 80);
            this.txtCategoriaAplicada.Name = "txtCategoriaAplicada";
            this.txtCategoriaAplicada.Size = new System.Drawing.Size(161, 23);
            this.txtCategoriaAplicada.TabIndex = 4;
            this.txtCategoriaAplicada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcularCategoria
            // 
            this.btnCalcularCategoria.Location = new System.Drawing.Point(15, 80);
            this.btnCalcularCategoria.Name = "btnCalcularCategoria";
            this.btnCalcularCategoria.Size = new System.Drawing.Size(150, 23);
            this.btnCalcularCategoria.TabIndex = 5;
            this.btnCalcularCategoria.Text = "Calcular Categoria";
            this.btnCalcularCategoria.UseVisualStyleBackColor = true;
            this.btnCalcularCategoria.Click += new System.EventHandler(this.btnCalcularCategoria_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(428, 20);
            this.txtNome.TabIndex = 6;
            // 
            // dtpDataDeNascimento
            // 
            this.dtpDataDeNascimento.Location = new System.Drawing.Point(125, 46);
            this.dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            this.dtpDataDeNascimento.Size = new System.Drawing.Size(200, 20);
            this.dtpDataDeNascimento.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 127);
            this.Controls.Add(this.dtpDataDeNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCalcularCategoria);
            this.Controls.Add(this.txtCategoriaAplicada);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblDataAtual);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblDataAtual;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label txtCategoriaAplicada;
        private System.Windows.Forms.Button btnCalcularCategoria;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpDataDeNascimento;
    }
}

