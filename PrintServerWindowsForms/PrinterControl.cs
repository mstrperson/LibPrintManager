using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibPrintManager;

namespace PrintServerWindowsForms
{
    public partial class PrinterControl : UserControl
    {
        private int Id { get; set; }

        public PrinterControl(int printerId)
        {
            InitializeComponent();
            using (PrintManagerDatabaseEntities db = new PrintManagerDatabaseEntities())
            {
                Printer printer = db.Printers.Find(printerId);
                if (printer == null) throw new ArgumentException("Invalid Printer Id", "printerId");

                Id = printerId;
                printerName.Text = printer.Name;
                isUseable.Checked = printer.IsWorking;

                foreach (Job job in printer.ActiveJobs.ToList()) 
                {
                    jobListView.Items.Add(new ListViewItem()
                    {
                        Text = String.Format("{0} {1} - {2} - {3}",
                                    job.SubmissionDate.ToShortDateString(),
                                    job.SubmissionDate.ToShortTimeString(),
                                    job.FileName,
                                    job.User.Email),
                        Tag = job.Id,
                        Selected = false
                    });
                }
            }
        }
    }
}
