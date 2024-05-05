using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using BCrypt.Net;


namespace Exploro_App
{
    public partial class Login : Form
    {
        string server = "localhost";
        string uid = "root";
        string password = "1234";
        string database = "exploro";
        


        public Point mouselocation;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void exit(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://youtu.be/xvFZjo5PgG0?si=qZYwZ1Dgqiw_5IYS");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouselocation = new Point(-e.X, -e.Y); 
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouselocation.X, mouselocation.Y);
                Location = mousePose;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            string constring = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection connection = new MySqlConnection(constring);
            connection.Open();
            string query_email = "SELECT eMail,password FROM exploro.users WHERE eMail = @email;";
            MySqlCommand cmd = new MySqlCommand(query_email,connection);
            cmd.Parameters.AddWithValue("@email", txtUserName.Text);

            MySqlDataReader datareader = cmd.ExecuteReader();

            if (datareader.Read())
            {
                string hashedPassword = Convert.ToString(datareader["password"]);
                if (BCrypt.Net.BCrypt.Verify(txtPassword.Text, hashedPassword))
                {
                    Form2 form = new Form2();
                    form.Show();
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Verkeerd wachtwoord of email address","FOUT WACHTWOORD");
                }
            }
            else
            {
                MessageBox.Show("Email bestaat niet", "FOUT EMAIL");
            }
            connection.Close();
        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pictureBox7.Visible = true;
            pictureBox6.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = true;
        }
    }
}
