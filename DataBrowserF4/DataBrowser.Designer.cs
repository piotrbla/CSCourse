namespace DataBrowserF4
{
    partial class DataBrowser
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
            this.lblTableName = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.btnShowBookmarks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(12, 52);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(48, 20);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(16, 75);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(896, 431);
            this.txtData.TabIndex = 1;
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(16, 12);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(218, 37);
            this.btnShowData.TabIndex = 2;
            this.btnShowData.Text = "Show data: shows";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.Location = new System.Drawing.Point(240, 12);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(218, 37);
            this.btnShowUsers.TabIndex = 3;
            this.btnShowUsers.Text = "Show data: users";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            // 
            // btnShowBookmarks
            // 
            this.btnShowBookmarks.Location = new System.Drawing.Point(464, 12);
            this.btnShowBookmarks.Name = "btnShowBookmarks";
            this.btnShowBookmarks.Size = new System.Drawing.Size(218, 37);
            this.btnShowBookmarks.TabIndex = 4;
            this.btnShowBookmarks.Text = "Show data: bookmarks";
            this.btnShowBookmarks.UseVisualStyleBackColor = true;
            this.btnShowBookmarks.Click += new System.EventHandler(this.btnShowBookmarks_Click);
            // 
            // DataBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 518);
            this.Controls.Add(this.btnShowBookmarks);
            this.Controls.Add(this.btnShowUsers);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblTableName);
            this.Name = "DataBrowser";
            this.Text = "Data browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.Button btnShowBookmarks;
    }
}

