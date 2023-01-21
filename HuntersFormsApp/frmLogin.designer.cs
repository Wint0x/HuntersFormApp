namespace OriginLauncher
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsernamelog = new System.Windows.Forms.TextBox();
            this.txtPasswordlog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkboxShowpass = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txtUsernamelog
            // 
            this.txtUsernamelog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsernamelog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsernamelog.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernamelog.Location = new System.Drawing.Point(37, 195);
            this.txtUsernamelog.Name = "txtUsernamelog";
            this.txtUsernamelog.Size = new System.Drawing.Size(216, 31);
            this.txtUsernamelog.TabIndex = 1;
            // 
            // txtPasswordlog
            // 
            this.txtPasswordlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPasswordlog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordlog.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordlog.Location = new System.Drawing.Point(37, 252);
            this.txtPasswordlog.Name = "txtPasswordlog";
            this.txtPasswordlog.PasswordChar = '•';
            this.txtPasswordlog.Size = new System.Drawing.Size(216, 31);
            this.txtPasswordlog.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // checkboxShowpass
            // 
            this.checkboxShowpass.AutoSize = true;
            this.checkboxShowpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxShowpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkboxShowpass.Location = new System.Drawing.Point(37, 289);
            this.checkboxShowpass.Name = "checkboxShowpass";
            this.checkboxShowpass.Size = new System.Drawing.Size(151, 27);
            this.checkboxShowpass.TabIndex = 5;
            this.checkboxShowpass.Text = "Show Password";
            this.checkboxShowpass.UseVisualStyleBackColor = true;
            this.checkboxShowpass.CheckedChanged += new System.EventHandler(this.checkboxShowpass_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(35, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button2.Location = new System.Drawing.Point(147, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Don\'t Have an Account?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label4.Location = new System.Drawing.Point(93, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Create Account";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(213, 531);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 24);
            this.button3.TabIndex = 10;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-18, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;

            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 567);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkboxShowpass);
            this.Controls.Add(this.txtPasswordlog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsernamelog);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswordlog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkboxShowpass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtUsernamelog;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

