using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Data.Odbc;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver.Linq;
using MongoDB.Driver;
using HuntersFormsApp;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace OriginLauncher
{

    public partial class frmLogin : Form
    {

        static private string connectionString = Environment.GetEnvironmentVariable("MONGO_URI");
        public static string AuthPublicName = "";
        public frmLogin()
        {
            InitializeComponent();

            //Get URI
        }

        //Login button
        private void button1_Click(object sender, EventArgs e)
        {

            //Left fields empty
            string username = (string.IsNullOrEmpty(this.txtUsernamelog.Text) ? null : this.txtUsernamelog.Text);
            string password = (string.IsNullOrEmpty(this.txtPasswordlog.Text) ? null : this.txtPasswordlog.Text);

            //Messagebox in case of null
            if (username == null || password == null)
            {
                ToolTip tEntryBoxEmpty = new ToolTip();
                tEntryBoxEmpty.ToolTipTitle = "Hey there!";
                tEntryBoxEmpty.IsBalloon = true;
                tEntryBoxEmpty.UseFading = true;
                tEntryBoxEmpty.ToolTipIcon = ToolTipIcon.Error;

                if (username == null)
                {
                    tEntryBoxEmpty.Show("Username left empty", txtUsernamelog, 1000);
                }

                if (password == null)
                {
                    tEntryBoxEmpty.Show("Password left empty", txtPasswordlog, 1000);
                }

                return;
            }

            //Connect and create settings for MongoDB...
            var settings = MongoClientSettings.FromConnectionString(connectionString);
            settings.LinqProvider = LinqProvider.V3;

            var client = new MongoClient(settings);

            var database = client.GetDatabase("test");

            //Passes in our credentials to the Mongo collection (Users class is just used as a BSON "mapper")
            IMongoCollection<Users> usersCollection = database.GetCollection<Users>("users");
            IMongoQueryable<Users> results =
                from user in usersCollection.AsQueryable()
                where user.User == username && user.Password == password
                select user;

            //No results, no matching username / password found!
            if (!results.Any())
            {
                Box.ErrorBox(new[] { "Wrong Username or Password", "Login Error" });
                return;
            }

            else
            {
                AuthPublicName = username;
                Home mainPage = new Home();
                mainPage.Show();
                this.Hide();
            }
        }

        //Switch to register form
        private void label4_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        //Show-hide pass
        private void checkboxShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowpass.Checked)
            {
                txtPasswordlog.PasswordChar = '\0';

            }
            else
            {
                txtPasswordlog.PasswordChar = '•';

            }
        }

        //Exit button
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }

    //Collection field from C# class to BSON mapping
    [BsonIgnoreExtraElements]
    internal class Users
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("user")]
        [BsonRequired]
        public string User { get; set; }

        [BsonElement("pass")]
        [BsonRequired]
        public string Password { get; set; }

        [BsonElement("email")]
        [BsonIgnoreIfNull]
        public string Email { get; set; }

        [BsonElement("image")]
        [BsonIgnoreIfDefault]
        public string Image { get; set; }
    }
}


