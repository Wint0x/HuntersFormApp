
using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver.Linq;
using MongoDB.Driver;
using OriginLauncher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HuntersFormsApp
{
    public partial class Home : Form
    {
        private IMongoCollection<Users> _usersCollection;
        public Home()
        {
            InitializeComponent();

            //Changes the form window title.
            this.Text= "Home";
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (frmLogin.AuthPublicName != "admin")
            {
                //Connect and create settings for MongoDB...
                string connectionString = Environment.GetEnvironmentVariable("MONGO_URI");
                var settings = MongoClientSettings.FromConnectionString(connectionString);
                settings.LinqProvider = LinqProvider.V3;

                var client = new MongoClient(settings);

                var database = client.GetDatabase("test");

                //Passes in our credentials to the Mongo collection (Users class is just used as a BSON "mapper")
                _usersCollection = database.GetCollection<Users>("users");


                label1.Text += $", {frmLogin.AuthPublicName}!";
                var loggedInUser = new Users();

                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(100, 100);

                int index = 0;
                foreach (var user in _usersCollection.AsQueryable())
                {
                    if (user.User == frmLogin.AuthPublicName)
                    {
                        loggedInUser = user;
                        continue;
                    }

                    ListViewItem item = new ListViewItem();
                    item.Text = user.FirstName + " " + user.LastName;

                    if (user.Image != null)
                    {
                        imageList.Images.Add(user.User, Image.FromFile(user.Image));
                        item.ImageKey = user.User;
                    }
                    item.ImageIndex = index;
                    listView1.Items.Add(item);
                    index++;
                }

                listView1.LargeImageList = imageList;
                label2.Text = loggedInUser.FirstName + " " + loggedInUser.LastName;
                pictureBox2.Image = new Bitmap(loggedInUser.Image);
            }
            //Allow access to admin control panel
            if (frmLogin.AuthPublicName == "admin")
            {
                this.cPanelBtn.Visible = true;
            }

        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Open admin panel form
        private void cPanelBtn_Click(object sender, EventArgs e)
        {
            frmAdminPanel adminP = new frmAdminPanel();
            adminP.Show();
            this.Hide();
        }

        //Close (EXIT button)
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Logout
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            frmLogin.AuthPublicName = "";
            frmLogin backToLogin = new frmLogin();
            this.Hide();
            backToLogin.Show();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            //if (frmLogin.AuthPublicName == "admin")
            //{
            //    return; //Disallow profile information for admin because of missing BSON elements in its document
            //}
            //new frmProfile().Show();
            //this.Hide();
        }

       
        private void label2_Click(object sender, EventArgs e)
        {
            if (frmLogin.AuthPublicName == "admin")
            {
                return; //Disallow profile information for admin because of missing BSON elements in its document
            }
            new frmProfile().Show();
            this.Hide();
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedUser = _usersCollection.AsQueryable().Where(x => x.FirstName + " " + x.LastName == listView1.SelectedItems[0].Text);
            new frmProfile(selectedUser.FirstOrDefault()).Show();
            this.Hide();
        }
    }
}
