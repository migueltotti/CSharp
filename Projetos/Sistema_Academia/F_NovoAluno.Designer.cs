namespace Sistema_Academia
{
    partial class F_NovoAluno
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
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_novo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_turma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_abrirTurmas = new System.Windows.Forms.Button();
            this.btn_abrirPlanos = new System.Windows.Forms.Button();
            this.tb_plano = new System.Windows.Forms.TextBox();
            this.Planos = new System.Windows.Forms.Label();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nome.Enabled = false;
            this.tb_nome.Location = new System.Drawing.Point(12, 29);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(289, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_gravar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 37);
            this.panel1.TabIndex = 2;
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.Silver;
            this.btn_novo.Location = new System.Drawing.Point(11, 3);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(107, 28);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // cb_status
            // 
            this.cb_status.Enabled = false;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(12, 91);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(133, 21);
            this.cb_status.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status";
            // 
            // tb_turma
            // 
            this.tb_turma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_turma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_turma.Location = new System.Drawing.Point(151, 92);
            this.tb_turma.Name = "tb_turma";
            this.tb_turma.ReadOnly = true;
            this.tb_turma.Size = new System.Drawing.Size(277, 20);
            this.tb_turma.TabIndex = 8;
            this.tb_turma.Tag = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Turmas";
            // 
            // btn_abrirTurmas
            // 
            this.btn_abrirTurmas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_abrirTurmas.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_abrirTurmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abrirTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrirTurmas.Location = new System.Drawing.Point(429, 89);
            this.btn_abrirTurmas.Name = "btn_abrirTurmas";
            this.btn_abrirTurmas.Size = new System.Drawing.Size(28, 25);
            this.btn_abrirTurmas.TabIndex = 1;
            this.btn_abrirTurmas.Text = "...";
            this.btn_abrirTurmas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_abrirTurmas.UseVisualStyleBackColor = false;
            this.btn_abrirTurmas.Click += new System.EventHandler(this.btn_abrirTurmas_Click);
            // 
            // btn_abrirPlanos
            // 
            this.btn_abrirPlanos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_abrirPlanos.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_abrirPlanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abrirPlanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrirPlanos.Location = new System.Drawing.Point(289, 155);
            this.btn_abrirPlanos.Name = "btn_abrirPlanos";
            this.btn_abrirPlanos.Size = new System.Drawing.Size(28, 25);
            this.btn_abrirPlanos.TabIndex = 9;
            this.btn_abrirPlanos.Text = "...";
            this.btn_abrirPlanos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_abrirPlanos.UseVisualStyleBackColor = false;
            // 
            // tb_plano
            // 
            this.tb_plano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_plano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_plano.Location = new System.Drawing.Point(11, 158);
            this.tb_plano.Name = "tb_plano";
            this.tb_plano.ReadOnly = true;
            this.tb_plano.Size = new System.Drawing.Size(277, 20);
            this.tb_plano.TabIndex = 11;
            // 
            // Planos
            // 
            this.Planos.AutoSize = true;
            this.Planos.Location = new System.Drawing.Point(8, 142);
            this.Planos.Name = "Planos";
            this.Planos.Size = new System.Drawing.Size(34, 13);
            this.Planos.TabIndex = 10;
            this.Planos.Text = "Plano";
            // 
            // btn_gravar
            // 
            this.btn_gravar.BackColor = System.Drawing.Color.Silver;
            this.btn_gravar.Enabled = false;
            this.btn_gravar.Location = new System.Drawing.Point(124, 3);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(107, 28);
            this.btn_gravar.TabIndex = 1;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = false;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Silver;
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(237, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(107, 28);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Silver;
            this.btn_fechar.Location = new System.Drawing.Point(350, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(107, 28);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtb_telefone.Enabled = false;
            this.mtb_telefone.Location = new System.Drawing.Point(307, 29);
            this.mtb_telefone.Mask = "(00)00000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(149, 20);
            this.mtb_telefone.TabIndex = 12;
            // 
            // F_NovoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 244);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.btn_abrirPlanos);
            this.Controls.Add(this.tb_plano);
            this.Controls.Add(this.Planos);
            this.Controls.Add(this.btn_abrirTurmas);
            this.Controls.Add(this.tb_turma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NovoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Aluno";
            this.Load += new System.EventHandler(this.F_NovoAluno_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_abrirTurmas;
        private System.Windows.Forms.Button btn_abrirPlanos;
        private System.Windows.Forms.TextBox tb_plano;
        private System.Windows.Forms.Label Planos;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        public System.Windows.Forms.TextBox tb_turma;
    }
}