namespace PlanSmartApp
{
    partial class emailForm
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
            this.instructions_Label = new System.Windows.Forms.Label();
            this.signupHeading_Label = new System.Windows.Forms.Label();
            this.sendInvite_Button = new System.Windows.Forms.Button();
            this.firstName_Label = new System.Windows.Forms.Label();
            this.lastName_Label = new System.Windows.Forms.Label();
            this.email_Label = new System.Windows.Forms.Label();
            this.location_Label = new System.Windows.Forms.Label();
            this.username_Label = new System.Windows.Forms.Label();
            this.location_TextBox = new System.Windows.Forms.TextBox();
            this.time_TextBox = new System.Windows.Forms.TextBox();
            this.eventName_TextBox = new System.Windows.Forms.TextBox();
            this.subject_TextBox = new System.Windows.Forms.TextBox();
            this.toEmail_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.message_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // instructions_Label
            // 
            this.instructions_Label.AutoSize = true;
            this.instructions_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instructions_Label.ForeColor = System.Drawing.Color.White;
            this.instructions_Label.Location = new System.Drawing.Point(64, 112);
            this.instructions_Label.Name = "instructions_Label";
            this.instructions_Label.Size = new System.Drawing.Size(272, 21);
            this.instructions_Label.TabIndex = 26;
            this.instructions_Label.Text = "Fill out this form to send an invitation.";
            // 
            // signupHeading_Label
            // 
            this.signupHeading_Label.AutoSize = true;
            this.signupHeading_Label.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signupHeading_Label.ForeColor = System.Drawing.Color.White;
            this.signupHeading_Label.Location = new System.Drawing.Point(120, 64);
            this.signupHeading_Label.Name = "signupHeading_Label";
            this.signupHeading_Label.Size = new System.Drawing.Size(174, 28);
            this.signupHeading_Label.TabIndex = 25;
            this.signupHeading_Label.Text = "Invitation Form";
            // 
            // sendInvite_Button
            // 
            this.sendInvite_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sendInvite_Button.Location = new System.Drawing.Point(192, 392);
            this.sendInvite_Button.Name = "sendInvite_Button";
            this.sendInvite_Button.Size = new System.Drawing.Size(136, 32);
            this.sendInvite_Button.TabIndex = 24;
            this.sendInvite_Button.Text = "Send Invite";
            this.sendInvite_Button.UseVisualStyleBackColor = true;
            this.sendInvite_Button.Click += new System.EventHandler(this.sendInvite_Button_Click);
            // 
            // firstName_Label
            // 
            this.firstName_Label.AutoSize = true;
            this.firstName_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstName_Label.ForeColor = System.Drawing.Color.White;
            this.firstName_Label.Location = new System.Drawing.Point(104, 152);
            this.firstName_Label.Name = "firstName_Label";
            this.firstName_Label.Size = new System.Drawing.Size(28, 21);
            this.firstName_Label.TabIndex = 23;
            this.firstName_Label.Text = "To:";
            // 
            // lastName_Label
            // 
            this.lastName_Label.AutoSize = true;
            this.lastName_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastName_Label.ForeColor = System.Drawing.Color.White;
            this.lastName_Label.Location = new System.Drawing.Point(72, 192);
            this.lastName_Label.Name = "lastName_Label";
            this.lastName_Label.Size = new System.Drawing.Size(64, 21);
            this.lastName_Label.TabIndex = 22;
            this.lastName_Label.Text = "Subject:";
            // 
            // email_Label
            // 
            this.email_Label.AutoSize = true;
            this.email_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_Label.ForeColor = System.Drawing.Color.White;
            this.email_Label.Location = new System.Drawing.Point(40, 232);
            this.email_Label.Name = "email_Label";
            this.email_Label.Size = new System.Drawing.Size(97, 21);
            this.email_Label.TabIndex = 21;
            this.email_Label.Text = "Event Name:";
            // 
            // location_Label
            // 
            this.location_Label.AutoSize = true;
            this.location_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.location_Label.ForeColor = System.Drawing.Color.White;
            this.location_Label.Location = new System.Drawing.Point(64, 312);
            this.location_Label.Name = "location_Label";
            this.location_Label.Size = new System.Drawing.Size(72, 21);
            this.location_Label.TabIndex = 20;
            this.location_Label.Text = "Location:";
            // 
            // username_Label
            // 
            this.username_Label.AutoSize = true;
            this.username_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username_Label.ForeColor = System.Drawing.Color.White;
            this.username_Label.Location = new System.Drawing.Point(88, 272);
            this.username_Label.Name = "username_Label";
            this.username_Label.Size = new System.Drawing.Size(47, 21);
            this.username_Label.TabIndex = 19;
            this.username_Label.Text = "Time:";
            // 
            // location_TextBox
            // 
            this.location_TextBox.Location = new System.Drawing.Point(144, 312);
            this.location_TextBox.Name = "location_TextBox";
            this.location_TextBox.Size = new System.Drawing.Size(192, 23);
            this.location_TextBox.TabIndex = 18;
            // 
            // time_TextBox
            // 
            this.time_TextBox.Location = new System.Drawing.Point(144, 272);
            this.time_TextBox.Name = "time_TextBox";
            this.time_TextBox.PlaceholderText = "mm/dd/yyyy hh:mm";
            this.time_TextBox.Size = new System.Drawing.Size(192, 23);
            this.time_TextBox.TabIndex = 17;
            // 
            // eventName_TextBox
            // 
            this.eventName_TextBox.Location = new System.Drawing.Point(144, 232);
            this.eventName_TextBox.Name = "eventName_TextBox";
            this.eventName_TextBox.Size = new System.Drawing.Size(192, 23);
            this.eventName_TextBox.TabIndex = 16;
            // 
            // subject_TextBox
            // 
            this.subject_TextBox.Location = new System.Drawing.Point(144, 192);
            this.subject_TextBox.Name = "subject_TextBox";
            this.subject_TextBox.Size = new System.Drawing.Size(192, 23);
            this.subject_TextBox.TabIndex = 15;
            // 
            // toEmail_TextBox
            // 
            this.toEmail_TextBox.Location = new System.Drawing.Point(144, 152);
            this.toEmail_TextBox.Name = "toEmail_TextBox";
            this.toEmail_TextBox.PlaceholderText = "example@mail.com";
            this.toEmail_TextBox.Size = new System.Drawing.Size(192, 23);
            this.toEmail_TextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Message:";
            // 
            // message_TextBox
            // 
            this.message_TextBox.Location = new System.Drawing.Point(144, 352);
            this.message_TextBox.Name = "message_TextBox";
            this.message_TextBox.PlaceholderText = "(Optional)";
            this.message_TextBox.Size = new System.Drawing.Size(192, 23);
            this.message_TextBox.TabIndex = 29;
            // 
            // emailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.message_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instructions_Label);
            this.Controls.Add(this.signupHeading_Label);
            this.Controls.Add(this.sendInvite_Button);
            this.Controls.Add(this.firstName_Label);
            this.Controls.Add(this.lastName_Label);
            this.Controls.Add(this.email_Label);
            this.Controls.Add(this.location_Label);
            this.Controls.Add(this.username_Label);
            this.Controls.Add(this.location_TextBox);
            this.Controls.Add(this.time_TextBox);
            this.Controls.Add(this.eventName_TextBox);
            this.Controls.Add(this.subject_TextBox);
            this.Controls.Add(this.toEmail_TextBox);
            this.Name = "emailForm";
            this.Text = "emailForn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label instructions_Label;
        private Label signupHeading_Label;
        private Button sendInvite_Button;
        private Label firstName_Label;
        private Label lastName_Label;
        private Label email_Label;
        private Label location_Label;
        private Label username_Label;
        private TextBox location_TextBox;
        private TextBox time_TextBox;
        private TextBox eventName_TextBox;
        private TextBox subject_TextBox;
        private TextBox toEmail_TextBox;
        private Label label1;
        private TextBox message_TextBox;
    }
}