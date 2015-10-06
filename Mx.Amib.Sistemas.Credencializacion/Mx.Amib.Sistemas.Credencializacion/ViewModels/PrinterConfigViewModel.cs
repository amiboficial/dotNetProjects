using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mx.Amib.Sistemas.Credencializacion.ViewModels
{
    public class PrinterConfigViewModel
    {
        private SortedDictionary<string, string> _printers;

        public PrinterConfigViewModel()
        {
            _printers = new SortedDictionary<string, string>();
            _printers.Add("Zebra8Printer", "Zebra ZXP Series 8 Printer");
            _printers.Add("FilePrinter", "Guardado en archivos");
        }
    }
}
