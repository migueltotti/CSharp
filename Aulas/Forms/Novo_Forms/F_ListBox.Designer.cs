namespace Novo_Forms
{
    partial class F_ListBox
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
            this.lbo_carros = new System.Windows.Forms.ListBox();
            this.lb_carro = new System.Windows.Forms.Label();
            this.tb_carro = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbo_carros
            // 
            this.lbo_carros.FormattingEnabled = true;
            this.lbo_carros.Location = new System.Drawing.Point(12, 12);
            this.lbo_carros.Name = "lbo_carros";
            this.lbo_carros.Size = new System.Drawing.Size(120, 238);
            this.lbo_carros.TabIndex = 0;
            // 
            // lb_carro
            // 
            this.lb_carro.AutoSize = true;
            this.lb_carro.Location = new System.Drawing.Point(138, 12);
            this.lb_carro.Name = "lb_carro";
            this.lb_carro.Size = new System.Drawing.Size(35, 13);
            this.lb_carro.TabIndex = 1;
            this.lb_carro.Text = "Carro:";
            // 
            // tb_carro
            // 
            this.tb_carro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_carro.Location = new System.Drawing.Point(138, 28);
            this.tb_carro.Name = "tb_carro";
            this.tb_carro.Size = new System.Drawing.Size(146, 20);
            this.tb_carro.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Silver;
            this.btn_add.Location = new System.Drawing.Point(138, 54);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(146, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.Silver;
            this.btn_remover.Location = new System.Drawing.Point(138, 83);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(146, 23);
            this.btn_remover.TabIndex = 4;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = false;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.BackColor = System.Drawing.Color.Silver;
            this.btn_obter.Location = new System.Drawing.Point(138, 112);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(146, 23);
            this.btn_obter.TabIndex = 5;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = false;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.Silver;
            this.btn_limpar.Location = new System.Drawing.Point(138, 141);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(146, 23);
            this.btn_limpar.TabIndex = 6;
            this.btn_limpar.Text = "Limpar Tudo";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 373);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_carro);
            this.Controls.Add(this.lb_carro);
            this.Controls.Add(this.lbo_carros);
            this.Name = "F_ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbo_carros;
        private System.Windows.Forms.Label lb_carro;
        private System.Windows.Forms.TextBox tb_carro;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_obter;
        private System.Windows.Forms.Button btn_limpar;
    }
}