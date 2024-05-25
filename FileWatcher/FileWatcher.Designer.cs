namespace FileWatcher
{
    partial class FileWatcher
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
            this.txtInputDirectory = new System.Windows.Forms.TextBox();
            this.txtBackupDirectory = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnChooseInput = new System.Windows.Forms.Button();
            this.btnChooseBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputDirectory
            // 
            this.txtInputDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputDirectory.Location = new System.Drawing.Point(24, 21);
            this.txtInputDirectory.Name = "txtInputDirectory";
            this.txtInputDirectory.Size = new System.Drawing.Size(1596, 48);
            this.txtInputDirectory.TabIndex = 0;
            // 
            // txtBackupDirectory
            // 
            this.txtBackupDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupDirectory.Location = new System.Drawing.Point(24, 87);
            this.txtBackupDirectory.Name = "txtBackupDirectory";
            this.txtBackupDirectory.Size = new System.Drawing.Size(1596, 48);
            this.txtBackupDirectory.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(24, 150);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(1824, 50);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start backup!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnChooseInput
            // 
            this.btnChooseInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseInput.Location = new System.Drawing.Point(1626, 21);
            this.btnChooseInput.Name = "btnChooseInput";
            this.btnChooseInput.Size = new System.Drawing.Size(222, 50);
            this.btnChooseInput.TabIndex = 3;
            this.btnChooseInput.Text = "input dir...";
            this.btnChooseInput.UseVisualStyleBackColor = true;
            this.btnChooseInput.Click += new System.EventHandler(this.btnChooseInput_Click);
            // 
            // btnChooseBackup
            // 
            this.btnChooseBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseBackup.Location = new System.Drawing.Point(1626, 87);
            this.btnChooseBackup.Name = "btnChooseBackup";
            this.btnChooseBackup.Size = new System.Drawing.Size(222, 50);
            this.btnChooseBackup.TabIndex = 4;
            this.btnChooseBackup.Text = "backup dir...";
            this.btnChooseBackup.UseVisualStyleBackColor = true;
            this.btnChooseBackup.Click += new System.EventHandler(this.btnChooseBackup_Click);
            // 
            // FileWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1870, 226);
            this.Controls.Add(this.btnChooseBackup);
            this.Controls.Add(this.btnChooseInput);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtBackupDirectory);
            this.Controls.Add(this.txtInputDirectory);
            this.Name = "FileWatcher";
            this.Text = "FileWatcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputDirectory;
        private System.Windows.Forms.TextBox txtBackupDirectory;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnChooseInput;
        private System.Windows.Forms.Button btnChooseBackup;
    }
}

