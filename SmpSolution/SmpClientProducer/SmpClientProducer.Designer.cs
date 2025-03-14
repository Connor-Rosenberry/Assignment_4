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
            this.Text_Message = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Send_Message_button = new System.Windows.Forms.Button();
            this.Priority_Container = new System.Windows.Forms.GroupBox();
            this.High_button = new System.Windows.Forms.RadioButton();
            this.Medium_button = new System.Windows.Forms.RadioButton();
            this.Low_button = new System.Windows.Forms.RadioButton();
            this.Settings_Container = new System.Windows.Forms.GroupBox();
            this.Port_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IP_Input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Server_Response = new System.Windows.Forms.TextBox();
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
            this.Messages_Container.Location = new System.Drawing.Point(16, 140);
            this.Messages_Container.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Messages_Container.Name = "Messages_Container";
            this.Messages_Container.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Messages_Container.Size = new System.Drawing.Size(679, 274);
            this.Messages_Container.TabIndex = 7;
            this.Messages_Container.TabStop = false;
            this.Messages_Container.Text = "Message";
            // 
            // Text_Message
            // 
            this.Text_Message.Location = new System.Drawing.Point(187, 58);
            this.Text_Message.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_Message.Name = "Text_Message";
            this.Text_Message.Size = new System.Drawing.Size(471, 166);
            this.Text_Message.TabIndex = 4;
            this.Text_Message.Text = "";
            this.Text_Message.TextChanged += new System.EventHandler(this.Text_Message_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Message Content";
            // 
            // Send_Message_button
            // 
            this.Send_Message_button.Location = new System.Drawing.Point(183, 233);
            this.Send_Message_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Send_Message_button.Name = "Send_Message_button";
            this.Send_Message_button.Size = new System.Drawing.Size(476, 34);
            this.Send_Message_button.TabIndex = 1;
            this.Send_Message_button.Text = "Send Message";
            this.Send_Message_button.UseVisualStyleBackColor = true;
            this.Send_Message_button.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // Priority_Container
            // 
            this.Priority_Container.Controls.Add(this.High_button);
            this.Priority_Container.Controls.Add(this.Medium_button);
            this.Priority_Container.Controls.Add(this.Low_button);
            this.Priority_Container.Location = new System.Drawing.Point(8, 44);
            this.Priority_Container.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Priority_Container.Name = "Priority_Container";
            this.Priority_Container.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Priority_Container.Size = new System.Drawing.Size(143, 186);
            this.Priority_Container.TabIndex = 0;
            this.Priority_Container.TabStop = false;
            this.Priority_Container.Text = "Priority";
            // 
            // High_button
            // 
            this.High_button.AutoSize = true;
            this.High_button.Location = new System.Drawing.Point(8, 126);
            this.High_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.High_button.Name = "High_button";
            this.High_button.Size = new System.Drawing.Size(53, 20);
            this.High_button.TabIndex = 2;
            this.High_button.TabStop = true;
            this.High_button.Text = "High";
            this.High_button.UseVisualStyleBackColor = true;
            this.High_button.Click += new System.EventHandler(this.btnHigh_Click);
            // 
            // Medium_button
            // 
            this.Medium_button.AutoSize = true;
            this.Medium_button.Location = new System.Drawing.Point(8, 75);
            this.Medium_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Medium_button.Name = "Medium_button";
            this.Medium_button.Size = new System.Drawing.Size(73, 20);
            this.Medium_button.TabIndex = 1;
            this.Medium_button.TabStop = true;
            this.Medium_button.Text = "Medium";
            this.Medium_button.UseVisualStyleBackColor = true;
            this.Medium_button.Click += new System.EventHandler(this.btnMedium_Click);
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
            this.Low_button.Click += new System.EventHandler(this.btnLow_Click);
            // 
            // Settings_Container
            // 
            this.Settings_Container.Controls.Add(this.Port_Input);
            this.Settings_Container.Controls.Add(this.label2);
            this.Settings_Container.Controls.Add(this.label1);
            this.Settings_Container.Controls.Add(this.IP_Input);
            this.Settings_Container.Location = new System.Drawing.Point(16, 15);
            this.Settings_Container.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Settings_Container.Name = "Settings_Container";
            this.Settings_Container.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Settings_Container.Size = new System.Drawing.Size(679, 71);
            this.Settings_Container.TabIndex = 5;
            this.Settings_Container.TabStop = false;
            this.Settings_Container.Text = "Settings";
            this.Settings_Container.Enter += new System.EventHandler(this.Settings_Container_Enter);
            // 
            // Port_Input
            // 
            this.Port_Input.Location = new System.Drawing.Point(537, 28);
            this.Port_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Port_Input.Name = "Port_Input";
            this.Port_Input.Size = new System.Drawing.Size(104, 22);
            this.Port_Input.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Application Port Number";
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
            // IP_Input
            // 
            this.IP_Input.AccessibleName = "IP_Input";
            this.IP_Input.Location = new System.Drawing.Point(139, 28);
            this.IP_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IP_Input.Name = "IP_Input";
            this.IP_Input.Size = new System.Drawing.Size(199, 22);
            this.IP_Input.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Server Response";
            // 
            // Server_Response
            // 
            this.Server_Response.Location = new System.Drawing.Point(167, 100);
            this.Server_Response.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Server_Response.Name = "Server_Response";
            this.Server_Response.Size = new System.Drawing.Size(507, 22);
            this.Server_Response.TabIndex = 9;
            // 
            // FormSmpClientProducer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 430);
            this.Controls.Add(this.Server_Response);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Messages_Container);
            this.Controls.Add(this.Settings_Container);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.RadioButton High_button;
        private System.Windows.Forms.RadioButton Medium_button;
        private System.Windows.Forms.RadioButton Low_button;
        private System.Windows.Forms.GroupBox Settings_Container;
        private System.Windows.Forms.TextBox Port_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IP_Input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Server_Response;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Text_Message;
    }
}

