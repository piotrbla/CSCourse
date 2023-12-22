using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBrowserF4
{
    public partial class DataBrowser : Form
    {
        public DataBrowser()
        {
            InitializeComponent();
        }

        
        private void btnShowData_Click(object sender, EventArgs e)
        {
            ShowsEntities db = new ShowsEntities();
            var query = from s in db.Shows 
                        select s;
            foreach (var item in query)
                txtData.Text += $"Title: {item.Title.Trim()} length: {item.Length}\r\n";
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            ShowsEntities db = new ShowsEntities();
            var query = from u in db.Users
                        select u;
            foreach (var item in query)
                txtData.Text += $"Login: {item.Login.Trim()} \r\n";
        }

        private void btnShowBookmarks_Click(object sender, EventArgs e)
        {
            ShowsEntities db = new ShowsEntities();
            var query = from b in db.UserShows where b.User.Login == "test2"
                        select b;
            foreach (var item in query)
            {
                txtData.Text +=
                    $"User: {item.User.Login.Trim()} " +
                    $"Show: {item.Show.Title.Trim()} " +
                    $"Bookmark: {item.Bookmark}/{item.Show.Length}\r\n";
            }
        }
    }
}
