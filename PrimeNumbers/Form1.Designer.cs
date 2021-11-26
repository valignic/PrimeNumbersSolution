
namespace PrimeNumbers
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbfirst = new System.Windows.Forms.TextBox();
            this.tblast = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPrimes = new System.Windows.Forms.DataGridView();
            this.lerror = new System.Windows.Forms.Label();
            this.desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar Proceso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbfirst
            // 
            this.tbfirst.Location = new System.Drawing.Point(127, 258);
            this.tbfirst.Name = "tbfirst";
            this.tbfirst.Size = new System.Drawing.Size(93, 22);
            this.tbfirst.TabIndex = 0;
            // 
            // tblast
            // 
            this.tblast.Location = new System.Drawing.Point(248, 258);
            this.tblast.Name = "tblast";
            this.tblast.Size = new System.Drawing.Size(93, 22);
            this.tblast.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Análisis Números Primos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione una opción del rango para comenzar el proceso";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 97);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 21);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1 a 99";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 124);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 21);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "100 a 999";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 151);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(117, 21);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "1.000 a 9.999";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(19, 178);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(133, 21);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "10.000 a 99.999";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(19, 205);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(149, 21);
            this.radioButton5.TabIndex = 10;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "100.000 a 999.999";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(19, 232);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(173, 21);
            this.radioButton6.TabIndex = 11;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "1.000.000 a 2.000.000";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(19, 259);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(102, 21);
            this.radioButton7.TabIndex = 12;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Otro rango:";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "a";
            // 
            // dgvPrimes
            // 
            this.dgvPrimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desde,
            this.hasta,
            this.primero,
            this.ultimo,
            this.cantidad,
            this.tiempo,
            this.obs});
            this.dgvPrimes.Location = new System.Drawing.Point(19, 326);
            this.dgvPrimes.Name = "dgvPrimes";
            this.dgvPrimes.RowHeadersWidth = 51;
            this.dgvPrimes.RowTemplate.Height = 24;
            this.dgvPrimes.Size = new System.Drawing.Size(1237, 456);
            this.dgvPrimes.TabIndex = 14;
            // 
            // lerror
            // 
            this.lerror.AutoSize = true;
            this.lerror.Location = new System.Drawing.Point(348, 262);
            this.lerror.Name = "lerror";
            this.lerror.Size = new System.Drawing.Size(0, 17);
            this.lerror.TabIndex = 15;
            // 
            // desde
            // 
            this.desde.HeaderText = "Desde";
            this.desde.MinimumWidth = 6;
            this.desde.Name = "desde";
            this.desde.Width = 125;
            // 
            // hasta
            // 
            this.hasta.HeaderText = "Hasta";
            this.hasta.MinimumWidth = 6;
            this.hasta.Name = "hasta";
            this.hasta.Width = 125;
            // 
            // primero
            // 
            this.primero.HeaderText = "Primo menor";
            this.primero.MinimumWidth = 6;
            this.primero.Name = "primero";
            this.primero.Width = 125;
            // 
            // ultimo
            // 
            this.ultimo.HeaderText = "Primo mayor";
            this.ultimo.MinimumWidth = 6;
            this.ultimo.Name = "ultimo";
            this.ultimo.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 125;
            // 
            // tiempo
            // 
            this.tiempo.HeaderText = "Tiempo (ms)";
            this.tiempo.MinimumWidth = 6;
            this.tiempo.Name = "tiempo";
            this.tiempo.Width = 125;
            // 
            // obs
            // 
            this.obs.HeaderText = "Observaciones";
            this.obs.MinimumWidth = 6;
            this.obs.Name = "obs";
            this.obs.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 794);
            this.Controls.Add(this.lerror);
            this.Controls.Add(this.dgvPrimes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblast);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbfirst);
            this.Name = "Form1";
            this.Text = "ANP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbfirst;
        private System.Windows.Forms.TextBox tblast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPrimes;
        private System.Windows.Forms.Label lerror;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn primero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
    }
}

