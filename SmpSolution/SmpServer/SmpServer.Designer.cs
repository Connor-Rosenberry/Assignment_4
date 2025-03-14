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
            this.txtMessagePriority = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMessageType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Messages_Container = new System.Windows.Forms.GroupBox();
            this.Message_display = new System.Windows.Forms.RichTextBox();
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
            this.Start_Server.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Start_Server.Location = new System.Drawing.Point(16, 15);
            this.Start_Server.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Start_Server.Name = "Start_Server";
            this.Start_Server.Size = new System.Drawing.Size(151, 106);
            this.Start_Server.TabIndex = 0;
            this.Start_Server.Text = "Start Server";
            this.Start_Server.UseVisualStyleBackColor = true;
            this.Start_Server.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // Settings_Container
            // 
            this.Settings_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Settings_Container.Controls.Add(this.Port_Input);
            this.Settings_Container.Controls.Add(this.label2);
            this.Settings_Container.Controls.Add(this.label1);
            this.Settings_Container.Controls.Add(this.Address_input);
            this.Settings_Container.Location = new System.Drawing.Point(199, 15);
            this.Settings_Container.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Settings_Container.Name = "Settings_Container";
            this.Settings_Container.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Settings_Container.Size = new System.Drawing.Size(351, 106);
            this.Settings_Container.TabIndex = 1;
            this.Settings_Container.TabStop = false;
            this.Settings_Container.Text = "Settings";
            // 
            // Port_Input
            // 
            this.Port_Input.Location = new System.Drawing.Point(139, 65);
            this.Port_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Port_Input.Name = "Port_Input";
            this.Port_Input.Size = new System.Drawing.Size(199, 22);
            this.Port_Input.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server IP Address";
            // 
            // Address_input
            // 
            this.Address_input.Location = new System.Drawing.Point(139, 28);
            this.Address_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Address_input.Name = "Address_input";
            this.Address_input.Size = new System.Drawing.Size(199, 22);
            this.Address_input.TabIndex = 0;
            this.Address_input.TextChanged += new System.EventHandler(this.Address_input_TextChanged);
            // 
            // Last_Received_message_container
            // 
            this.Last_Received_message_container.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Last_Received_message_container.Controls.Add(this.txtMessagePriority);
            this.Last_Received_message_container.Controls.Add(this.label4);
            this.Last_Received_message_container.Controls.Add(this.txtMessageType);
            this.Last_Received_message_container.Controls.Add(this.label3);
            this.Last_Received_message_container.Location = new System.Drawing.Point(16, 142);
            this.Last_Received_message_container.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Last_Received_message_container.Name = "Last_Received_message_container";
            this.Last_Received_message_container.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Last_Received_message_container.Size = new System.Drawing.Size(533, 69);
            this.Last_Received_message_container.TabIndex = 2;
            this.Last_Received_message_container.TabStop = false;
            this.Last_Received_message_container.Text = "Last Received Message";
            // 
            // txtMessagePriority
            // 
            this.txtMessagePriority.Location = new System.Drawing.Point(381, 27);
            this.txtMessagePriority.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMessagePriority.Name = "txtMessagePriority";
            this.txtMessagePriority.Size = new System.Drawing.Size(129, 22);
            this.txtMessagePriority.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Message Priority";
            // 
            // txtMessageType
            // 
            this.txtMessageType.Location = new System.Drawing.Point(123, 27);
            this.txtMessageType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMessageType.Name = "txtMessageType";
            this.txtMessageType.Size = new System.Drawing.Size(129, 22);
            this.txtMessageType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message Type";
            // 
            // Messages_Container
            // 
            this.Messages_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Messages_Container.Controls.Add(this.Message_display);
            this.Messages_Container.Controls.Add(this.Show_Messages_button);
            this.Messages_Container.Controls.Add(this.Priority_Container);
            this.Messages_Container.Location = new System.Drawing.Point(16, 234);
            this.Messages_Container.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Messages_Container.Name = "Messages_Container";
            this.Messages_Container.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Messages_Container.Size = new System.Drawing.Size(521, 262);
            this.Messages_Container.TabIndex = 3;
            this.Messages_Container.TabStop = false;
            this.Messages_Container.Text = "Messages";
            this.Messages_Container.Enter += new System.EventHandler(this.Messages_Container_Enter);
            // 
            // Message_display
            // 
            this.Message_display.Location = new System.Drawing.Point(195, 28);
            this.Message_display.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Message_display.Name = "Message_display";
            this.Message_display.Size = new System.Drawing.Size(284, 180);
            this.Message_display.TabIndex = 3;
            this.Message_display.Text = "";
            this.Message_display.TextChanged += new System.EventHandler(this.Messages_Container_Enter);
            // 
            // Show_Messages_button
            // 
            this.Show_Messages_button.Location = new System.Drawing.Point(277, 220);
            this.Show_Messages_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Show_Messages_button.Name = "Show_Messages_button";
            this.Show_Messages_button.Size = new System.Drawing.Size(140, 34);
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
            this.Priority_Container.Location = new System.Drawing.Point(8, 23);
            this.Priority_Container.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Priority_Container.Name = "Priority_Container";
            this.Priority_Container.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Priority_Container.Size = new System.Drawing.Size(143, 186);
            this.Priority_Container.TabIndex = 0;
            this.Priority_Container.TabStop = false;
            this.Priority_Container.Text = "Priority";
            // 
            // All_button
            // 
            this.All_button.AutoSize = true;
            this.All_button.Location = new System.Drawing.Point(8, 145);
            this.All_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.All_button.Name = "All_button";
            this.All_button.Size = new System.Drawing.Size(40, 20);
            this.All_button.TabIndex = 3;
            this.All_button.TabStop = true;
            this.All_button.Text = "All";
            this.All_button.UseVisualStyleBackColor = true;
            this.All_button.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // High_Button
            // 
            this.High_Button.AutoSize = true;
            this.High_Button.Location = new System.Drawing.Point(8, 105);
            this.High_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.High_Button.Name = "High_Button";
            this.High_Button.Size = new System.Drawing.Size(53, 20);
            this.High_Button.TabIndex = 2;
            this.High_Button.TabStop = true;
            this.High_Button.Text = "High";
            this.High_Button.UseVisualStyleBackColor = true;
            this.High_Button.Click += new System.EventHandler(this.BtnHigh_Click);
            // 
            // Medium_button
            // 
            this.Medium_button.AutoSize = true;
            this.Medium_button.Location = new System.Drawing.Point(8, 63);
            this.Medium_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Medium_button.Name = "Medium_button";
            this.Medium_button.Size = new System.Drawing.Size(73, 20);
            this.Medium_button.TabIndex = 1;
            this.Medium_button.TabStop = true;
            this.Medium_button.Text = "Medium";
            this.Medium_button.UseVisualStyleBackColor = true;
            this.Medium_button.Click += new System.EventHandler(this.BtnMedium_Click);
            // 
            // Low_button
            // 
            this.Low_button.AutoSize = true;
            this.Low_button.Location = new System.Drawing.Point(8, 23);
            this.Low_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Low_button.Name = "Low_button";
            this.Low_button.Size = new System.Drawing.Size(49, 20);
            this.Low_button.TabIndex = 0;
            this.Low_button.TabStop = true;
            this.Low_button.Text = "Low";
            this.Low_button.UseVisualStyleBackColor = true;
            this.Low_button.Click += new System.EventHandler(this.BtnLow_Click);
            // 
            // FormSmpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 506);
            this.Controls.Add(this.Messages_Container);
            this.Controls.Add(this.Last_Received_message_container);
            this.Controls.Add(this.Settings_Container);
            this.Controls.Add(this.Start_Server);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox txtMessagePriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMessageType;
        private System.Windows.Forms.RichTextBox Message_display;
    }
}

