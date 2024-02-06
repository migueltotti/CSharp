namespace Novo_Forms
{
    partial class F_CheckBox
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
            this.cb_carro = new System.Windows.Forms.CheckBox();
            this.cb_aviao = new System.Windows.Forms.CheckBox();
            this.cb_navio = new System.Windows.Forms.CheckBox();
            this.btn_transportes = new System.Windows.Forms.Button();
            this.cb_patinete = new System.Windows.Forms.CheckBox();
            this.btn_abrirFilho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_carro
            // 
            this.cb_carro.AutoSize = true;
            this.cb_carro.Location = new System.Drawing.Point(12, 12);
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.Size = new System.Drawing.Size(51, 17);
            this.cb_carro.TabIndex = 0;
            this.cb_carro.Text = "Carro";
            this.cb_carro.UseVisualStyleBackColor = true;
            // 
            // cb_aviao
            // 
            this.cb_aviao.AutoSize = true;
            this.cb_aviao.Location = new System.Drawing.Point(12, 35);
            this.cb_aviao.Name = "cb_aviao";
            this.cb_aviao.Size = new System.Drawing.Size(53, 17);
            this.cb_aviao.TabIndex = 1;
            this.cb_aviao.Text = "Aviao";
            this.cb_aviao.UseVisualStyleBackColor = true;
            // 
            // cb_navio
            // 
            this.cb_navio.AutoSize = true;
            this.cb_navio.Location = new System.Drawing.Point(12, 58);
            this.cb_navio.Name = "cb_navio";
            this.cb_navio.Size = new System.Drawing.Size(54, 17);
            this.cb_navio.TabIndex = 2;
            this.cb_navio.Text = "Navio";
            this.cb_navio.UseVisualStyleBackColor = true;
            // 
            // btn_transportes
            // 
            this.btn_transportes.Location = new System.Drawing.Point(138, 12);
            this.btn_transportes.Name = "btn_transportes";
            this.btn_transportes.Size = new System.Drawing.Size(212, 23);
            this.btn_transportes.TabIndex = 3;
            this.btn_transportes.Text = "Transportes";
            this.btn_transportes.UseVisualStyleBackColor = true;
            this.btn_transportes.Click += new System.EventHandler(this.btn_transportes_Click);
            // 
            // cb_patinete
            // 
            this.cb_patinete.AutoSize = true;
            this.cb_patinete.Location = new System.Drawing.Point(12, 209);
            this.cb_patinete.Name = "cb_patinete";
            this.cb_patinete.Size = new System.Drawing.Size(65, 17);
            this.cb_patinete.TabIndex = 4;
            this.cb_patinete.Text = "Patinete";
            this.cb_patinete.UseVisualStyleBackColor = true;
            this.cb_patinete.CheckedChanged += new System.EventHandler(this.cb_patinete_CheckedChanged);
            // 
            // btn_abrirFilho
            // 
            this.btn_abrirFilho.Location = new System.Drawing.Point(142, 72);
            this.btn_abrirFilho.Name = "btn_abrirFilho";
            this.btn_abrirFilho.Size = new System.Drawing.Size(208, 23);
            this.btn_abrirFilho.TabIndex = 5;
            this.btn_abrirFilho.Text = "Abrir Forms Filho";
            this.btn_abrirFilho.UseVisualStyleBackColor = true;
            this.btn_abrirFilho.Click += new System.EventHandler(this.btn_abrirFilho_Click);
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 281);
            this.Controls.Add(this.btn_abrirFilho);
            this.Controls.Add(this.cb_patinete);
            this.Controls.Add(this.btn_transportes);
            this.Controls.Add(this.cb_navio);
            this.Controls.Add(this.cb_aviao);
            this.Controls.Add(this.cb_carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_transportes;
        private System.Windows.Forms.CheckBox cb_patinete;
        public System.Windows.Forms.CheckBox cb_carro;
        public System.Windows.Forms.CheckBox cb_aviao;
        public System.Windows.Forms.CheckBox cb_navio;
        private System.Windows.Forms.Button btn_abrirFilho;
    }
}