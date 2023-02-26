using System.Drawing;
using System.Windows.Forms;

namespace ProyectoCuentasFinal_U1
{
    partial class FormMenuInicial
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuInicial));
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresarMovimiento = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA GESTOR\r\n    DE CUENTAS\r\n";
            // 
            // btnIngresarMovimiento
            // 
            this.btnIngresarMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnIngresarMovimiento.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold);
            this.btnIngresarMovimiento.Location = new System.Drawing.Point(46, 127);
            this.btnIngresarMovimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresarMovimiento.Name = "btnIngresarMovimiento";
            this.btnIngresarMovimiento.Size = new System.Drawing.Size(309, 67);
            this.btnIngresarMovimiento.TabIndex = 1;
            this.btnIngresarMovimiento.Text = "Nuevo Movimiento";
            this.btnIngresarMovimiento.UseVisualStyleBackColor = false;
            this.btnIngresarMovimiento.Click += new System.EventHandler(this.btnIngresarMovimiento_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(46, 198);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "Libro Diario";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(212, 198);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "Libro Mayor";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(46, 279);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 63);
            this.button4.TabIndex = 4;
            this.button4.Text = "Balance Cuentas";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(212, 279);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "Balance General";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormMenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(635, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIngresarMovimiento);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMenuInicial";
            this.Text = "Menu Inicial";
            this.Load += new System.EventHandler(this.FormMenuInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresarMovimiento;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Button button1;
    }
}

