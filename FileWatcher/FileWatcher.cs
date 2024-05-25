using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace FileWatcher
{
    public partial class FileWatcher : Form
    {
        public FileWatcher()
        {
            InitializeComponent();
        }

        private void btnChooseInput_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = ConfigurationManager.AppSettings.Get("StartPath");
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtInputDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnChooseBackup_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = ConfigurationManager.AppSettings.Get("StartPath");
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtBackupDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            var watcher = new FileSystemWatcher(txtInputDirectory.Text);
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.IncludeSubdirectories = false;
            watcher.EnableRaisingEvents = true;
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            var backupPath = txtBackupDirectory.Text + "\\" + e.Name;
            File.Copy(e.FullPath, backupPath);
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            var fileName = e.Name;
            var fileExtension = Path.GetExtension(fileName);
            var fileNameStart = Path.GetFileNameWithoutExtension(fileName);
            if (fileExtension == ".txt")
            {
                var fullFileName = fileNameStart + "_backup_" +
                    DateTime.Now.ToString("yyyyMMddHHmmss") + fileExtension;
                var backupPath = Path.Combine(txtBackupDirectory.Text, fullFileName);
                if (!File.Exists(backupPath))
                    File.Copy(e.FullPath, backupPath);
            }
        }
    }
}
