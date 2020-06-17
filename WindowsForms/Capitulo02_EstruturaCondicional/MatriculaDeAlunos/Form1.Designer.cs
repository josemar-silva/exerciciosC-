namespace MatriculaDeAlunos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.Label();
            this.btnIdentificarCategoria = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAnoNascmento = new System.Windows.Forms.TextBox();
            this.txtUltimoAniversario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ano nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano último aniversário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.Yellow;
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Location = new System.Drawing.Point(211, 100);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(147, 23);
            this.txtCategoria.TabIndex = 4;
            this.txtCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIdentificarCategoria
            // 
            this.btnIdentificarCategoria.Location = new System.Drawing.Point(15, 100);
            this.btnIdentificarCategoria.Name = "btnIdentificarCategoria";
            this.btnIdentificarCategoria.Size = new System.Drawing.Size(113, 23);
            this.btnIdentificarCategoria.TabIndex = 5;
            this.btnIdentificarCategoria.Text = "Identificar Categoria";
            this.btnIdentificarCategoria.UseVisualStyleBackColor = true;
            this.btnIdentificarCategoria.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(63, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(299, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtAnoNascmento
            // 
            this.txtAnoNascmento.Location = new System.Drawing.Point(104, 59);
            this.txtAnoNascmento.Name = "txtAnoNascmento";
            this.txtAnoNascmento.Size = new System.Drawing.Size(65, 20);
            this.txtAnoNascmento.TabIndex = 7;
            // 
            // txtUltimoAniversario
            // 
            this.txtUltimoAniversario.Location = new System.Drawing.Point(297, 59);
            this.txtUltimoAniversario.Name = "txtUltimoAniversario";
            this.txtUltimoAniversario.Size = new System.Drawing.Size(65, 20);
            this.txtUltimoAniversario.TabIndex = 8;
            this.txtUltimoAniversario.TextChanged += new System.EventHandler(this.txtUltimoAniversario_Enter);
            this.txtUltimoAniversario.Validating += new System.ComponentModel.CancelEventHandler(this.txtUltimoAniversario_Validating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 130);
            this.Controls.Add(this.txtUltimoAniversario);
            this.Controls.Add(this.txtAnoNascmento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnIdentificarCategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matricula Do Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtCategoria;
        private System.Windows.Forms.Button btnIdentificarCategoria;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAnoNascmento;
        private System.Windows.Forms.TextBox txtUltimoAniversario;
    }
}

