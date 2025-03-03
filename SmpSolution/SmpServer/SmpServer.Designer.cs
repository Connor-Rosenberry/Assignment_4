namespace SmpServer
{
    partial class FormSmpServer
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
            this.Start_Server = new System.Windows.Forms.Button();
            this.Settings_Container = new System.Windows.Forms.GroupBox();
            this.Port_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Address_input = new System.Windows.Forms.TextBox();
            this.Last_Received_message_container = new System.Windows.Forms.GroupBox();
            this.Message_priority_Input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Message_type_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Messages_Container = new System.Windows.Forms.GroupBox();
            this.Message_display = new System.Windows.Forms.ListBox();
            this.Show_Messages_button = new System.Windows.Forms.Button();
            this.Priority_Container = new System.Windows.Forms.GroupBox();
            this.All_button = new System.Windows.Forms.RadioButton();
            this.High_Button = new System.Windows.Forms.RadioButton();
            this.Medium_button = new System.Windows.Forms.RadioButton();
            this.Low_button = new System.Windows.Forms.RadioButton();
            this.Settings_Container.SuspendLayout();
            this.Last_Received_message_container.SuspendLayout();
            this.Messages_Container.SuspendLayout();
            this.Priority_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start_Server
            // 
            this.Start_Server.Location = new System.Drawing.Point(12, 12);
            this.Start_Server.Name = "Start_Server";
            this.Start_Server.Size = new System.Drawing.Size(113, 86);
            this.Start_Server.TabIndex = 0;
            this.Start_Server.Text = "Start Server";
            this.Start_Server.UseVisualStyleBackColor = true;
            this.Start_Server.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // Settings_Container
            // 
            this.Settings_Container.Controls.Add(this.Port_Input);
            this.Settings_Container.Controls.Add(this.label2);
            this.Settings_Container.Controls.Add(this.label1);
            this.Settings_Container.Controls.Add(this.Address_input);
            this.Settings_Container.Location = new System.Drawing.Point(149, 12);
            this.Settings_Container.Name = "Settings_Container";
            this.Settings_Container.Size = new System.Drawing.Size(263, 86);
            this.Settings_Container.TabIndex = 1;
            this.Settings_Container.TabStop = false;
            this.Settings_Container.Text = "Settings";
            // 
            // Port_Input
            // 
            this.Port_Input.Location = new System.Drawing.Point(104, 53);
            this.Port_Input.Name = "Port_Input";
            this.Port_Input.Size = new System.Drawing.Size(150, 20);
            this.Port_Input.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server IP Address";
            // 
            // Address_input
            // 
            this.Address_input.Location = new System.Drawing.Point(104, 23);
            this.Address_input.Name = "Address_input";
            this.Address_input.Size = new System.Drawing.Size(150, 20);
            this.Address_input.TabIndex = 0;
            // 
            // Last_Received_message_container
            // 
            this.Last_Received_message_container.Controls.Add(this.Message_priority_Input);
            this.Last_Received_message_container.Controls.Add(this.label4);
            this.Last_Received_message_container.Controls.Add(this.Message_type_input);
            this.Last_Received_message_container.Controls.Add(this.label3);
            this.Last_Received_message_container.Location = new System.Drawing.Point(12, 115);
            this.Last_Received_message_container.Name = "Last_Received_message_container";
            this.Last_Received_message_container.Size = new System.Drawing.Size(400, 56);
            this.Last_Received_message_container.TabIndex = 2;
            this.Last_Received_message_container.TabStop = false;
            this.Last_Received_message_container.Text = "Last Received Message";
            // 
            // Message_priority_Input
            // 
            this.Message_priority_Input.Location = new System.Drawing.Point(286, 22);
            this.Message_priority_Input.Name = "Message_priority_Input";
            this.Message_priority_Input.Size = new System.Drawing.Size(98, 20);
            this.Message_priority_Input.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Message Priority";
            // 
            // Message_type_input
            // 
            this.Message_type_input.Location = new System.Drawing.Point(92, 22);
            this.Message_type_input.Name = "Message_type_input";
            this.Message_type_input.Size = new System.Drawing.Size(98, 20);
            this.Message_type_input.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message Type";
            // 
            // Messages_Container
            // 
            this.Messages_Container.Controls.Add(this.Message_display);
            this.Messages_Container.Controls.Add(this.Show_Messages_button);
            this.Messages_Container.Controls.Add(this.Priority_Container);
            this.Messages_Container.Location = new System.Drawing.Point(12, 190);
            this.Messages_Container.Name = "Messages_Container";
            this.Messages_Container.Size = new System.Drawing.Size(391, 213);
            this.Messages_Container.TabIndex = 3;
            this.Messages_Container.TabStop = false;
            this.Messages_Container.Text = "Messages";
            // 
            // Message_display
            // 
            this.Message_display.FormattingEnabled = true;
            this.Message_display.Location = new System.Drawing.Point(137, 29);
            this.Message_display.Name = "Message_display";
            this.Message_display.Size = new System.Drawing.Size(233, 134);
            this.Message_display.TabIndex = 2;
            // 
            // Show_Messages_button
            // 
            this.Show_Messages_button.Location = new System.Drawing.Point(208, 179);
            this.Show_Messages_button.Name = "Show_Messages_button";
            this.Show_Messages_button.Size = new System.Drawing.Size(105, 28);
            this.Show_Messages_button.TabIndex = 1;
            this.Show_Messages_button.Text = "Show Messages";
            this.Show_Messages_button.UseVisualStyleBackColor = true;
            this.Show_Messages_button.Click += new System.EventHandler(this.btnShowMessages_Click);
            // 
            // Priority_Container
            // 
            this.Priority_Container.Controls.Add(this.All_button);
            this.Priority_Container.Controls.Add(this.High_Button);
            this.Priority_Container.Controls.Add(this.Medium_button);
            this.Priority_Container.Controls.Add(this.Low_button);
            this.Priority_Container.Location = new System.Drawing.Point(6, 19);
            this.Priority_Container.Name = "Priority_Container";
            this.Priority_Container.Size = new System.Drawing.Size(107, 151);
            this.Priority_Container.TabIndex = 0;
            this.Priority_Container.TabStop = false;
            this.Priority_Container.Text = "Priority";
            // 
            // All_button
            // 
            this.All_button.AutoSize = true;
            this.All_button.Location = new System.Drawing.Point(6, 118);
            this.All_button.Name = "All_button";
            this.All_button.Size = new System.Drawing.Size(36, 17);
            this.All_button.TabIndex = 3;
            this.All_button.TabStop = true;
            this.All_button.Text = "All";
            this.All_button.UseVisualStyleBackColor = true;
            // 
            // High_Button
            // 
            this.High_Button.AutoSize = true;
            this.High_Button.Location = new System.Drawing.Point(6, 85);
            this.High_Button.Name = "High_Button";
            this.High_Button.Size = new System.Drawing.Size(47, 17);
            this.High_Button.TabIndex = 2;
            this.High_Button.TabStop = true;
            this.High_Button.Text = "High";
            this.High_Button.UseVisualStyleBackColor = true;
            // 
            // Medium_button
            // 
            this.Medium_button.AutoSize = true;
            this.Medium_button.Location = new System.Drawing.Point(6, 51);
            this.Medium_button.Name = "Medium_button";
            this.Medium_button.Size = new System.Drawing.Size(62, 17);
            this.Medium_button.TabIndex = 1;
            this.Medium_button.TabStop = true;
            this.Medium_button.Text = "Medium";
            this.Medium_button.UseVisualStyleBackColor = true;
            // 
            // Low_button
            // 
            this.Low_button.AutoSize = true;
            this.Low_button.Location = new System.Drawing.Point(6, 19);
            this.Low_button.Name = "Low_button";
            this.Low_button.Size = new System.Drawing.Size(45, 17);
            this.Low_button.TabIndex = 0;
            this.Low_button.TabStop = true;
            this.Low_button.Text = "Low";
            this.Low_button.UseVisualStyleBackColor = true;
            // 
            // FormSmpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 411);
            this.Controls.Add(this.Messages_Container);
            this.Controls.Add(this.Last_Received_message_container);
            this.Controls.Add(this.Settings_Container);
            this.Controls.Add(this.Start_Server);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSmpServer";
            this.Text = "SMP Server";
            this.Settings_Container.ResumeLayout(false);
            this.Settings_Container.PerformLayout();
            this.Last_Received_message_container.ResumeLayout(false);
            this.Last_Received_message_container.PerformLayout();
            this.Messages_Container.ResumeLayout(false);
            this.Priority_Container.ResumeLayout(false);
            this.Priority_Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_Server;
        private System.Windows.Forms.GroupBox Settings_Container;
        private System.Windows.Forms.GroupBox Last_Received_message_container;
        private System.Windows.Forms.GroupBox Messages_Container;
        private System.Windows.Forms.Button Show_Messages_button;
        private System.Windows.Forms.GroupBox Priority_Container;
        private System.Windows.Forms.RadioButton All_button;
        private System.Windows.Forms.RadioButton High_Button;
        private System.Windows.Forms.RadioButton Medium_button;
        private System.Windows.Forms.RadioButton Low_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Address_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Port_Input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Message_priority_Input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Message_type_input;
        private System.Windows.Forms.ListBox Message_display;
    }
}

