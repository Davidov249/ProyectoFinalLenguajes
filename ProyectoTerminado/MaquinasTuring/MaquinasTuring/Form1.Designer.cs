namespace MaquinasTuring
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
            this.components = new System.ComponentModel.Container();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.lblCadena = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.Actualizador = new System.Windows.Forms.Timer(this.components);
            this.txtCinta = new System.Windows.Forms.TextBox();
            this.txtCabezal = new System.Windows.Forms.TextBox();
            this.rtxtCinta = new System.Windows.Forms.RichTextBox();
            this.lblPasos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(40, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Palindromos";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(169, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(146, 21);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Copia de Patrones";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(349, 32);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(111, 21);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Suma Unaria";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(495, 32);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(112, 21);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Resta Unaria";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(624, 32);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(159, 21);
            this.radioButton5.TabIndex = 9;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Multiplicacion Unaria";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(101, 80);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(350, 22);
            this.txtCadena.TabIndex = 10;
            // 
            // lblCadena
            // 
            this.lblCadena.AutoSize = true;
            this.lblCadena.Location = new System.Drawing.Point(37, 83);
            this.lblCadena.Name = "lblCadena";
            this.lblCadena.Size = new System.Drawing.Size(57, 17);
            this.lblCadena.TabIndex = 11;
            this.lblCadena.Text = "Cadena";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(476, 78);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(90, 24);
            this.btnEjecutar.TabIndex = 12;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // Actualizador
            // 
            this.Actualizador.Interval = 1000;
            this.Actualizador.Tick += new System.EventHandler(this.Actualizador_Tick);
            // 
            // txtCinta
            // 
            this.txtCinta.Location = new System.Drawing.Point(12, 314);
            this.txtCinta.Name = "txtCinta";
            this.txtCinta.ReadOnly = true;
            this.txtCinta.Size = new System.Drawing.Size(791, 22);
            this.txtCinta.TabIndex = 14;
            this.txtCinta.Visible = false;
            // 
            // txtCabezal
            // 
            this.txtCabezal.Location = new System.Drawing.Point(12, 169);
            this.txtCabezal.Name = "txtCabezal";
            this.txtCabezal.ReadOnly = true;
            this.txtCabezal.Size = new System.Drawing.Size(791, 22);
            this.txtCabezal.TabIndex = 15;
            // 
            // rtxtCinta
            // 
            this.rtxtCinta.Location = new System.Drawing.Point(12, 131);
            this.rtxtCinta.Name = "rtxtCinta";
            this.rtxtCinta.ReadOnly = true;
            this.rtxtCinta.Size = new System.Drawing.Size(791, 32);
            this.rtxtCinta.TabIndex = 16;
            this.rtxtCinta.Text = "";
            // 
            // lblPasos
            // 
            this.lblPasos.AutoSize = true;
            this.lblPasos.Location = new System.Drawing.Point(719, 67);
            this.lblPasos.Name = "lblPasos";
            this.lblPasos.Size = new System.Drawing.Size(24, 17);
            this.lblPasos.TabIndex = 17;
            this.lblPasos.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "No. de pasos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Estado actual";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(719, 83);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(24, 17);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "q0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 248);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPasos);
            this.Controls.Add(this.rtxtCinta);
            this.Controls.Add(this.txtCabezal);
            this.Controls.Add(this.txtCinta);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.lblCadena);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form1";
            this.Text = "Proyecto Lenguajes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Label lblCadena;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Timer Actualizador;
        private System.Windows.Forms.TextBox txtCinta;
        private System.Windows.Forms.TextBox txtCabezal;
        private System.Windows.Forms.RichTextBox rtxtCinta;
        private System.Windows.Forms.Label lblPasos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEstado;
    }
}

