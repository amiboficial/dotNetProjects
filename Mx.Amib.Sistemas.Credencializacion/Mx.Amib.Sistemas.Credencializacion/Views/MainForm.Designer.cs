namespace Mx.Amib.Sistemas.Credencializacion.Views
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Búsqueda de Autorizados");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Credencialización de Autorizados", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Cola de Trabajo");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Bitácora de Impresión");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Configuración de Impresora");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Configuración de Plantilla");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Gestión de Impresión", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlTitleGradient = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.tvwSideMenu = new System.Windows.Forms.TreeView();
            this.imglSideMenu = new System.Windows.Forms.ImageList(this.components);
            this.pnlModule = new System.Windows.Forms.Panel();
            this.printerLoggingUserControl = new Mx.Amib.Sistemas.Credencializacion.Views.PrinterLoggingUserControl();
            this.printerQueueUserControl = new Mx.Amib.Sistemas.Credencializacion.Views.PrinterQueueUserControl();
            this.sustentantesUserControl = new Mx.Amib.Sistemas.Credencializacion.Views.SustentantesUserControl();
            this.templateConfigUserControl = new Mx.Amib.Sistemas.Credencializacion.Views.TemplateConfigUserControl();
            this.pnlTitle.SuspendLayout();
            this.pnlTitleGradient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTitle.BackgroundImage = global::Mx.Amib.Sistemas.Credencializacion.Properties.Resources.FondoTitulo;
            this.pnlTitle.Controls.Add(this.pnlTitleGradient);
            this.pnlTitle.Controls.Add(this.pbxLogo);
            this.pnlTitle.Controls.Add(this.lblCompany);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(944, 94);
            this.pnlTitle.TabIndex = 9;
            // 
            // pnlTitleGradient
            // 
            this.pnlTitleGradient.BackgroundImage = global::Mx.Amib.Sistemas.Credencializacion.Properties.Resources.DegradadoTituloAplicacion;
            this.pnlTitleGradient.Controls.Add(this.lblVersion);
            this.pnlTitleGradient.Controls.Add(this.lblAppTitle);
            this.pnlTitleGradient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTitleGradient.Location = new System.Drawing.Point(0, 62);
            this.pnlTitleGradient.Name = "pnlTitleGradient";
            this.pnlTitleGradient.Size = new System.Drawing.Size(944, 32);
            this.pnlTitleGradient.TabIndex = 9;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVersion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(77)))), ((int)(((byte)(21)))));
            this.lblVersion.Location = new System.Drawing.Point(854, 7);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(87, 18);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "Versión 0.1";
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAppTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(77)))), ((int)(((byte)(21)))));
            this.lblAppTitle.Location = new System.Drawing.Point(10, 7);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(146, 19);
            this.lblAppTitle.TabIndex = 10;
            this.lblAppTitle.Text = "Credencialización";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxLogo.Image = global::Mx.Amib.Sistemas.Credencializacion.Properties.Resources.LogotipoAmib;
            this.pbxLogo.InitialImage = null;
            this.pbxLogo.Location = new System.Drawing.Point(236, 6);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(55, 50);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 6;
            this.pbxLogo.TabStop = false;
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCompany.AutoSize = true;
            this.lblCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblCompany.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.ForeColor = System.Drawing.Color.White;
            this.lblCompany.Location = new System.Drawing.Point(304, 20);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(404, 23);
            this.lblCompany.TabIndex = 7;
            this.lblCompany.Text = "Asociación Mexicana de Intermediarios Bursátiles";
            // 
            // tvwSideMenu
            // 
            this.tvwSideMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvwSideMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwSideMenu.HideSelection = false;
            this.tvwSideMenu.ImageIndex = 0;
            this.tvwSideMenu.ImageList = this.imglSideMenu;
            this.tvwSideMenu.Location = new System.Drawing.Point(0, 94);
            this.tvwSideMenu.Name = "tvwSideMenu";
            treeNode1.Name = "nodeSustentante";
            treeNode1.Tag = "Sustentantes";
            treeNode1.Text = "Búsqueda de Autorizados";
            treeNode2.Name = "nodeCred";
            treeNode2.Tag = "Default";
            treeNode2.Text = "Credencialización de Autorizados";
            treeNode3.Name = "nodePrinterQueue";
            treeNode3.Tag = "PrinterQueue";
            treeNode3.Text = "Cola de Trabajo";
            treeNode4.Name = "nodePrinterLogging";
            treeNode4.Tag = "PrinterLogging";
            treeNode4.Text = "Bitácora de Impresión";
            treeNode5.Name = "nodePrinterConfig";
            treeNode5.Tag = "PrinterConfig";
            treeNode5.Text = "Configuración de Impresora";
            treeNode6.Name = "nodeTemplateConfig";
            treeNode6.Tag = "TemplateConfig";
            treeNode6.Text = "Configuración de Plantilla";
            treeNode7.Name = "nodePrinting";
            treeNode7.Tag = "Default";
            treeNode7.Text = "Gestión de Impresión";
            this.tvwSideMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode7});
            this.tvwSideMenu.SelectedImageIndex = 0;
            this.tvwSideMenu.Size = new System.Drawing.Size(265, 507);
            this.tvwSideMenu.TabIndex = 12;
            this.tvwSideMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwSideMenu_AfterSelect);
            // 
            // imglSideMenu
            // 
            this.imglSideMenu.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imglSideMenu.ImageSize = new System.Drawing.Size(16, 16);
            this.imglSideMenu.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlModule
            // 
            this.pnlModule.BackColor = System.Drawing.SystemColors.Control;
            this.pnlModule.Controls.Add(this.templateConfigUserControl);
            this.pnlModule.Controls.Add(this.printerLoggingUserControl);
            this.pnlModule.Controls.Add(this.printerQueueUserControl);
            this.pnlModule.Controls.Add(this.sustentantesUserControl);
            this.pnlModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlModule.Location = new System.Drawing.Point(265, 94);
            this.pnlModule.Name = "pnlModule";
            this.pnlModule.Size = new System.Drawing.Size(679, 507);
            this.pnlModule.TabIndex = 13;
            // 
            // printerLoggingUserControl
            // 
            this.printerLoggingUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printerLoggingUserControl.Location = new System.Drawing.Point(0, 0);
            this.printerLoggingUserControl.Name = "printerLoggingUserControl";
            this.printerLoggingUserControl.Size = new System.Drawing.Size(679, 507);
            this.printerLoggingUserControl.TabIndex = 2;
            // 
            // printerQueueUserControl
            // 
            this.printerQueueUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printerQueueUserControl.Location = new System.Drawing.Point(0, 0);
            this.printerQueueUserControl.Name = "printerQueueUserControl";
            this.printerQueueUserControl.Size = new System.Drawing.Size(679, 507);
            this.printerQueueUserControl.TabIndex = 1;
            // 
            // sustentantesUserControl
            // 
            this.sustentantesUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sustentantesUserControl.Location = new System.Drawing.Point(0, 0);
            this.sustentantesUserControl.Name = "sustentantesUserControl";
            this.sustentantesUserControl.Size = new System.Drawing.Size(679, 507);
            this.sustentantesUserControl.TabIndex = 0;
            // 
            // templateConfigUserControl
            // 
            this.templateConfigUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateConfigUserControl.Location = new System.Drawing.Point(0, 0);
            this.templateConfigUserControl.Name = "templateConfigUserControl";
            this.templateConfigUserControl.Size = new System.Drawing.Size(679, 507);
            this.templateConfigUserControl.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.pnlModule);
            this.Controls.Add(this.tvwSideMenu);
            this.Controls.Add(this.pnlTitle);
            this.Name = "MainForm";
            this.Text = "Credencialización";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlTitleGradient.ResumeLayout(false);
            this.pnlTitleGradient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlModule.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleGradient;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TreeView tvwSideMenu;
        private System.Windows.Forms.ImageList imglSideMenu;
        private System.Windows.Forms.Panel pnlModule;
        private SustentantesUserControl sustentantesUserControl;
        private PrinterQueueUserControl printerQueueUserControl;
        private PrinterLoggingUserControl printerLoggingUserControl;
        private TemplateConfigUserControl templateConfigUserControl;
    }
}