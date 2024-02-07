namespace Novo_Forms
{
    partial class F_ProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.btn_definirValor = new System.Windows.Forms.Button();
            this.btn_preencher = new System.Windows.Forms.Button();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(26, 200);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(438, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            // 
            // tb_valor
            // 
            this.tb_valor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_valor.Location = new System.Drawing.Point(26, 40);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(183, 20);
            this.tb_valor.TabIndex = 1;
            // 
            // btn_definirValor
            // 
            this.btn_definirValor.Location = new System.Drawing.Point(26, 66);
            this.btn_definirValor.Name = "btn_definirValor";
            this.btn_definirValor.Size = new System.Drawing.Size(75, 23);
            this.btn_definirValor.TabIndex = 2;
            this.btn_definirValor.Text = "Definir Valor";
            this.btn_definirValor.UseVisualStyleBackColor = true;
            this.btn_definirValor.Click += new System.EventHandler(this.btn_definirValor_Click);
            // 
            // btn_preencher
            // 
            this.btn_preencher.Location = new System.Drawing.Point(26, 171);
            this.btn_preencher.Name = "btn_preencher";
            this.btn_preencher.Size = new System.Drawing.Size(75, 23);
            this.btn_preencher.TabIndex = 3;
            this.btn_preencher.Text = "Preencher";
            this.btn_preencher.UseVisualStyleBackColor = true;
            this.btn_preencher.Click += new System.EventHandler(this.btn_preencher_Click);
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_quantidade.Location = new System.Drawing.Point(295, 40);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(188, 20);
            this.tb_quantidade.TabIndex = 4;
            this.tb_quantidade.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor de i:";
            // 
            // F_ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_quantidade);
            this.Controls.Add(this.btn_preencher);
            this.Controls.Add(this.btn_definirValor);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.progressBar1);
            this.Name = "F_ProgressBar";
            this.Text = "F_ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Button btn_definirValor;
        private System.Windows.Forms.Button btn_preencher;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.Label label1;
    }
}