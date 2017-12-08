namespace PrintServerWindowsForms
{
    partial class PrinterControl
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
            this.printerName = new System.Windows.Forms.Label();
            this.isUseable = new System.Windows.Forms.CheckBox();
            this.jobListView = new System.Windows.Forms.ListView();
            this.Job = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.start = new System.Windows.Forms.Button();
            this.notPrintable = new System.Windows.Forms.Button();
            this.complete = new System.Windows.Forms.Button();
            this.other = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printerName
            // 
            this.printerName.AutoSize = true;
            this.printerName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.printerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.printerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.printerName.Location = new System.Drawing.Point(4, 4);
            this.printerName.Name = "printerName";
            this.printerName.Size = new System.Drawing.Size(157, 31);
            this.printerName.TabIndex = 0;
            this.printerName.Text = "Printer Name";
            // 
            // isUseable
            // 
            this.isUseable.AutoSize = true;
            this.isUseable.Checked = true;
            this.isUseable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isUseable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isUseable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isUseable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.isUseable.Location = new System.Drawing.Point(4, 39);
            this.isUseable.Name = "isUseable";
            this.isUseable.Size = new System.Drawing.Size(183, 24);
            this.isUseable.TabIndex = 1;
            this.isUseable.Text = "This Printer Is Working";
            this.isUseable.UseVisualStyleBackColor = true;
            // 
            // jobListView
            // 
            this.jobListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.jobListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Job,
            this.Status,
            this.User});
            this.jobListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.jobListView.HideSelection = false;
            this.jobListView.Location = new System.Drawing.Point(212, 4);
            this.jobListView.MultiSelect = false;
            this.jobListView.Name = "jobListView";
            this.jobListView.Size = new System.Drawing.Size(387, 229);
            this.jobListView.TabIndex = 2;
            this.jobListView.UseCompatibleStateImageBehavior = false;
            // 
            // Job
            // 
            this.Job.Text = "";
            // 
            // Status
            // 
            this.Status.Text = "";
            // 
            // User
            // 
            this.User.Text = "";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(34, 93);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(142, 23);
            this.start.TabIndex = 3;
            this.start.Text = "Start Job";
            this.start.UseVisualStyleBackColor = true;
            // 
            // notPrintable
            // 
            this.notPrintable.Location = new System.Drawing.Point(34, 123);
            this.notPrintable.Name = "notPrintable";
            this.notPrintable.Size = new System.Drawing.Size(141, 23);
            this.notPrintable.TabIndex = 4;
            this.notPrintable.Text = "Job Isn\'t Printable";
            this.notPrintable.UseVisualStyleBackColor = true;
            // 
            // complete
            // 
            this.complete.Location = new System.Drawing.Point(34, 153);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(140, 23);
            this.complete.TabIndex = 5;
            this.complete.Text = "Job Is Complete";
            this.complete.UseVisualStyleBackColor = true;
            // 
            // other
            // 
            this.other.Location = new System.Drawing.Point(4, 209);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(199, 23);
            this.other.TabIndex = 6;
            this.other.Text = "Other Job Related Issue";
            this.other.UseVisualStyleBackColor = true;
            // 
            // PrinterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.other);
            this.Controls.Add(this.complete);
            this.Controls.Add(this.notPrintable);
            this.Controls.Add(this.start);
            this.Controls.Add(this.jobListView);
            this.Controls.Add(this.isUseable);
            this.Controls.Add(this.printerName);
            this.Name = "PrinterControl";
            this.Size = new System.Drawing.Size(602, 236);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label printerName;
        private System.Windows.Forms.CheckBox isUseable;
        private System.Windows.Forms.ListView jobListView;
        private System.Windows.Forms.ColumnHeader Job;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button notPrintable;
        private System.Windows.Forms.Button complete;
        private System.Windows.Forms.Button other;
    }
}
