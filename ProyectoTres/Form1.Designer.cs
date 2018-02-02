namespace ProyectoTres
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
            this.LblProm = new System.Windows.Forms.Label();
            this.TxtPromProms = new System.Windows.Forms.TextBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnDesplegar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblProm
            // 
            this.LblProm.AutoSize = true;
            this.LblProm.Location = new System.Drawing.Point(100, 42);
            this.LblProm.Name = "LblProm";
            this.LblProm.Size = new System.Drawing.Size(35, 13);
            this.LblProm.TabIndex = 0;
            this.LblProm.Text = "label1";
            // 
            // TxtPromProms
            // 
            this.TxtPromProms.Location = new System.Drawing.Point(254, 42);
            this.TxtPromProms.Name = "TxtPromProms";
            this.TxtPromProms.Size = new System.Drawing.Size(100, 20);
            this.TxtPromProms.TabIndex = 1;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(471, 271);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(155, 45);
            this.BtnRegresar.TabIndex = 2;
            this.BtnRegresar.Text = "Salir";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            // 
            // BtnDesplegar
            // 
            this.BtnDesplegar.Location = new System.Drawing.Point(203, 271);
            this.BtnDesplegar.Name = "BtnDesplegar";
            this.BtnDesplegar.Size = new System.Drawing.Size(126, 45);
            this.BtnDesplegar.TabIndex = 3;
            this.BtnDesplegar.Text = "Desplegar";
            this.BtnDesplegar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 351);
            this.Controls.Add(this.BtnDesplegar);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.TxtPromProms);
            this.Controls.Add(this.LblProm);
            this.Name = "Form1";
            this.Text = "Calcular promedio de promedios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProm;
        private System.Windows.Forms.TextBox TxtPromProms;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnDesplegar;
    }
}

