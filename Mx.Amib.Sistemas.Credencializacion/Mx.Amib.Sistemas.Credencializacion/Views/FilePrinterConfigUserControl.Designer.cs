namespace Mx.Amib.Sistemas.Credencializacion.Views
{
    partial class FilePrinterConfigUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowsePath = new System.Windows.Forms.Button();
            this.cbxSetDefaultPath = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(53, 11);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(98, 13);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Carpeta de guardar";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(244, 8);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(384, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnBrowsePath
            // 
            this.btnBrowsePath.Location = new System.Drawing.Point(163, 6);
            this.btnBrowsePath.Name = "btnBrowsePath";
            this.btnBrowsePath.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePath.TabIndex = 2;
            this.btnBrowsePath.Text = "Examinar...";
            this.btnBrowsePath.UseVisualStyleBackColor = true;
            this.btnBrowsePath.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxSetDefaultPath
            // 
            this.cbxSetDefaultPath.AutoSize = true;
            this.cbxSetDefaultPath.Location = new System.Drawing.Point(163, 35);
            this.cbxSetDefaultPath.Name = "cbxSetDefaultPath";
            this.cbxSetDefaultPath.Size = new System.Drawing.Size(405, 17);
            this.cbxSetDefaultPath.TabIndex = 3;
            this.cbxSetDefaultPath.Text = "Establecer como impresora de credenciales predeterminada para esta aplicación";
            this.cbxSetDefaultPath.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aplicar cambios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(533, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Restablecer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FilePrinterConfigUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxSetDefaultPath);
            this.Controls.Add(this.btnBrowsePath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.Name = "FilePrinterConfigUserControl";
            this.Size = new System.Drawing.Size(646, 366);
            this.Load += new System.EventHandler(this.FilePrinterConfigUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowsePath;
        private System.Windows.Forms.CheckBox cbxSetDefaultPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}
