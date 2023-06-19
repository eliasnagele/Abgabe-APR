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
    public partial class Data : Form
    {
        public DataTable dt = new DataTable();

        public Data()
        {
            InitializeComponent();

            dtv_Data.ReadOnly = true;
            bt_SaveData.Visible = false;

            if (Login.userisadmin.Equals(true))        //checking if user is logged in
            {
                dtv_Data.ReadOnly = false;
                bt_SaveData.Visible = true;
            }

            dt = SQLCommunication.DataGridView(Home.tablename);         //saving the datatable, which is returned by the method "DataGridView", to dt

            dtv_Data.DataSource = dt;       //changing the datasource for "dtv_Data"

        }

        private void bt_CloseData_Click(object sender, EventArgs e)     //closing the application
        {
            Environment.Exit(0);                
        }

        private void bt_ReturnData_Click(object sender, EventArgs e)    //return to form "Home"
        {
            this.Hide();
        }

        private void bt_SaveData_Click(object sender, EventArgs e)
        {
            SQLCommunication.SaveChanges();                             //calling method "SaveChanges" which updates the datatable
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            string searchtext = tb_Search.Text;         //save the users search-text to a variable

            dt = SQLCommunication.DataSearch(Home.tablename, searchtext);       //open the method DataSearch which searches for data which contains the search-text
            dtv_Data.DataSource = dt;
        }
    }
}
