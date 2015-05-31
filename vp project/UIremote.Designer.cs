namespace vp_project
{
    partial class UIremote
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
            this.USB_blocked = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // USB_blocked
            // 
            this.USB_blocked.Location = new System.Drawing.Point(73, 21);
            this.USB_blocked.Name = "USB_blocked";
            this.USB_blocked.Size = new System.Drawing.Size(124, 50);
            this.USB_blocked.TabIndex = 0;
            this.USB_blocked.Text = "Block USB";
            this.USB_blocked.UseVisualStyleBackColor = true;
            this.USB_blocked.Click += new System.EventHandler(this.USB_blocked_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(73, 98);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(124, 45);
            this.save.TabIndex = 1;
            this.save.Text = "Apply changes";
            this.save.UseVisualStyleBackColor = true;
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(73, 172);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(123, 38);
            this.end.TabIndex = 2;
            this.end.Text = "Exit";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // UIremote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.end);
            this.Controls.Add(this.save);
            this.Controls.Add(this.USB_blocked);
            this.Name = "UIremote";
            this.Text = "UIremote";
            this.Load += new System.EventHandler(this.UIremote_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button USB_blocked;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button end;
    }
}