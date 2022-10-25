namespace PlanSmartApp
{
    partial class eventsForm
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
            this.createEvent_Button = new System.Windows.Forms.Button();
            this.modifyEvent_Button = new System.Windows.Forms.Button();
            this.deleteEvent_Button = new System.Windows.Forms.Button();
            this.events_ListBox = new System.Windows.Forms.ListBox();
            this.header_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createEvent_Button
            // 
            this.createEvent_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createEvent_Button.Location = new System.Drawing.Point(72, 376);
            this.createEvent_Button.Name = "createEvent_Button";
            this.createEvent_Button.Size = new System.Drawing.Size(80, 56);
            this.createEvent_Button.TabIndex = 0;
            this.createEvent_Button.Text = "Create Event";
            this.createEvent_Button.UseVisualStyleBackColor = true;
            this.createEvent_Button.Click += new System.EventHandler(this.createEvent_Button_Click);
            // 
            // modifyEvent_Button
            // 
            this.modifyEvent_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modifyEvent_Button.Location = new System.Drawing.Point(168, 376);
            this.modifyEvent_Button.Name = "modifyEvent_Button";
            this.modifyEvent_Button.Size = new System.Drawing.Size(80, 56);
            this.modifyEvent_Button.TabIndex = 1;
            this.modifyEvent_Button.Text = "Modify Event";
            this.modifyEvent_Button.UseVisualStyleBackColor = true;
            this.modifyEvent_Button.Click += new System.EventHandler(this.modifyEvent_Button_Click);
            // 
            // deleteEvent_Button
            // 
            this.deleteEvent_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteEvent_Button.Location = new System.Drawing.Point(264, 376);
            this.deleteEvent_Button.Name = "deleteEvent_Button";
            this.deleteEvent_Button.Size = new System.Drawing.Size(80, 56);
            this.deleteEvent_Button.TabIndex = 2;
            this.deleteEvent_Button.Text = "Delete Event";
            this.deleteEvent_Button.UseVisualStyleBackColor = true;
            this.deleteEvent_Button.Click += new System.EventHandler(this.deleteEvent_Button_Click);
            // 
            // events_ListBox
            // 
            this.events_ListBox.FormattingEnabled = true;
            this.events_ListBox.ItemHeight = 15;
            this.events_ListBox.Location = new System.Drawing.Point(0, 80);
            this.events_ListBox.Name = "events_ListBox";
            this.events_ListBox.Size = new System.Drawing.Size(416, 274);
            this.events_ListBox.TabIndex = 3;
            // 
            // header_Label
            // 
            this.header_Label.AutoSize = true;
            this.header_Label.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.header_Label.Location = new System.Drawing.Point(16, 24);
            this.header_Label.Name = "header_Label";
            this.header_Label.Size = new System.Drawing.Size(229, 37);
            this.header_Label.TabIndex = 4;
            this.header_Label.Text = "Scheduled Events:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(264, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "00/00/00";
            // 
            // eventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header_Label);
            this.Controls.Add(this.events_ListBox);
            this.Controls.Add(this.deleteEvent_Button);
            this.Controls.Add(this.modifyEvent_Button);
            this.Controls.Add(this.createEvent_Button);
            this.Name = "eventsForm";
            this.Text = "dateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button createEvent_Button;
        private Button modifyEvent_Button;
        private Button deleteEvent_Button;
        private ListBox events_ListBox;
        private Label header_Label;
        private Label label1;
    }
}