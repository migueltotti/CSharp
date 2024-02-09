namespace Sistema_Academia
{
    partial class F_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_logar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // tb_username
            // 
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Location = new System.Drawing.Point(12, 25);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(167, 20);
            this.tb_username.TabIndex = 1;
            this.tb_username.Text = "m.totti";
            // 
            // tb_senha
            // 
            this.tb_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_senha.Location = new System.Drawing.Point(12, 75);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(167, 20);
            this.tb_senha.TabIndex = 3;
            this.tb_senha.Text = "120822";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // btn_logar
            // 
            this.btn_logar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_logar.Location = new System.Drawing.Point(12, 101);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(167, 28);
            this.btn_logar.TabIndex = 4;
            this.btn_logar.Text = "Logar";
            this.btn_logar.UseVisualStyleBackColor = false;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cancelar.Location = new System.Drawing.Point(12, 135);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(167, 28);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(194, 172);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}