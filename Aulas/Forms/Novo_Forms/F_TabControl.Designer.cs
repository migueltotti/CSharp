namespace Novo_Forms
{
    partial class F_TabControl
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
            this.tb_novaTab = new System.Windows.Forms.TextBox();
            this.btn_addTab = new System.Windows.Forms.Button();
            this.btn_removerTab = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_posicionarTab = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab_componentes = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tab_componentes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_novaTab
            // 
            this.tb_novaTab.Location = new System.Drawing.Point(12, 12);
            this.tb_novaTab.Name = "tb_novaTab";
            this.tb_novaTab.Size = new System.Drawing.Size(174, 20);
            this.tb_novaTab.TabIndex = 1;
            // 
            // btn_addTab
            // 
            this.btn_addTab.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_addTab.Location = new System.Drawing.Point(192, 12);
            this.btn_addTab.Name = "btn_addTab";
            this.btn_addTab.Size = new System.Drawing.Size(158, 23);
            this.btn_addTab.TabIndex = 2;
            this.btn_addTab.Text = "Adicionar Tab";
            this.btn_addTab.UseVisualStyleBackColor = false;
            this.btn_addTab.Click += new System.EventHandler(this.btn_addTab_Click);
            // 
            // btn_removerTab
            // 
            this.btn_removerTab.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_removerTab.Location = new System.Drawing.Point(356, 12);
            this.btn_removerTab.Name = "btn_removerTab";
            this.btn_removerTab.Size = new System.Drawing.Size(158, 23);
            this.btn_removerTab.TabIndex = 3;
            this.btn_removerTab.Text = "Remover Tab Atual";
            this.btn_removerTab.UseVisualStyleBackColor = false;
            this.btn_removerTab.Click += new System.EventHandler(this.btn_removerTab_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 41);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(174, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // btn_posicionarTab
            // 
            this.btn_posicionarTab.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_posicionarTab.Location = new System.Drawing.Point(192, 41);
            this.btn_posicionarTab.Name = "btn_posicionarTab";
            this.btn_posicionarTab.Size = new System.Drawing.Size(158, 23);
            this.btn_posicionarTab.TabIndex = 5;
            this.btn_posicionarTab.Text = "Posicionar na Tab";
            this.btn_posicionarTab.UseVisualStyleBackColor = false;
            this.btn_posicionarTab.Click += new System.EventHandler(this.btn_posicionarTab_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tab_componentes
            // 
            this.tab_componentes.Controls.Add(this.label1);
            this.tab_componentes.Controls.Add(this.button1);
            this.tab_componentes.Controls.Add(this.textBox1);
            this.tab_componentes.Location = new System.Drawing.Point(4, 22);
            this.tab_componentes.Name = "tab_componentes";
            this.tab_componentes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_componentes.Size = new System.Drawing.Size(648, 351);
            this.tab_componentes.TabIndex = 0;
            this.tab_componentes.Text = "Componentes";
            this.tab_componentes.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_componentes);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // F_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.btn_posicionarTab);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_removerTab);
            this.Controls.Add(this.btn_addTab);
            this.Controls.Add(this.tb_novaTab);
            this.Controls.Add(this.tabControl1);
            this.Name = "F_TabControl";
            this.Text = "F_TabControl";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tab_componentes.ResumeLayout(false);
            this.tab_componentes.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_novaTab;
        private System.Windows.Forms.Button btn_addTab;
        private System.Windows.Forms.Button btn_removerTab;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_posicionarTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tab_componentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}