namespace CalcularEdad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesos = new System.Windows.Forms.Button();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.txtMetro = new System.Windows.Forms.TextBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLibra = new System.Windows.Forms.TextBox();
            this.txtMilla = new System.Windows.Forms.TextBox();
            this.txtFarenheit = new System.Windows.Forms.TextBox();
            this.btnDistancias = new System.Windows.Forms.Button();
            this.btnTemperatura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversión de UNIDADES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kilogramo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Metros:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Celsius:";
            // 
            // btnPesos
            // 
            this.btnPesos.Location = new System.Drawing.Point(452, 55);
            this.btnPesos.Name = "btnPesos";
            this.btnPesos.Size = new System.Drawing.Size(145, 23);
            this.btnPesos.TabIndex = 2;
            this.btnPesos.Text = "Calcular pesos";
            this.btnPesos.UseVisualStyleBackColor = true;
            this.btnPesos.Click += new System.EventHandler(this.btnPesos_Click);
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(65, 57);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(161, 20);
            this.txtKilo.TabIndex = 3;
            // 
            // txtMetro
            // 
            this.txtMetro.Location = new System.Drawing.Point(118, 83);
            this.txtMetro.Name = "txtMetro";
            this.txtMetro.Size = new System.Drawing.Size(108, 20);
            this.txtMetro.TabIndex = 4;
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(76, 111);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(150, 20);
            this.txtCelsius.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 60);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Libras:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Millas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Farenheit:";
            // 
            // txtLibra
            // 
            this.txtLibra.Enabled = false;
            this.txtLibra.Location = new System.Drawing.Point(285, 57);
            this.txtLibra.Name = "txtLibra";
            this.txtLibra.ReadOnly = true;
            this.txtLibra.Size = new System.Drawing.Size(161, 20);
            this.txtLibra.TabIndex = 3;
            // 
            // txtMilla
            // 
            this.txtMilla.Enabled = false;
            this.txtMilla.Location = new System.Drawing.Point(338, 83);
            this.txtMilla.Name = "txtMilla";
            this.txtMilla.ReadOnly = true;
            this.txtMilla.Size = new System.Drawing.Size(108, 20);
            this.txtMilla.TabIndex = 4;
            // 
            // txtFarenheit
            // 
            this.txtFarenheit.Enabled = false;
            this.txtFarenheit.Location = new System.Drawing.Point(296, 111);
            this.txtFarenheit.Name = "txtFarenheit";
            this.txtFarenheit.ReadOnly = true;
            this.txtFarenheit.Size = new System.Drawing.Size(150, 20);
            this.txtFarenheit.TabIndex = 4;
            // 
            // btnDistancias
            // 
            this.btnDistancias.Location = new System.Drawing.Point(452, 82);
            this.btnDistancias.Name = "btnDistancias";
            this.btnDistancias.Size = new System.Drawing.Size(145, 23);
            this.btnDistancias.TabIndex = 2;
            this.btnDistancias.Text = "Calcular Distancias";
            this.btnDistancias.UseVisualStyleBackColor = true;
            this.btnDistancias.Click += new System.EventHandler(this.btnDistancias_Click);
            // 
            // btnTemperatura
            // 
            this.btnTemperatura.Location = new System.Drawing.Point(452, 109);
            this.btnTemperatura.Name = "btnTemperatura";
            this.btnTemperatura.Size = new System.Drawing.Size(145, 23);
            this.btnTemperatura.TabIndex = 2;
            this.btnTemperatura.Text = "Calcular temperaturas";
            this.btnTemperatura.UseVisualStyleBackColor = true;
            this.btnTemperatura.Click += new System.EventHandler(this.btnTemperatura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 146);
            this.Controls.Add(this.txtFarenheit);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.txtMilla);
            this.Controls.Add(this.txtMetro);
            this.Controls.Add(this.txtLibra);
            this.Controls.Add(this.txtKilo);
            this.Controls.Add(this.btnTemperatura);
            this.Controls.Add(this.btnDistancias);
            this.Controls.Add(this.btnPesos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de edad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesos;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.TextBox txtMetro;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLibra;
        private System.Windows.Forms.TextBox txtMilla;
        private System.Windows.Forms.TextBox txtFarenheit;
        private System.Windows.Forms.Button btnDistancias;
        private System.Windows.Forms.Button btnTemperatura;
    }
}

