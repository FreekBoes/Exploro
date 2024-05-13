using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exploro_App.Gamemode_1
{
    public partial class Level3 : Form
    {
        public Level3()
        {
            InitializeComponent();
        }

        public Point mouselocation;
        int question = 0;
        int punten = 0;

        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (question == 0)
            {
                question = question + 1;
                if (checkLinks.Checked == true)
                {
                    MessageBox.Show("Juist");
                    punten = punten + 1;
                }
                else if (checkRechts.Checked == true)
                {
                    MessageBox.Show("Fout");
                }
                else
                {

                }
                picLeft.Image = Properties.Resources._32rechts;
                picRight.Image = Properties.Resources._22rechts;
                lblVraag.Text = "Welke foto speelt de grootste rol in de factor Natuurlijk?";
                checkLinks.Checked = false;
                checkRechts.Checked = false;

            }
            else if (question == 1)
            {
                question = question + 1;
                if (checkLinks.Checked == true)
                {
                    MessageBox.Show("Fout!");

                }
                else if (checkRechts.Checked == true)
                {
                    MessageBox.Show("Juist!");
                    punten = punten + 1;
                }
                else
                {
                    MessageBox.Show("Je hebt geen antwoord ingegeven dus krijg je geen punten.");
                }
                picLeft.Image = Properties.Resources._33links;
                picRight.Image = Properties.Resources._24links;
                lblVraag.Text = "Welke foto speelt de grootste rol in de factor Sociaal-Economisch?";
                checkLinks.Checked = false;
                checkRechts.Checked = false;
            }
            else if (question == 2)
            {
                question = question + 1;
                if (checkLinks.Checked == true)
                {
                    MessageBox.Show("Juist");
                    punten = punten + 1;
                }
                else if (checkRechts.Checked == true)
                {
                    MessageBox.Show("Fout");
                }
                else
                {
                    MessageBox.Show("Je hebt geen antwoord ingegeven dus krijg je geen punten.");
                }
                picLeft.Image = Properties.Resources._12links;
                picRight.Image = Properties.Resources._34rechts;
                lblVraag.Text = "Welke foto speelt de grootste rol in de factor Natuurlijk?";
                checkLinks.Checked = false;
                checkRechts.Checked = false;
            }
            else if (question == 3)
            {
                question = question + 1;
                if (checkLinks.Checked == true)
                {
                    MessageBox.Show("Fout!");

                }
                else if (checkRechts.Checked == true)
                {
                    MessageBox.Show("Juist!");
                    punten = punten + 1;
                }
                else
                {
                    MessageBox.Show("Je hebt geen antwoord ingegeven dus krijg je geen punten.");
                }
                picLeft.Image = Properties.Resources._35links;
                picRight.Image = Properties.Resources._25links;
                lblVraag.Text = "Welke foto speelt de grootste rol in de factor Cultuur?";
                checkLinks.Checked = false;
                checkRechts.Checked = false;
            }
            else if (question == 4)
            {
                question = question + 1;
                if (checkLinks.Checked == true)
                {
                    MessageBox.Show("Juist");
                    punten = punten + 1;
                }
                else if (checkRechts.Checked == true)
                {
                    MessageBox.Show("Fout");
                }
                else
                {
                    MessageBox.Show("Je hebt geen antwoord ingegeven dus krijg je geen punten.");
                }
                MessageBox.Show("Je hebt " + Convert.ToString(punten) + " van de 5 vragen juist");
                this.Close();
            }

        }
    }
}
