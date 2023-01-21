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
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver.Linq;
using MongoDB.Driver;
using System.Drawing.Text;
using System.Collections;
using HuntersFormsApp;
using System.IO;
using System.Xml.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace OriginLauncher
{
    public partial class frmRegister : Form
    {
        private static string connectionString = Environment.GetEnvironmentVariable("MONGO_URI");
        
        private static bool isImageSelected = false;
        private static string userImage = "";

        //For profile pictures...
        public static string RESOURCES_PATH = Path.GetDirectoryName(Environment.CurrentDirectory).Replace("bin", "Resources"); //Get the directory of Resources
        public static string DEFAULT_PFP = RESOURCES_PATH + "\\default_user.png";
        public frmRegister()
        {
            InitializeComponent();
            
        }

        //On_register press
        private void button1_Click(object sender, EventArgs e)
        {
            /*necessary fields check */
            string username = (String.IsNullOrEmpty(this.txtUsername.Text) ? null : this.txtUsername.Text);
            string password = (String.IsNullOrEmpty(this.txtPassword.Text) ? null : this.txtPassword.Text);
            string fname = (String.IsNullOrEmpty(this.txtFirstname.Text) ? null : this.txtFirstname.Text);
            string lname = (String.IsNullOrEmpty(this.txtLastname.Text) ? null : this.txtLastname.Text);
            string mail = (String.IsNullOrEmpty(this.txtEmail.Text) ? null : this.txtEmail.Text);
            string imagePath = (isImageSelected ? userImage : DEFAULT_PFP);

            string interests = (String.IsNullOrEmpty(this.txtInterests.Text) ? "None" : this.txtInterests.Text);

            int ageNum = 0;
            string age = null;

            //Age check and correction
            try
            {
                ageNum = int.Parse(this.txtAge.Text.ToString());
                if (ageNum < 15 || ageNum > 100)
                {
                    age = "Not specified";
                }

                else
                {
                    age = ageNum.ToString();
                }
            }
            
            catch (Exception)
            {
                age = "Not specified";
            }

            //Empty fields check (appends the missing field into a list to be joined in the messagebox)
            List<string> forLog = new List<string>() { };
            if (username == null)
            {
                forLog.Add("Username");
            }
            if (password == null)
            {
                forLog.Add("Password");
            }
            if (fname == null)
            {
                forLog.Add("First Name");
            }
            if (lname == null)
            {
                forLog.Add("Last Name");
            }
            if (mail == null)
            {
                forLog.Add("E-mail");
            }

            //Means list contains missing fields
            if (forLog.Count() > 0)
            {
                //Join missing fields and messagebox the user!
                string LOG = String.Join(", ", forLog);
                this.errorLbl.Text = $"Missing fields: {LOG}";
                return;
            }

            //Password does not match check
            string conPass = this.txtConPassword.Text;

            if (conPass != password)
            {
                this.errorLbl.Text = "Passwords do not match!";
                return;
            }
            
            //Invalid username Check
            if (!isUsernameValid(username))
            {
                return;
            }

            //Invalid e-mail Check
            if (!isEmailValid(mail))
            {
                return;
            }

            //Invalid Password Check
            if(!isPasswordValid(password))
            {
                return;
            }

            //Database
            var settings = MongoClientSettings.FromConnectionString(connectionString);
            settings.LinqProvider = LinqProvider.V3;

            var client = new MongoClient(settings);

            var database = client.GetDatabase("test");

            var personsBsonCollection = database.GetCollection<BsonDocument>("users");

            //Do query to see if email and username already exists...
            IMongoCollection<Users> usersCollection = database.GetCollection<Users>("users");
            IMongoQueryable<Users> results =
                from user in usersCollection.AsQueryable()
                where user.User == username || user.Email == mail
                select user;

            //If results, accout creation attempt is a duplicate
            if (results.Any())
            {
                this.errorLbl.Text = "This user already exists!";
                return;
            }

            var bsonPerson = new BsonDocument
            {
                { "user", username},
                {"pass", password },
                { "fname", fname},
                { "lname", lname},
                {"interests", interests },
                { "email", mail},
                { "age", age},
                { "image", imagePath}
             };

            //Add bsondocument
            personsBsonCollection.InsertOne(bsonPerson);
            this.errorLbl.ForeColor = Color.LightGreen;
            this.errorLbl.Text = "Account succesfully registered, you may now login!";

            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        //Show hide password
        private void checkboxShowpass_CheckedChanged(object sender, EventArgs e)
        {

            if (checkboxShowpass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';

            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtConPassword.PasswordChar = '•';

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConPassword.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtInterests.Text = "";
            txtEmail.Text = "";
            txtAge.Text = "";
            this.errorLbl.Text = "";
            this.selectedImageShowLbl.Text = "Selected: ";

            //Reset selected image if it was selected by resetting 
            //isImageSelected to false
            isImageSelected = false;

            txtUsername.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //The following method is used to select an image from the computer
        //to set as profile picture.
        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Tutorial from https://www.youtube.com/watch?v=sGP6u68k2hc&t=173s
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPEG files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                
                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                this.selectedImageShowLbl.Text = $"Selected: {dialog.SafeFileName}";
                string source = dialog.FileName.Trim(); //Get the uploaded image source full path
                string saveTo = Path.Combine(RESOURCES_PATH, dialog.SafeFileName.Trim()); //Combine Resources and the filename (Example: example.png, just the file name and extension, without full path) of the uploaded image
                
                //Extension check
                if (!(Path.GetExtension(source) == ".png" || Path.GetExtension(source) == ".jpg"))
                {
                    this.errorLbl.Text = "The selected image is not valid!";
                    return;
                }

                File.Copy(source, saveTo, false); //Copy this file

                isImageSelected = true;
                userImage = saveTo; //This path will be stored in the database and the program will fetch it to display it as pfp
                return;
            }
            catch (Exception ex)
            {
                this.errorLbl.Text = ex.Message; 
                return;
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        //Ex-Validator class, registration fields check
        public bool isUsernameValid(string username)
        {
            //Try converting first letter to int, if it works it means the username is invalid
            try
            {
                int first_letter = int.Parse(username[0].ToString());
            }

            catch (Exception)
            {
                if (username.Length < 4)
                {
                    this.errorLbl.Text = "Error: Username too short!";
                    return false;
                }

                return true;
            }

            this.errorLbl.Text = "Username cannot begin with a number!";
            return false;
        }

        private static List<string> ValidMailServices = new List<string>() { "gmail.com", "nyc.gr", "hotmail.com", "protonmail.com", "yahoo.com" };

        public bool isEmailValid(string email)
        {
            //e-mail doesn't contain @ symbol
            try
            {
                var split_mail = email.Split('@');

                //Check length of email before @ symbol:
                if (split_mail[0].ToString().Length < 4)
                {
                    throw new Exception("Invalid e-mail");
                }
            }

            catch (Exception)
            {
                this.errorLbl.Text = "Error: Invalid E-mail!";
                return false;
            }

            //Valid e-mail provider check
            if (ValidMailServices.Any(x => email.EndsWith(x)))
            {
                return true;
            }

            else { this.errorLbl.Text = "Not a valid E-mail provider!"; return false; }

            //return true;
        }

        public bool isPasswordValid(string pw)
        {
            if (pw.Length < 8)
            {
                this.errorLbl.Text = "Error: Password too weak!"; ;
                return false;
            }

            return true;
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
        [BsonRequired]
        public string Password { get; set; }

        [BsonElement("fname")]
        [BsonRequired]
        public string FirstName { get; set; }

        [BsonElement("lname")]
        [BsonRequired]
        public string LastName { get; set; }

        [BsonElement("interests")]
        [BsonIgnoreIfNull]
        public string Interests { get; set; }

        [BsonElement("email")]
        [BsonRequired]
        public string Email { get; set; }

        [BsonElement("age")]
        [BsonIgnoreIfNull]
        public string Age { get; set; }

        [BsonElement("image")]
        [BsonIgnoreIfDefault]
        public string Image { get; set; }

    }

}
