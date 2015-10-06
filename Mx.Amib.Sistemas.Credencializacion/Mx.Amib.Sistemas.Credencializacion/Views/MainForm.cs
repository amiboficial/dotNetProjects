using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mx.Amib.Sistemas.Credencializacion.Properties;

namespace Mx.Amib.Sistemas.Credencializacion.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            //utiliza el icono del archivo de recursos
            this.Icon = Resources.IconoAplicacion;
            //expande todo el menú del arbol
            this.tvwSideMenu.ExpandAll();
            //inicializa el listado de imagenes para el menu obtienendolas de los resources
            this.imglSideMenu.Images.Add("Default", Properties.Resources.MenuIconDefault);
            this.imglSideMenu.Images.Add("Sustentantes", Properties.Resources.MenuIconSustentantes);
            this.imglSideMenu.Images.Add("PrinterQueue", Properties.Resources.MenuIconPrinterQueue);
            this.imglSideMenu.Images.Add("PrinterLogging", Properties.Resources.MenuIconPrinterLogging);
            this.imglSideMenu.Images.Add("PrinterConfig", Properties.Resources.MenuIconPrinterConfig);
            this.imglSideMenu.Images.Add("TemplateConfig", Properties.Resources.MenuIconTemplateConfig);
            //asigna las imagenes en el list a los elementos del menu
            this.tvwSideMenu.Nodes["nodeCred"].Nodes["nodeSustentante"].ImageKey = "Sustentantes";
            this.tvwSideMenu.Nodes["nodeCred"].Nodes["nodeSustentante"].SelectedImageKey = "Sustentantes";
            this.tvwSideMenu.Nodes["nodePrinting"].Nodes["nodePrinterQueue"].ImageKey = "PrinterQueue";
            this.tvwSideMenu.Nodes["nodePrinting"].Nodes["nodePrinterQueue"].SelectedImageKey = "PrinterQueue";
            this.tvwSideMenu.Nodes["nodePrinting"].Nodes["nodePrinterLogging"].ImageKey = "PrinterLogging";
            this.tvwSideMenu.Nodes["nodePrinting"].Nodes["nodePrinterLogging"].SelectedImageKey = "PrinterLogging";
            this.tvwSideMenu.Nodes["nodePrinting"].Nodes["nodePrinterConfig"].ImageKey = "PrinterConfig";
            this.tvwSideMenu.Nodes["nodePrinting"].Nodes["nodePrinterConfig"].SelectedImageKey = "PrinterConfig";
            this.tvwSideMenu.Nodes["nodePrinting"].Nodes["nodeTemplateConfig"].ImageKey = "TemplateConfig";
            this.tvwSideMenu.Nodes["nodePrinting"].Nodes["nodeTemplateConfig"].SelectedImageKey = "TemplateConfig";
            //this.tvwSideMenu.im
        }

        private void tvwSideMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedMenu = (string)e.Node.Tag;

            this.sustentantesUserControl.Visible = false;
            this.printerQueueUserControl.Visible = false;
            this.printerLoggingUserControl.Visible = false;
            this.templateConfigUserControl.Visible = false;
            this.printerConfigUserControl.Visible = false;

            if (selectedMenu == "Sustentantes")
            {
                this.sustentantesUserControl.Visible = true;
            }
            else if (selectedMenu == "PrinterQueue")
            {
                this.printerQueueUserControl.Visible = true;
            }
            else if (selectedMenu == "PrinterLogging")
            {
                this.printerLoggingUserControl.Visible = true;
            }
            else if (selectedMenu == "TemplateConfig")
            {
                this.templateConfigUserControl.Visible = true;
            }
            else if (selectedMenu == "PrinterConfig")
            {
                this.printerConfigUserControl.Visible = true;
            }
        }
    }
}
