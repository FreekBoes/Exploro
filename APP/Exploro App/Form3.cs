using Exploro_App.Gamemode_1;
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
    public partial class Form3 : Form
    {
        private Constructor constructor;
        public Point mouselocation;
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //om de applicatie te sluiten
            Close();
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
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

        private void btnlevel1_Click(object sender, EventArgs e)
        {
            Level_3 level1 = new Level_3();
            level1.Show();
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            Level2 level2 = new Level2();
            level2.Show();
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            Level3 level3 = new Level3();
            level3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form = new Form2(constructor);
            form.Show();
        }
    }
}
