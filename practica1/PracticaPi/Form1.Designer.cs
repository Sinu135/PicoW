namespace PracticaPi
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
            this.cmbPuertos = new System.Windows.Forms.ComboBox();
            this.C = new System.Windows.Forms.Button();
            this.btnConexion = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(157, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demo Conexion Serial";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(30, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puerto";
            // 
            // cmbPuertos
            // 
            this.cmbPuertos.FormattingEnabled = true;
            this.cmbPuertos.Location = new System.Drawing.Point(247, 168);
            this.cmbPuertos.Name = "cmbPuertos";
            this.cmbPuertos.Size = new System.Drawing.Size(212, 24);
            this.cmbPuertos.TabIndex = 2;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(492, 160);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(98, 38);
            this.C.TabIndex = 3;
            this.C.Text = "Conectar";
            this.C.UseVisualStyleBackColor = true;
            // 
            // btnConexion
            // 
            this.btnConexion.Location = new System.Drawing.Point(626, 160);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(98, 38);
            this.btnConexion.TabIndex = 4;
            this.btnConexion.Text = "Cerrar";
            this.btnConexion.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(259, 320);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(98, 38);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(421, 320);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 38);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(216, 258);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(326, 22);
            this.txtMensaje.TabIndex = 7;
            this.txtMensaje.Text = "Texto todo cuqui";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnConexion);
            this.Controls.Add(this.C);
            this.Controls.Add(this.cmbPuertos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPuertos;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtMensaje;
    }
}

