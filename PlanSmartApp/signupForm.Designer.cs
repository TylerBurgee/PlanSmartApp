namespace PlanSmartApp
{
    partial class signupForm
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
            this.firstName_TextBox = new System.Windows.Forms.TextBox();
            this.lastName_TextBox = new System.Windows.Forms.TextBox();
            this.email_TextBox = new System.Windows.Forms.TextBox();
            this.username_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.username_Label = new System.Windows.Forms.Label();
            this.password_Label = new System.Windows.Forms.Label();
            this.email_Label = new System.Windows.Forms.Label();
            this.lastName_Label = new System.Windows.Forms.Label();
            this.firstName_Label = new System.Windows.Forms.Label();
            this.register_Button = new System.Windows.Forms.Button();
            this.signupHeading_Label = new System.Windows.Forms.Label();
            this.instructions_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstName_TextBox
            // 
            this.firstName_TextBox.Location = new System.Drawing.Point(336, 168);
            this.firstName_TextBox.Name = "firstName_TextBox";
            this.firstName_TextBox.Size = new System.Drawing.Size(192, 23);
            this.firstName_TextBox.TabIndex = 1;
            // 
            // lastName_TextBox
            // 
            this.lastName_TextBox.Location = new System.Drawing.Point(336, 208);
            this.lastName_TextBox.Name = "lastName_TextBox";
            this.lastName_TextBox.Size = new System.Drawing.Size(192, 23);
            this.lastName_TextBox.TabIndex = 2;
            // 
            // email_TextBox
            // 
            this.email_TextBox.Location = new System.Drawing.Point(336, 248);
            this.email_TextBox.Name = "email_TextBox";
            this.email_TextBox.Size = new System.Drawing.Size(192, 23);
            this.email_TextBox.TabIndex = 3;
            // 
            // username_TextBox
            // 
            this.username_TextBox.Location = new System.Drawing.Point(336, 288);
            this.username_TextBox.Name = "username_TextBox";
            this.username_TextBox.Size = new System.Drawing.Size(192, 23);
            this.username_TextBox.TabIndex = 4;
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(336, 328);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(192, 23);
            this.password_TextBox.TabIndex = 5;
            // 
            // username_Label
            // 
            this.username_Label.AutoSize = true;
            this.username_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username_Label.ForeColor = System.Drawing.Color.White;
            this.username_Label.Location = new System.Drawing.Point(240, 288);
            this.username_Label.Name = "username_Label";
            this.username_Label.Size = new System.Drawing.Size(84, 21);
            this.username_Label.TabIndex = 6;
            this.username_Label.Text = "Username:";
            // 
            // password_Label
            // 
            this.password_Label.AutoSize = true;
            this.password_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_Label.ForeColor = System.Drawing.Color.White;
            this.password_Label.Location = new System.Drawing.Point(248, 328);
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(79, 21);
            this.password_Label.TabIndex = 7;
            this.password_Label.Text = "Password:";
            // 
            // email_Label
            // 
            this.email_Label.AutoSize = true;
            this.email_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_Label.ForeColor = System.Drawing.Color.White;
            this.email_Label.Location = new System.Drawing.Point(272, 248);
            this.email_Label.Name = "email_Label";
            this.email_Label.Size = new System.Drawing.Size(51, 21);
            this.email_Label.TabIndex = 8;
            this.email_Label.Text = "Email:";
            // 
            // lastName_Label
            // 
            this.lastName_Label.AutoSize = true;
            this.lastName_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastName_Label.ForeColor = System.Drawing.Color.White;
            this.lastName_Label.Location = new System.Drawing.Point(240, 208);
            this.lastName_Label.Name = "lastName_Label";
            this.lastName_Label.Size = new System.Drawing.Size(87, 21);
            this.lastName_Label.TabIndex = 9;
            this.lastName_Label.Text = "Last Name:";
            // 
            // firstName_Label
            // 
            this.firstName_Label.AutoSize = true;
            this.firstName_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstName_Label.ForeColor = System.Drawing.Color.White;
            this.firstName_Label.Location = new System.Drawing.Point(232, 168);
            this.firstName_Label.Name = "firstName_Label";
            this.firstName_Label.Size = new System.Drawing.Size(89, 21);
            this.firstName_Label.TabIndex = 10;
            this.firstName_Label.Text = "First Name:";
            // 
            // register_Button
            // 
            this.register_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.register_Button.Location = new System.Drawing.Point(392, 368);
            this.register_Button.Name = "register_Button";
            this.register_Button.Size = new System.Drawing.Size(136, 32);
            this.register_Button.TabIndex = 11;
            this.register_Button.Text = "Register";
            this.register_Button.UseVisualStyleBackColor = true;
            this.register_Button.Click += new System.EventHandler(this.register_Button_Click);
            // 
            // signupHeading_Label
            // 
            this.signupHeading_Label.AutoSize = true;
            this.signupHeading_Label.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signupHeading_Label.ForeColor = System.Drawing.Color.White;
            this.signupHeading_Label.Location = new System.Drawing.Point(296, 80);
            this.signupHeading_Label.Name = "signupHeading_Label";
            this.signupHeading_Label.Size = new System.Drawing.Size(194, 28);
            this.signupHeading_Label.TabIndex = 12;
            this.signupHeading_Label.Text = "Let\'s Get Started!";
            // 
            // instructions_Label
            // 
            this.instructions_Label.AutoSize = true;
            this.instructions_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instructions_Label.ForeColor = System.Drawing.Color.White;
            this.instructions_Label.Location = new System.Drawing.Point(184, 128);
            this.instructions_Label.Name = "instructions_Label";
            this.instructions_Label.Size = new System.Drawing.Size(404, 21);
            this.instructions_Label.TabIndex = 13;
            this.instructions_Label.Text = "Fill out this form to create a new account with PlanSmart.";
            // 
            // signupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.instructions_Label);
            this.Controls.Add(this.signupHeading_Label);
            this.Controls.Add(this.register_Button);
            this.Controls.Add(this.firstName_Label);
            this.Controls.Add(this.lastName_Label);
            this.Controls.Add(this.email_Label);
            this.Controls.Add(this.password_Label);
            this.Controls.Add(this.username_Label);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.username_TextBox);
            this.Controls.Add(this.email_TextBox);
            this.Controls.Add(this.lastName_TextBox);
            this.Controls.Add(this.firstName_TextBox);
            this.Name = "signupForm";
            this.Text = "signupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox firstName_TextBox;
        private TextBox lastName_TextBox;
        private TextBox email_TextBox;
        private TextBox username_TextBox;
        private TextBox password_TextBox;
        private Label username_Label;
        private Label password_Label;
        private Label email_Label;
        private Label lastName_Label;
        private Label firstName_Label;
        private Button register_Button;
        private Label signupHeading_Label;
        private Label instructions_Label;
    }
}