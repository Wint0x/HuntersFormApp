
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

namespace HuntersFormsApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            //Changes the form window title.
            this.Text= "Home";
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label1.Text += $", {frmLogin.AuthPublicName}!";
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
    }
}
