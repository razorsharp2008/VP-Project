namespace vp_project
{
    partial class Choice
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
            this.this_comp = new System.Windows.Forms.Button();
            this.remote_comp = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // this_comp
            // 
            this.this_comp.Location = new System.Drawing.Point(39, 53);
            this.this_comp.Name = "this_comp";
            this.this_comp.Size = new System.Drawing.Size(152, 40);
            this.this_comp.TabIndex = 0;
            this.this_comp.Text = "Manage this computer";
            this.this_comp.UseVisualStyleBackColor = true;
            this.this_comp.Click += new System.EventHandler(this.this_comp_Click);
            // 
            // remote_comp
            // 
            this.remote_comp.Location = new System.Drawing.Point(39, 123);
            this.remote_comp.Name = "remote_comp";
            this.remote_comp.Size = new System.Drawing.Size(152, 35);
            this.remote_comp.TabIndex = 1;
            this.remote_comp.Text = "Manage remote computer";
            this.remote_comp.UseVisualStyleBackColor = true;
            this.remote_comp.Click += new System.EventHandler(this.remote_comp_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(163, 274);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(86, 26);
            this.end.TabIndex = 2;
            this.end.Text = "Exit";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Which computer would you like to manage?";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.remote_comp);
            this.groupBox1.Controls.Add(this.this_comp);
            this.groupBox1.Location = new System.Drawing.Point(90, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 167);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::vp_project.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(407, 328);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.end);
            this.Name = "Choice";
            this.Text = "Choice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button this_comp;
        private System.Windows.Forms.Button remote_comp;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}