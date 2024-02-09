namespace Novo_Forms
{
    partial class F_Timer
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_iniciar_t1 = new System.Windows.Forms.Button();
            this.btn_parar_t1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reiniciar_t1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_iniciar_carro = new System.Windows.Forms.Button();
            this.t_carro = new System.Windows.Forms.Timer(this.components);
            this.btn_parar_carro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_inicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_iniciar_t1
            // 
            this.btn_iniciar_t1.Location = new System.Drawing.Point(12, 12);
            this.btn_iniciar_t1.Name = "btn_iniciar_t1";
            this.btn_iniciar_t1.Size = new System.Drawing.Size(100, 27);
            this.btn_iniciar_t1.TabIndex = 0;
            this.btn_iniciar_t1.Text = "Iniciar";
            this.btn_iniciar_t1.UseVisualStyleBackColor = true;
            this.btn_iniciar_t1.Click += new System.EventHandler(this.btn_iniciar_t1_Click);
            // 
            // btn_parar_t1
            // 
            this.btn_parar_t1.Location = new System.Drawing.Point(118, 12);
            this.btn_parar_t1.Name = "btn_parar_t1";
            this.btn_parar_t1.Size = new System.Drawing.Size(100, 27);
            this.btn_parar_t1.TabIndex = 1;
            this.btn_parar_t1.Text = "Parar";
            this.btn_parar_t1.UseVisualStyleBackColor = true;
            this.btn_parar_t1.Click += new System.EventHandler(this.btn_parar_t1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btn_reiniciar_t1
            // 
            this.btn_reiniciar_t1.Location = new System.Drawing.Point(224, 12);
            this.btn_reiniciar_t1.Name = "btn_reiniciar_t1";
            this.btn_reiniciar_t1.Size = new System.Drawing.Size(100, 27);
            this.btn_reiniciar_t1.TabIndex = 3;
            this.btn_reiniciar_t1.Text = "Reiniciar";
            this.btn_reiniciar_t1.UseVisualStyleBackColor = true;
            this.btn_reiniciar_t1.Click += new System.EventHandler(this.btn_reiniciar_t1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Definir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Definir Intervalo de Tempo (milisegundos):";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Novo_Forms.Properties.Resources.lovepik_cartoon_car_png_image_400177154_wh860;
            this.pictureBox1.Location = new System.Drawing.Point(2, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_iniciar_carro
            // 
            this.btn_iniciar_carro.Location = new System.Drawing.Point(2, 99);
            this.btn_iniciar_carro.Name = "btn_iniciar_carro";
            this.btn_iniciar_carro.Size = new System.Drawing.Size(100, 27);
            this.btn_iniciar_carro.TabIndex = 8;
            this.btn_iniciar_carro.Text = "Iniciar";
            this.btn_iniciar_carro.UseVisualStyleBackColor = true;
            this.btn_iniciar_carro.Click += new System.EventHandler(this.btn_iniciar_carro_Click);
            // 
            // t_carro
            // 
            this.t_carro.Interval = 1;
            this.t_carro.Tick += new System.EventHandler(this.t_carro_Tick);
            // 
            // btn_parar_carro
            // 
            this.btn_parar_carro.Location = new System.Drawing.Point(108, 99);
            this.btn_parar_carro.Name = "btn_parar_carro";
            this.btn_parar_carro.Size = new System.Drawing.Size(100, 27);
            this.btn_parar_carro.TabIndex = 9;
            this.btn_parar_carro.Text = "Parar";
            this.btn_parar_carro.UseVisualStyleBackColor = true;
            this.btn_parar_carro.Click += new System.EventHandler(this.btn_parar_carro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ini: 2, Final: 528";
            // 
            // btn_inicio
            // 
            this.btn_inicio.Location = new System.Drawing.Point(214, 99);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(100, 27);
            this.btn_inicio.TabIndex = 11;
            this.btn_inicio.Text = "Voltar do Inicio";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // F_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_parar_carro);
            this.Controls.Add(this.btn_iniciar_carro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_reiniciar_t1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_parar_t1);
            this.Controls.Add(this.btn_iniciar_t1);
            this.Name = "F_Timer";
            this.Text = "F_Timer";
            this.Load += new System.EventHandler(this.F_Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_iniciar_t1;
        private System.Windows.Forms.Button btn_parar_t1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reiniciar_t1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_iniciar_carro;
        private System.Windows.Forms.Timer t_carro;
        private System.Windows.Forms.Button btn_parar_carro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_inicio;
    }
}