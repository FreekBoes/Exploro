namespace Exploro_App.Gamemode_1
{
    partial class Level_3
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblVraag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkLinks = new System.Windows.Forms.CheckBox();
            this.checkRechts = new System.Windows.Forms.CheckBox();
            this.picRight = new System.Windows.Forms.PictureBox();
            this.picLeft = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1050, 38);
            this.panel3.TabIndex = 31;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Exploro_App.Properties.Resources.minus;
            this.pictureBox5.Location = new System.Drawing.Point(982, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Exploro_App.Properties.Resources.kruisje;
            this.pictureBox4.Location = new System.Drawing.Point(1016, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(206)))), ((int)(((byte)(217)))));
            this.btnCheck.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(333, 542);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(370, 52);
            this.btnCheck.TabIndex = 38;
            this.btnCheck.Text = "Controleer";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblVraag
            // 
            this.lblVraag.AutoSize = true;
            this.lblVraag.Font = new System.Drawing.Font("Bauhaus 93", 17F);
            this.lblVraag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(206)))), ((int)(((byte)(217)))));
            this.lblVraag.Location = new System.Drawing.Point(16, 118);
            this.lblVraag.Name = "lblVraag";
            this.lblVraag.Size = new System.Drawing.Size(1018, 39);
            this.lblVraag.TabIndex = 34;
            this.lblVraag.Text = "Welke foto speelt de grootste rol in de factor Sociaal-Economisch?";
            this.lblVraag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(206)))), ((int)(((byte)(217)))));
            this.label1.Location = new System.Drawing.Point(280, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 54);
            this.label1.TabIndex = 32;
            this.label1.Text = "Gamemode 1 - Level 1";
            // 
            // checkLinks
            // 
            this.checkLinks.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.checkLinks.AutoSize = true;
            this.checkLinks.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkLinks.Location = new System.Drawing.Point(162, 477);
            this.checkLinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkLinks.Name = "checkLinks";
            this.checkLinks.Size = new System.Drawing.Size(84, 25);
            this.checkLinks.TabIndex = 39;
            this.checkLinks.Text = "Links";
            this.checkLinks.UseVisualStyleBackColor = true;
            // 
            // checkRechts
            // 
            this.checkRechts.AutoSize = true;
            this.checkRechts.Location = new System.Drawing.Point(783, 477);
            this.checkRechts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkRechts.Name = "checkRechts";
            this.checkRechts.Size = new System.Drawing.Size(86, 24);
            this.checkRechts.TabIndex = 40;
            this.checkRechts.Text = "Rechts";
            this.checkRechts.UseVisualStyleBackColor = true;
            // 
            // picRight
            // 
            this.picRight.Image = global::Exploro_App.Properties.Resources._21links;
            this.picRight.Location = new System.Drawing.Point(602, 185);
            this.picRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picRight.Name = "picRight";
            this.picRight.Size = new System.Drawing.Size(420, 260);
            this.picRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRight.TabIndex = 42;
            this.picRight.TabStop = false;
            // 
            // picLeft
            // 
            this.picLeft.Image = global::Exploro_App.Properties.Resources._11links;
            this.picLeft.Location = new System.Drawing.Point(27, 185);
            this.picLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLeft.Name = "picLeft";
            this.picLeft.Size = new System.Drawing.Size(420, 260);
            this.picLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLeft.TabIndex = 41;
            this.picLeft.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exploro_App.Properties.Resources.arrow_left1;
            this.pictureBox1.Location = new System.Drawing.Point(230, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Back);
            // 
            // Level_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 612);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picRight);
            this.Controls.Add(this.picLeft);
            this.Controls.Add(this.checkRechts);
            this.Controls.Add(this.checkLinks);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblVraag);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Level_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level_3";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblVraag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkLinks;
        private System.Windows.Forms.CheckBox checkRechts;
        private System.Windows.Forms.PictureBox picLeft;
        private System.Windows.Forms.PictureBox picRight;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}