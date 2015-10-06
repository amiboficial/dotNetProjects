namespace Mx.Amib.Sistemas.Credencializacion.Views
{
    partial class PrinterConfigUserControl
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxSelPrinter = new System.Windows.Forms.GroupBox();
            this.cbxPrintersToConfig = new System.Windows.Forms.ComboBox();
            this.lblPrinterToConfig = new System.Windows.Forms.Label();
            this.gbxPrinterConfig = new System.Windows.Forms.GroupBox();
            this.zebra8PrinterConfigUserControl = new Mx.Amib.Sistemas.Credencializacion.Views.Zebra8PrinterConfigUserControl();
            this.filePrinterConfigUserControl = new Mx.Amib.Sistemas.Credencializacion.Views.FilePrinterConfigUserControl();
            this.gbxSelPrinter.SuspendLayout();
            this.gbxPrinterConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 20);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Configuración de impresora";
            // 
            // gbxSelPrinter
            // 
            this.gbxSelPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSelPrinter.Controls.Add(this.cbxPrintersToConfig);
            this.gbxSelPrinter.Controls.Add(this.lblPrinterToConfig);
            this.gbxSelPrinter.Location = new System.Drawing.Point(9, 37);
            this.gbxSelPrinter.Name = "gbxSelPrinter";
            this.gbxSelPrinter.Size = new System.Drawing.Size(653, 66);
            this.gbxSelPrinter.TabIndex = 5;
            this.gbxSelPrinter.TabStop = false;
            this.gbxSelPrinter.Text = "Selección de impresora";
            // 
            // cbxPrintersToConfig
            // 
            this.cbxPrintersToConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPrintersToConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrintersToConfig.FormattingEnabled = true;
            this.cbxPrintersToConfig.Location = new System.Drawing.Point(145, 23);
            this.cbxPrintersToConfig.Name = "cbxPrintersToConfig";
            this.cbxPrintersToConfig.Size = new System.Drawing.Size(487, 21);
            this.cbxPrintersToConfig.TabIndex = 1;
            // 
            // lblPrinterToConfig
            // 
            this.lblPrinterToConfig.AutoSize = true;
            this.lblPrinterToConfig.Location = new System.Drawing.Point(27, 26);
            this.lblPrinterToConfig.Name = "lblPrinterToConfig";
            this.lblPrinterToConfig.Size = new System.Drawing.Size(112, 13);
            this.lblPrinterToConfig.TabIndex = 0;
            this.lblPrinterToConfig.Text = "Impresora a configurar";
            // 
            // gbxPrinterConfig
            // 
            this.gbxPrinterConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxPrinterConfig.Controls.Add(this.zebra8PrinterConfigUserControl);
            this.gbxPrinterConfig.Controls.Add(this.filePrinterConfigUserControl);
            this.gbxPrinterConfig.Location = new System.Drawing.Point(10, 109);
            this.gbxPrinterConfig.Name = "gbxPrinterConfig";
            this.gbxPrinterConfig.Size = new System.Drawing.Size(652, 385);
            this.gbxPrinterConfig.TabIndex = 6;
            this.gbxPrinterConfig.TabStop = false;
            this.gbxPrinterConfig.Text = "Configuración";
            // 
            // zebra8PrinterConfigUserControl
            // 
            this.zebra8PrinterConfigUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zebra8PrinterConfigUserControl.Location = new System.Drawing.Point(3, 16);
            this.zebra8PrinterConfigUserControl.Name = "zebra8PrinterConfigUserControl";
            this.zebra8PrinterConfigUserControl.Size = new System.Drawing.Size(646, 366);
            this.zebra8PrinterConfigUserControl.TabIndex = 1;
            // 
            // filePrinterConfigUserControl
            // 
            this.filePrinterConfigUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePrinterConfigUserControl.Location = new System.Drawing.Point(3, 16);
            this.filePrinterConfigUserControl.Name = "filePrinterConfigUserControl";
            this.filePrinterConfigUserControl.Size = new System.Drawing.Size(646, 366);
            this.filePrinterConfigUserControl.TabIndex = 0;
            // 
            // PrinterConfigUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxPrinterConfig);
            this.Controls.Add(this.gbxSelPrinter);
            this.Controls.Add(this.lblTitle);
            this.Name = "PrinterConfigUserControl";
            this.Size = new System.Drawing.Size(679, 507);
            this.gbxSelPrinter.ResumeLayout(false);
            this.gbxSelPrinter.PerformLayout();
            this.gbxPrinterConfig.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbxSelPrinter;
        private System.Windows.Forms.ComboBox cbxPrintersToConfig;
        private System.Windows.Forms.Label lblPrinterToConfig;
        private System.Windows.Forms.GroupBox gbxPrinterConfig;
        private FilePrinterConfigUserControl filePrinterConfigUserControl;
        private Zebra8PrinterConfigUserControl zebra8PrinterConfigUserControl;
    }
}
