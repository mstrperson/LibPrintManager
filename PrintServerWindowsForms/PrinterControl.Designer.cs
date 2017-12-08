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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Job = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Job,
            this.Status,
            this.User});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(212, 4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(387, 229);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start Job";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Job Isn\'t Printable";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(34, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Job Is Complete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Other Job Related Issue";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // PrinterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Job;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
