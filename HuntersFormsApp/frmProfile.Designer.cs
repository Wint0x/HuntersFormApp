
namespace HuntersFormsApp
{
    partial class frmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.profName = new System.Windows.Forms.Label();
            this.profAge = new System.Windows.Forms.Label();
            this.profEmail = new System.Windows.Forms.Label();
            this.profGender = new System.Windows.Forms.Label();
            this.profInterests = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.goback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1068, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.White;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.logoutBtn.Location = new System.Drawing.Point(805, 642);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(116, 34);
            this.logoutBtn.TabIndex = 42;
            this.logoutBtn.Text = "LOGOUT";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(929, 642);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 34);
            this.button3.TabIndex = 41;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // profName
            // 
            this.profName.AutoSize = true;
            this.profName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.profName.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.profName.Location = new System.Drawing.Point(248, 123);
            this.profName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.profName.Name = "profName";
            this.profName.Size = new System.Drawing.Size(202, 46);
            this.profName.TabIndex = 43;
            this.profName.Text = "First Name:";
            this.profName.Click += new System.EventHandler(this.profName_Click);
            // 
            // profAge
            // 
            this.profAge.AutoSize = true;
            this.profAge.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.profAge.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.profAge.Location = new System.Drawing.Point(67, 308);
            this.profAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.profAge.Name = "profAge";
            this.profAge.Size = new System.Drawing.Size(92, 46);
            this.profAge.TabIndex = 44;
            this.profAge.Text = "Age:";
            this.profAge.Click += new System.EventHandler(this.profAge_Click);
            // 
            // profEmail
            // 
            this.profEmail.AutoSize = true;
            this.profEmail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.profEmail.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.profEmail.Location = new System.Drawing.Point(67, 369);
            this.profEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.profEmail.Name = "profEmail";
            this.profEmail.Size = new System.Drawing.Size(130, 46);
            this.profEmail.TabIndex = 45;
            this.profEmail.Text = "E-mail:";
            // 
            // profGender
            // 
            this.profGender.AutoSize = true;
            this.profGender.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.profGender.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.profGender.Location = new System.Drawing.Point(248, 201);
            this.profGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.profGender.Name = "profGender";
            this.profGender.Size = new System.Drawing.Size(195, 46);
            this.profGender.TabIndex = 46;
            this.profGender.Text = "Last Name:";
            // 
            // profInterests
            // 
            this.profInterests.AutoSize = true;
            this.profInterests.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.profInterests.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profInterests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.profInterests.Location = new System.Drawing.Point(67, 431);
            this.profInterests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.profInterests.Name = "profInterests";
            this.profInterests.Size = new System.Drawing.Size(167, 46);
            this.profInterests.TabIndex = 47;
            this.profInterests.Text = "Interests:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(67, 123);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // goback
            // 
            this.goback.BackColor = System.Drawing.Color.White;
            this.goback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goback.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.goback.Location = new System.Drawing.Point(67, 500);
            this.goback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(116, 34);
            this.goback.TabIndex = 49;
            this.goback.Text = "BACK";
            this.goback.UseVisualStyleBackColor = false;
            this.goback.Click += new System.EventHandler(this.goback_Click);
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.goback);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.profInterests);
            this.Controls.Add(this.profGender);
            this.Controls.Add(this.profEmail);
            this.Controls.Add(this.profAge);
            this.Controls.Add(this.profName);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 200);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProfile";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label profName;
        private System.Windows.Forms.Label profAge;
        private System.Windows.Forms.Label profEmail;
        private System.Windows.Forms.Label profGender;
        private System.Windows.Forms.Label profInterests;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button goback;
    }
}
