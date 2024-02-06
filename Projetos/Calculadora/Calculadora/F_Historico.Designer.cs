namespace Calculadora
{
    partial class F_Historico
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
            this.lbo_historico = new System.Windows.Forms.ListBox();
            this.btn_retornar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbo_historico
            // 
            this.lbo_historico.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbo_historico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbo_historico.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbo_historico.FormattingEnabled = true;
            this.lbo_historico.ItemHeight = 20;
            this.lbo_historico.Location = new System.Drawing.Point(12, 12);
            this.lbo_historico.Name = "lbo_historico";
            this.lbo_historico.Size = new System.Drawing.Size(345, 364);
            this.lbo_historico.TabIndex = 0;
            // 
            // btn_retornar
            // 
            this.btn_retornar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_retornar.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retornar.Location = new System.Drawing.Point(12, 382);
            this.btn_retornar.Name = "btn_retornar";
            this.btn_retornar.Size = new System.Drawing.Size(345, 32);
            this.btn_retornar.TabIndex = 1;
            this.btn_retornar.Text = "Retornar Conta";
            this.btn_retornar.UseVisualStyleBackColor = false;
            this.btn_retornar.Click += new System.EventHandler(this.btn_retornar_Click);
            // 
            // F_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(374, 422);
            this.Controls.Add(this.btn_retornar);
            this.Controls.Add(this.lbo_historico);
            this.Name = "F_Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico Recente";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbo_historico;
        private System.Windows.Forms.Button btn_retornar;
    }
}