namespace Novo_Forms
{
    partial class F_DateTimePicker
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.btn_obterData = new System.Windows.Forms.Button();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.btn_setarData = new System.Windows.Forms.Button();
            this.btn_dataAtual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(12, 21);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(295, 20);
            this.dtp_data.TabIndex = 0;
            // 
            // btn_obterData
            // 
            this.btn_obterData.BackColor = System.Drawing.Color.Silver;
            this.btn_obterData.Location = new System.Drawing.Point(313, 21);
            this.btn_obterData.Name = "btn_obterData";
            this.btn_obterData.Size = new System.Drawing.Size(191, 22);
            this.btn_obterData.TabIndex = 1;
            this.btn_obterData.Text = "Obter Data";
            this.btn_obterData.UseVisualStyleBackColor = false;
            this.btn_obterData.Click += new System.EventHandler(this.btn_obterData_Click);
            // 
            // tb_data
            // 
            this.tb_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_data.Location = new System.Drawing.Point(13, 47);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(294, 20);
            this.tb_data.TabIndex = 2;
            // 
            // tb_dia
            // 
            this.tb_dia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dia.Location = new System.Drawing.Point(12, 73);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(94, 20);
            this.tb_dia.TabIndex = 3;
            // 
            // tb_mes
            // 
            this.tb_mes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_mes.Location = new System.Drawing.Point(112, 73);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(94, 20);
            this.tb_mes.TabIndex = 4;
            // 
            // tb_ano
            // 
            this.tb_ano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ano.Location = new System.Drawing.Point(212, 73);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(94, 20);
            this.tb_ano.TabIndex = 5;
            // 
            // btn_setarData
            // 
            this.btn_setarData.BackColor = System.Drawing.Color.Silver;
            this.btn_setarData.Location = new System.Drawing.Point(312, 73);
            this.btn_setarData.Name = "btn_setarData";
            this.btn_setarData.Size = new System.Drawing.Size(191, 22);
            this.btn_setarData.TabIndex = 9;
            this.btn_setarData.Text = "Setar Data";
            this.btn_setarData.UseVisualStyleBackColor = false;
            this.btn_setarData.Click += new System.EventHandler(this.btn_setarData_Click);
            // 
            // btn_dataAtual
            // 
            this.btn_dataAtual.BackColor = System.Drawing.Color.Silver;
            this.btn_dataAtual.Location = new System.Drawing.Point(313, 122);
            this.btn_dataAtual.Name = "btn_dataAtual";
            this.btn_dataAtual.Size = new System.Drawing.Size(185, 24);
            this.btn_dataAtual.TabIndex = 10;
            this.btn_dataAtual.Text = "Data atual";
            this.btn_dataAtual.UseVisualStyleBackColor = false;
            this.btn_dataAtual.Click += new System.EventHandler(this.btn_dataAtual_Click);
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 158);
            this.Controls.Add(this.btn_dataAtual);
            this.Controls.Add(this.btn_setarData);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.btn_obterData);
            this.Controls.Add(this.dtp_data);
            this.Name = "F_DateTimePicker";
            this.Text = "F_DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Button btn_obterData;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_dia;
        private System.Windows.Forms.TextBox tb_mes;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.Button btn_setarData;
        private System.Windows.Forms.Button btn_dataAtual;
    }
}