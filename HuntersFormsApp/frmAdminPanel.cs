﻿using MongoDB.Driver;
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
using HuntersFormsApp;
using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver.Linq;
using HuntersFormsApp.Properties;

namespace HuntersFormsApp
{
    public partial class frmAdminPanel : Form
    {
        static private string connectionString = Environment.GetEnvironmentVariable("MONGO_URI");
        public frmAdminPanel()
        {
            //Only admin can access
            if (frmLogin.AuthPublicName == "admin")
            {

                InitializeComponent();
            }

            else
            {
                DestroyHandle();
                Application.Exit();
            }
        }

        // get db
        public static MongoClientSettings settings = MongoClientSettings.FromConnectionString(connectionString);
        internal static MongoClient client = new MongoClient(settings);

        internal static IMongoDatabase usersDatabase = client.GetDatabase("test");

        // get a collection reference
        internal static IMongoCollection<Users> personsCollection = usersDatabase
            .GetCollection<Users>("users");


        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Do actions
        private void doActionBtn_Click(object sender, EventArgs e)
        {
            string userToDelete = (String.IsNullOrEmpty(this.textBox1.Text) ? null : this.textBox1.Text);

            if (userToDelete == null)
            {
                Box.ErrorBox("Please enter a user first!", "Delete Error");
                return;
            }


            //Can't cancel Admin
            if (userToDelete == "admin")
            {
                Box.ErrorBox("Attempted to delete admin account!", "Critical Error!");
                return;
            }

            // find a person using an equality filter on its id
            var filter = Builders<Users>.Filter.Eq(person => person.User, userToDelete);

            // delete the person
            var personDeleteResult = personsCollection.DeleteOne(filter);

            //Log results
            if (personDeleteResult.DeletedCount == 1)
            {
                Box.SuccessBox($"Succesfully deleted user {userToDelete}!", "Success");
            }

            else
            {
                Box.ErrorBox($"User {userToDelete} was not found!", "Delete Error");
            }

        }

        private void frmAdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //Iterate all users
        static public bool button1_clicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            //boolean to change functionality of the button on each click
            if (!button1_clicked)
            {

                ////Load DB again
                //var settings = MongoClientSettings.FromConnectionString(connectionString);
                //settings.LinqProvider = LinqProvider.V3;

                //var client = new MongoClient(settings);

                //var usersDatabase = client.GetDatabase("test");

                //// get a collection reference
                //var personsCollection = usersDatabase
                //    .GetCollection<Users>("users");

                //Get all users from collection (loaded at start)
                var all_users = personsCollection.AsQueryable().AsEnumerable().Select(x => x.User);

                string print_users = string.Join(", ", all_users);
                this.users_lbl.Text = $"Here is the list of users:\n{print_users}";

                this.button1.Text = "Hide Users";

                button1_clicked = true;
            }

            else
            {
                this.users_lbl.Text = "";
                this.button1.Text = "Show Users";
                button1_clicked = false;
            }


            return;
        }
    }
}
