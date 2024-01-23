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
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.lstShows = new System.Windows.Forms.ListBox();
            this.lstBookmarks = new System.Windows.Forms.ListBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnDeleteShow = new System.Windows.Forms.Button();
            this.btnEditShow = new System.Windows.Forms.Button();
            this.btnAddShow = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDeleteBookmark = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
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
            this.txtData.Size = new System.Drawing.Size(996, 431);
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
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 20;
            this.lstUsers.Location = new System.Drawing.Point(16, 786);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(309, 144);
            this.lstUsers.TabIndex = 5;
            // 
            // lstShows
            // 
            this.lstShows.FormattingEnabled = true;
            this.lstShows.ItemHeight = 20;
            this.lstShows.Location = new System.Drawing.Point(357, 786);
            this.lstShows.Name = "lstShows";
            this.lstShows.Size = new System.Drawing.Size(309, 144);
            this.lstShows.TabIndex = 6;
            // 
            // lstBookmarks
            // 
            this.lstBookmarks.FormattingEnabled = true;
            this.lstBookmarks.ItemHeight = 20;
            this.lstBookmarks.Location = new System.Drawing.Point(703, 786);
            this.lstBookmarks.Name = "lstBookmarks";
            this.lstBookmarks.Size = new System.Drawing.Size(309, 144);
            this.lstBookmarks.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(16, 562);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(272, 44);
            this.txtUserName.TabIndex = 8;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(357, 562);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(272, 44);
            this.txtTitle.TabIndex = 9;
            // 
            // numLength
            // 
            this.numLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLength.Location = new System.Drawing.Point(357, 653);
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(272, 44);
            this.numLength.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "Length:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 952);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(1000, 129);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(19, 721);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(98, 59);
            this.btnAddUser.TabIndex = 17;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btEditUser
            // 
            this.btEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditUser.Location = new System.Drawing.Point(123, 721);
            this.btEditUser.Name = "btEditUser";
            this.btEditUser.Size = new System.Drawing.Size(98, 59);
            this.btEditUser.TabIndex = 18;
            this.btEditUser.Text = "Edit";
            this.btEditUser.UseVisualStyleBackColor = true;
            this.btEditUser.Click += new System.EventHandler(this.btEditUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(227, 721);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(98, 59);
            this.btnDeleteUser.TabIndex = 19;
            this.btnDeleteUser.Text = "Del";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnDeleteShow
            // 
            this.btnDeleteShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteShow.Location = new System.Drawing.Point(565, 721);
            this.btnDeleteShow.Name = "btnDeleteShow";
            this.btnDeleteShow.Size = new System.Drawing.Size(98, 59);
            this.btnDeleteShow.TabIndex = 22;
            this.btnDeleteShow.Text = "Del";
            this.btnDeleteShow.UseVisualStyleBackColor = true;
            this.btnDeleteShow.Click += new System.EventHandler(this.btnDeleteShow_Click);
            // 
            // btnEditShow
            // 
            this.btnEditShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditShow.Location = new System.Drawing.Point(461, 721);
            this.btnEditShow.Name = "btnEditShow";
            this.btnEditShow.Size = new System.Drawing.Size(98, 59);
            this.btnEditShow.TabIndex = 21;
            this.btnEditShow.Text = "Edit";
            this.btnEditShow.UseVisualStyleBackColor = true;
            this.btnEditShow.Click += new System.EventHandler(this.btnEditShow_Click);
            // 
            // btnAddShow
            // 
            this.btnAddShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShow.Location = new System.Drawing.Point(360, 721);
            this.btnAddShow.Name = "btnAddShow";
            this.btnAddShow.Size = new System.Drawing.Size(98, 59);
            this.btnAddShow.TabIndex = 20;
            this.btnAddShow.Text = "Add";
            this.btnAddShow.UseVisualStyleBackColor = true;
            this.btnAddShow.Click += new System.EventHandler(this.btnAddShow_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(703, 721);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(205, 59);
            this.btnConnect.TabIndex = 23;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDeleteBookmark
            // 
            this.btnDeleteBookmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBookmark.Location = new System.Drawing.Point(914, 721);
            this.btnDeleteBookmark.Name = "btnDeleteBookmark";
            this.btnDeleteBookmark.Size = new System.Drawing.Size(98, 59);
            this.btnDeleteBookmark.TabIndex = 24;
            this.btnDeleteBookmark.Text = "Del";
            this.btnDeleteBookmark.UseVisualStyleBackColor = true;
            this.btnDeleteBookmark.Click += new System.EventHandler(this.btnDeleteBookmark_Click);
            // 
            // DataBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 1096);
            this.Controls.Add(this.btnDeleteBookmark);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnDeleteShow);
            this.Controls.Add(this.btnEditShow);
            this.Controls.Add(this.btnAddShow);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numLength);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lstBookmarks);
            this.Controls.Add(this.lstShows);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.btnShowBookmarks);
            this.Controls.Add(this.btnShowUsers);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblTableName);
            this.Name = "DataBrowser";
            this.Text = "Data browser";
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.Button btnShowBookmarks;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.ListBox lstShows;
        private System.Windows.Forms.ListBox lstBookmarks;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnDeleteShow;
        private System.Windows.Forms.Button btnEditShow;
        private System.Windows.Forms.Button btnAddShow;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDeleteBookmark;
    }
}

