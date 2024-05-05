using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exploro_App.Gamemode_2
{
    public partial class Level3 : Form
    {
        public Point mouselocation;
        private Constructor constructor;
        public Level3(Constructor constructor)
        {
            this.constructor = constructor;
            InitializeComponent();
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

        private void Level3_Load(object sender, EventArgs e)
        {

        }

        public void connection()
        {
            Constructor construcor = new Constructor();
            string server = "localhost";
            string uid = "root";
            string password = "1234";
            string database = "exploro";
            string VarEmail = "";

            string constring = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;

            MySqlConnection connection = new MySqlConnection(constring);
            connection.Open();

            VarEmail = constructor.emailDoorgeven();

            // Disable SQL_SAFE_UPDATES
            string query_disable_safe_updates = "SET SQL_SAFE_UPDATES = 0";
            MySqlCommand cmd_disable_safe_updates = new MySqlCommand(query_disable_safe_updates, connection);
            cmd_disable_safe_updates.ExecuteNonQuery();

            // Perform the UPDATE operation
            string query_email = "UPDATE exploro.scores " +
                                      "INNER JOIN exploro.users ON scores.userId = users.userId " +
                                      "SET scores.scores = scores.scores + 1 " +
                                      "WHERE users.eMail = '" + VarEmail + "'";
            MySqlCommand cmd = new MySqlCommand(query_email, connection);
            cmd.ExecuteNonQuery();

            // Enable SQL_SAFE_UPDATES
            string query_enable_safe_updates = "SET SQL_SAFE_UPDATES = 1";
            MySqlCommand cmd_enable_safe_updates = new MySqlCommand(query_enable_safe_updates, connection);
            cmd_enable_safe_updates.ExecuteNonQuery();
            connection.Close();

        }

        private void btnSociaalEconomisch_Click(object sender, EventArgs e)
        {
            connection();

            DialogResult knop_messagebox = MessageBox.Show("Correct!", "resulaat", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (knop_messagebox == DialogResult.OK || knop_messagebox == DialogResult.Cancel)
            {
                this.Close();
                Level_Gamode_2_level level_Gamode_2_Level = new Level_Gamode_2_level(constructor);
                level_Gamode_2_Level.Show();
            }
        }

        private void btnNatuurlijk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dit is het verkeerde antwoord, probeer opnieuw!", "FOUT ANTWOORD", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
        }

        private void btnCultureel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dit is het verkeerde antwoord, probeer opnieuw!", "FOUT ANTWOORD", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

        }
    }
}
