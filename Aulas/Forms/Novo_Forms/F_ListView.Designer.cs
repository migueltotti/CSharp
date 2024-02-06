namespace Novo_Forms
{
    partial class F_ListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "120",
            "19,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "85",
            "39,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "38",
            "500,00"}, -1);
            this.lv_produtos = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_qtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_produto = new System.Windows.Forms.TextBox();
            this.tb_qtde = new System.Windows.Forms.TextBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_produto = new System.Windows.Forms.Label();
            this.lb_qtde = new System.Windows.Forms.Label();
            this.lb_preco = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_produtos
            // 
            this.lv_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_produto,
            this.col_qtde,
            this.col_preco});
            this.lv_produtos.FullRowSelect = true;
            this.lv_produtos.HideSelection = false;
            this.lv_produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lv_produtos.Location = new System.Drawing.Point(12, 12);
            this.lv_produtos.MultiSelect = false;
            this.lv_produtos.Name = "lv_produtos";
            this.lv_produtos.Size = new System.Drawing.Size(490, 243);
            this.lv_produtos.TabIndex = 0;
            this.lv_produtos.UseCompatibleStateImageBehavior = false;
            this.lv_produtos.View = System.Windows.Forms.View.Details;
            this.lv_produtos.SelectedIndexChanged += new System.EventHandler(this.lv_produtos_SelectedIndexChanged);
            // 
            // col_id
            // 
            this.col_id.Text = "Id";
            this.col_id.Width = 40;
            // 
            // col_produto
            // 
            this.col_produto.Text = "Produto";
            this.col_produto.Width = 250;
            // 
            // col_qtde
            // 
            this.col_qtde.Text = "Quantidade";
            this.col_qtde.Width = 80;
            // 
            // col_preco
            // 
            this.col_preco.Text = "Preço";
            this.col_preco.Width = 110;
            // 
            // tb_id
            // 
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_id.Location = new System.Drawing.Point(12, 275);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(41, 20);
            this.tb_id.TabIndex = 1;
            // 
            // tb_produto
            // 
            this.tb_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_produto.Location = new System.Drawing.Point(59, 275);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(238, 20);
            this.tb_produto.TabIndex = 2;
            // 
            // tb_qtde
            // 
            this.tb_qtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_qtde.Location = new System.Drawing.Point(303, 275);
            this.tb_qtde.Name = "tb_qtde";
            this.tb_qtde.Size = new System.Drawing.Size(74, 20);
            this.tb_qtde.TabIndex = 3;
            // 
            // tb_preco
            // 
            this.tb_preco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_preco.Location = new System.Drawing.Point(383, 275);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(99, 20);
            this.tb_preco.TabIndex = 4;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(9, 259);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(16, 13);
            this.lb_id.TabIndex = 5;
            this.lb_id.Text = "Id";
            // 
            // lb_produto
            // 
            this.lb_produto.AutoSize = true;
            this.lb_produto.Location = new System.Drawing.Point(59, 259);
            this.lb_produto.Name = "lb_produto";
            this.lb_produto.Size = new System.Drawing.Size(44, 13);
            this.lb_produto.TabIndex = 6;
            this.lb_produto.Text = "Produto";
            // 
            // lb_qtde
            // 
            this.lb_qtde.AutoSize = true;
            this.lb_qtde.Location = new System.Drawing.Point(300, 259);
            this.lb_qtde.Name = "lb_qtde";
            this.lb_qtde.Size = new System.Drawing.Size(62, 13);
            this.lb_qtde.TabIndex = 7;
            this.lb_qtde.Text = "Quantidade";
            // 
            // lb_preco
            // 
            this.lb_preco.AutoSize = true;
            this.lb_preco.Location = new System.Drawing.Point(380, 259);
            this.lb_preco.Name = "lb_preco";
            this.lb_preco.Size = new System.Drawing.Size(35, 13);
            this.lb_preco.TabIndex = 8;
            this.lb_preco.Text = "Preço";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Silver;
            this.btn_add.Location = new System.Drawing.Point(12, 308);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(178, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.Silver;
            this.btn_remover.Location = new System.Drawing.Point(12, 337);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(178, 23);
            this.btn_remover.TabIndex = 10;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = false;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.BackColor = System.Drawing.Color.Silver;
            this.btn_obter.Location = new System.Drawing.Point(12, 366);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(178, 23);
            this.btn_obter.TabIndex = 11;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = false;
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 399);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lb_preco);
            this.Controls.Add(this.lb_qtde);
            this.Controls.Add(this.lb_produto);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.tb_qtde);
            this.Controls.Add(this.tb_produto);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lv_produtos);
            this.Name = "F_ListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_produtos;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_produto;
        private System.Windows.Forms.ColumnHeader col_qtde;
        private System.Windows.Forms.ColumnHeader col_preco;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_produto;
        private System.Windows.Forms.TextBox tb_qtde;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_produto;
        private System.Windows.Forms.Label lb_qtde;
        private System.Windows.Forms.Label lb_preco;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_obter;
    }
}