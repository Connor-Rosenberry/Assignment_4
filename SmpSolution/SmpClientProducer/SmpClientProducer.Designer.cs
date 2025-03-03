namespace SmpClientProducer
{
    partial class FormSmpClientProducer
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
            this.Messages_Container = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Send_Message_button = new System.Windows.Forms.Button();
            this.Priority_Container = new System.Windows.Forms.GroupBox();
            this.All_button = new System.Windows.Forms.RadioButton();
            this.High_Button = new System.Windows.Forms.RadioButton();
            this.Medium_button = new System.Windows.Forms.RadioButton();
            this.Low_button = new System.Windows.Forms.RadioButton();
            this.Settings_Container = new System.Windows.Forms.GroupBox();
            this.Port_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Address_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Server_Response = new System.Windows.Forms.TextBox();
            this.Text_Message = new System.Windows.Forms.RichTextBox();
            this.Messages_Container.SuspendLayout();
            this.Priority_Container.SuspendLayout();
            this.Settings_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // Messages_Container
            // 
            this.Messages_Container.Controls.Add(this.Text_Message);
            this.Messages_Container.Controls.Add(this.label4);
            this.Messages_Container.Controls.Add(this.Send_Message_button);
            this.Messages_Container.Controls.Add(this.Priority_Container);
            this.Messages_Container.Location = new System.Drawing.Point(12, 114);
            this.Messages_Container.Name = "Messages_Container";
            this.Messages_Container.Size = new System.Drawing.Size(509, 223);
            this.Messages_Container.TabIndex = 7;
            this.Messages_Container.TabStop = false;
            this.Messages_Container.Text = "Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Message Content";
            // 
            // Send_Message_button
            // 
            this.Send_Message_button.Location = new System.Drawing.Point(137, 189);
            this.Send_Message_button.Name = "Send_Message_button";
            this.Send_Message_button.Size = new System.Drawing.Size(357, 28);
            this.Send_Message_button.TabIndex = 1;
            this.Send_Message_button.Text = "Send Message";
            this.Send_Message_button.UseVisualStyleBackColor = true;
            this.Send_Message_button.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // Priority_Container
            // 
            this.Priority_Container.Controls.Add(this.All_button);
            this.Priority_Container.Controls.Add(this.High_Button);
            this.Priority_Container.Controls.Add(this.Medium_button);
            this.Priority_Container.Controls.Add(this.Low_button);
            this.Priority_Container.Location = new System.Drawing.Point(6, 36);
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
            // Settings_Container
            // 
            this.Settings_Container.Controls.Add(this.Port_Input);
            this.Settings_Container.Controls.Add(this.label2);
            this.Settings_Container.Controls.Add(this.label1);
            this.Settings_Container.Controls.Add(this.Address_input);
            this.Settings_Container.Location = new System.Drawing.Point(12, 12);
            this.Settings_Container.Name = "Settings_Container";
            this.Settings_Container.Size = new System.Drawing.Size(509, 58);
            this.Settings_Container.TabIndex = 5;
            this.Settings_Container.TabStop = false;
            this.Settings_Container.Text = "Settings";
            // 
            // Port_Input
            // 
            this.Port_Input.Location = new System.Drawing.Point(403, 23);
            this.Port_Input.Name = "Port_Input";
            this.Port_Input.Size = new System.Drawing.Size(79, 20);
            this.Port_Input.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Application Port Number";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Server Response";
            // 
            // Server_Response
            // 
            this.Server_Response.Location = new System.Drawing.Point(125, 81);
            this.Server_Response.Name = "Server_Response";
            this.Server_Response.Size = new System.Drawing.Size(381, 20);
            this.Server_Response.TabIndex = 9;
            // 
            // Text_Message
            // 
            this.Text_Message.Location = new System.Drawing.Point(140, 47);
            this.Text_Message.Name = "Text_Message";
            this.Text_Message.Size = new System.Drawing.Size(354, 136);
            this.Text_Message.TabIndex = 4;
            this.Text_Message.Text = "";
            // 
            // FormSmpClientProducer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 349);
            this.Controls.Add(this.Server_Response);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Messages_Container);
            this.Controls.Add(this.Settings_Container);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSmpClientProducer";
            this.Text = "SMP Client Producer";
            this.Messages_Container.ResumeLayout(false);
            this.Messages_Container.PerformLayout();
            this.Priority_Container.ResumeLayout(false);
            this.Priority_Container.PerformLayout();
            this.Settings_Container.ResumeLayout(false);
            this.Settings_Container.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Messages_Container;
        private System.Windows.Forms.Button Send_Message_button;
        private System.Windows.Forms.GroupBox Priority_Container;
        private System.Windows.Forms.RadioButton All_button;
        private System.Windows.Forms.RadioButton High_Button;
        private System.Windows.Forms.RadioButton Medium_button;
        private System.Windows.Forms.RadioButton Low_button;
        private System.Windows.Forms.GroupBox Settings_Container;
        private System.Windows.Forms.TextBox Port_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Address_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Server_Response;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Text_Message;
    }
}

