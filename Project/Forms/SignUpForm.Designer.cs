namespace Project.Forms
{
    partial class SignUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name_lbe = new System.Windows.Forms.Label();
            this.email_lbe = new System.Windows.Forms.Label();
            this.pass_lbe = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.term_check = new System.Windows.Forms.CheckBox();
            this.Signup_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started Now";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1110, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 1043);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // name_lbe
            // 
            this.name_lbe.AutoSize = true;
            this.name_lbe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbe.Location = new System.Drawing.Point(66, 172);
            this.name_lbe.Name = "name_lbe";
            this.name_lbe.Size = new System.Drawing.Size(56, 21);
            this.name_lbe.TabIndex = 2;
            this.name_lbe.Text = "Name";
            // 
            // email_lbe
            // 
            this.email_lbe.AutoSize = true;
            this.email_lbe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbe.Location = new System.Drawing.Point(66, 240);
            this.email_lbe.Name = "email_lbe";
            this.email_lbe.Size = new System.Drawing.Size(53, 21);
            this.email_lbe.TabIndex = 3;
            this.email_lbe.Text = "Email";
            // 
            // pass_lbe
            // 
            this.pass_lbe.AutoSize = true;
            this.pass_lbe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_lbe.Location = new System.Drawing.Point(66, 311);
            this.pass_lbe.Name = "pass_lbe";
            this.pass_lbe.Size = new System.Drawing.Size(82, 21);
            this.pass_lbe.TabIndex = 4;
            this.pass_lbe.Text = "Password";
            // 
            // name_txt
            // 
            this.name_txt.AccessibleName = "name_txt";
            this.name_txt.BackColor = System.Drawing.SystemColors.Window;
            this.name_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(70, 196);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(322, 25);
            this.name_txt.TabIndex = 5;
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // email_txt
            // 
            this.email_txt.AccessibleName = "email_txt";
            this.email_txt.BackColor = System.Drawing.SystemColors.Window;
            this.email_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.Location = new System.Drawing.Point(70, 264);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(322, 25);
            this.email_txt.TabIndex = 6;
            // 
            // pass_txt
            // 
            this.pass_txt.AccessibleName = "pass_txt";
            this.pass_txt.BackColor = System.Drawing.SystemColors.Window;
            this.pass_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_txt.Location = new System.Drawing.Point(70, 335);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(322, 25);
            this.pass_txt.TabIndex = 7;
            this.pass_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // term_check
            // 
            this.term_check.AccessibleName = "term_check";
            this.term_check.AutoSize = true;
            this.term_check.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.term_check.Location = new System.Drawing.Point(70, 383);
            this.term_check.Name = "term_check";
            this.term_check.Size = new System.Drawing.Size(168, 17);
            this.term_check.TabIndex = 8;
            this.term_check.Text = "I agree to the terms and policy";
            this.term_check.UseVisualStyleBackColor = false;
            // 
            // Signup_btn
            // 
            this.Signup_btn.AccessibleName = "Signup_btn";
            this.Signup_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.Signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_btn.ForeColor = System.Drawing.Color.White;
            this.Signup_btn.Location = new System.Drawing.Point(70, 429);
            this.Signup_btn.Name = "Signup_btn";
            this.Signup_btn.Size = new System.Drawing.Size(322, 33);
            this.Signup_btn.TabIndex = 10;
            this.Signup_btn.Text = "Signup";
            this.Signup_btn.UseVisualStyleBackColor = false;
            this.Signup_btn.Click += new System.EventHandler(this.Signup_btn_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.Signup_btn);
            this.Controls.Add(this.term_check);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.pass_lbe);
            this.Controls.Add(this.email_lbe);
            this.Controls.Add(this.name_lbe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name_lbe;
        private System.Windows.Forms.Label email_lbe;
        private System.Windows.Forms.Label pass_lbe;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.CheckBox term_check;
        private System.Windows.Forms.Button Signup_btn;
    }
}