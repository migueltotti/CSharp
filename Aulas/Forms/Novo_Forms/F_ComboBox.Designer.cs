namespace Novo_Forms
{
    partial class F_ComboBox
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
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.btn_mostrarSelecionado = new System.Windows.Forms.Button();
            this.btn_limparElementos = new System.Windows.Forms.Button();
            this.btn_resetarElementos = new System.Windows.Forms.Button();
            this.tb_novoElemento = new System.Windows.Forms.TextBox();
            this.btn_addElementos = new System.Windows.Forms.Button();
            this.lb_adicionarElementos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Aviao",
            "Navio",
            "Onibus",
            "Trem",
            "Moto"});
            this.cb_transportes.Location = new System.Drawing.Point(12, 12);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(196, 21);
            this.cb_transportes.TabIndex = 0;
            this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
            // 
            // btn_mostrarSelecionado
            // 
            this.btn_mostrarSelecionado.Location = new System.Drawing.Point(221, 10);
            this.btn_mostrarSelecionado.Name = "btn_mostrarSelecionado";
            this.btn_mostrarSelecionado.Size = new System.Drawing.Size(166, 23);
            this.btn_mostrarSelecionado.TabIndex = 1;
            this.btn_mostrarSelecionado.Text = "Mostrar o Selecionado";
            this.btn_mostrarSelecionado.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionado.Click += new System.EventHandler(this.btn_mostrarSelecionado_Click);
            // 
            // btn_limparElementos
            // 
            this.btn_limparElementos.Location = new System.Drawing.Point(221, 39);
            this.btn_limparElementos.Name = "btn_limparElementos";
            this.btn_limparElementos.Size = new System.Drawing.Size(166, 23);
            this.btn_limparElementos.TabIndex = 2;
            this.btn_limparElementos.Text = "Limpar Elementos";
            this.btn_limparElementos.UseVisualStyleBackColor = true;
            this.btn_limparElementos.Click += new System.EventHandler(this.btn_limparElementos_Click);
            // 
            // btn_resetarElementos
            // 
            this.btn_resetarElementos.Location = new System.Drawing.Point(221, 68);
            this.btn_resetarElementos.Name = "btn_resetarElementos";
            this.btn_resetarElementos.Size = new System.Drawing.Size(166, 23);
            this.btn_resetarElementos.TabIndex = 3;
            this.btn_resetarElementos.Text = "Resetar Elementos";
            this.btn_resetarElementos.UseVisualStyleBackColor = true;
            this.btn_resetarElementos.Click += new System.EventHandler(this.btn_resetarElementos_Click);
            // 
            // tb_novoElemento
            // 
            this.tb_novoElemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_novoElemento.Location = new System.Drawing.Point(221, 140);
            this.tb_novoElemento.Name = "tb_novoElemento";
            this.tb_novoElemento.Size = new System.Drawing.Size(166, 20);
            this.tb_novoElemento.TabIndex = 4;
            // 
            // btn_addElementos
            // 
            this.btn_addElementos.Location = new System.Drawing.Point(221, 166);
            this.btn_addElementos.Name = "btn_addElementos";
            this.btn_addElementos.Size = new System.Drawing.Size(166, 23);
            this.btn_addElementos.TabIndex = 5;
            this.btn_addElementos.Text = "Adicionar";
            this.btn_addElementos.UseVisualStyleBackColor = true;
            this.btn_addElementos.Click += new System.EventHandler(this.button4_Click);
            // 
            // lb_adicionarElementos
            // 
            this.lb_adicionarElementos.AutoSize = true;
            this.lb_adicionarElementos.Location = new System.Drawing.Point(218, 124);
            this.lb_adicionarElementos.Name = "lb_adicionarElementos";
            this.lb_adicionarElementos.Size = new System.Drawing.Size(106, 13);
            this.lb_adicionarElementos.TabIndex = 6;
            this.lb_adicionarElementos.Text = "Adicionar Elementos:";
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 301);
            this.Controls.Add(this.lb_adicionarElementos);
            this.Controls.Add(this.btn_addElementos);
            this.Controls.Add(this.tb_novoElemento);
            this.Controls.Add(this.btn_resetarElementos);
            this.Controls.Add(this.btn_limparElementos);
            this.Controls.Add(this.btn_mostrarSelecionado);
            this.Controls.Add(this.cb_transportes);
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_transportes;
        private System.Windows.Forms.Button btn_mostrarSelecionado;
        private System.Windows.Forms.Button btn_limparElementos;
        private System.Windows.Forms.Button btn_resetarElementos;
        private System.Windows.Forms.TextBox tb_novoElemento;
        private System.Windows.Forms.Button btn_addElementos;
        private System.Windows.Forms.Label lb_adicionarElementos;
    }
}