using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nagele_Jahresprojekt
{
    public partial class Home : Form
    {
        public static string tablename = "default";     //create the variable 'tablename' and set it to "default"

        public Home()
        {
            InitializeComponent();

            SQLCommunication.CreateDatabase();          //open methiod 'CreateDatabase' which checks if database already exists; if not database and tables will be created
        }


        private void bt_CloseMenu_Click(object sender, EventArgs e)     //close the application
        {
            Environment.Exit(0);
        }

        private void bt_Drivers_Click(object sender, EventArgs e)       //open form drivers and change tablename to "drivers"
        {
            tablename = "drivers";

            this.Hide();
            Data data = new Data();
            data.ShowDialog();
            this.Show();
        }

        private void bt_Teams_Click(object sender, EventArgs e)         //open form teams and change tablename to "teams"
        {
            tablename = "teams";

            this.Hide();
            Data data = new Data();
            data.ShowDialog();
            this.Show();
        }

        private void bt_Tracks_Click(object sender, EventArgs e)        //open form tracks and change tablename to "tracks"
        {
            tablename = "tracks";

            this.Hide();
            Data data = new Data();
            data.ShowDialog();
            this.Show();
        }

        private void bt_RaceResults_Click(object sender, EventArgs e)   //open form raceresults and change tablename to "raceresults"
        {
            tablename = "raceresults";

            this.Hide();
            Data data = new Data();
            data.ShowDialog();
            this.Show();
        }

        private void bt_ChampionshipResults_Click(object sender, EventArgs e)       //open form championshipresults and change tablename to "championshipresults"
        {
            tablename = "championshipresults";

            this.Hide();
            Data data = new Data();
            data.ShowDialog();
            this.Show();
        }

        private void bt_News_Click(object sender, EventArgs e)      //open form news and change tablename to "news"
        {
            tablename = "news";

            this.Hide();
            Data data = new Data();
            data.ShowDialog();
            this.Show();
        }

        private void bt_Calendar_Click(object sender, EventArgs e)      //open form calendar and change tablename to "calendar"
        {
            tablename = "calendar";

            this.Hide();
            Calendar calendar = new Calendar();
            calendar.ShowDialog();
            this.Show();
        }

        private void bt_LoginRegister_Click(object sender, EventArgs e)     //open form Login
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Show();
        }
    }
}
