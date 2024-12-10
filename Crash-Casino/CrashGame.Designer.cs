namespace Crash_Hack
{
    partial class CrashGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrashGame));
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.LGSText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PNText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CGText = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkInfo = new Guna.UI2.WinForms.Guna2Button();
            this.startBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TimerTick = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.chnglbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.StartGame = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.info2 = new System.Windows.Forms.PictureBox();
            this.info3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(199, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "CRASH Predictor";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(608, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(559, 1);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 4;
            // 
            // LGSText
            // 
            this.LGSText.BorderRadius = 12;
            this.LGSText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LGSText.DefaultText = "";
            this.LGSText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LGSText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LGSText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LGSText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LGSText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LGSText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LGSText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LGSText.Location = new System.Drawing.Point(163, 182);
            this.LGSText.Name = "LGSText";
            this.LGSText.PasswordChar = '\0';
            this.LGSText.PlaceholderText = "0000000000000000001b34dc6a1e86083f95500b096231436e9b25cbdd0075c4";
            this.LGSText.SelectedText = "";
            this.LGSText.Size = new System.Drawing.Size(200, 30);
            this.LGSText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(158, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Game Seed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(158, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hash";
            // 
            // PNText
            // 
            this.PNText.BorderRadius = 12;
            this.PNText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PNText.DefaultText = "";
            this.PNText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PNText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PNText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PNText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNText.Location = new System.Drawing.Point(163, 256);
            this.PNText.Name = "PNText";
            this.PNText.PasswordChar = '\0';
            this.PNText.PlaceholderText = "daf906d98c3253d073f12a3a4ce7791971f02eee314d22832787258c6087269e";
            this.PNText.SelectedText = "";
            this.PNText.Size = new System.Drawing.Size(200, 30);
            this.PNText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(158, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Crash Last Game ID";
            // 
            // CGText
            // 
            this.CGText.BorderRadius = 12;
            this.CGText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CGText.DefaultText = "";
            this.CGText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CGText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CGText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CGText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CGText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CGText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CGText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CGText.Location = new System.Drawing.Point(163, 334);
            this.CGText.Name = "CGText";
            this.CGText.PasswordChar = '\0';
            this.CGText.PlaceholderText = "0000d000-0000-0000-0000-000000000000";
            this.CGText.SelectedText = "";
            this.CGText.Size = new System.Drawing.Size(200, 30);
            this.CGText.TabIndex = 9;
            // 
            // chkInfo
            // 
            this.chkInfo.BorderRadius = 12;
            this.chkInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.chkInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.chkInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.chkInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.chkInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkInfo.ForeColor = System.Drawing.Color.White;
            this.chkInfo.Location = new System.Drawing.Point(163, 390);
            this.chkInfo.Name = "chkInfo";
            this.chkInfo.Size = new System.Drawing.Size(200, 30);
            this.chkInfo.TabIndex = 11;
            this.chkInfo.Text = "Check Information";
            this.chkInfo.Click += new System.EventHandler(this.chkInfo_Click);
            // 
            // startBtn
            // 
            this.startBtn.BorderRadius = 12;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.startBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.startBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.startBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(386, 390);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(113, 30);
            this.startBtn.TabIndex = 12;
            this.startBtn.Text = "Start";
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // TimerTick
            // 
            this.TimerTick.Tick += new System.EventHandler(this.TimerTick_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(399, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Luck Rate";
            // 
            // chnglbl
            // 
            this.chnglbl.AutoSize = true;
            this.chnglbl.Cursor = System.Windows.Forms.Cursors.No;
            this.chnglbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chnglbl.ForeColor = System.Drawing.Color.White;
            this.chnglbl.Location = new System.Drawing.Point(415, 284);
            this.chnglbl.Name = "chnglbl";
            this.chnglbl.Size = new System.Drawing.Size(55, 21);
            this.chnglbl.TabIndex = 14;
            this.chnglbl.Text = "0.00%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.No;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(416, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 21);
            this.label11.TabIndex = 16;
            this.label11.Text = "0.00X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.No;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(399, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 21);
            this.label12.TabIndex = 15;
            this.label12.Text = "Prediction";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 544);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(224, 19);
            this.guna2HtmlLabel1.TabIndex = 17;
            this.guna2HtmlLabel1.Text = "Crash Predictor. All Rights Reserved";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartGame
            // 
            this.StartGame.BorderRadius = 12;
            this.StartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartGame.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StartGame.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartGame.ForeColor = System.Drawing.Color.White;
            this.StartGame.Location = new System.Drawing.Point(378, 200);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(130, 30);
            this.StartGame.TabIndex = 18;
            this.StartGame.Text = "Start Crash Game";
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // info
            // 
            this.info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.info.Cursor = System.Windows.Forms.Cursors.Help;
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.Location = new System.Drawing.Point(291, 154);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(20, 20);
            this.info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info.TabIndex = 19;
            this.info.TabStop = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(616, 544);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(488, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Network Status";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // info2
            // 
            this.info2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.info2.Cursor = System.Windows.Forms.Cursors.Help;
            this.info2.Image = ((System.Drawing.Image)(resources.GetObject("info2.Image")));
            this.info2.Location = new System.Drawing.Point(209, 228);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(20, 20);
            this.info2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info2.TabIndex = 22;
            this.info2.TabStop = false;
            this.info2.Click += new System.EventHandler(this.info2_Click);
            // 
            // info3
            // 
            this.info3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.info3.Cursor = System.Windows.Forms.Cursors.Help;
            this.info3.Image = ((System.Drawing.Image)(resources.GetObject("info3.Image")));
            this.info3.Location = new System.Drawing.Point(317, 306);
            this.info3.Name = "info3";
            this.info3.Size = new System.Drawing.Size(20, 20);
            this.info3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info3.TabIndex = 23;
            this.info3.TabStop = false;
            this.info3.Click += new System.EventHandler(this.info3_Click);
            // 
            // CrashGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(655, 575);
            this.Controls.Add(this.info3);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.info);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chnglbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.chkInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CGText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PNText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LGSText);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CrashGame";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox LGSText;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox CGText;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox PNText;
        private Guna.UI2.WinForms.Guna2Button chkInfo;
        private Guna.UI2.WinForms.Guna2Button startBtn;
        private System.Windows.Forms.Timer TimerTick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label chnglbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button StartGame;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox info;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox info3;
        public System.Windows.Forms.PictureBox info2;
    }
}

