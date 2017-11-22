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
using System.IO;

namespace PrintServerWindowsForms
{
    public partial class JobControl : UserControl
    {
        public String JobTitle
        {
            get
            {
                return this.jobTitle.Text;
            }
            set
            {
                this.jobTitle.Text = value;
            }
        }

        public String JobOwner
        {
            get
            {
                return this.jobOwnerLabel.Text;
            }
            set
            {
                this.jobOwnerLabel.Text = value;
            }
        }

        public JobStatus Status
        {
            get
            {
                return (JobStatus)this.statusDropdown.SelectedItem;
            }
            set
            {
                this.statusDropdown.SelectedItem = value;
            }
        }

        public int JobId
        {
            get; set;
        }

        public JobControl()
        {
            InitializeComponent();
        }

        public void LoadJob(Job job)
        {
            JobOwner = String.IsNullOrEmpty(job.User.Name) ? job.User.Email : job.User.Name;
            JobTitle = job.FileName;
            Status = job.JobStatus;
            JobId = job.Id;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (PrintManagerDatabaseEntities db = new PrintManagerDatabaseEntities())
            {
                Job job = db.Jobs.Find(JobId);
                job.StatusId = (int)statusDropdown.SelectedValue;
                db.SaveChanges();
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            downloadDialog.FileName = JobTitle;
            downloadDialog.ShowDialog();
        }

        private void downloadDialog_FileOk(object sender, CancelEventArgs e)
        {
            using (PrintManagerDatabaseEntities db = new PrintManagerDatabaseEntities())
            {
                Stream fs = downloadDialog.OpenFile();
                Job job = db.Jobs.Find(JobId);

                foreach(Byte bt in job.File)
                {
                    fs.WriteByte(bt);
                }

                fs.Flush();
                fs.Close();
            }
        }
    }
}
