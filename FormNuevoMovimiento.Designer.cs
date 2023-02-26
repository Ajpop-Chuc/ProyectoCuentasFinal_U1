using System.Drawing;
using System.Windows.Forms;

namespace ProyectoCuentasFinal_U1
{
    partial class FormNuevoMovimiento
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
            this.CBoxInDebe = new System.Windows.Forms.ComboBox();
            this.CBoxInHaber = new System.Windows.Forms.ComboBox();
            this.TBoxInMontoDebe = new System.Windows.Forms.TextBox();
            this.TBoxInMontoHaber = new System.Windows.Forms.TextBox();
            this.BtnGuardarDebe = new System.Windows.Forms.Button();
            this.BtnGuardarHaber = new System.Windows.Forms.Button();
            this.BtnFinMovimiento = new System.Windows.Forms.Button();
            this.BtnGuardarNuevaCuenta = new System.Windows.Forms.Button();
            this.CBoxNewTipoCuenta = new System.Windows.Forms.ComboBox();
            this.TBoxNombreCuentaNueva = new System.Windows.Forms.TextBox();
            this.BtnNuevaCuenta = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBoxInDebe
            // 
            this.CBoxInDebe.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold);
            this.CBoxInDebe.FormattingEnabled = true;
            this.CBoxInDebe.Location = new System.Drawing.Point(70, 77);
            this.CBoxInDebe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBoxInDebe.Name = "CBoxInDebe";
            this.CBoxInDebe.Size = new System.Drawing.Size(151, 30);
            this.CBoxInDebe.TabIndex = 0;
            // 
            // CBoxInHaber
            // 
            this.CBoxInHaber.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold);
            this.CBoxInHaber.FormattingEnabled = true;
            this.CBoxInHaber.Location = new System.Drawing.Point(70, 128);
            this.CBoxInHaber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBoxInHaber.Name = "CBoxInHaber";
            this.CBoxInHaber.Size = new System.Drawing.Size(151, 30);
            this.CBoxInHaber.TabIndex = 1;
            // 
            // TBoxInMontoDebe
            // 
            this.TBoxInMontoDebe.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold);
            this.TBoxInMontoDebe.Location = new System.Drawing.Point(248, 77);
            this.TBoxInMontoDebe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBoxInMontoDebe.Name = "TBoxInMontoDebe";
            this.TBoxInMontoDebe.Size = new System.Drawing.Size(146, 28);
            this.TBoxInMontoDebe.TabIndex = 2;
            // 
            // TBoxInMontoHaber
            // 
            this.TBoxInMontoHaber.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold);
            this.TBoxInMontoHaber.Location = new System.Drawing.Point(248, 129);
            this.TBoxInMontoHaber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBoxInMontoHaber.Name = "TBoxInMontoHaber";
            this.TBoxInMontoHaber.Size = new System.Drawing.Size(146, 28);
            this.TBoxInMontoHaber.TabIndex = 3;
            // 
            // BtnGuardarDebe
            // 
            this.BtnGuardarDebe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnGuardarDebe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnGuardarDebe.FlatAppearance.BorderSize = 4;
            this.BtnGuardarDebe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnGuardarDebe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnGuardarDebe.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold);
            this.BtnGuardarDebe.Location = new System.Drawing.Point(422, 66);
            this.BtnGuardarDebe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardarDebe.Name = "BtnGuardarDebe";
            this.BtnGuardarDebe.Size = new System.Drawing.Size(143, 41);
            this.BtnGuardarDebe.TabIndex = 4;
            this.BtnGuardarDebe.Text = "Guardar Debe";
            this.BtnGuardarDebe.UseVisualStyleBackColor = false;
            this.BtnGuardarDebe.Click += new System.EventHandler(this.BtnGuardarDebe_Click);
            // 
            // BtnGuardarHaber
            // 
            this.BtnGuardarHaber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnGuardarHaber.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold);
            this.BtnGuardarHaber.Location = new System.Drawing.Point(422, 118);
            this.BtnGuardarHaber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardarHaber.Name = "BtnGuardarHaber";
            this.BtnGuardarHaber.Size = new System.Drawing.Size(143, 42);
            this.BtnGuardarHaber.TabIndex = 5;
            this.BtnGuardarHaber.Text = "Guardar Haber";
            this.BtnGuardarHaber.UseVisualStyleBackColor = false;
            this.BtnGuardarHaber.Click += new System.EventHandler(this.BtnGuardarHaber_Click);
            // 
            // BtnFinMovimiento
            // 
            this.BtnFinMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnFinMovimiento.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold);
            this.BtnFinMovimiento.Location = new System.Drawing.Point(248, 174);
            this.BtnFinMovimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFinMovimiento.Name = "BtnFinMovimiento";
            this.BtnFinMovimiento.Size = new System.Drawing.Size(146, 41);
            this.BtnFinMovimiento.TabIndex = 6;
            this.BtnFinMovimiento.Text = "Teminar Partida";
            this.BtnFinMovimiento.UseVisualStyleBackColor = false;
            this.BtnFinMovimiento.Click += new System.EventHandler(this.BtnFinMovimiento_Click);
            // 
            // BtnGuardarNuevaCuenta
            // 
            this.BtnGuardarNuevaCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnGuardarNuevaCuenta.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold);
            this.BtnGuardarNuevaCuenta.Location = new System.Drawing.Point(422, 242);
            this.BtnGuardarNuevaCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardarNuevaCuenta.Name = "BtnGuardarNuevaCuenta";
            this.BtnGuardarNuevaCuenta.Size = new System.Drawing.Size(144, 37);
            this.BtnGuardarNuevaCuenta.TabIndex = 7;
            this.BtnGuardarNuevaCuenta.Text = "Guardar Cuenta";
            this.BtnGuardarNuevaCuenta.UseVisualStyleBackColor = false;
            this.BtnGuardarNuevaCuenta.Visible = false;
            this.BtnGuardarNuevaCuenta.Click += new System.EventHandler(this.BtnGuardarNuevaCuenta_Click);
            // 
            // CBoxNewTipoCuenta
            // 
            this.CBoxNewTipoCuenta.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold);
            this.CBoxNewTipoCuenta.FormattingEnabled = true;
            this.CBoxNewTipoCuenta.Items.AddRange(new object[] {
            "ActivoCorriente",
            "ActivoNoCorriente",
            "PasivoCorriente",
            "PasivoNoCorriente"});
            this.CBoxNewTipoCuenta.Location = new System.Drawing.Point(70, 250);
            this.CBoxNewTipoCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBoxNewTipoCuenta.Name = "CBoxNewTipoCuenta";
            this.CBoxNewTipoCuenta.Size = new System.Drawing.Size(151, 30);
            this.CBoxNewTipoCuenta.TabIndex = 8;
            this.CBoxNewTipoCuenta.Visible = false;
            // 
            // TBoxNombreCuentaNueva
            // 
            this.TBoxNombreCuentaNueva.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold);
            this.TBoxNombreCuentaNueva.Location = new System.Drawing.Point(248, 250);
            this.TBoxNombreCuentaNueva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBoxNombreCuentaNueva.Name = "TBoxNombreCuentaNueva";
            this.TBoxNombreCuentaNueva.Size = new System.Drawing.Size(146, 28);
            this.TBoxNombreCuentaNueva.TabIndex = 9;
            this.TBoxNombreCuentaNueva.Visible = false;
            // 
            // BtnNuevaCuenta
            // 
            this.BtnNuevaCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnNuevaCuenta.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold);
            this.BtnNuevaCuenta.Location = new System.Drawing.Point(70, 174);
            this.BtnNuevaCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNuevaCuenta.Name = "BtnNuevaCuenta";
            this.BtnNuevaCuenta.Size = new System.Drawing.Size(151, 41);
            this.BtnNuevaCuenta.TabIndex = 10;
            this.BtnNuevaCuenta.Text = "Crear Cuenta";
            this.BtnNuevaCuenta.UseVisualStyleBackColor = false;
            this.BtnNuevaCuenta.Click += new System.EventHandler(this.BtnNuevaCuenta_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnReset.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(422, 174);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(143, 41);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Nueva Partida";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(159, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nuevo Movimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(116, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "_____________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(23, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(630, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "_________________________________________";
            // 
            // FormNuevoMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(667, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.BtnNuevaCuenta);
            this.Controls.Add(this.TBoxNombreCuentaNueva);
            this.Controls.Add(this.CBoxNewTipoCuenta);
            this.Controls.Add(this.BtnGuardarNuevaCuenta);
            this.Controls.Add(this.BtnFinMovimiento);
            this.Controls.Add(this.BtnGuardarHaber);
            this.Controls.Add(this.BtnGuardarDebe);
            this.Controls.Add(this.TBoxInMontoHaber);
            this.Controls.Add(this.TBoxInMontoDebe);
            this.Controls.Add(this.CBoxInHaber);
            this.Controls.Add(this.CBoxInDebe);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormNuevoMovimiento";
            this.Text = "FormNuevoMovimiento";
            this.Load += new System.EventHandler(this.FormNuevoMovimiento_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxInDebe;
        private System.Windows.Forms.ComboBox CBoxInHaber;
        private System.Windows.Forms.ComboBox CBoxNewTipoCuenta;
        private System.Windows.Forms.TextBox TBoxInMontoDebe;
        private System.Windows.Forms.TextBox TBoxInMontoHaber;
        private System.Windows.Forms.TextBox TBoxNombreCuentaNueva;
        private System.Windows.Forms.Button BtnGuardarDebe;
        private System.Windows.Forms.Button BtnGuardarHaber;
        private System.Windows.Forms.Button BtnGuardarNuevaCuenta;
        private System.Windows.Forms.Button BtnFinMovimiento;
        private System.Windows.Forms.Button BtnNuevaCuenta;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}