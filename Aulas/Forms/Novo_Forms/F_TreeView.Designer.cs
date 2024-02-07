namespace Novo_Forms
{
    partial class F_TreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("HRV");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Fit");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Honda", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Golf");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Polo");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Volksvagem", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.tb_raiz = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tb_no = new System.Windows.Forms.TextBox();
            this.lb_raiz = new System.Windows.Forms.Label();
            this.lb_no = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "hrv";
            treeNode1.Text = "HRV";
            treeNode2.Name = "fit";
            treeNode2.Text = "Fit";
            treeNode3.Name = "Honda";
            treeNode3.Tag = "http://www.youtube.com";
            treeNode3.Text = "Honda";
            treeNode4.Name = "golf";
            treeNode4.Text = "Golf";
            treeNode5.Name = "polo";
            treeNode5.Text = "Polo";
            treeNode6.Name = "volksvagem";
            treeNode6.Text = "Volksvagem";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(151, 259);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(169, 12);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(162, 23);
            this.btn_Adicionar.TabIndex = 1;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(169, 41);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(162, 23);
            this.btn_remover.TabIndex = 2;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // tb_raiz
            // 
            this.tb_raiz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_raiz.Location = new System.Drawing.Point(169, 83);
            this.tb_raiz.Name = "tb_raiz";
            this.tb_raiz.Size = new System.Drawing.Size(162, 20);
            this.tb_raiz.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(12, 300);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Remover Selecionado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(12, 277);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 6;
            // 
            // tb_no
            // 
            this.tb_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_no.Location = new System.Drawing.Point(169, 123);
            this.tb_no.Name = "tb_no";
            this.tb_no.Size = new System.Drawing.Size(162, 20);
            this.tb_no.TabIndex = 7;
            // 
            // lb_raiz
            // 
            this.lb_raiz.AutoSize = true;
            this.lb_raiz.Location = new System.Drawing.Point(169, 67);
            this.lb_raiz.Name = "lb_raiz";
            this.lb_raiz.Size = new System.Drawing.Size(34, 13);
            this.lb_raiz.TabIndex = 8;
            this.lb_raiz.Text = "Raiz :";
            // 
            // lb_no
            // 
            this.lb_no.AutoSize = true;
            this.lb_no.Location = new System.Drawing.Point(169, 107);
            this.lb_no.Name = "lb_no";
            this.lb_no.Size = new System.Drawing.Size(27, 13);
            this.lb_no.TabIndex = 9;
            this.lb_no.Text = "No :";
            // 
            // F_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.lb_no);
            this.Controls.Add(this.lb_raiz);
            this.Controls.Add(this.tb_no);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tb_raiz);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.treeView1);
            this.Name = "F_TreeView";
            this.Text = "F_TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.TextBox tb_raiz;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tb_no;
        private System.Windows.Forms.Label lb_raiz;
        private System.Windows.Forms.Label lb_no;
    }
}