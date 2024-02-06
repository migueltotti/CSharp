namespace Novo_Forms
{
    partial class F_MonthCalendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_pegarData = new System.Windows.Forms.Button();
            this.tb_dataInicial = new System.Windows.Forms.TextBox();
            this.tb_dataFinal = new System.Windows.Forms.TextBox();
            this.tb_dataHoje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 29);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btn_pegarData
            // 
            this.btn_pegarData.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_pegarData.Location = new System.Drawing.Point(257, 29);
            this.btn_pegarData.Name = "btn_pegarData";
            this.btn_pegarData.Size = new System.Drawing.Size(270, 33);
            this.btn_pegarData.TabIndex = 1;
            this.btn_pegarData.Text = "Pegar Data";
            this.btn_pegarData.UseVisualStyleBackColor = false;
            this.btn_pegarData.Click += new System.EventHandler(this.btn_pegarData_Click);
            // 
            // tb_dataInicial
            // 
            this.tb_dataInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dataInicial.Location = new System.Drawing.Point(257, 68);
            this.tb_dataInicial.Name = "tb_dataInicial";
            this.tb_dataInicial.Size = new System.Drawing.Size(270, 20);
            this.tb_dataInicial.TabIndex = 2;
            // 
            // tb_dataFinal
            // 
            this.tb_dataFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dataFinal.Location = new System.Drawing.Point(257, 94);
            this.tb_dataFinal.Name = "tb_dataFinal";
            this.tb_dataFinal.Size = new System.Drawing.Size(270, 20);
            this.tb_dataFinal.TabIndex = 3;
            // 
            // tb_dataHoje
            // 
            this.tb_dataHoje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dataHoje.Location = new System.Drawing.Point(257, 120);
            this.tb_dataHoje.Name = "tb_dataHoje";
            this.tb_dataHoje.Size = new System.Drawing.Size(270, 20);
            this.tb_dataHoje.TabIndex = 4;
            // 
            // F_MonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.tb_dataHoje);
            this.Controls.Add(this.tb_dataFinal);
            this.Controls.Add(this.tb_dataInicial);
            this.Controls.Add(this.btn_pegarData);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "F_MonthCalendar";
            this.Text = "F_MonthCalendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_pegarData;
        private System.Windows.Forms.TextBox tb_dataInicial;
        private System.Windows.Forms.TextBox tb_dataFinal;
        private System.Windows.Forms.TextBox tb_dataHoje;
    }
}