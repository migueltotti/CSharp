namespace Eventos_de_Click_e_Componentes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_texto = new System.Windows.Forms.Button();
            this.lb_text = new System.Windows.Forms.Label();
            this.tb_texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_texto
            // 
            this.btn_texto.BackColor = System.Drawing.Color.DarkGray;
            this.btn_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_texto.ForeColor = System.Drawing.Color.Blue;
            this.btn_texto.Location = new System.Drawing.Point(26, 46);
            this.btn_texto.Name = "btn_texto";
            this.btn_texto.Size = new System.Drawing.Size(147, 55);
            this.btn_texto.TabIndex = 0;
            this.btn_texto.Text = "Ok";
            this.btn_texto.UseVisualStyleBackColor = false;
            this.btn_texto.Click += new System.EventHandler(this.btn_texto_Click);
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_text.Location = new System.Drawing.Point(31, 126);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(48, 20);
            this.lb_text.TabIndex = 1;
            this.lb_text.Text = "Texto";
            // 
            // tb_texto
            // 
            this.tb_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_texto.Location = new System.Drawing.Point(26, 20);
            this.tb_texto.Name = "tb_texto";
            this.tb_texto.Size = new System.Drawing.Size(147, 23);
            this.tb_texto.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_texto);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.btn_texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_texto;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.TextBox tb_texto;
    }
}

