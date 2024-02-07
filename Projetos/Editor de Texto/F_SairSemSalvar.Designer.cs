namespace Editor_de_Texto
{
    partial class F_SairSemSalvar
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
            this.lb_alerta = new System.Windows.Forms.Label();
            this.btn_naoSalvar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_alerta
            // 
            this.lb_alerta.AutoSize = true;
            this.lb_alerta.Location = new System.Drawing.Point(20, 21);
            this.lb_alerta.Name = "lb_alerta";
            this.lb_alerta.Size = new System.Drawing.Size(0, 13);
            this.lb_alerta.TabIndex = 0;
            // 
            // btn_naoSalvar
            // 
            this.btn_naoSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_naoSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_naoSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_naoSalvar.Location = new System.Drawing.Point(12, 64);
            this.btn_naoSalvar.Name = "btn_naoSalvar";
            this.btn_naoSalvar.Size = new System.Drawing.Size(68, 29);
            this.btn_naoSalvar.TabIndex = 2;
            this.btn_naoSalvar.Text = "Sim";
            this.btn_naoSalvar.UseVisualStyleBackColor = false;
            this.btn_naoSalvar.Click += new System.EventHandler(this.btn_naoSalvar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(86, 64);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(68, 29);
            this.btn_salvar.TabIndex = 3;
            this.btn_salvar.Text = "Nao";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(160, 64);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(68, 29);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Deseja **** sem Sair?";
            // 
            // F_SairSemSalvar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(239, 105);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_naoSalvar);
            this.Controls.Add(this.lb_alerta);
            this.Name = "F_SairSemSalvar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alerta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_alerta;
        private System.Windows.Forms.Button btn_naoSalvar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox textBox1;
    }
}