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

namespace OriginLauncher.Resources
{
    public partial class frmadmintable : Form
    {
        public frmadmintable()
        {
            InitializeComponent();

        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void frmadmintable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_usersDataSet4.tbl_users' table. You can move, or remove it, as needed.
            this.tbl_usersTableAdapter.Fill(this.db_usersDataSet4.tbl_users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand CMD = con.CreateCommand();
            cmd.CommandType= CommandType.Text;
            cmd.CommandText = "insert into tbl_users values('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data inserted succesfully"); 
        }
    }
}
