﻿namespace Exploro_App.Gamemode_1
{
    partial class Level2
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
            this.picRight = new System.Windows.Forms.PictureBox();
            this.picLeft = new System.Windows.Forms.PictureBox();
            this.checkRechts = new System.Windows.Forms.CheckBox();
            this.checkLinks = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblVraag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // picRight
            // 
            this.picRight.Image = global::Exploro_App.Properties.Resources._35links;
            this.picRight.Location = new System.Drawing.Point(397, 122);
            this.picRight.Name = "picRight";
            this.picRight.Size = new System.Drawing.Size(280, 169);
            this.picRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRight.TabIndex = 50;
            this.picRight.TabStop = false;
            this.picRight.Click += new System.EventHandler(this.picRight_Click);
            this.picRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.picRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // picLeft
            // 
            this.picLeft.Image = global::Exploro_App.Properties.Resources._21links;
            this.picLeft.Location = new System.Drawing.Point(14, 122);
            this.picLeft.Name = "picLeft";
            this.picLeft.Size = new System.Drawing.Size(280, 169);
            this.picLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLeft.TabIndex = 49;
            this.picLeft.TabStop = false;
            this.picLeft.Click += new System.EventHandler(this.picLeft_Click);
            this.picLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.picLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // checkRechts
            // 
            this.checkRechts.AutoSize = true;
            this.checkRechts.Location = new System.Drawing.Point(518, 312);
            this.checkRechts.Name = "checkRechts";
            this.checkRechts.Size = new System.Drawing.Size(60, 17);
            this.checkRechts.TabIndex = 48;
            this.checkRechts.Text = "Rechts";
            this.checkRechts.UseVisualStyleBackColor = true;
            this.checkRechts.CheckedChanged += new System.EventHandler(this.checkRechts_CheckedChanged);
            this.checkRechts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.checkRechts.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // checkLinks
            // 
            this.checkLinks.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.checkLinks.AutoSize = true;
            this.checkLinks.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkLinks.Location = new System.Drawing.Point(104, 312);
            this.checkLinks.Name = "checkLinks";
            this.checkLinks.Size = new System.Drawing.Size(57, 18);
            this.checkLinks.TabIndex = 47;
            this.checkLinks.Text = "Links";
            this.checkLinks.UseVisualStyleBackColor = true;
            this.checkLinks.CheckedChanged += new System.EventHandler(this.checkLinks_CheckedChanged);
            this.checkLinks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.checkLinks.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(699, 25);
            this.panel3.TabIndex = 43;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Exploro_App.Properties.Resources.minus;
            this.pictureBox5.Location = new System.Drawing.Point(655, 2);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 21);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Exploro_App.Properties.Resources.kruisje;
            this.pictureBox4.Location = new System.Drawing.Point(677, 2);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(19, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(206)))), ((int)(((byte)(217)))));
            this.btnCheck.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(218, 354);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(247, 34);
            this.btnCheck.TabIndex = 46;
            this.btnCheck.Text = "Controleer";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.btnCheck.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // lblVraag
            // 
            this.lblVraag.AutoSize = true;
            this.lblVraag.Font = new System.Drawing.Font("Bauhaus 93", 17F);
            this.lblVraag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(206)))), ((int)(((byte)(217)))));
            this.lblVraag.Location = new System.Drawing.Point(7, 79);
            this.lblVraag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVraag.Name = "lblVraag";
            this.lblVraag.Size = new System.Drawing.Size(591, 26);
            this.lblVraag.TabIndex = 45;
            this.lblVraag.Text = "Welke foto speelt de grootste rol in de factor Natuurlijk?";
            this.lblVraag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVraag.Click += new System.EventHandler(this.lblVraag_Click);
            this.lblVraag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.lblVraag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(206)))), ((int)(((byte)(217)))));
            this.label1.Location = new System.Drawing.Point(183, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 36);
            this.label1.TabIndex = 44;
            this.label1.Text = "Gamemode 1 - Level 2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 396);
            this.Controls.Add(this.picRight);
            this.Controls.Add(this.picLeft);
            this.Controls.Add(this.checkRechts);
            this.Controls.Add(this.checkLinks);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblVraag);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Level2";
            this.Text = "Level2";
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRight;
        private System.Windows.Forms.PictureBox picLeft;
        private System.Windows.Forms.CheckBox checkRechts;
        private System.Windows.Forms.CheckBox checkLinks;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblVraag;
        private System.Windows.Forms.Label label1;
    }
}