namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelXbox = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.labelConnected = new System.Windows.Forms.Label();
            this.listBoxCommands = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSonar = new System.Windows.Forms.Button();
            this.listBoxRecieved = new System.Windows.Forms.ListBox();
            this.labelSent = new System.Windows.Forms.Label();
            this.labelReceived = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnForward
            // 
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Location = new System.Drawing.Point(95, 88);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(50, 50);
            this.btnForward.TabIndex = 0;
            this.btnForward.Text = "^";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnForward_MouseDown);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(143, 144);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(50, 50);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(45, 144);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(50, 50);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(95, 200);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "\\/";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseDown);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(231, 328);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(60, 328);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(165, 20);
            this.textBoxAddress.TabIndex = 5;
            this.textBoxAddress.Text = "ws://127.0.0.1:80/Simulator";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(9, 331);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(45, 13);
            this.labelAdress.TabIndex = 6;
            this.labelAdress.Text = "Address";
            // 
            // labelXbox
            // 
            this.labelXbox.AutoSize = true;
            this.labelXbox.Location = new System.Drawing.Point(57, 56);
            this.labelXbox.Name = "labelXbox";
            this.labelXbox.Size = new System.Drawing.Size(123, 13);
            this.labelXbox.TabIndex = 7;
            this.labelXbox.Text = "Controller not connected";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(312, 328);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // labelConnected
            // 
            this.labelConnected.AutoSize = true;
            this.labelConnected.Location = new System.Drawing.Point(57, 312);
            this.labelConnected.Name = "labelConnected";
            this.labelConnected.Size = new System.Drawing.Size(79, 13);
            this.labelConnected.TabIndex = 9;
            this.labelConnected.Text = "Not Connected";
            // 
            // listBoxCommands
            // 
            this.listBoxCommands.FormattingEnabled = true;
            this.listBoxCommands.Location = new System.Drawing.Point(231, 56);
            this.listBoxCommands.Name = "listBoxCommands";
            this.listBoxCommands.Size = new System.Drawing.Size(177, 251);
            this.listBoxCommands.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSonar
            // 
            this.btnSonar.Location = new System.Drawing.Point(84, 270);
            this.btnSonar.Name = "btnSonar";
            this.btnSonar.Size = new System.Drawing.Size(75, 23);
            this.btnSonar.TabIndex = 11;
            this.btnSonar.Text = "Sonar";
            this.btnSonar.UseVisualStyleBackColor = true;
            this.btnSonar.Click += new System.EventHandler(this.btnSonar_Click);
            // 
            // listBoxRecieved
            // 
            this.listBoxRecieved.FormattingEnabled = true;
            this.listBoxRecieved.Location = new System.Drawing.Point(426, 56);
            this.listBoxRecieved.Name = "listBoxRecieved";
            this.listBoxRecieved.Size = new System.Drawing.Size(160, 251);
            this.listBoxRecieved.TabIndex = 12;
            // 
            // labelSent
            // 
            this.labelSent.AutoSize = true;
            this.labelSent.Location = new System.Drawing.Point(228, 40);
            this.labelSent.Name = "labelSent";
            this.labelSent.Size = new System.Drawing.Size(29, 13);
            this.labelSent.TabIndex = 13;
            this.labelSent.Text = "Sent";
            // 
            // labelReceived
            // 
            this.labelReceived.AutoSize = true;
            this.labelReceived.Location = new System.Drawing.Point(426, 37);
            this.labelReceived.Name = "labelReceived";
            this.labelReceived.Size = new System.Drawing.Size(53, 13);
            this.labelReceived.TabIndex = 14;
            this.labelReceived.Text = "Received";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 360);
            this.Controls.Add(this.labelReceived);
            this.Controls.Add(this.labelSent);
            this.Controls.Add(this.listBoxRecieved);
            this.Controls.Add(this.btnSonar);
            this.Controls.Add(this.listBoxCommands);
            this.Controls.Add(this.labelConnected);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.labelXbox);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnForward);
            this.Name = "Form1";
            this.Text = "BWC Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelXbox;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label labelConnected;
        private System.Windows.Forms.ListBox listBoxCommands;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSonar;
        private System.Windows.Forms.ListBox listBoxRecieved;
        private System.Windows.Forms.Label labelSent;
        private System.Windows.Forms.Label labelReceived;
    }
}

