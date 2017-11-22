namespace PrintServerWindowsForms
{
    partial class JobControl
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
            this.components = new System.ComponentModel.Container();
            this.statusDropdown = new System.Windows.Forms.ComboBox();
            this.jobStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printManagerDatabaseDataSet = new PrintServerWindowsForms.PrintManagerDatabaseDataSet();
            this.jobStatusTableAdapter = new PrintServerWindowsForms.PrintManagerDatabaseDataSetTableAdapters.JobStatusTableAdapter();
            this.jobOwnerLabel = new System.Windows.Forms.Label();
            this.jobTitle = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jobStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printManagerDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // statusDropdown
            // 
            this.statusDropdown.DataSource = this.jobStatusBindingSource;
            this.statusDropdown.DisplayMember = "Label";
            this.statusDropdown.FormattingEnabled = true;
            this.statusDropdown.Location = new System.Drawing.Point(3, 80);
            this.statusDropdown.Name = "statusDropdown";
            this.statusDropdown.Size = new System.Drawing.Size(443, 28);
            this.statusDropdown.TabIndex = 0;
            this.statusDropdown.ValueMember = "Id";
            // 
            // jobStatusBindingSource
            // 
            this.jobStatusBindingSource.DataMember = "JobStatus";
            this.jobStatusBindingSource.DataSource = this.printManagerDatabaseDataSet;
            // 
            // printManagerDatabaseDataSet
            // 
            this.printManagerDatabaseDataSet.DataSetName = "PrintManagerDatabaseDataSet";
            this.printManagerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobStatusTableAdapter
            // 
            this.jobStatusTableAdapter.ClearBeforeFill = true;
            // 
            // jobOwnerLabel
            // 
            this.jobOwnerLabel.AutoSize = true;
            this.jobOwnerLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.jobOwnerLabel.Location = new System.Drawing.Point(3, 0);
            this.jobOwnerLabel.Name = "jobOwnerLabel";
            this.jobOwnerLabel.Size = new System.Drawing.Size(85, 20);
            this.jobOwnerLabel.TabIndex = 1;
            this.jobOwnerLabel.Text = "Job Owner";
            // 
            // jobTitle
            // 
            this.jobTitle.AutoSize = true;
            this.jobTitle.Location = new System.Drawing.Point(3, 40);
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(68, 20);
            this.jobTitle.TabIndex = 2;
            this.jobTitle.Text = "Job Title";
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(167, 31);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(127, 38);
            this.downloadButton.TabIndex = 3;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(300, 31);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(146, 38);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update Status";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // JobControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.jobTitle);
            this.Controls.Add(this.jobOwnerLabel);
            this.Controls.Add(this.statusDropdown);
            this.Name = "JobControl";
            this.Size = new System.Drawing.Size(449, 111);
            ((System.ComponentModel.ISupportInitialize)(this.jobStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printManagerDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox statusDropdown;
        private System.Windows.Forms.BindingSource jobStatusBindingSource;
        private PrintManagerDatabaseDataSet printManagerDatabaseDataSet;
        private PrintManagerDatabaseDataSetTableAdapters.JobStatusTableAdapter jobStatusTableAdapter;
        private System.Windows.Forms.Label jobOwnerLabel;
        private System.Windows.Forms.Label jobTitle;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button updateButton;
    }
}
