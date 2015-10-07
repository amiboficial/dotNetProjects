namespace Mx.Amib.Sistemas.Credencializacion.Views
{
    partial class Zebra8PrinterConfigUserControl
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
            this.lblInfoEng = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPrinterConnection = new System.Windows.Forms.TabPage();
            this.cbxSetDefaultPrinterConnection = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDiscovery = new System.Windows.Forms.Button();
            this.cbxPrinters = new System.Windows.Forms.ComboBox();
            this.lblPrinters = new System.Windows.Forms.Label();
            this.cbxPrinterPorts = new System.Windows.Forms.ComboBox();
            this.lblPrinterPorts = new System.Windows.Forms.Label();
            this.tabCardOptions = new System.Windows.Forms.TabPage();
            this.cbxSetDefaultCardOptions = new System.Windows.Forms.CheckBox();
            this.cbxCardTypeInUse = new System.Windows.Forms.ComboBox();
            this.cbxCardDestination = new System.Windows.Forms.ComboBox();
            this.cbxCardSource = new System.Windows.Forms.ComboBox();
            this.lblCardTypeInUse = new System.Windows.Forms.Label();
            this.lblCardDestination = new System.Windows.Forms.Label();
            this.lblCardSource = new System.Windows.Forms.Label();
            this.tabLaminatorOptions = new System.Windows.Forms.TabPage();
            this.cbxSetDefaultLaminatorOptions = new System.Windows.Forms.CheckBox();
            this.txtBottomLaminate = new System.Windows.Forms.TextBox();
            this.txtTopLaminate = new System.Windows.Forms.TextBox();
            this.txtLaminator = new System.Windows.Forms.TextBox();
            this.cbxLaminationMode = new System.Windows.Forms.ComboBox();
            this.lblBottomLaminate = new System.Windows.Forms.Label();
            this.lblTopLaminate = new System.Windows.Forms.Label();
            this.lblLaminationMode = new System.Windows.Forms.Label();
            this.lblLaminator = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPrinterConnection.SuspendLayout();
            this.tabCardOptions.SuspendLayout();
            this.tabLaminatorOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfoEng
            // 
            this.lblInfoEng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoEng.BackColor = System.Drawing.SystemColors.Info;
            this.lblInfoEng.Image = global::Mx.Amib.Sistemas.Credencializacion.Properties.Resources.IconInfo;
            this.lblInfoEng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInfoEng.Location = new System.Drawing.Point(15, 13);
            this.lblInfoEng.Name = "lblInfoEng";
            this.lblInfoEng.Size = new System.Drawing.Size(612, 27);
            this.lblInfoEng.TabIndex = 0;
            this.lblInfoEng.Text = "Las opciones mostradas a continuación se encuentran en inglés dado que son propia" +
    "s del fabricante";
            this.lblInfoEng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPrinterConnection);
            this.tabControl.Controls.Add(this.tabCardOptions);
            this.tabControl.Controls.Add(this.tabLaminatorOptions);
            this.tabControl.Location = new System.Drawing.Point(18, 43);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(609, 279);
            this.tabControl.TabIndex = 1;
            // 
            // tabPrinterConnection
            // 
            this.tabPrinterConnection.Controls.Add(this.cbxSetDefaultPrinterConnection);
            this.tabPrinterConnection.Controls.Add(this.btnConnect);
            this.tabPrinterConnection.Controls.Add(this.btnDiscovery);
            this.tabPrinterConnection.Controls.Add(this.cbxPrinters);
            this.tabPrinterConnection.Controls.Add(this.lblPrinters);
            this.tabPrinterConnection.Controls.Add(this.cbxPrinterPorts);
            this.tabPrinterConnection.Controls.Add(this.lblPrinterPorts);
            this.tabPrinterConnection.Location = new System.Drawing.Point(4, 22);
            this.tabPrinterConnection.Name = "tabPrinterConnection";
            this.tabPrinterConnection.Size = new System.Drawing.Size(601, 253);
            this.tabPrinterConnection.TabIndex = 2;
            this.tabPrinterConnection.Text = "Printer connection";
            this.tabPrinterConnection.UseVisualStyleBackColor = true;
            // 
            // cbxSetDefaultPrinterConnection
            // 
            this.cbxSetDefaultPrinterConnection.AutoSize = true;
            this.cbxSetDefaultPrinterConnection.Location = new System.Drawing.Point(147, 126);
            this.cbxSetDefaultPrinterConnection.Name = "cbxSetDefaultPrinterConnection";
            this.cbxSetDefaultPrinterConnection.Size = new System.Drawing.Size(91, 17);
            this.cbxSetDefaultPrinterConnection.TabIndex = 6;
            this.cbxSetDefaultPrinterConnection.Text = "Set as default";
            this.cbxSetDefaultPrinterConnection.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(147, 97);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnDiscovery
            // 
            this.btnDiscovery.Location = new System.Drawing.Point(147, 41);
            this.btnDiscovery.Name = "btnDiscovery";
            this.btnDiscovery.Size = new System.Drawing.Size(75, 23);
            this.btnDiscovery.TabIndex = 4;
            this.btnDiscovery.Text = "Discovery";
            this.btnDiscovery.UseVisualStyleBackColor = true;
            // 
            // cbxPrinters
            // 
            this.cbxPrinters.FormattingEnabled = true;
            this.cbxPrinters.Location = new System.Drawing.Point(147, 70);
            this.cbxPrinters.Name = "cbxPrinters";
            this.cbxPrinters.Size = new System.Drawing.Size(409, 21);
            this.cbxPrinters.TabIndex = 3;
            // 
            // lblPrinters
            // 
            this.lblPrinters.Location = new System.Drawing.Point(16, 67);
            this.lblPrinters.Name = "lblPrinters";
            this.lblPrinters.Size = new System.Drawing.Size(125, 24);
            this.lblPrinters.TabIndex = 2;
            this.lblPrinters.Text = "Printers";
            this.lblPrinters.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxPrinterPorts
            // 
            this.cbxPrinterPorts.FormattingEnabled = true;
            this.cbxPrinterPorts.Location = new System.Drawing.Point(147, 16);
            this.cbxPrinterPorts.Name = "cbxPrinterPorts";
            this.cbxPrinterPorts.Size = new System.Drawing.Size(196, 21);
            this.cbxPrinterPorts.TabIndex = 1;
            // 
            // lblPrinterPorts
            // 
            this.lblPrinterPorts.Location = new System.Drawing.Point(16, 13);
            this.lblPrinterPorts.Name = "lblPrinterPorts";
            this.lblPrinterPorts.Size = new System.Drawing.Size(125, 24);
            this.lblPrinterPorts.TabIndex = 0;
            this.lblPrinterPorts.Text = "Printer ports";
            this.lblPrinterPorts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabCardOptions
            // 
            this.tabCardOptions.Controls.Add(this.cbxSetDefaultCardOptions);
            this.tabCardOptions.Controls.Add(this.cbxCardTypeInUse);
            this.tabCardOptions.Controls.Add(this.cbxCardDestination);
            this.tabCardOptions.Controls.Add(this.cbxCardSource);
            this.tabCardOptions.Controls.Add(this.lblCardTypeInUse);
            this.tabCardOptions.Controls.Add(this.lblCardDestination);
            this.tabCardOptions.Controls.Add(this.lblCardSource);
            this.tabCardOptions.Location = new System.Drawing.Point(4, 22);
            this.tabCardOptions.Name = "tabCardOptions";
            this.tabCardOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabCardOptions.Size = new System.Drawing.Size(601, 253);
            this.tabCardOptions.TabIndex = 0;
            this.tabCardOptions.Text = "Card options";
            this.tabCardOptions.UseVisualStyleBackColor = true;
            // 
            // cbxSetDefaultCardOptions
            // 
            this.cbxSetDefaultCardOptions.AutoSize = true;
            this.cbxSetDefaultCardOptions.Location = new System.Drawing.Point(147, 97);
            this.cbxSetDefaultCardOptions.Name = "cbxSetDefaultCardOptions";
            this.cbxSetDefaultCardOptions.Size = new System.Drawing.Size(91, 17);
            this.cbxSetDefaultCardOptions.TabIndex = 7;
            this.cbxSetDefaultCardOptions.Text = "Set as default";
            this.cbxSetDefaultCardOptions.UseVisualStyleBackColor = true;
            // 
            // cbxCardTypeInUse
            // 
            this.cbxCardTypeInUse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCardTypeInUse.FormattingEnabled = true;
            this.cbxCardTypeInUse.Location = new System.Drawing.Point(147, 70);
            this.cbxCardTypeInUse.Name = "cbxCardTypeInUse";
            this.cbxCardTypeInUse.Size = new System.Drawing.Size(391, 21);
            this.cbxCardTypeInUse.TabIndex = 6;
            // 
            // cbxCardDestination
            // 
            this.cbxCardDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCardDestination.FormattingEnabled = true;
            this.cbxCardDestination.Location = new System.Drawing.Point(147, 43);
            this.cbxCardDestination.Name = "cbxCardDestination";
            this.cbxCardDestination.Size = new System.Drawing.Size(391, 21);
            this.cbxCardDestination.TabIndex = 5;
            // 
            // cbxCardSource
            // 
            this.cbxCardSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCardSource.FormattingEnabled = true;
            this.cbxCardSource.Location = new System.Drawing.Point(147, 16);
            this.cbxCardSource.Name = "cbxCardSource";
            this.cbxCardSource.Size = new System.Drawing.Size(391, 21);
            this.cbxCardSource.TabIndex = 4;
            // 
            // lblCardTypeInUse
            // 
            this.lblCardTypeInUse.Location = new System.Drawing.Point(16, 67);
            this.lblCardTypeInUse.Name = "lblCardTypeInUse";
            this.lblCardTypeInUse.Size = new System.Drawing.Size(125, 24);
            this.lblCardTypeInUse.TabIndex = 3;
            this.lblCardTypeInUse.Text = "Card type in use";
            this.lblCardTypeInUse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCardDestination
            // 
            this.lblCardDestination.Location = new System.Drawing.Point(16, 40);
            this.lblCardDestination.Name = "lblCardDestination";
            this.lblCardDestination.Size = new System.Drawing.Size(125, 24);
            this.lblCardDestination.TabIndex = 2;
            this.lblCardDestination.Text = "Card destination";
            this.lblCardDestination.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCardSource
            // 
            this.lblCardSource.Location = new System.Drawing.Point(16, 13);
            this.lblCardSource.Name = "lblCardSource";
            this.lblCardSource.Size = new System.Drawing.Size(125, 24);
            this.lblCardSource.TabIndex = 1;
            this.lblCardSource.Text = "Card source";
            this.lblCardSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabLaminatorOptions
            // 
            this.tabLaminatorOptions.Controls.Add(this.cbxSetDefaultLaminatorOptions);
            this.tabLaminatorOptions.Controls.Add(this.txtBottomLaminate);
            this.tabLaminatorOptions.Controls.Add(this.txtTopLaminate);
            this.tabLaminatorOptions.Controls.Add(this.txtLaminator);
            this.tabLaminatorOptions.Controls.Add(this.cbxLaminationMode);
            this.tabLaminatorOptions.Controls.Add(this.lblBottomLaminate);
            this.tabLaminatorOptions.Controls.Add(this.lblTopLaminate);
            this.tabLaminatorOptions.Controls.Add(this.lblLaminationMode);
            this.tabLaminatorOptions.Controls.Add(this.lblLaminator);
            this.tabLaminatorOptions.Location = new System.Drawing.Point(4, 22);
            this.tabLaminatorOptions.Name = "tabLaminatorOptions";
            this.tabLaminatorOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabLaminatorOptions.Size = new System.Drawing.Size(601, 253);
            this.tabLaminatorOptions.TabIndex = 1;
            this.tabLaminatorOptions.Text = "Laminator info and options";
            this.tabLaminatorOptions.UseVisualStyleBackColor = true;
            // 
            // cbxSetDefaultLaminatorOptions
            // 
            this.cbxSetDefaultLaminatorOptions.AutoSize = true;
            this.cbxSetDefaultLaminatorOptions.Location = new System.Drawing.Point(147, 123);
            this.cbxSetDefaultLaminatorOptions.Name = "cbxSetDefaultLaminatorOptions";
            this.cbxSetDefaultLaminatorOptions.Size = new System.Drawing.Size(91, 17);
            this.cbxSetDefaultLaminatorOptions.TabIndex = 10;
            this.cbxSetDefaultLaminatorOptions.Text = "Set as default";
            this.cbxSetDefaultLaminatorOptions.UseVisualStyleBackColor = true;
            // 
            // txtBottomLaminate
            // 
            this.txtBottomLaminate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBottomLaminate.Location = new System.Drawing.Point(147, 97);
            this.txtBottomLaminate.Name = "txtBottomLaminate";
            this.txtBottomLaminate.Size = new System.Drawing.Size(391, 20);
            this.txtBottomLaminate.TabIndex = 9;
            // 
            // txtTopLaminate
            // 
            this.txtTopLaminate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTopLaminate.Location = new System.Drawing.Point(147, 71);
            this.txtTopLaminate.Name = "txtTopLaminate";
            this.txtTopLaminate.Size = new System.Drawing.Size(391, 20);
            this.txtTopLaminate.TabIndex = 8;
            // 
            // txtLaminator
            // 
            this.txtLaminator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLaminator.Location = new System.Drawing.Point(147, 16);
            this.txtLaminator.Name = "txtLaminator";
            this.txtLaminator.Size = new System.Drawing.Size(391, 20);
            this.txtLaminator.TabIndex = 7;
            // 
            // cbxLaminationMode
            // 
            this.cbxLaminationMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLaminationMode.FormattingEnabled = true;
            this.cbxLaminationMode.Location = new System.Drawing.Point(147, 43);
            this.cbxLaminationMode.Name = "cbxLaminationMode";
            this.cbxLaminationMode.Size = new System.Drawing.Size(391, 21);
            this.cbxLaminationMode.TabIndex = 6;
            // 
            // lblBottomLaminate
            // 
            this.lblBottomLaminate.Location = new System.Drawing.Point(16, 94);
            this.lblBottomLaminate.Name = "lblBottomLaminate";
            this.lblBottomLaminate.Size = new System.Drawing.Size(125, 24);
            this.lblBottomLaminate.TabIndex = 5;
            this.lblBottomLaminate.Text = "Bottom laminate";
            this.lblBottomLaminate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTopLaminate
            // 
            this.lblTopLaminate.Location = new System.Drawing.Point(16, 67);
            this.lblTopLaminate.Name = "lblTopLaminate";
            this.lblTopLaminate.Size = new System.Drawing.Size(125, 24);
            this.lblTopLaminate.TabIndex = 4;
            this.lblTopLaminate.Text = "Top laminate";
            this.lblTopLaminate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLaminationMode
            // 
            this.lblLaminationMode.Location = new System.Drawing.Point(16, 40);
            this.lblLaminationMode.Name = "lblLaminationMode";
            this.lblLaminationMode.Size = new System.Drawing.Size(125, 24);
            this.lblLaminationMode.TabIndex = 3;
            this.lblLaminationMode.Text = "Lamination mode";
            this.lblLaminationMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLaminator
            // 
            this.lblLaminator.Location = new System.Drawing.Point(16, 13);
            this.lblLaminator.Name = "lblLaminator";
            this.lblLaminator.Size = new System.Drawing.Size(125, 24);
            this.lblLaminator.TabIndex = 2;
            this.lblLaminator.Text = "Laminator";
            this.lblLaminator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(363, 328);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(127, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply changes";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnDiscard
            // 
            this.btnDiscard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiscard.Location = new System.Drawing.Point(496, 328);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(127, 23);
            this.btnDiscard.TabIndex = 3;
            this.btnDiscard.Text = "Discard changes";
            this.btnDiscard.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Location = new System.Drawing.Point(18, 328);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset settings";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Zebra8PrinterConfigUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblInfoEng);
            this.Name = "Zebra8PrinterConfigUserControl";
            this.Size = new System.Drawing.Size(646, 366);
            this.tabControl.ResumeLayout(false);
            this.tabPrinterConnection.ResumeLayout(false);
            this.tabPrinterConnection.PerformLayout();
            this.tabCardOptions.ResumeLayout(false);
            this.tabCardOptions.PerformLayout();
            this.tabLaminatorOptions.ResumeLayout(false);
            this.tabLaminatorOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfoEng;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPrinterConnection;
        private System.Windows.Forms.TabPage tabCardOptions;
        private System.Windows.Forms.TabPage tabLaminatorOptions;
        private System.Windows.Forms.CheckBox cbxSetDefaultPrinterConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDiscovery;
        private System.Windows.Forms.ComboBox cbxPrinters;
        private System.Windows.Forms.Label lblPrinters;
        private System.Windows.Forms.ComboBox cbxPrinterPorts;
        private System.Windows.Forms.Label lblPrinterPorts;
        private System.Windows.Forms.Label lblCardSource;
        private System.Windows.Forms.CheckBox cbxSetDefaultCardOptions;
        private System.Windows.Forms.ComboBox cbxCardTypeInUse;
        private System.Windows.Forms.ComboBox cbxCardDestination;
        private System.Windows.Forms.ComboBox cbxCardSource;
        private System.Windows.Forms.Label lblCardTypeInUse;
        private System.Windows.Forms.Label lblCardDestination;
        private System.Windows.Forms.Label lblBottomLaminate;
        private System.Windows.Forms.Label lblTopLaminate;
        private System.Windows.Forms.Label lblLaminationMode;
        private System.Windows.Forms.Label lblLaminator;
        private System.Windows.Forms.CheckBox cbxSetDefaultLaminatorOptions;
        private System.Windows.Forms.TextBox txtBottomLaminate;
        private System.Windows.Forms.TextBox txtTopLaminate;
        private System.Windows.Forms.TextBox txtLaminator;
        private System.Windows.Forms.ComboBox cbxLaminationMode;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnReset;
    }
}
