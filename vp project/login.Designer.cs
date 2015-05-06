namespace vp_project
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginID_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.Login_ID = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::vp_project.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 472);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginID_text
            // 
            this.loginID_text.AcceptsReturn = true;
            this.loginID_text.BackColor = System.Drawing.SystemColors.Window;
            this.loginID_text.ImeMode = System.Windows.Forms.ImeMode.On;
            this.loginID_text.Location = new System.Drawing.Point(77, 7);
            this.loginID_text.Name = "loginID_text";
            this.loginID_text.Size = new System.Drawing.Size(128, 20);
            this.loginID_text.TabIndex = 1;
            // 
            // password_text
            // 
            this.password_text.ImeMode = System.Windows.Forms.ImeMode.On;
            this.password_text.Location = new System.Drawing.Point(78, 38);
            this.password_text.Name = "password_text";
            this.password_text.PasswordChar = '*';
            this.password_text.Size = new System.Drawing.Size(127, 20);
            this.password_text.TabIndex = 2;
            // 
            // Login_ID
            // 
            this.Login_ID.AutoSize = true;
            this.Login_ID.Location = new System.Drawing.Point(7, 10);
            this.Login_ID.Name = "Login_ID";
            this.Login_ID.Size = new System.Drawing.Size(47, 13);
            this.Login_ID.TabIndex = 3;
            this.Login_ID.Text = "Login ID";
            this.Login_ID.Click += new System.EventHandler(this.Login_ID_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(7, 38);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(200, 200);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(83, 35);
            this.log.TabIndex = 5;
            this.log.Text = "Login";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.Login_ID);
            this.panel1.Controls.Add(this.password_text);
            this.panel1.Controls.Add(this.loginID_text);
            this.panel1.Location = new System.Drawing.Point(122, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 70);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // login
            // 
            this.AcceptButton = this.log;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 288);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.log);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox loginID_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label Login_ID;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Panel panel1;
    }
}