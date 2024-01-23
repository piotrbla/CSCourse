using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBrowserF4
{
    public partial class DataBrowser : Form
    {
        ShowsEntities db = new ShowsEntities();
        public DataBrowser()
        {
            InitializeComponent();
        }

        
        private void btnShowData_Click(object sender, EventArgs e)
        {
            var query = from s in db.Shows 
                        select s;
            foreach (var item in query)
                txtData.Text += $"Title: {item.Title.Trim()} length: {item.Length}\r\n";
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            var query = from u in db.Users
                        select u;
            foreach (var item in query)
                txtData.Text += $"Login: {item.Login.Trim()} \r\n";
            //create new user
            var newUser = new User()
            {
                Login = "test2"
            };
            db.Users.Add(newUser);
            db.SaveChanges();
            
            var newShow = new Show()
            {
                Title = "test2",
                Length = 100
            };
            db.Shows.Add(newShow);
            db.SaveChanges();
        }

        private void btnShowBookmarks_Click(object sender, EventArgs e)
        {
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

        private void RefreshData()
        {
            var queryUsers = from u in db.Users select u;
            var queryShows = from s in db.Shows select s;
            var queryBookmarks = from b in db.UserShows select b;
            lstUsers.Items.Clear();
            lstShows.Items.Clear();
            lstBookmarks.Items.Clear();
            foreach (var item in queryUsers)
                lstUsers.Items.Add(item.Login.Trim());
            foreach (var item in queryShows)
                lstShows.Items.Add(item.Title.Trim());
            foreach (var item in queryBookmarks)
                lstBookmarks.Items.Add($"{item.User.Login.Trim()} {item.Show.Title.Trim()} {item.Bookmark}/{item.Show.Length}");
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            txtUserName.Text = txtUserName.Text.Trim();
            if (txtUserName.Text.Length > 0)
            {
                var hasTransaction = db.Database.CurrentTransaction != null;
                var query = from u in db.Users where u.Login == txtUserName.Text select u;
                if (query.Count() == 0)
                {
                    var newUser = new User()
                    {
                        Login = txtUserName.Text
                    };
                    db.Database.BeginTransaction();
                    try
                    {
                        db.Users.Add(newUser);
                        if (newUser.Id == 0)
                            db.Entry(newUser).State = EntityState.Added;
                        else
                            db.Entry(newUser).State = EntityState.Modified;
                        var saveChangesResult = db.SaveChanges();
                        if (saveChangesResult == 0)
                            throw new Exception("User not added");
                        db.Database.CurrentTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        db.Database.CurrentTransaction.Rollback();
                        // Log the exception details
                        txtUserName.Text = ex.Message;
                    }
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("User already exists");
                }
            }
        }

        private void btEditUser_Click(object sender, EventArgs e)
        {
            txtUserName.Text = txtUserName.Text.Trim();
            if (lstUsers.SelectedIndex >= 0 && txtUserName.Text.Length > 0)
            {
                var query = from u in db.Users where u.Login == txtUserName.Text select u;
                if (query.Count() == 0)
                {
                    var user = db.Users.First(u => u.Login == lstUsers.SelectedItem.ToString());
                    user.Login = txtUserName.Text;
                    db.SaveChanges();
                    txtUserName.Text = "";
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("User already exists");
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedIndex >= 0)
            {
                var user = db.Users.First(u => u.Login == lstUsers.SelectedItem.ToString());
                db.Database.BeginTransaction();
                try
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                    db.Database.CurrentTransaction.Commit();
                    RefreshData();
                }
                catch (Exception ex)
                {
                    db.Database.CurrentTransaction.Rollback();
                    // Log the exception details
                    txtUserName.Text = ex.Message;
                }
            }
        }

        private void btnAddShow_Click(object sender, EventArgs e)
        {
            txtTitle.Text = txtTitle.Text.Trim();
            if (txtTitle.Text.Length > 0)
            {
                var hasTransaction = db.Database.CurrentTransaction != null;
                var query = from s in db.Shows where s.Title == txtTitle.Text select s;
                if (query.Count() == 0)
                {
                    var newShow = new Show()
                    {
                        Title = txtTitle.Text,
                        Length = (int)numLength.Value
                    };
                    //db.Database.BeginTransaction();
                    try
                    {
                        db.Shows.Add(newShow);
                        var saveChangesResult = db.SaveChanges();
                        if (saveChangesResult == 0)
                            throw new Exception("Show not added");
                        //db.Database.CurrentTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        //db.Database.CurrentTransaction.Rollback();
                        // Log the exception details
                        txtTitle.Text = ex.Message;
                    }
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Show already exists");
                }
            }
        }

        private void btnEditShow_Click(object sender, EventArgs e)
        {
            txtTitle.Text = txtTitle.Text.Trim();
            if (lstShows.SelectedIndex >= 0 && txtTitle.Text.Length > 0)
            {
                var query = from s in db.Shows where s.Title == txtTitle.Text select s;
                if (query.Count() == 0)
                {
                    var show = db.Shows.First(s => s.Title == lstShows.SelectedItem.ToString());
                    show.Title = txtTitle.Text;
                    show.Length = (int)numLength.Value;
                    db.SaveChanges();
                    txtTitle.Text = "";
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Show already exists");
                }
            }
        }

        private void btnDeleteShow_Click(object sender, EventArgs e)
        {
            if (lstShows.SelectedIndex >= 0)
            {
                var show = db.Shows.First(s => s.Title == lstShows.SelectedItem.ToString());
                db.Database.BeginTransaction();
                try
                {
                    db.Shows.Remove(show);
                    db.SaveChanges();
                    db.Database.CurrentTransaction.Commit();
                    RefreshData();
                }
                catch (Exception ex)
                {
                    db.Database.CurrentTransaction.Rollback();
                    // Log the exception details
                    txtTitle.Text = ex.Message;
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(lstUsers.SelectedIndex >= 0 && lstShows.SelectedIndex >= 0)
            {
                var query = from b in db.UserShows
                            where b.User.Login == lstUsers.SelectedItem.ToString() &&
                            b.Show.Title == lstShows.SelectedItem.ToString()
                            select b;
                if (query.Count() == 0)
                {
                    var newBookmark = new UserShow()
                    {
                        UserId = db.Users.First(u => u.Login == lstUsers.SelectedItem.ToString()).Id,
                        ShowId = db.Shows.First(s => s.Title == lstShows.SelectedItem.ToString()).Id,
                        Bookmark = 0
                    };
                    db.UserShows.Add(newBookmark);
                    db.SaveChanges();
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Connection already exists");
                }
            }
        }

        private void btnDeleteBookmark_Click(object sender, EventArgs e)
        {
            if(lstBookmarks.SelectedIndex >= 0)
            {
                var login = lstBookmarks.SelectedItem.ToString().Split(' ')[0];
                var title = lstBookmarks.SelectedItem.ToString().Split(' ')[1];
                var bookmark = db.UserShows.First(b => b.User.Login == login && b.Show.Title == title);
                db.Database.BeginTransaction();
                try
                {
                    db.UserShows.Remove(bookmark);
                    db.SaveChanges();
                    db.Database.CurrentTransaction.Commit();
                    RefreshData();
                }
                catch (Exception ex)
                {
                    db.Database.CurrentTransaction.Rollback();
                    // Log the exception details
                    txtTitle.Text = ex.Message;
                }
            }
        }
    }
}
