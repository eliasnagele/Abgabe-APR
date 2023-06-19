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
    public partial class Calendar : Form
    {
        public DataTable dt = new DataTable();
        public static int nextRaceNumber;

        public Calendar()
        {
            InitializeComponent();

            dtv_Calendar.Visible = false;
            bt_CalendarSave.Visible = false;

            if (Login.userisadmin.Equals(true))         //if user is admin datagridview is shown
            {
                dtv_Calendar.Visible = true;
                bt_CalendarSave.Visible = true;
                lb_AdminInfoCalendar.Visible = true;
                dtv_Calendar.AllowUserToDeleteRows = false;
            }

            SQLCommunication.GetMinMaxRaceID();
            nextRaceNumber = SQLCommunication.nextRaceID;       //get next ID from next race
            SQLCommunication.CalendarInfo(nextRaceNumber);

            tb_CalendarCountry.Text = SQLCommunication.country;     //fill the textboxes with the data of the upcoming race
            tb_CalendarRaceName.Text = SQLCommunication.name;
            tb_CalendarDate.Text = SQLCommunication.fromDate.Day + "." + SQLCommunication.fromDate.Month + "." + SQLCommunication.fromDate.Year + "  -  " + SQLCommunication.toDate.Day + "." + SQLCommunication.toDate.Month + "." + SQLCommunication.toDate.Year;

            dt = SQLCommunication.DataGridView(Home.tablename);     //save data to a datatable
            dtv_Calendar.DataSource = dt;
        }

        private void bt_latest_Click(object sender, EventArgs e)
        {
            if (nextRaceNumber > SQLCommunication.minRaceID)        //check if nextRaceNumber is bigger than minRaceID
                nextRaceNumber--;

            SQLCommunication.CalendarInfo(nextRaceNumber);          //open CalendarInfo with the ID of the latest race
            tb_CalendarCountry.Text = SQLCommunication.country;
            tb_CalendarRaceName.Text = SQLCommunication.name;
            tb_CalendarDate.Text = SQLCommunication.fromDate.Day + "." + SQLCommunication.fromDate.Month + "." + SQLCommunication.fromDate.Year + "  -  " + SQLCommunication.toDate.Day + "." + SQLCommunication.toDate.Month + "." + SQLCommunication.toDate.Year;
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            if (nextRaceNumber < SQLCommunication.maxRaceID)        //check if nextRaceNumber is smaller than maxRaceID
                nextRaceNumber++;

            SQLCommunication.CalendarInfo(nextRaceNumber);          //open CalendarInfo with the ID of the next race
            tb_CalendarCountry.Text = SQLCommunication.country;
            tb_CalendarRaceName.Text = SQLCommunication.name;
            tb_CalendarDate.Text = SQLCommunication.fromDate.Day + "." + SQLCommunication.fromDate.Month + "." + SQLCommunication.fromDate.Year + "  -  " + SQLCommunication.toDate.Day + "." + SQLCommunication.toDate.Month + "." + SQLCommunication.toDate.Year;
        }

        private void bt_CalendarSave_Click(object sender, EventArgs e)      //save changes made to the datagridview
        {
            SQLCommunication.SaveChanges();
            MessageBox.Show("Calendar updated successfully");
        }

        private void bt_CloseCalendar_Click(object sender, EventArgs e)     //close the hole application
        {
            Environment.Exit(0);
        }

        private void bt_ReturnCalendar_Click(object sender, EventArgs e)    //return to form "Home"
        {
            this.Hide();
        }
    }
}
