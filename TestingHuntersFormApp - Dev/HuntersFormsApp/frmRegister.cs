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
                Box.ErrorBox($"The following fields were left empty: {LOG}", "Registration Error");
                return;
            }

            //Password does not match check
            string conPass = this.txtConPassword.Text;

            if (conPass != password)
            {
                Box.ErrorBox("Passwords do not match!", "Registration Error");
                return;
            }
            
            //Invalid username Check
            if (!Validator.isUsernameValid(username))
            {
                return;
            }

            //Invalid e-mail Check
            if (!Validator.isEmailValid(mail))
            {
                return;
            }

            //Invalid Password Check
            if(!Validator.isPasswordValid(password))
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
                Box.ErrorBox("This user already exists!", "Registration Failed");
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
            Box.SuccessBox("Account created succesfully! You may now Login!", "Success!");

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

                string source = dialog.FileName.Trim(); //Get the uploaded image source full path
                string saveTo = Path.Combine(RESOURCES_PATH, dialog.SafeFileName.Trim()); //Combine Resources and the filename (Example: example.png, just the file name and extension, without full path) of the uploaded image
                
                //Extension check
                if (Path.GetExtension(source) != ".png" || Path.GetExtension(source) != ".jpg")
                {
                    return;
                }

                File.Copy(source, saveTo, false); //Copy this file

                isImageSelected = true;
                userImage = saveTo; //This path will be stored in the database and the program will fetch it to display it as pfp
                return;
            }
            catch (Exception ex)
            {
                Box.ErrorBox(ex.Message, "Error"); return;
            }
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


    internal static class Validator
    {

        public static bool isUsernameValid(string username)
        {
            //Try converting first letter to int, if it works it means the username is invalid
            try
            {
                int first_letter = int.Parse(username[0].ToString());
            }

            catch(Exception)
            {
                if (username.Length < 4)
                {
                    Box.ErrorBox("Username too short!", "Registration Error");
                    return false;
                }

                return true;
            }

            Box.ErrorBox("Username cannot begin with a number!", "Registration Error");
            return false;
        }

        private static List<string> ValidMailServices = new List<string>() { "gmail.com", "nyc.gr", "hotmail.com", "protonmail.com", "yahoo.com" };
        public static bool isEmailValid(string email)
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
                Box.ErrorBox("Invalid E-Mail!", "Registration Error");
                return false;
            }
            
            //Valid e-mail provider check
            if (ValidMailServices.Any(x => email.EndsWith(x)))
            {
                return true;
            }

            else { Box.ErrorBox("Please use a valid email service provider! (i.e. - @gmail.com)", "Registration Error"); return false; }

            //return true;
        }

        public static bool isPasswordValid(string pw)
        {
            if (pw.Length < 8)
            {
                Box.ErrorBox("Please enter a stronger password! (at least 8 characters)", "Registration Error");
                return false;
            }

            return true;
        }

    }
}
