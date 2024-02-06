namespace Novo_Forms
{
    partial class F_MaskedTextBox
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
            this.mtb_senha = new System.Windows.Forms.MaskedTextBox();
            this.btn_mostrarSenha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btn_mostrarTexto = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mtb_senha
            // 
            this.mtb_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtb_senha.Location = new System.Drawing.Point(12, 23);
            this.mtb_senha.Name = "mtb_senha";
            this.mtb_senha.PasswordChar = '*';
            this.mtb_senha.Size = new System.Drawing.Size(301, 20);
            this.mtb_senha.TabIndex = 0;
            // 
            // btn_mostrarSenha
            // 
            this.btn_mostrarSenha.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_mostrarSenha.Location = new System.Drawing.Point(332, 19);
            this.btn_mostrarSenha.Name = "btn_mostrarSenha";
            this.btn_mostrarSenha.Size = new System.Drawing.Size(236, 25);
            this.btn_mostrarSenha.TabIndex = 1;
            this.btn_mostrarSenha.Text = "Mostra Senha";
            this.btn_mostrarSenha.UseVisualStyleBackColor = false;
            this.btn_mostrarSenha.Click += new System.EventHandler(this.btn_mostrarSenha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SENHA:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 100);
            this.maskedTextBox1.Mask = "000.000.000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(301, 20);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_mostrarTexto
            // 
            this.btn_mostrarTexto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_mostrarTexto.Location = new System.Drawing.Point(435, 100);
            this.btn_mostrarTexto.Name = "btn_mostrarTexto";
            this.btn_mostrarTexto.Size = new System.Drawing.Size(133, 25);
            this.btn_mostrarTexto.TabIndex = 4;
            this.btn_mostrarTexto.Text = "Mostra Texto";
            this.btn_mostrarTexto.UseVisualStyleBackColor = false;
            this.btn_mostrarTexto.Click += new System.EventHandler(this.btn_mostrarTexto_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(331, 103);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Somente Texto";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // F_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_mostrarTexto);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_mostrarSenha);
            this.Controls.Add(this.mtb_senha);
            this.Name = "F_MaskedTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_senha;
        private System.Windows.Forms.Button btn_mostrarSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btn_mostrarTexto;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}