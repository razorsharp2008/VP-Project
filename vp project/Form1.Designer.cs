namespace vp_project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start_picture = new System.Windows.Forms.PictureBox();
            this.access_control_label = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.start_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // start_picture
            // 
            this.start_picture.Image = global::vp_project.Properties.Resources.pictah;
            this.start_picture.Location = new System.Drawing.Point(-3, -1);
            this.start_picture.Name = "start_picture";
            this.start_picture.Size = new System.Drawing.Size(697, 511);
            this.start_picture.TabIndex = 2;
            this.start_picture.TabStop = false;
            // 
            // access_control_label
            // 
            this.access_control_label.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.access_control_label.Location = new System.Drawing.Point(265, 215);
            this.access_control_label.MaximumSize = new System.Drawing.Size(500, 200);
            this.access_control_label.Name = "access_control_label";
            this.access_control_label.Size = new System.Drawing.Size(249, 88);
            this.access_control_label.TabIndex = 3;
            this.access_control_label.Text = "ACCESS CONTROL      MECHANISM";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(332, 366);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(102, 27);
            this.start.TabIndex = 4;
            this.start.Text = "Begin";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(332, 424);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(101, 24);
            this.end.TabIndex = 5;
            this.end.Text = "Exit";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 506);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.access_control_label);
            this.Controls.Add(this.start_picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Start Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.start_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox start_picture;
        private System.Windows.Forms.Label access_control_label;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button end;
    }
}

