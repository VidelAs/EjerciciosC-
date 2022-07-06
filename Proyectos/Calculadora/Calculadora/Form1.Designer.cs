namespace Calculadora
{
    partial class Form1
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
            System.Windows.Forms.Button btnsuma;
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnsiete = new System.Windows.Forms.Button();
            this.btnseis = new System.Windows.Forms.Button();
            this.btnnueve = new System.Windows.Forms.Button();
            this.btnocho = new System.Windows.Forms.Button();
            this.btncinco = new System.Windows.Forms.Button();
            this.btndos = new System.Windows.Forms.Button();
            this.btnuno = new System.Windows.Forms.Button();
            this.btncuatro = new System.Windows.Forms.Button();
            this.btntres = new System.Windows.Forms.Button();
            this.bntborrartodo = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.bntborrar = new System.Windows.Forms.Button();
            this.btnraiz = new System.Windows.Forms.Button();
            this.btnmultiplicacion = new System.Windows.Forms.Button();
            this.btnpotencia = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btnsigno = new System.Windows.Forms.Button();
            this.btncero = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            btnsuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsuma
            // 
            btnsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnsuma.Location = new System.Drawing.Point(283, 178);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new System.Drawing.Size(65, 65);
            btnsuma.TabIndex = 17;
            btnsuma.Text = "+";
            btnsuma.UseVisualStyleBackColor = true;
            btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(33, 42);
            this.txtResultado.MaxLength = 20;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(376, 106);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnsiete
            // 
            this.btnsiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiete.Location = new System.Drawing.Point(33, 257);
            this.btnsiete.Name = "btnsiete";
            this.btnsiete.Size = new System.Drawing.Size(50, 50);
            this.btnsiete.TabIndex = 1;
            this.btnsiete.Text = "7";
            this.btnsiete.UseVisualStyleBackColor = true;
            this.btnsiete.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btnseis
            // 
            this.btnseis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseis.Location = new System.Drawing.Point(209, 333);
            this.btnseis.Name = "btnseis";
            this.btnseis.Size = new System.Drawing.Size(50, 50);
            this.btnseis.TabIndex = 2;
            this.btnseis.Text = "6";
            this.btnseis.UseVisualStyleBackColor = true;
            this.btnseis.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btnnueve
            // 
            this.btnnueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnueve.Location = new System.Drawing.Point(209, 257);
            this.btnnueve.Name = "btnnueve";
            this.btnnueve.Size = new System.Drawing.Size(50, 50);
            this.btnnueve.TabIndex = 3;
            this.btnnueve.Text = "9";
            this.btnnueve.UseVisualStyleBackColor = true;
            this.btnnueve.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btnocho
            // 
            this.btnocho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnocho.Location = new System.Drawing.Point(125, 257);
            this.btnocho.Name = "btnocho";
            this.btnocho.Size = new System.Drawing.Size(50, 50);
            this.btnocho.TabIndex = 4;
            this.btnocho.Text = "8";
            this.btnocho.UseVisualStyleBackColor = true;
            this.btnocho.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btncinco
            // 
            this.btncinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncinco.Location = new System.Drawing.Point(125, 333);
            this.btncinco.Name = "btncinco";
            this.btncinco.Size = new System.Drawing.Size(50, 50);
            this.btncinco.TabIndex = 5;
            this.btncinco.Text = "5";
            this.btncinco.UseVisualStyleBackColor = true;
            this.btncinco.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btndos
            // 
            this.btndos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndos.Location = new System.Drawing.Point(125, 409);
            this.btndos.Name = "btndos";
            this.btndos.Size = new System.Drawing.Size(50, 50);
            this.btndos.TabIndex = 6;
            this.btndos.Text = "2";
            this.btndos.UseVisualStyleBackColor = true;
            this.btndos.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btnuno
            // 
            this.btnuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuno.Location = new System.Drawing.Point(33, 409);
            this.btnuno.Name = "btnuno";
            this.btnuno.Size = new System.Drawing.Size(50, 50);
            this.btnuno.TabIndex = 7;
            this.btnuno.Text = "1";
            this.btnuno.UseVisualStyleBackColor = true;
            this.btnuno.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btncuatro
            // 
            this.btncuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncuatro.Location = new System.Drawing.Point(33, 333);
            this.btncuatro.Name = "btncuatro";
            this.btncuatro.Size = new System.Drawing.Size(50, 50);
            this.btncuatro.TabIndex = 8;
            this.btncuatro.Text = "4";
            this.btncuatro.UseVisualStyleBackColor = true;
            this.btncuatro.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btntres
            // 
            this.btntres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntres.Location = new System.Drawing.Point(209, 409);
            this.btntres.Name = "btntres";
            this.btntres.Size = new System.Drawing.Size(50, 50);
            this.btntres.TabIndex = 9;
            this.btntres.Text = "3";
            this.btntres.UseVisualStyleBackColor = true;
            this.btntres.Click += new System.EventHandler(this.agregar_numero);
            // 
            // bntborrartodo
            // 
            this.bntborrartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntborrartodo.Location = new System.Drawing.Point(110, 178);
            this.bntborrartodo.Name = "bntborrartodo";
            this.bntborrartodo.Size = new System.Drawing.Size(65, 65);
            this.bntborrartodo.TabIndex = 12;
            this.bntborrartodo.Text = "C";
            this.bntborrartodo.UseVisualStyleBackColor = true;
            this.bntborrartodo.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(194, 178);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(65, 65);
            this.button11.TabIndex = 11;
            this.button11.Text = "<-";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // bntborrar
            // 
            this.bntborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntborrar.Location = new System.Drawing.Point(23, 178);
            this.bntborrar.Name = "bntborrar";
            this.bntborrar.Size = new System.Drawing.Size(65, 65);
            this.bntborrar.TabIndex = 10;
            this.bntborrar.Text = "CE";
            this.bntborrar.UseVisualStyleBackColor = true;
            // 
            // btnraiz
            // 
            this.btnraiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnraiz.Location = new System.Drawing.Point(382, 178);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(65, 65);
            this.btnraiz.TabIndex = 16;
            this.btnraiz.Text = "√";
            this.btnraiz.UseVisualStyleBackColor = true;
            // 
            // btnmultiplicacion
            // 
            this.btnmultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicacion.Location = new System.Drawing.Point(382, 481);
            this.btnmultiplicacion.Name = "btnmultiplicacion";
            this.btnmultiplicacion.Size = new System.Drawing.Size(65, 65);
            this.btnmultiplicacion.TabIndex = 15;
            this.btnmultiplicacion.Text = "X";
            this.btnmultiplicacion.UseVisualStyleBackColor = true;
            // 
            // btnpotencia
            // 
            this.btnpotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpotencia.Location = new System.Drawing.Point(382, 289);
            this.btnpotencia.Name = "btnpotencia";
            this.btnpotencia.Size = new System.Drawing.Size(65, 65);
            this.btnpotencia.TabIndex = 14;
            this.btnpotencia.Text = "X²";
            this.btnpotencia.UseVisualStyleBackColor = true;
            // 
            // btndivision
            // 
            this.btndivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivision.Location = new System.Drawing.Point(382, 402);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(65, 65);
            this.btndivision.TabIndex = 13;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = true;
            // 
            // btnresta
            // 
            this.btnresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresta.Location = new System.Drawing.Point(283, 289);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(65, 65);
            this.btnresta.TabIndex = 18;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            // 
            // btnigual
            // 
            this.btnigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.Location = new System.Drawing.Point(283, 402);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(65, 144);
            this.btnigual.TabIndex = 19;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btnsigno
            // 
            this.btnsigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsigno.Location = new System.Drawing.Point(33, 481);
            this.btnsigno.Name = "btnsigno";
            this.btnsigno.Size = new System.Drawing.Size(50, 50);
            this.btnsigno.TabIndex = 21;
            this.btnsigno.Text = "+/-";
            this.btnsigno.UseVisualStyleBackColor = true;
            // 
            // btncero
            // 
            this.btncero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncero.Location = new System.Drawing.Point(125, 476);
            this.btncero.Name = "btncero";
            this.btncero.Size = new System.Drawing.Size(50, 50);
            this.btncero.TabIndex = 23;
            this.btncero.Text = "0";
            this.btncero.UseVisualStyleBackColor = true;
            this.btncero.Click += new System.EventHandler(this.agregar_numero);
            // 
            // btnpunto
            // 
            this.btnpunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpunto.Location = new System.Drawing.Point(209, 488);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(50, 50);
            this.btnpunto.TabIndex = 24;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(459, 582);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btncero);
            this.Controls.Add(this.btnsigno);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(btnsuma);
            this.Controls.Add(this.btnraiz);
            this.Controls.Add(this.btnmultiplicacion);
            this.Controls.Add(this.btnpotencia);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.bntborrartodo);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.bntborrar);
            this.Controls.Add(this.btntres);
            this.Controls.Add(this.btncuatro);
            this.Controls.Add(this.btnuno);
            this.Controls.Add(this.btndos);
            this.Controls.Add(this.btncinco);
            this.Controls.Add(this.btnocho);
            this.Controls.Add(this.btnnueve);
            this.Controls.Add(this.btnseis);
            this.Controls.Add(this.btnsiete);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnsiete;
        private System.Windows.Forms.Button btnseis;
        private System.Windows.Forms.Button btnnueve;
        private System.Windows.Forms.Button btnocho;
        private System.Windows.Forms.Button btncinco;
        private System.Windows.Forms.Button btndos;
        private System.Windows.Forms.Button btnuno;
        private System.Windows.Forms.Button btncuatro;
        private System.Windows.Forms.Button btntres;
        private System.Windows.Forms.Button bntborrartodo;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button bntborrar;
        private System.Windows.Forms.Button btnraiz;
        private System.Windows.Forms.Button btnmultiplicacion;
        private System.Windows.Forms.Button btnpotencia;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btnsigno;
        private System.Windows.Forms.Button btncero;
        private System.Windows.Forms.Button btnpunto;
    }
}

