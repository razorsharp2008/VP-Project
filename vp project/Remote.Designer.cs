namespace vp_project
{
    partial class Remote
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
            this.ip_label = new System.Windows.Forms.Label();
            this.textRemoteIp = new System.Windows.Forms.TextBox();
            this.connection = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.rem_block_usb = new System.Windows.Forms.Button();
            this.rem_block_dvd = new System.Windows.Forms.Button();
            this.rem_block_floppy = new System.Windows.Forms.Button();
            this.rem_allow_usb = new System.Windows.Forms.Button();
            this.rem_allow_dvd = new System.Windows.Forms.Button();
            this.rem_allow_floppy = new System.Windows.Forms.Button();
            this.block_container = new System.Windows.Forms.GroupBox();
            this.allow_container = new System.Windows.Forms.GroupBox();
            this.disconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.block_container.SuspendLayout();
            this.allow_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // ip_label
            // 
            this.ip_label.AutoSize = true;
            this.ip_label.Location = new System.Drawing.Point(100, 109);
            this.ip_label.Name = "ip_label";
            this.ip_label.Size = new System.Drawing.Size(139, 13);
            this.ip_label.TabIndex = 15;
            this.ip_label.Text = "Enter IP of remote computer";
            // 
            // textRemoteIp
            // 
            this.textRemoteIp.Location = new System.Drawing.Point(245, 109);
            this.textRemoteIp.Name = "textRemoteIp";
            this.textRemoteIp.Size = new System.Drawing.Size(164, 20);
            this.textRemoteIp.TabIndex = 11;
            // 
            // connection
            // 
            this.connection.Location = new System.Drawing.Point(257, 186);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(135, 36);
            this.connection.TabIndex = 17;
            this.connection.Text = "Connect";
            this.connection.UseVisualStyleBackColor = true;
            this.connection.Click += new System.EventHandler(this.connection_Click_1);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(255, 384);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(137, 29);
            this.previous.TabIndex = 18;
            this.previous.Text = "Back";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // rem_block_usb
            // 
            this.rem_block_usb.Location = new System.Drawing.Point(4, 56);
            this.rem_block_usb.Name = "rem_block_usb";
            this.rem_block_usb.Size = new System.Drawing.Size(118, 35);
            this.rem_block_usb.TabIndex = 19;
            this.rem_block_usb.Text = "Block USB";
            this.rem_block_usb.UseVisualStyleBackColor = true;
            this.rem_block_usb.Click += new System.EventHandler(this.rem_block_usb_Click);
            // 
            // rem_block_dvd
            // 
            this.rem_block_dvd.Location = new System.Drawing.Point(4, 129);
            this.rem_block_dvd.Name = "rem_block_dvd";
            this.rem_block_dvd.Size = new System.Drawing.Size(118, 35);
            this.rem_block_dvd.TabIndex = 20;
            this.rem_block_dvd.Text = "Block DVD";
            this.rem_block_dvd.UseVisualStyleBackColor = true;
            this.rem_block_dvd.Click += new System.EventHandler(this.rem_block_dvd_Click);
            // 
            // rem_block_floppy
            // 
            this.rem_block_floppy.Location = new System.Drawing.Point(4, 208);
            this.rem_block_floppy.Name = "rem_block_floppy";
            this.rem_block_floppy.Size = new System.Drawing.Size(118, 35);
            this.rem_block_floppy.TabIndex = 21;
            this.rem_block_floppy.Text = "Block Floppy";
            this.rem_block_floppy.UseVisualStyleBackColor = true;
            this.rem_block_floppy.Click += new System.EventHandler(this.rem_block_floppy_Click);
            // 
            // rem_allow_usb
            // 
            this.rem_allow_usb.Location = new System.Drawing.Point(9, 51);
            this.rem_allow_usb.Name = "rem_allow_usb";
            this.rem_allow_usb.Size = new System.Drawing.Size(118, 35);
            this.rem_allow_usb.TabIndex = 22;
            this.rem_allow_usb.Text = "Allow USB";
            this.rem_allow_usb.UseVisualStyleBackColor = true;
            this.rem_allow_usb.Click += new System.EventHandler(this.rem_allow_usb_Click);
            // 
            // rem_allow_dvd
            // 
            this.rem_allow_dvd.Location = new System.Drawing.Point(9, 124);
            this.rem_allow_dvd.Name = "rem_allow_dvd";
            this.rem_allow_dvd.Size = new System.Drawing.Size(118, 35);
            this.rem_allow_dvd.TabIndex = 23;
            this.rem_allow_dvd.Text = "Allow DVD";
            this.rem_allow_dvd.UseVisualStyleBackColor = true;
            this.rem_allow_dvd.Click += new System.EventHandler(this.rem_allow_dvd_Click);
            // 
            // rem_allow_floppy
            // 
            this.rem_allow_floppy.Location = new System.Drawing.Point(9, 203);
            this.rem_allow_floppy.Name = "rem_allow_floppy";
            this.rem_allow_floppy.Size = new System.Drawing.Size(118, 35);
            this.rem_allow_floppy.TabIndex = 24;
            this.rem_allow_floppy.Text = "Allow Floppy";
            this.rem_allow_floppy.UseVisualStyleBackColor = true;
            this.rem_allow_floppy.Click += new System.EventHandler(this.rem_allow_floppy_Click);
            // 
            // block_container
            // 
            this.block_container.Controls.Add(this.rem_block_floppy);
            this.block_container.Controls.Add(this.rem_block_dvd);
            this.block_container.Controls.Add(this.rem_block_usb);
            this.block_container.Location = new System.Drawing.Point(76, 99);
            this.block_container.Name = "block_container";
            this.block_container.Size = new System.Drawing.Size(139, 254);
            this.block_container.TabIndex = 25;
            this.block_container.TabStop = false;
            this.block_container.Text = "Block devices";
            this.block_container.Visible = false;
            // 
            // allow_container
            // 
            this.allow_container.Controls.Add(this.rem_allow_floppy);
            this.allow_container.Controls.Add(this.rem_allow_dvd);
            this.allow_container.Controls.Add(this.rem_allow_usb);
            this.allow_container.Location = new System.Drawing.Point(437, 99);
            this.allow_container.Name = "allow_container";
            this.allow_container.Size = new System.Drawing.Size(147, 254);
            this.allow_container.TabIndex = 26;
            this.allow_container.TabStop = false;
            this.allow_container.Text = "Allow devices";
            this.allow_container.Visible = false;
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(261, 157);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(130, 29);
            this.disconnect.TabIndex = 27;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Visible = false;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 42);
            this.label1.TabIndex = 28;
            this.label1.Text = "Remote Control Mechanism";
            // 
            // Remote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.allow_container);
            this.Controls.Add(this.block_container);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.connection);
            this.Controls.Add(this.ip_label);
            this.Controls.Add(this.textRemoteIp);
            this.Name = "Remote";
            this.Text = "Remote";
            this.Load += new System.EventHandler(this.Remote_Load);
            this.block_container.ResumeLayout(false);
            this.allow_container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ip_label;
        private System.Windows.Forms.TextBox textRemoteIp;
        private System.Windows.Forms.Button connection;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button rem_block_usb;
        private System.Windows.Forms.Button rem_block_dvd;
        private System.Windows.Forms.Button rem_block_floppy;
        private System.Windows.Forms.Button rem_allow_usb;
        private System.Windows.Forms.Button rem_allow_dvd;
        private System.Windows.Forms.Button rem_allow_floppy;
        private System.Windows.Forms.GroupBox block_container;
        private System.Windows.Forms.GroupBox allow_container;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Label label1;
    }
}