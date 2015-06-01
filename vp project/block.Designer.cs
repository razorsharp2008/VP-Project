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
            this.Block_device_menu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dvd_check = new System.Windows.Forms.CheckBox();
            this.floppy_check = new System.Windows.Forms.CheckBox();
            this.all_checked = new System.Windows.Forms.CheckBox();
            this.reset_checked = new System.Windows.Forms.CheckBox();
            this.save_changes = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usb_group = new System.Windows.Forms.GroupBox();
            this.write_protect_check = new System.Windows.Forms.RadioButton();
            this.full_block_check = new System.Windows.Forms.RadioButton();
            this.usb_check = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.usb_group.SuspendLayout();
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
            // Block_device_menu
            // 
            this.Block_device_menu.AutoSize = true;
            this.Block_device_menu.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Block_device_menu.Location = new System.Drawing.Point(135, 23);
            this.Block_device_menu.Name = "Block_device_menu";
            this.Block_device_menu.Size = new System.Drawing.Size(275, 45);
            this.Block_device_menu.TabIndex = 1;
            this.Block_device_menu.Text = "BLOCK DEVICES";
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
            // floppy_check
            // 
            this.floppy_check.AutoCheck = false;
            this.floppy_check.Location = new System.Drawing.Point(20, 89);
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
            this.save_changes.Location = new System.Drawing.Point(219, 353);
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
            this.panel1.Controls.Add(this.usb_group);
            this.panel1.Controls.Add(this.floppy_check);
            this.panel1.Controls.Add(this.dvd_check);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(198, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 223);
            this.panel1.TabIndex = 11;
            // 
            // usb_group
            // 
            this.usb_group.Controls.Add(this.write_protect_check);
            this.usb_group.Controls.Add(this.full_block_check);
            this.usb_group.Controls.Add(this.usb_check);
            this.usb_group.Location = new System.Drawing.Point(14, 130);
            this.usb_group.Name = "usb_group";
            this.usb_group.Size = new System.Drawing.Size(168, 65);
            this.usb_group.TabIndex = 9;
            this.usb_group.TabStop = false;
            this.usb_group.Enter += new System.EventHandler(this.usb_group_Enter);
            // 
            // write_protect_check
            // 
            this.write_protect_check.AutoSize = true;
            this.write_protect_check.Location = new System.Drawing.Point(66, 39);
            this.write_protect_check.Name = "write_protect_check";
            this.write_protect_check.Size = new System.Drawing.Size(86, 17);
            this.write_protect_check.TabIndex = 8;
            this.write_protect_check.TabStop = true;
            this.write_protect_check.Text = "Write protect";
            this.write_protect_check.UseVisualStyleBackColor = true;
            this.write_protect_check.Visible = false;
            this.write_protect_check.CheckedChanged += new System.EventHandler(this.write_protect_check_CheckedChanged);
            this.write_protect_check.Click += new System.EventHandler(this.write_protect_check_Click);
            // 
            // full_block_check
            // 
            this.full_block_check.AutoSize = true;
            this.full_block_check.Location = new System.Drawing.Point(66, 16);
            this.full_block_check.Name = "full_block_check";
            this.full_block_check.Size = new System.Drawing.Size(70, 17);
            this.full_block_check.TabIndex = 7;
            this.full_block_check.TabStop = true;
            this.full_block_check.Text = "Full block";
            this.full_block_check.UseVisualStyleBackColor = true;
            this.full_block_check.Visible = false;
            this.full_block_check.Click += new System.EventHandler(this.full_block_check_Click);
            // 
            // usb_check
            // 
            this.usb_check.AutoCheck = false;
            this.usb_check.Location = new System.Drawing.Point(6, 0);
            this.usb_check.Name = "usb_check";
            this.usb_check.Size = new System.Drawing.Size(146, 17);
            this.usb_check.TabIndex = 4;
            this.usb_check.Text = "USB/Portable HDD";
            this.usb_check.UseVisualStyleBackColor = true;
            this.usb_check.Click += new System.EventHandler(this.usb_check_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.reset_checked);
            this.panel2.Controls.Add(this.all_checked);
            this.panel2.Location = new System.Drawing.Point(19, 265);
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
            this.Controls.Add(this.Block_device_menu);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "block";
            this.Text = "Block";
            this.Load += new System.EventHandler(this.block_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.usb_group.ResumeLayout(false);
            this.usb_group.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Block_device_menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox dvd_check;
        private System.Windows.Forms.CheckBox floppy_check;
        private System.Windows.Forms.CheckBox all_checked;
        private System.Windows.Forms.CheckBox reset_checked;
        private System.Windows.Forms.Button save_changes;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton write_protect_check;
        private System.Windows.Forms.RadioButton full_block_check;
        private System.Windows.Forms.CheckBox usb_check;
        private System.Windows.Forms.GroupBox usb_group;
    }
}