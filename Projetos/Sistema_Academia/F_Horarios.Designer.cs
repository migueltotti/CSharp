﻿namespace Sistema_Academia
{
    partial class F_Horarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_novoHorario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluirHorario = new System.Windows.Forms.Button();
            this.btn_salvarHorario = new System.Windows.Forms.Button();
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.mtb_horario = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_id.Location = new System.Drawing.Point(12, 29);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(67, 20);
            this.tb_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horário";
            // 
            // btn_novoHorario
            // 
            this.btn_novoHorario.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_novoHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novoHorario.Location = new System.Drawing.Point(12, 3);
            this.btn_novoHorario.Name = "btn_novoHorario";
            this.btn_novoHorario.Size = new System.Drawing.Size(94, 23);
            this.btn_novoHorario.TabIndex = 4;
            this.btn_novoHorario.Text = "Novo Horário";
            this.btn_novoHorario.UseVisualStyleBackColor = false;
            this.btn_novoHorario.Click += new System.EventHandler(this.btn_novoHorario_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluirHorario);
            this.panel1.Controls.Add(this.btn_salvarHorario);
            this.panel1.Controls.Add(this.btn_novoHorario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 32);
            this.panel1.TabIndex = 5;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(312, 4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(94, 23);
            this.btn_fechar.TabIndex = 7;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_excluirHorario
            // 
            this.btn_excluirHorario.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_excluirHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluirHorario.Location = new System.Drawing.Point(212, 4);
            this.btn_excluirHorario.Name = "btn_excluirHorario";
            this.btn_excluirHorario.Size = new System.Drawing.Size(94, 23);
            this.btn_excluirHorario.TabIndex = 6;
            this.btn_excluirHorario.Text = "Excluir Horário";
            this.btn_excluirHorario.UseVisualStyleBackColor = false;
            this.btn_excluirHorario.Click += new System.EventHandler(this.btn_excluirHorario_Click);
            // 
            // btn_salvarHorario
            // 
            this.btn_salvarHorario.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_salvarHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvarHorario.Location = new System.Drawing.Point(112, 4);
            this.btn_salvarHorario.Name = "btn_salvarHorario";
            this.btn_salvarHorario.Size = new System.Drawing.Size(94, 23);
            this.btn_salvarHorario.TabIndex = 5;
            this.btn_salvarHorario.Text = "Salvar Horário";
            this.btn_salvarHorario.UseVisualStyleBackColor = false;
            this.btn_salvarHorario.Click += new System.EventHandler(this.btn_salvarHorario_Click);
            // 
            // dgv_horarios
            // 
            this.dgv_horarios.AllowUserToAddRows = false;
            this.dgv_horarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horarios.EnableHeadersVisualStyles = false;
            this.dgv_horarios.Location = new System.Drawing.Point(12, 55);
            this.dgv_horarios.MultiSelect = false;
            this.dgv_horarios.Name = "dgv_horarios";
            this.dgv_horarios.ReadOnly = true;
            this.dgv_horarios.RowHeadersVisible = false;
            this.dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horarios.Size = new System.Drawing.Size(394, 359);
            this.dgv_horarios.TabIndex = 6;
            this.dgv_horarios.SelectionChanged += new System.EventHandler(this.dgv_horarios_SelectionChanged);
            // 
            // mtb_horario
            // 
            this.mtb_horario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtb_horario.Location = new System.Drawing.Point(85, 29);
            this.mtb_horario.Mask = "99:99 \\até 99:99";
            this.mtb_horario.Name = "mtb_horario";
            this.mtb_horario.Size = new System.Drawing.Size(90, 20);
            this.mtb_horario.TabIndex = 7;
            // 
            // F_Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.mtb_horario);
            this.Controls.Add(this.dgv_horarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horarios";
            this.Load += new System.EventHandler(this.F_Horarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_novoHorario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluirHorario;
        private System.Windows.Forms.Button btn_salvarHorario;
        private System.Windows.Forms.DataGridView dgv_horarios;
        private System.Windows.Forms.MaskedTextBox mtb_horario;
    }
}