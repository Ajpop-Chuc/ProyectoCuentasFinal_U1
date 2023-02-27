namespace ProyectoCuentasFinal_U1
{
    partial class FormMayor
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Partida");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Cuenta");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Debe");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Haber");
            this.label1 = new System.Windows.Forms.Label();
            this.listViewlibromayor = new System.Windows.Forms.ListView();
            this.listViewlibromayor2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libro Mayor";
            // 
            // listViewlibromayor
            // 
            this.listViewlibromayor.HideSelection = false;
            this.listViewlibromayor.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listViewlibromayor.Location = new System.Drawing.Point(68, 80);
            this.listViewlibromayor.Name = "listViewlibromayor";
            this.listViewlibromayor.Size = new System.Drawing.Size(210, 311);
            this.listViewlibromayor.TabIndex = 1;
            this.listViewlibromayor.UseCompatibleStateImageBehavior = false;
            // 
            // listViewlibromayor2
            // 
            this.listViewlibromayor2.HideSelection = false;
            this.listViewlibromayor2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.listViewlibromayor2.Location = new System.Drawing.Point(274, 80);
            this.listViewlibromayor2.Name = "listViewlibromayor2";
            this.listViewlibromayor2.Size = new System.Drawing.Size(121, 311);
            this.listViewlibromayor2.TabIndex = 2;
            this.listViewlibromayor2.UseCompatibleStateImageBehavior = false;
            // 
            // FormMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 465);
            this.Controls.Add(this.listViewlibromayor2);
            this.Controls.Add(this.listViewlibromayor);
            this.Controls.Add(this.label1);
            this.Name = "FormMayor";
            this.Text = "FormMayor";
            this.Load += new System.EventHandler(this.FormMayor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewlibromayor;
        private System.Windows.Forms.ListView listViewlibromayor2;
    }
}