using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintServerWindowsForms
{
    public partial class PrinterControl : UserControl
    {
        private int Id { get; set; }

        public PrinterControl(int printerId)
        {
            InitializeComponent();

            Id = printerId;
        }
    }
}
