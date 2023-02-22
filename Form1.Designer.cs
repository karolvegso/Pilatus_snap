namespace Pilatus_Snap_WinFormApp
{
    partial class MainForm
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
            this.pilatus_tabControl = new System.Windows.Forms.TabControl();
            this.pilatusIPaddress_tabPage = new System.Windows.Forms.TabPage();
            this.portNumber_textBox = new System.Windows.Forms.TextBox();
            this.portNumber_label = new System.Windows.Forms.Label();
            this.ipAddress_textBox = new System.Windows.Forms.TextBox();
            this.ipAddress_label = new System.Windows.Forms.Label();
            this.setthreshold_tabPage = new System.Windows.Forms.TabPage();
            this.setthreshold_button = new System.Windows.Forms.Button();
            this.setthresholdCmd_textBox = new System.Windows.Forms.TextBox();
            this.setthresholdCmd_label = new System.Windows.Forms.Label();
            this.takeImage_tabPage = new System.Windows.Forms.TabPage();
            this.pilatusResponse_richTextBox = new System.Windows.Forms.RichTextBox();
            this.pilatusResponse_label = new System.Windows.Forms.Label();
            this.takeImage_button = new System.Windows.Forms.Button();
            this.imageName_textBox = new System.Windows.Forms.TextBox();
            this.imageName_label = new System.Windows.Forms.Label();
            this.expp_textBox = new System.Windows.Forms.TextBox();
            this.expp_label = new System.Windows.Forms.Label();
            this.expt_textBox = new System.Windows.Forms.TextBox();
            this.expt_label = new System.Windows.Forms.Label();
            this.ni_textBox = new System.Windows.Forms.TextBox();
            this.ni_label = new System.Windows.Forms.Label();
            this.pilatus_tabControl.SuspendLayout();
            this.pilatusIPaddress_tabPage.SuspendLayout();
            this.setthreshold_tabPage.SuspendLayout();
            this.takeImage_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pilatus_tabControl
            // 
            this.pilatus_tabControl.Controls.Add(this.pilatusIPaddress_tabPage);
            this.pilatus_tabControl.Controls.Add(this.setthreshold_tabPage);
            this.pilatus_tabControl.Controls.Add(this.takeImage_tabPage);
            this.pilatus_tabControl.Location = new System.Drawing.Point(13, 13);
            this.pilatus_tabControl.Name = "pilatus_tabControl";
            this.pilatus_tabControl.SelectedIndex = 0;
            this.pilatus_tabControl.Size = new System.Drawing.Size(775, 425);
            this.pilatus_tabControl.TabIndex = 0;
            // 
            // pilatusIPaddress_tabPage
            // 
            this.pilatusIPaddress_tabPage.Controls.Add(this.portNumber_textBox);
            this.pilatusIPaddress_tabPage.Controls.Add(this.portNumber_label);
            this.pilatusIPaddress_tabPage.Controls.Add(this.ipAddress_textBox);
            this.pilatusIPaddress_tabPage.Controls.Add(this.ipAddress_label);
            this.pilatusIPaddress_tabPage.Location = new System.Drawing.Point(4, 25);
            this.pilatusIPaddress_tabPage.Name = "pilatusIPaddress_tabPage";
            this.pilatusIPaddress_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pilatusIPaddress_tabPage.Size = new System.Drawing.Size(767, 396);
            this.pilatusIPaddress_tabPage.TabIndex = 0;
            this.pilatusIPaddress_tabPage.Text = "Pilatus\'s IP address";
            this.pilatusIPaddress_tabPage.UseVisualStyleBackColor = true;
            // 
            // portNumber_textBox
            // 
            this.portNumber_textBox.Location = new System.Drawing.Point(32, 91);
            this.portNumber_textBox.Name = "portNumber_textBox";
            this.portNumber_textBox.Size = new System.Drawing.Size(181, 22);
            this.portNumber_textBox.TabIndex = 3;
            this.portNumber_textBox.Text = "41234";
            // 
            // portNumber_label
            // 
            this.portNumber_label.AutoSize = true;
            this.portNumber_label.Location = new System.Drawing.Point(32, 71);
            this.portNumber_label.Name = "portNumber_label";
            this.portNumber_label.Size = new System.Drawing.Size(86, 17);
            this.portNumber_label.TabIndex = 2;
            this.portNumber_label.Text = "Port number";
            // 
            // ipAddress_textBox
            // 
            this.ipAddress_textBox.Location = new System.Drawing.Point(32, 41);
            this.ipAddress_textBox.Name = "ipAddress_textBox";
            this.ipAddress_textBox.Size = new System.Drawing.Size(184, 22);
            this.ipAddress_textBox.TabIndex = 1;
            this.ipAddress_textBox.Text = "147.213.112.19";
            // 
            // ipAddress_label
            // 
            this.ipAddress_label.AutoSize = true;
            this.ipAddress_label.Location = new System.Drawing.Point(29, 20);
            this.ipAddress_label.Name = "ipAddress_label";
            this.ipAddress_label.Size = new System.Drawing.Size(75, 17);
            this.ipAddress_label.TabIndex = 0;
            this.ipAddress_label.Text = "IP address";
            // 
            // setthreshold_tabPage
            // 
            this.setthreshold_tabPage.Controls.Add(this.setthreshold_button);
            this.setthreshold_tabPage.Controls.Add(this.setthresholdCmd_textBox);
            this.setthreshold_tabPage.Controls.Add(this.setthresholdCmd_label);
            this.setthreshold_tabPage.Location = new System.Drawing.Point(4, 25);
            this.setthreshold_tabPage.Name = "setthreshold_tabPage";
            this.setthreshold_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.setthreshold_tabPage.Size = new System.Drawing.Size(767, 396);
            this.setthreshold_tabPage.TabIndex = 1;
            this.setthreshold_tabPage.Text = "Set threshold";
            this.setthreshold_tabPage.UseVisualStyleBackColor = true;
            // 
            // setthreshold_button
            // 
            this.setthreshold_button.Location = new System.Drawing.Point(34, 78);
            this.setthreshold_button.Name = "setthreshold_button";
            this.setthreshold_button.Size = new System.Drawing.Size(254, 23);
            this.setthreshold_button.TabIndex = 2;
            this.setthreshold_button.Text = "Set threshold";
            this.setthreshold_button.UseVisualStyleBackColor = true;
            this.setthreshold_button.Click += new System.EventHandler(this.setthreshold_Click);
            // 
            // setthresholdCmd_textBox
            // 
            this.setthresholdCmd_textBox.Location = new System.Drawing.Point(34, 39);
            this.setthresholdCmd_textBox.Name = "setthresholdCmd_textBox";
            this.setthresholdCmd_textBox.Size = new System.Drawing.Size(254, 22);
            this.setthresholdCmd_textBox.TabIndex = 1;
            this.setthresholdCmd_textBox.Text = "setthreshold midg 5000";
            // 
            // setthresholdCmd_label
            // 
            this.setthresholdCmd_label.AutoSize = true;
            this.setthresholdCmd_label.Location = new System.Drawing.Point(31, 18);
            this.setthresholdCmd_label.Name = "setthresholdCmd_label";
            this.setthresholdCmd_label.Size = new System.Drawing.Size(157, 17);
            this.setthresholdCmd_label.TabIndex = 0;
            this.setthresholdCmd_label.Text = "Set threshold command";
            // 
            // takeImage_tabPage
            // 
            this.takeImage_tabPage.Controls.Add(this.pilatusResponse_richTextBox);
            this.takeImage_tabPage.Controls.Add(this.pilatusResponse_label);
            this.takeImage_tabPage.Controls.Add(this.takeImage_button);
            this.takeImage_tabPage.Controls.Add(this.imageName_textBox);
            this.takeImage_tabPage.Controls.Add(this.imageName_label);
            this.takeImage_tabPage.Controls.Add(this.expp_textBox);
            this.takeImage_tabPage.Controls.Add(this.expp_label);
            this.takeImage_tabPage.Controls.Add(this.expt_textBox);
            this.takeImage_tabPage.Controls.Add(this.expt_label);
            this.takeImage_tabPage.Controls.Add(this.ni_textBox);
            this.takeImage_tabPage.Controls.Add(this.ni_label);
            this.takeImage_tabPage.Location = new System.Drawing.Point(4, 25);
            this.takeImage_tabPage.Name = "takeImage_tabPage";
            this.takeImage_tabPage.Size = new System.Drawing.Size(767, 396);
            this.takeImage_tabPage.TabIndex = 2;
            this.takeImage_tabPage.Text = "Take image";
            this.takeImage_tabPage.UseVisualStyleBackColor = true;
            // 
            // pilatusResponse_richTextBox
            // 
            this.pilatusResponse_richTextBox.Location = new System.Drawing.Point(51, 252);
            this.pilatusResponse_richTextBox.Name = "pilatusResponse_richTextBox";
            this.pilatusResponse_richTextBox.Size = new System.Drawing.Size(367, 96);
            this.pilatusResponse_richTextBox.TabIndex = 10;
            this.pilatusResponse_richTextBox.Text = "Pilatus\'s response";
            // 
            // pilatusResponse_label
            // 
            this.pilatusResponse_label.AutoSize = true;
            this.pilatusResponse_label.Location = new System.Drawing.Point(48, 232);
            this.pilatusResponse_label.Name = "pilatusResponse_label";
            this.pilatusResponse_label.Size = new System.Drawing.Size(123, 17);
            this.pilatusResponse_label.TabIndex = 9;
            this.pilatusResponse_label.Text = "Pilatus\'s response";
            // 
            // takeImage_button
            // 
            this.takeImage_button.Location = new System.Drawing.Point(302, 47);
            this.takeImage_button.Name = "takeImage_button";
            this.takeImage_button.Size = new System.Drawing.Size(243, 23);
            this.takeImage_button.TabIndex = 8;
            this.takeImage_button.Text = "Take image / run / expo";
            this.takeImage_button.UseVisualStyleBackColor = true;
            this.takeImage_button.Click += new System.EventHandler(this.takeImage_Click);
            // 
            // imageName_textBox
            // 
            this.imageName_textBox.Location = new System.Drawing.Point(48, 195);
            this.imageName_textBox.Name = "imageName_textBox";
            this.imageName_textBox.Size = new System.Drawing.Size(367, 22);
            this.imageName_textBox.TabIndex = 7;
            this.imageName_textBox.Text = "image_name";
            // 
            // imageName_label
            // 
            this.imageName_label.AutoSize = true;
            this.imageName_label.Location = new System.Drawing.Point(45, 175);
            this.imageName_label.Name = "imageName_label";
            this.imageName_label.Size = new System.Drawing.Size(85, 17);
            this.imageName_label.TabIndex = 6;
            this.imageName_label.Text = "Image name";
            // 
            // expp_textBox
            // 
            this.expp_textBox.Location = new System.Drawing.Point(48, 147);
            this.expp_textBox.Name = "expp_textBox";
            this.expp_textBox.Size = new System.Drawing.Size(193, 22);
            this.expp_textBox.TabIndex = 5;
            this.expp_textBox.Text = "expp";
            // 
            // expp_label
            // 
            this.expp_label.AutoSize = true;
            this.expp_label.Location = new System.Drawing.Point(45, 127);
            this.expp_label.Name = "expp_label";
            this.expp_label.Size = new System.Drawing.Size(373, 17);
            this.expp_label.TabIndex = 4;
            this.expp_label.Text = "Exposure period in sec (always larger than exposure time)";
            // 
            // expt_textBox
            // 
            this.expt_textBox.Location = new System.Drawing.Point(48, 98);
            this.expt_textBox.Name = "expt_textBox";
            this.expt_textBox.Size = new System.Drawing.Size(196, 22);
            this.expt_textBox.TabIndex = 3;
            this.expt_textBox.Text = "expt";
            // 
            // expt_label
            // 
            this.expt_label.AutoSize = true;
            this.expt_label.Location = new System.Drawing.Point(45, 78);
            this.expt_label.Name = "expt_label";
            this.expt_label.Size = new System.Drawing.Size(138, 17);
            this.expt_label.TabIndex = 2;
            this.expt_label.Text = "Exposure time in sec";
            // 
            // ni_textBox
            // 
            this.ni_textBox.Location = new System.Drawing.Point(48, 48);
            this.ni_textBox.Name = "ni_textBox";
            this.ni_textBox.Size = new System.Drawing.Size(199, 22);
            this.ni_textBox.TabIndex = 1;
            this.ni_textBox.Text = "ni";
            // 
            // ni_label
            // 
            this.ni_label.AutoSize = true;
            this.ni_label.Location = new System.Drawing.Point(45, 27);
            this.ni_label.Name = "ni_label";
            this.ni_label.Size = new System.Drawing.Size(123, 17);
            this.ni_label.TabIndex = 0;
            this.ni_label.Text = "Number of images";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pilatus_tabControl);
            this.Name = "MainForm";
            this.Text = "Pilatus snap program";
            this.pilatus_tabControl.ResumeLayout(false);
            this.pilatusIPaddress_tabPage.ResumeLayout(false);
            this.pilatusIPaddress_tabPage.PerformLayout();
            this.setthreshold_tabPage.ResumeLayout(false);
            this.setthreshold_tabPage.PerformLayout();
            this.takeImage_tabPage.ResumeLayout(false);
            this.takeImage_tabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pilatus_tabControl;
        private System.Windows.Forms.TabPage pilatusIPaddress_tabPage;
        private System.Windows.Forms.TabPage setthreshold_tabPage;
        private System.Windows.Forms.TabPage takeImage_tabPage;
        private System.Windows.Forms.TextBox ipAddress_textBox;
        private System.Windows.Forms.Label ipAddress_label;
        private System.Windows.Forms.TextBox portNumber_textBox;
        private System.Windows.Forms.Label portNumber_label;
        private System.Windows.Forms.Label setthresholdCmd_label;
        private System.Windows.Forms.TextBox setthresholdCmd_textBox;
        private System.Windows.Forms.Button setthreshold_button;
        private System.Windows.Forms.TextBox ni_textBox;
        private System.Windows.Forms.Label ni_label;
        private System.Windows.Forms.TextBox expt_textBox;
        private System.Windows.Forms.Label expt_label;
        private System.Windows.Forms.Label expp_label;
        private System.Windows.Forms.TextBox expp_textBox;
        private System.Windows.Forms.TextBox imageName_textBox;
        private System.Windows.Forms.Label imageName_label;
        private System.Windows.Forms.Button takeImage_button;
        private System.Windows.Forms.RichTextBox pilatusResponse_richTextBox;
        private System.Windows.Forms.Label pilatusResponse_label;
    }
}

