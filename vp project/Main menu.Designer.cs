namespace vp_project
{
    partial class Main_menu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.block = new System.Windows.Forms.Button();
            this.allow = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::vp_project.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(578, 435);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO ACCESS CONTROL MECHANISM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // block
            // 
            this.block.Location = new System.Drawing.Point(237, 183);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(101, 43);
            this.block.TabIndex = 2;
            this.block.Text = "Block device";
            this.block.UseVisualStyleBackColor = true;
            this.block.Click += new System.EventHandler(this.block_Click);
            // 
            // allow
            // 
            this.allow.Location = new System.Drawing.Point(237, 264);
            this.allow.Name = "allow";
            this.allow.Size = new System.Drawing.Size(102, 43);
            this.allow.TabIndex = 3;
            this.allow.Text = "Allow device";
            this.allow.UseVisualStyleBackColor = true;
            this.allow.Click += new System.EventHandler(this.allow_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(237, 345);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(102, 41);
            this.end.TabIndex = 4;
            this.end.Text = "Exit";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 430);
            this.Controls.Add(this.end);
            this.Controls.Add(this.allow);
            this.Controls.Add(this.block);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main_menu";
            this.Text = "Main_menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button block;
        private System.Windows.Forms.Button allow;
        private System.Windows.Forms.Button end;
    }
}