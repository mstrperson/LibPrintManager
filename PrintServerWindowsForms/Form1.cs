using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibPrintManager;

namespace PrintServerWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (PrintManagerDatabaseEntities db = new PrintManagerDatabaseEntities())
            {
                foreach(Printer printer in db.Printers.ToList())
                {
                    ToolStripMenuItem tsmi = new ToolStripMenuItem(printer.Name);
                    tsmi.Click += LoadPrinter;
                    tsmi.Tag = printer.Id;
                }
            }
        }

        private void LoadPrinter(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            PrinterControl pc = new PrinterControl();
            pc.LoadPrinterInfo((int)tsmi.Tag);

            this.Controls.Add(pc);
        }
    }
}
