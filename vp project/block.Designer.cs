namespace vp_project
{
    partial class block
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(block));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dvd_check = new System.Windows.Forms.CheckBox();
            this.usb_check = new System.Windows.Forms.CheckBox();
            this.phone_check = new System.Windows.Forms.CheckBox();
            this.floppy_check = new System.Windows.Forms.CheckBox();
            this.all_checked = new System.Windows.Forms.CheckBox();
            this.reset_checked = new System.Windows.Forms.CheckBox();
            this.save_changes = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::vp_project.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(3, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 410);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "BLOCK DEVICES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select devices to block";
            // 
            // dvd_check
            // 
            this.dvd_check.AutoCheck = false;
            this.dvd_check.Location = new System.Drawing.Point(20, 50);
            this.dvd_check.Name = "dvd_check";
            this.dvd_check.Size = new System.Drawing.Size(91, 17);
            this.dvd_check.TabIndex = 3;
            this.dvd_check.Text = "DVD";
            this.dvd_check.UseVisualStyleBackColor = true;
            this.dvd_check.Click += new System.EventHandler(this.dvd_check_Click);
            // 
            // usb_check
            // 
            this.usb_check.AutoCheck = false;
            this.usb_check.Location = new System.Drawing.Point(20, 83);
            this.usb_check.Name = "usb_check";
            this.usb_check.Size = new System.Drawing.Size(91, 17);
            this.usb_check.TabIndex = 4;
            this.usb_check.Text = "USB";
            this.usb_check.UseVisualStyleBackColor = true;
            this.usb_check.Click += new System.EventHandler(this.usb_check_Click);
            // 
            // phone_check
            // 
            this.phone_check.AutoCheck = false;
            this.phone_check.AutoSize = true;
            this.phone_check.Location = new System.Drawing.Point(20, 115);
            this.phone_check.Name = "phone_check";
            this.phone_check.Size = new System.Drawing.Size(91, 17);
            this.phone_check.TabIndex = 5;
            this.phone_check.Text = "Mobile Phone";
            this.phone_check.UseVisualStyleBackColor = true;
            this.phone_check.Click += new System.EventHandler(this.phone_check_Click);
            // 
            // floppy_check
            // 
            this.floppy_check.AutoCheck = false;
            this.floppy_check.Location = new System.Drawing.Point(20, 148);
            this.floppy_check.Name = "floppy_check";
            this.floppy_check.Size = new System.Drawing.Size(91, 17);
            this.floppy_check.TabIndex = 6;
            this.floppy_check.Text = "Floppy";
            this.floppy_check.UseVisualStyleBackColor = true;
            this.floppy_check.Click += new System.EventHandler(this.floppy_check_Click);
            // 
            // all_checked
            // 
            this.all_checked.AutoCheck = false;
            this.all_checked.Location = new System.Drawing.Point(2, 6);
            this.all_checked.Name = "all_checked";
            this.all_checked.Size = new System.Drawing.Size(91, 17);
            this.all_checked.TabIndex = 7;
            this.all_checked.Text = "Select All";
            this.all_checked.UseVisualStyleBackColor = true;
            this.all_checked.Click += new System.EventHandler(this.all_checked_Click);
            // 
            // reset_checked
            // 
            this.reset_checked.AutoCheck = false;
            this.reset_checked.Location = new System.Drawing.Point(2, 38);
            this.reset_checked.Name = "reset_checked";
            this.reset_checked.Size = new System.Drawing.Size(91, 17);
            this.reset_checked.TabIndex = 8;
            this.reset_checked.Text = "Reset";
            this.reset_checked.UseVisualStyleBackColor = true;
            this.reset_checked.Click += new System.EventHandler(this.reset_checked_Click);
            // 
            // save_changes
            // 
            this.save_changes.Location = new System.Drawing.Point(218, 336);
            this.save_changes.Name = "save_changes";
            this.save_changes.Size = new System.Drawing.Size(102, 30);
            this.save_changes.TabIndex = 9;
            this.save_changes.Text = "Apply changes";
            this.save_changes.UseVisualStyleBackColor = true;
            this.save_changes.Click += new System.EventHandler(this.save_changes_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(19, 27);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 10;
            this.start.Text = "Home";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.floppy_check);
            this.panel1.Controls.Add(this.phone_check);
            this.panel1.Controls.Add(this.usb_check);
            this.panel1.Controls.Add(this.dvd_check);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(198, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 174);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.reset_checked);
            this.panel2.Controls.Add(this.all_checked);
            this.panel2.Location = new System.Drawing.Point(21, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 63);
            this.panel2.TabIndex = 12;
            // 
            // block
            // 
            this.AcceptButton = this.save_changes;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 404);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.save_changes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "block";
            this.Text = "block";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox dvd_check;
        private System.Windows.Forms.CheckBox usb_check;
        private System.Windows.Forms.CheckBox phone_check;
        private System.Windows.Forms.CheckBox floppy_check;
        private System.Windows.Forms.CheckBox all_checked;
        private System.Windows.Forms.CheckBox reset_checked;
        private System.Windows.Forms.Button save_changes;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}