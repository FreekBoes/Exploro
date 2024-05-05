using Exploro_App.Gamemode_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exploro_App
{
    public partial class Level_Gamode_2_level : Form
    {
        public Point mouselocation;
        private Constructor constructor;
        public Level_Gamode_2_level(Constructor constructor)
        {
            this.constructor = constructor;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Close(object sender, EventArgs e)
        {

            //om de applicatie te sluiten
            Close();
            Application.Exit();
        }

        private void Minimize(object sender, EventArgs e)
        {
            //dit dient voor de window te minimizen
            WindowState = FormWindowState.Minimized;
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            mouselocation = new Point(-e.X, -e.Y);
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouselocation.X, mouselocation.Y);
                Location = mousePose;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnlevel1_Click(object sender, EventArgs e)
        {
            this.Close();
            Level1 level1 = new Level1(constructor);
            level1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form = new Form2(constructor);
            form.Show();
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            this.Close();
            Level2 level2 = new Level2(constructor);
            level2.Show();
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            this.Close();
            Level3 level3 = new Level3(constructor);
            level3.Show();
        }

        private void btnLevel4_Click(object sender, EventArgs e)
        {
            this.Close();
            level4 level4 = new level4(constructor);
            level4.Show();
        }

        private void btnLevel5_Click(object sender, EventArgs e)
        {
            this.Close();
            level5 level5 = new level5(constructor);
            level5.Show();
        }
    }
}
