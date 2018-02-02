namespace ProyectoDos
{
    partial class ProyectoDos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbA = new System.Windows.Forms.TextBox();
            this.TxbB = new System.Windows.Forms.TextBox();
            this.TxbC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LbProm = new System.Windows.Forms.Label();
            this.cuantos = new System.Windows.Forms.Label();
            this.txtCuantos = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblPromGen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dar valor de  b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dar valor de c:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dar valor de a:";
            // 
            // TxbA
            // 
            this.TxbA.Location = new System.Drawing.Point(224, 56);
            this.TxbA.Name = "TxbA";
            this.TxbA.Size = new System.Drawing.Size(100, 20);
            this.TxbA.TabIndex = 4;
            this.TxbA.Text = "0";
            this.TxbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxbA.TextChanged += new System.EventHandler(this.TxbA_TextChanged);
            // 
            // TxbB
            // 
            this.TxbB.Location = new System.Drawing.Point(226, 111);
            this.TxbB.Name = "TxbB";
            this.TxbB.Size = new System.Drawing.Size(100, 20);
            this.TxbB.TabIndex = 5;
            this.TxbB.Text = "0";
            this.TxbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxbB.TextChanged += new System.EventHandler(this.TxbB_TextChanged);
            // 
            // TxbC
            // 
            this.TxbC.Location = new System.Drawing.Point(226, 173);
            this.TxbC.Name = "TxbC";
            this.TxbC.Size = new System.Drawing.Size(100, 20);
            this.TxbC.TabIndex = 6;
            this.TxbC.Text = "0";
            this.TxbC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxbC.TextChanged += new System.EventHandler(this.TxbC_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Promediar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BotonGenerar);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "El promedio es: ";
            // 
            // LbProm
            // 
            this.LbProm.AutoSize = true;
            this.LbProm.Location = new System.Drawing.Point(288, 243);
            this.LbProm.Name = "LbProm";
            this.LbProm.Size = new System.Drawing.Size(22, 13);
            this.LbProm.TabIndex = 9;
            this.LbProm.Text = "0.0";
            // 
            // cuantos
            // 
            this.cuantos.AutoSize = true;
            this.cuantos.Location = new System.Drawing.Point(43, 21);
            this.cuantos.Name = "cuantos";
            this.cuantos.Size = new System.Drawing.Size(52, 13);
            this.cuantos.TabIndex = 10;
            this.cuantos.Text = "Cuantos?";
            // 
            // txtCuantos
            // 
            this.txtCuantos.Enabled = false;
            this.txtCuantos.Location = new System.Drawing.Point(117, 14);
            this.txtCuantos.Name = "txtCuantos";
            this.txtCuantos.Size = new System.Drawing.Size(100, 20);
            this.txtCuantos.TabIndex = 11;
            this.txtCuantos.TextChanged += new System.EventHandler(this.txtCuantos_TextChanged);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(411, 272);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 12;
            // 
            // lblPromGen
            // 
            this.lblPromGen.AutoSize = true;
            this.lblPromGen.Location = new System.Drawing.Point(405, 33);
            this.lblPromGen.Name = "lblPromGen";
            this.lblPromGen.Size = new System.Drawing.Size(121, 13);
            this.lblPromGen.TabIndex = 13;
            this.lblPromGen.Text = "El promedio general: 0.0";
            // 
            // ProyectoDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 321);
            this.Controls.Add(this.lblPromGen);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtCuantos);
            this.Controls.Add(this.cuantos);
            this.Controls.Add(this.LbProm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxbC);
            this.Controls.Add(this.TxbB);
            this.Controls.Add(this.TxbA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ProyectoDos";
            this.Text = "Mi ventanita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbA;
        private System.Windows.Forms.TextBox TxbB;
        private System.Windows.Forms.TextBox TxbC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbProm;
        private System.Windows.Forms.Label cuantos;
        private System.Windows.Forms.TextBox txtCuantos;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblPromGen;
    }
}

