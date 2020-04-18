﻿namespace IE322_App_KAU
{
    partial class frmMain
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
            this.btnRadio = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.lblPW = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnPic2 = new System.Windows.Forms.Button();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.LnkForgot = new System.Windows.Forms.LinkLabel();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.BtnMethods = new System.Windows.Forms.Button();
            this.BtnArray = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StsMain = new System.Windows.Forms.StatusStrip();
            this.grpLogin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRadio
            // 
            this.btnRadio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRadio.Location = new System.Drawing.Point(12, 22);
            this.btnRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(100, 28);
            this.btnRadio.TabIndex = 0;
            this.btnRadio.Text = "Radio";
            this.btnRadio.UseVisualStyleBackColor = true;
            this.btnRadio.Click += new System.EventHandler(this.btnRadio_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(11, 43);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(95, 34);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(132, 22);
            this.txtUser.TabIndex = 2;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.MouseLeave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(95, 84);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(132, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPW_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPW_Leave);
            // 
            // btnCheck
            // 
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheck.Location = new System.Drawing.Point(120, 22);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 28);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "CheckBox";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCombo.Location = new System.Drawing.Point(72, 62);
            this.btnCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(100, 28);
            this.btnCombo.TabIndex = 5;
            this.btnCombo.Text = "Combo";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btnPic
            // 
            this.btnPic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPic.Location = new System.Drawing.Point(12, 69);
            this.btnPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(100, 28);
            this.btnPic.TabIndex = 6;
            this.btnPic.Text = "PictureBox";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.BackColor = System.Drawing.Color.HotPink;
            this.btnEXIT.Location = new System.Drawing.Point(3, 374);
            this.btnEXIT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(257, 102);
            this.btnEXIT.TabIndex = 8;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = false;
            this.btnEXIT.Click += new System.EventHandler(this.BtnEXIT_Click);
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(11, 87);
            this.lblPW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(69, 17);
            this.lblPW.TabIndex = 9;
            this.lblPW.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(121, 121);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnPic2
            // 
            this.btnPic2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPic2.Location = new System.Drawing.Point(187, 69);
            this.btnPic2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPic2.Name = "btnPic2";
            this.btnPic2.Size = new System.Drawing.Size(100, 28);
            this.btnPic2.TabIndex = 11;
            this.btnPic2.Text = "PictureBox2";
            this.btnPic2.UseVisualStyleBackColor = true;
            this.btnPic2.Click += new System.EventHandler(this.btnPic2_Click);
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.LnkForgot);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.lblPW);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.txtUser);
            this.grpLogin.Controls.Add(this.lblUsername);
            this.grpLogin.Controls.Add(this.BtnAbout);
            this.grpLogin.Location = new System.Drawing.Point(3, 16);
            this.grpLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpLogin.Size = new System.Drawing.Size(257, 177);
            this.grpLogin.TabIndex = 12;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login to IE322";
            // 
            // LnkForgot
            // 
            this.LnkForgot.Location = new System.Drawing.Point(0, 0);
            this.LnkForgot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LnkForgot.Name = "LnkForgot";
            this.LnkForgot.Size = new System.Drawing.Size(133, 28);
            this.LnkForgot.TabIndex = 0;
            // 
            // BtnAbout
            // 
            this.BtnAbout.Location = new System.Drawing.Point(0, 0);
            this.BtnAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(100, 28);
            this.BtnAbout.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox10);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(268, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1095, 465);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox10.Controls.Add(this.BtnMethods);
            this.groupBox10.Controls.Add(this.BtnArray);
            this.groupBox10.Location = new System.Drawing.Point(466, 305);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox10.Size = new System.Drawing.Size(244, 118);
            this.groupBox10.TabIndex = 32;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Object Oriented";
            // 
            // BtnMethods
            // 
            this.BtnMethods.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMethods.Location = new System.Drawing.Point(24, 23);
            this.BtnMethods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMethods.Name = "BtnMethods";
            this.BtnMethods.Size = new System.Drawing.Size(196, 28);
            this.BtnMethods.TabIndex = 30;
            this.BtnMethods.Text = "Methods";
            this.BtnMethods.UseVisualStyleBackColor = false;
            this.BtnMethods.Click += new System.EventHandler(this.BtnMethods_Click);
            // 
            // BtnArray
            // 
            this.BtnArray.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnArray.Location = new System.Drawing.Point(21, 58);
            this.BtnArray.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnArray.Name = "BtnArray";
            this.BtnArray.Size = new System.Drawing.Size(199, 48);
            this.BtnArray.TabIndex = 29;
            this.BtnArray.Text = "Arrays";
            this.BtnArray.UseVisualStyleBackColor = false;
            this.BtnArray.Click += new System.EventHandler(this.BtnArray_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Controls.Add(this.btnRandom);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Location = new System.Drawing.Point(7, 285);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(313, 138);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "More Controls";
            // 
            // btnRandom
            // 
            this.btnRandom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRandom.Location = new System.Drawing.Point(12, 59);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(100, 28);
            this.btnRandom.TabIndex = 15;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(187, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 21;
            this.button1.Text = "RandomCombo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnRandomCombo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.btnPic);
            this.groupBox3.Controls.Add(this.btnPic2);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(7, 52);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(313, 154);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphical";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.btnRadio);
            this.groupBox2.Controls.Add(this.btnCheck);
            this.groupBox2.Controls.Add(this.btnCombo);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(466, 83);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(244, 94);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Controls";
            // 
            // StsMain
            // 
            this.StsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StsMain.Location = new System.Drawing.Point(0, 489);
            this.StsMain.Name = "StsMain";
            this.StsMain.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StsMain.Size = new System.Drawing.Size(1016, 22);
            this.StsMain.TabIndex = 16;
            this.StsMain.Text = "Dr. Atif Shahzad";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 511);
            this.Controls.Add(this.StsMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.btnEXIT);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Yahya Labwork";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRadio;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnPic2;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.StatusStrip StsMain;
        private System.Windows.Forms.LinkLabel LnkForgot;
        private System.Windows.Forms.Button BtnMethods;
        private System.Windows.Forms.Button BtnArray;
        private System.Windows.Forms.GroupBox groupBox10;
    }
}