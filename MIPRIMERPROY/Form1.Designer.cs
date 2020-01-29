namespace MIPRIMERPROY
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnprocess = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.GbEcuacion = new System.Windows.Forms.GroupBox();
            this.optSuma = new System.Windows.Forms.RadioButton();
            this.optResta = new System.Windows.Forms.RadioButton();
            this.optMult = new System.Windows.Forms.RadioButton();
            this.optDiv = new System.Windows.Forms.RadioButton();
            this.GbEcuacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnprocess
            // 
            this.btnprocess.Location = new System.Drawing.Point(101, 123);
            this.btnprocess.Name = "btnprocess";
            this.btnprocess.Size = new System.Drawing.Size(75, 23);
            this.btnprocess.TabIndex = 0;
            this.btnprocess.Text = "Procesar";
            this.btnprocess.UseVisualStyleBackColor = true;
            this.btnprocess.Click += new System.EventHandler(this.btnprocess_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(49, 34);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(71, 20);
            this.txtnum1.TabIndex = 1;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(181, 33);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(71, 20);
            this.txtnum2.TabIndex = 2;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(2, 40);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(35, 13);
            this.lblnum1.TabIndex = 3;
            this.lblnum1.Text = "Num1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(141, 41);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(35, 13);
            this.lblnum2.TabIndex = 4;
            this.lblnum2.Text = "Num2";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(98, 85);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(70, 13);
            this.lblRespuesta.TabIndex = 5;
            this.lblRespuesta.Text = "Respuesta: ?";
            // 
            // GbEcuacion
            // 
            this.GbEcuacion.Controls.Add(this.optDiv);
            this.GbEcuacion.Controls.Add(this.optMult);
            this.GbEcuacion.Controls.Add(this.optResta);
            this.GbEcuacion.Controls.Add(this.optSuma);
            this.GbEcuacion.Location = new System.Drawing.Point(283, 33);
            this.GbEcuacion.Name = "GbEcuacion";
            this.GbEcuacion.Size = new System.Drawing.Size(200, 100);
            this.GbEcuacion.TabIndex = 6;
            this.GbEcuacion.TabStop = false;
            this.GbEcuacion.Text = "Ecuaciones";
            // 
            // optSuma
            // 
            this.optSuma.AutoSize = true;
            this.optSuma.Location = new System.Drawing.Point(6, 19);
            this.optSuma.Name = "optSuma";
            this.optSuma.Size = new System.Drawing.Size(52, 17);
            this.optSuma.TabIndex = 0;
            this.optSuma.TabStop = true;
            this.optSuma.Text = "Suma";
            this.optSuma.UseVisualStyleBackColor = true;
            // 
            // optResta
            // 
            this.optResta.AutoSize = true;
            this.optResta.Location = new System.Drawing.Point(6, 50);
            this.optResta.Name = "optResta";
            this.optResta.Size = new System.Drawing.Size(53, 17);
            this.optResta.TabIndex = 1;
            this.optResta.TabStop = true;
            this.optResta.Text = "Resta";
            this.optResta.UseVisualStyleBackColor = true;
            // 
            // optMult
            // 
            this.optMult.AutoSize = true;
            this.optMult.Location = new System.Drawing.Point(94, 19);
            this.optMult.Name = "optMult";
            this.optMult.Size = new System.Drawing.Size(89, 17);
            this.optMult.TabIndex = 2;
            this.optMult.TabStop = true;
            this.optMult.Text = "Multiplicacion";
            this.optMult.UseVisualStyleBackColor = true;
            // 
            // optDiv
            // 
            this.optDiv.AutoSize = true;
            this.optDiv.Location = new System.Drawing.Point(94, 52);
            this.optDiv.Name = "optDiv";
            this.optDiv.Size = new System.Drawing.Size(62, 17);
            this.optDiv.TabIndex = 3;
            this.optDiv.TabStop = true;
            this.optDiv.Text = "Division";
            this.optDiv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 214);
            this.Controls.Add(this.GbEcuacion);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.btnprocess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.GbEcuacion.ResumeLayout(false);
            this.GbEcuacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprocess;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.GroupBox GbEcuacion;
        private System.Windows.Forms.RadioButton optDiv;
        private System.Windows.Forms.RadioButton optMult;
        private System.Windows.Forms.RadioButton optResta;
        private System.Windows.Forms.RadioButton optSuma;
    }
}

