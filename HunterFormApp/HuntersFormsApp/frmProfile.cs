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
using OriginLauncher;

namespace HuntersFormsApp
{


    public partial class frmProfile : Form
    {
        static private string connectionString = Environment.GetEnvironmentVariable("MONGO_URI");

        public frmProfile()
        {
            InitializeComponent();
            this.Text = "Profile";
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            frmLogin.AuthPublicName = "";
            frmLogin backToLogin = new frmLogin();
            this.Hide();
            backToLogin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static MongoClientSettings settings = MongoClientSettings.FromConnectionString(connectionString);
        internal static MongoClient client = new MongoClient(settings);

        internal static IMongoDatabase usersDatabase = client.GetDatabase("test");

        // get a collection reference
        internal static IMongoCollection<UsersRegister> personsCollection = usersDatabase.GetCollection<UsersRegister>("users");
        private void frmProfile_Load(object sender, EventArgs e)
        {
            

            //var filter = Builders<UsersRegister>.Filter.Eq(person => person.User, frmLogin.AuthPublicName);
            var interests = personsCollection.AsQueryable().AsEnumerable().Where(x => x.User.Equals(frmLogin.AuthPublicName)).Select(x => x.Interests).First().ToString();
            var age = personsCollection.AsQueryable().AsEnumerable().Where(x => x.User.Equals(frmLogin.AuthPublicName)).Select(x => x.Age).First().ToString();
            var fname = personsCollection.AsQueryable().AsEnumerable().Where(x => x.User.Equals(frmLogin.AuthPublicName)).Select(x => x.FirstName).First().ToString();
            var email = personsCollection.AsQueryable().AsEnumerable().Where(x => x.User.Equals(frmLogin.AuthPublicName)).Select(x => x.Email).First().ToString();
            var lname = personsCollection.AsQueryable().AsEnumerable().Where(x => x.User.Equals(frmLogin.AuthPublicName)).Select(x => x.LastName).First().ToString();
            var image = personsCollection.AsQueryable().AsEnumerable().Where(x => x.User.Equals(frmLogin.AuthPublicName)).Select(x => x.Image).First().ToString();


            profInterests.Text += $" {interests}";
            profAge.Text += $" {age}";
            profEmail.Text += $" {email}";
            profName.Text += $" {fname}";
            profGender.Text += $" {lname}";
            pictureBox2.ImageLocation = image;
        }

        private void profName_Click(object sender, EventArgs e)
        {

        }

        private void profAge_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
    //Collection field from C# class to BSON mapping, for post only action (do registration)
    [BsonIgnoreExtraElements]
    internal class UsersRegister
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("user")]
        [BsonRequired]
        public string User { get; set; }

        [BsonElement("pass")]
        [BsonIgnoreIfDefault]
        public string Password { get; set; }

        [BsonElement("fname")]
        [BsonIgnoreIfDefault]
        public string FirstName { get; set; }

        [BsonElement("lname")]
        [BsonIgnoreIfDefault]
        public string LastName { get; set; }

        [BsonElement("interests")]
        [BsonIgnoreIfDefault]
        public string Interests { get; set; }

        [BsonElement("email")]
        [BsonIgnoreIfDefault]
        public string Email { get; set; }

        [BsonElement("age")]
        [BsonIgnoreIfDefault]
        public string Age { get; set; }

        [BsonElement("image")]
        [BsonIgnoreIfDefault]
        public string Image { get; set; }

    }
}
