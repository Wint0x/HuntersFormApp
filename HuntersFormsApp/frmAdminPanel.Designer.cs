namespace HuntersFormsApp
{
    partial class frmAdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.doActionBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dltLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(702, 507);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(86, 44);
            this.close_btn.TabIndex = 13;
            this.close_btn.Text = "EXIT";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.welcomeLabel.Location = new System.Drawing.Point(262, 163);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(310, 41);
            this.welcomeLabel.TabIndex = 14;
            this.welcomeLabel.Text = "Admin Control Panel";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doActionBtn
            // 
            this.doActionBtn.BackColor = System.Drawing.Color.Black;
            this.doActionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doActionBtn.FlatAppearance.BorderSize = 0;
            this.doActionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doActionBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doActionBtn.ForeColor = System.Drawing.Color.White;
            this.doActionBtn.Location = new System.Drawing.Point(323, 507);
            this.doActionBtn.Name = "doActionBtn";
            this.doActionBtn.Size = new System.Drawing.Size(169, 44);
            this.doActionBtn.TabIndex = 15;
            this.doActionBtn.Text = "EXECUTE";
            this.doActionBtn.UseVisualStyleBackColor = false;
            this.doActionBtn.Click += new System.EventHandler(this.doActionBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 516);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 27);
            this.textBox1.TabIndex = 16;
            // 
            // dltLabel
            // 
            this.dltLabel.AutoSize = true;
            this.dltLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dltLabel.ForeColor = System.Drawing.Color.Red;
            this.dltLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dltLabel.Location = new System.Drawing.Point(20, 485);
            this.dltLabel.Name = "dltLabel";
            this.dltLabel.Size = new System.Drawing.Size(145, 28);
            this.dltLabel.TabIndex = 17;
            this.dltLabel.Text = "Delete Account";
            this.dltLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dltLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.dltLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.doActionBtn);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button doActionBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label dltLabel;
    }
}