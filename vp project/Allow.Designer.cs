namespace vp_project
{
    partial class Allow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Allow));
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.save_changes = new System.Windows.Forms.Button();
            this.reset_checked = new System.Windows.Forms.CheckBox();
            this.all_checked = new System.Windows.Forms.CheckBox();
            this.floppy_check = new System.Windows.Forms.CheckBox();
            this.usb_check = new System.Windows.Forms.CheckBox();
            this.dvd_check = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Allow_panel = new System.Windows.Forms.Panel();
            this.allow_group = new System.Windows.Forms.GroupBox();
            this.Disable_write_protect = new System.Windows.Forms.RadioButton();
            this.Allow_access = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Allow_panel.SuspendLayout();
            this.allow_group.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-104, -42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.Location = new System.Drawing.Point(-100, 253);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(91, 17);
            this.checkBox6.TabIndex = 19;
            this.checkBox6.Text = "Reset";
            this.checkBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Location = new System.Drawing.Point(-100, 221);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(91, 17);
            this.checkBox5.TabIndex = 18;
            this.checkBox5.Text = "Select All";
            this.checkBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, -46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "BLOCK DEVICES";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(8, 32);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(110, 26);
            this.start.TabIndex = 32;
            this.start.Text = "Home";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // save_changes
            // 
            this.save_changes.Location = new System.Drawing.Point(215, 358);
            this.save_changes.Name = "save_changes";
            this.save_changes.Size = new System.Drawing.Size(137, 26);
            this.save_changes.TabIndex = 31;
            this.save_changes.Text = "Apply changes";
            this.save_changes.UseVisualStyleBackColor = true;
            this.save_changes.Click += new System.EventHandler(this.save_changes_Click);
            // 
            // reset_checked
            // 
            this.reset_checked.AutoCheck = false;
            this.reset_checked.Location = new System.Drawing.Point(7, 37);
            this.reset_checked.Name = "reset_checked";
            this.reset_checked.Size = new System.Drawing.Size(91, 17);
            this.reset_checked.TabIndex = 30;
            this.reset_checked.Text = "Reset";
            this.reset_checked.UseVisualStyleBackColor = true;
            this.reset_checked.Click += new System.EventHandler(this.reset_checked_Click);
            // 
            // all_checked
            // 
            this.all_checked.AutoCheck = false;
            this.all_checked.Location = new System.Drawing.Point(7, 5);
            this.all_checked.Name = "all_checked";
            this.all_checked.Size = new System.Drawing.Size(91, 17);
            this.all_checked.TabIndex = 29;
            this.all_checked.Text = "Select All";
            this.all_checked.UseVisualStyleBackColor = true;
            this.all_checked.Click += new System.EventHandler(this.all_checked_Click);
            // 
            // floppy_check
            // 
            this.floppy_check.AutoCheck = false;
            this.floppy_check.Location = new System.Drawing.Point(18, 88);
            this.floppy_check.Name = "floppy_check";
            this.floppy_check.Size = new System.Drawing.Size(91, 17);
            this.floppy_check.TabIndex = 28;
            this.floppy_check.Text = "Floppy";
            this.floppy_check.UseVisualStyleBackColor = true;
            this.floppy_check.Click += new System.EventHandler(this.floppy_check_Click);
            // 
            // usb_check
            // 
            this.usb_check.AutoCheck = false;
            this.usb_check.Location = new System.Drawing.Point(11, 6);
            this.usb_check.Name = "usb_check";
            this.usb_check.Size = new System.Drawing.Size(145, 17);
            this.usb_check.TabIndex = 26;
            this.usb_check.Text = "USB/Portable HDD";
            this.usb_check.UseVisualStyleBackColor = true;
            this.usb_check.CheckedChanged += new System.EventHandler(this.usb_check_CheckedChanged);
            this.usb_check.Click += new System.EventHandler(this.usb_check_Click);
            // 
            // dvd_check
            // 
            this.dvd_check.AutoCheck = false;
            this.dvd_check.Location = new System.Drawing.Point(18, 47);
            this.dvd_check.Name = "dvd_check";
            this.dvd_check.Size = new System.Drawing.Size(91, 17);
            this.dvd_check.TabIndex = 25;
            this.dvd_check.Text = "DVD";
            this.dvd_check.UseVisualStyleBackColor = true;
            this.dvd_check.Click += new System.EventHandler(this.dvd_check_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Select devices to allow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 45);
            this.label3.TabIndex = 23;
            this.label3.Text = "ALLOW DEVICES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::vp_project.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 405);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Allow_panel
            // 
            this.Allow_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Allow_panel.Controls.Add(this.allow_group);
            this.Allow_panel.Controls.Add(this.floppy_check);
            this.Allow_panel.Controls.Add(this.dvd_check);
            this.Allow_panel.Controls.Add(this.label2);
            this.Allow_panel.Location = new System.Drawing.Point(196, 108);
            this.Allow_panel.Name = "Allow_panel";
            this.Allow_panel.Size = new System.Drawing.Size(192, 222);
            this.Allow_panel.TabIndex = 33;
            // 
            // allow_group
            // 
            this.allow_group.Controls.Add(this.Disable_write_protect);
            this.allow_group.Controls.Add(this.Allow_access);
            this.allow_group.Controls.Add(this.usb_check);
            this.allow_group.Location = new System.Drawing.Point(7, 126);
            this.allow_group.Name = "allow_group";
            this.allow_group.Size = new System.Drawing.Size(180, 70);
            this.allow_group.TabIndex = 31;
            this.allow_group.TabStop = false;
            // 
            // Disable_write_protect
            // 
            this.Disable_write_protect.AutoSize = true;
            this.Disable_write_protect.Location = new System.Drawing.Point(63, 43);
            this.Disable_write_protect.Name = "Disable_write_protect";
            this.Disable_write_protect.Size = new System.Drawing.Size(104, 17);
            this.Disable_write_protect.TabIndex = 30;
            this.Disable_write_protect.TabStop = true;
            this.Disable_write_protect.Text = "No Write Protect";
            this.Disable_write_protect.UseVisualStyleBackColor = true;
            this.Disable_write_protect.Visible = false;
            this.Disable_write_protect.CheckedChanged += new System.EventHandler(this.Disable_write_protect_CheckedChanged);
            this.Disable_write_protect.Click += new System.EventHandler(this.Disable_write_protect_Click);
            // 
            // Allow_access
            // 
            this.Allow_access.AutoSize = true;
            this.Allow_access.Location = new System.Drawing.Point(63, 20);
            this.Allow_access.Name = "Allow_access";
            this.Allow_access.Size = new System.Drawing.Size(79, 17);
            this.Allow_access.TabIndex = 29;
            this.Allow_access.TabStop = true;
            this.Allow_access.Text = "Full Access";
            this.Allow_access.UseVisualStyleBackColor = true;
            this.Allow_access.Visible = false;
            this.Allow_access.Click += new System.EventHandler(this.Allow_access_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.reset_checked);
            this.panel2.Controls.Add(this.all_checked);
            this.panel2.Location = new System.Drawing.Point(8, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 64);
            this.panel2.TabIndex = 34;
            // 
            // Allow
            // 
            this.AcceptButton = this.save_changes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 396);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Allow_panel);
            this.Controls.Add(this.start);
            this.Controls.Add(this.save_changes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Allow";
            this.Text = "Allow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Allow_panel.ResumeLayout(false);
            this.Allow_panel.PerformLayout();
            this.allow_group.ResumeLayout(false);
            this.allow_group.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button save_changes;
        private System.Windows.Forms.CheckBox reset_checked;
        private System.Windows.Forms.CheckBox all_checked;
        private System.Windows.Forms.CheckBox floppy_check;
        private System.Windows.Forms.CheckBox usb_check;
        private System.Windows.Forms.CheckBox dvd_check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Allow_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox allow_group;
        private System.Windows.Forms.RadioButton Disable_write_protect;
        private System.Windows.Forms.RadioButton Allow_access;
    }
}