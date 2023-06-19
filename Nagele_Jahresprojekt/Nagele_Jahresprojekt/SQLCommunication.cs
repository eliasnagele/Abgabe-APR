using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nagele_Jahresprojekt
{
    internal class SQLCommunication
    {
        public static SqlConnection conn = new SqlConnection(@"server = (localdb)\MSSQLLocalDB; Integrated Security = true;");  //creating new SQLConnection
        public static SqlCommand cmd = new SqlCommand("", conn);
        public static DataTable dt = new DataTable();
        public static int minRaceID, maxRaceID, nextRaceID;
        public static string country, name;
        public static DateTime fromDate, toDate;


        public static void CreateDatabase()
        {
            try
            {
                conn.Open();
                cmd.CommandText = "SELECT COUNT(*) from sys.databases where name = 'f1facts';";    //check if db exists
                bool exists = cmd.ExecuteScalar().ToString().Equals("0") ? false : true;
                conn.Close();

                if (!exists)
                {
                    conn.Open();

                    cmd.CommandText = "CREATE DATABASE f1facts;";   //create db
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    conn.ConnectionString += " database = f1facts;";    //changing the database to 'f1facts'

                    conn.Open();
                    cmd.CommandText = "create table login(ID int not null primary key identity, username nvarchar(50), password nvarchar(200), isAdmin tinyint);";    //create table 'login'
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "create table drivers(ID int not null primary key identity, Name nvarchar(100), Birthday nvarchar(50)," +     //create table 'driver'
                        " Country nvarchar(100), WDC tinyint, wins smallint, podiums smallint, fastestlaps smallint, lapsled smallint," +
                        " racestarts smallint, firstrace nvarchar(100), lastrace nvarchar(100))";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "create table teams(ID int not null primary key identity, Name nvarchar(100), Founded_In int, Country nvarchar(100), WCC int, Team_Principal nvarchar(100));";        //create table 'teams'
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "create table tracks(ID int not null primary key identity, Name nvarchar(100), Country nvarchar(100), First_GP date, GPs_hosted int);";       //create table 'tracks'
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "create table raceresults(ID int not null primary key identity, Location nvarchar(100), Date date, Winner nvarchar(100), second_place nvarchar(100), third_place nvarchar(100));";        //create table 'raceresults'
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "create table championshipresults(ID int not null primary key identity, Year date, Winner nvarchar(100), Points_1 int, second_place nvarchar(100), Points_2 int, third_place nvarchar(100), Points_3 int);";  //create table 'championshipresults'
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "create table news(ID int not null primary key identity, Date date, Headline nvarchar(200), Text text);";         //create table 'news'
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "create table calendar(ID int not null primary key identity, RaceID int, Country nvarchar(100), Name nvarchar(500), From_Date date, To_Date date);";
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    DemonstrateData();
                }
                else
                {
                    conn.ConnectionString += " database = f1facts;";        //changing the database to 'f1facts'
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }        //check if database exists; if it doesn`t the database and all tables will be created
               
        public static DataTable DataGridView(string tablename)
        {
            try
            {
                conn.Open();
                dt.Clear();     //clearing the datatable
                dt.Columns.Clear();
                cmd.CommandText = "select * from " + tablename;      //selecting the data from the table
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                conn.Close();
                return dt;          //returning dt
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return dt;
            }
        }       //fill a DataTable with the information of a table

        public static DataTable DataSearch(string tablename, string searchText)
        {
            try
            {
                conn.Open();
                SqlDataReader reader;       //create a new reader

                dt.Clear();
                dt.Columns.Clear();         //clear datatable

                switch (tablename)          //a switch which searches for the keywords entered by the user
                {
                    case "drivers":     
                        cmd.CommandText = "select * from drivers where Name like '%" + searchText + "%' or Birthday like '%" + searchText + "%' or Country like '%" + searchText + "%' or WDC like '%" + searchText + "%' or wins like '%" + searchText + "%' or podiums like '%" + searchText + "%' or fastestlaps like '%" + searchText + "%' or lapsled like '%" + searchText + "%' or racestarts like '%" + searchText + "%' or firstrace like '%" + searchText + "%' or lastrace like '%" + searchText + "%';";
                        reader = cmd.ExecuteReader();
                        dt.Load(reader);
                        conn.Close();
                        break;
                    case "teams":
                        cmd.CommandText = "select * from teams where Name like '%" + searchText + "%' or Founded_In like '%" + searchText + "%' or Country like '%" + searchText + "%' or WCC like '%" + searchText + "%' or Team_Principal like '%" + searchText + "%';";
                        reader = cmd.ExecuteReader();
                        dt.Load(reader);
                        conn.Close();
                        break;
                    case "tracks":
                        cmd.CommandText = "select * from tracks where Name like '%" + searchText + "%' or Country like '%" + searchText + "%' or First_GP like '%" + searchText + "%' or GPs_hosted like '%" + searchText + "%';";
                        reader = cmd.ExecuteReader();
                        dt.Load(reader);
                        conn.Close();
                        break;
                    case "raceresults":
                        cmd.CommandText = "select * from raceresults where Location like '%" + searchText + "%' or Date like '%" + searchText + "%' or Winner like '%" + searchText + "%' or second_place like '%" + searchText + "%' or third_place like '%" + searchText + "%';";
                        reader = cmd.ExecuteReader();
                        dt.Load(reader);
                        conn.Close();
                        break;
                    case "championshipresults":
                        cmd.CommandText = "select * from championshipresults where Year like '%" + searchText + "%' or Winner like '%" + searchText + "%' or Points_1 like '%" + searchText + "%' or second_place like '%" + searchText + "%' or Points_2 like '%" + searchText + "%' or third_place like '%" + searchText + "%' or Points_3 like '%" + searchText + "%';";
                        reader = cmd.ExecuteReader();
                        dt.Load(reader);
                        conn.Close();
                        break;
                    case "news":
                        cmd.CommandText = "select * from news where Date like '%" + searchText + "%' or Headline like '%" + searchText + "%' or Text like '%" + searchText + "%';";
                        reader = cmd.ExecuteReader();
                        dt.Load(reader);
                        conn.Close();
                        break;
                }

                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return dt;
            }
        }       //fill a DataTable with the results of the search-text

        public static void SaveChanges()
        {
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);         //creating SqlDataAdapter and SqlCommandBuilder 

                sda.Update(dt);     //updating datatable 'dt' via SqlDataAdapter
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }       //save the changes made to a dataset

        public static void Register(string username, string password)
        {
            string salt = BCrypt.GenerateSalt();
            string hashedpassword = BCrypt.HashPassword(password, salt);        //hashing the password

            try
            {
                conn.Open();
                cmd.CommandText = "INSERT INTO login VALUES ('" + username + "', '" + hashedpassword + "', 0);";       //inserting username and hashed password to table 'login'
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }       //register a new user

        public static bool GetPassword(string username, string password)
        {
            try
            {
                conn.Open();
                cmd.CommandText = "select password from login where username = '" + username + "';";        //selecting the hashed password

                if (BCrypt.CheckPassword(password, cmd.ExecuteScalar().ToString()))         //'CheckPassword' checks if password and hashed password are the same
                {
                    conn.Close();       //if passwords are the same true is returned
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }                                
        }           //check if password belongs to useraname

        public static bool CheckUsername(string username)
        {
            bool usernameexist = false;

            try
            {
                conn.Open();
                cmd.CommandText = "select count(*) from login where Username = '" + username + "';";       //checking if username exists
                string checkusername = cmd.ExecuteScalar().ToString();
                conn.Close();

                if (checkusername.Equals("0"))
                {
                    usernameexist = false;     //if username exists 'usernameexist' is set to true
                }
                if (checkusername.Equals("1"))
                {
                    usernameexist = true;
                }
                return usernameexist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return usernameexist;
            }
        }           //check if username exists

        public static bool CheckIfAdmin(string username)
        {
            bool userisadmin = false;

            try
            {
                conn.Open();
                cmd.CommandText = "select isAdmin from login where username = '" + username + "';";

                if (cmd.ExecuteScalar().ToString().Equals("1"))
                    userisadmin = true;

                conn.Close();
                return userisadmin;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return userisadmin;
            }
        }           //check if user is admin

        public static void GetMinMaxRaceID()              //get the minimum, maximum and the ID of the upcoming race from table Calendar
        {
            DateTime current_year = DateTime.Now;
            string year = current_year.Year.ToString();
            string date = current_year.Month.ToString() + "." + current_year.Day.ToString() + "." + current_year.Year.ToString();       //build the current date in the format month.day.year

            try
            {
                conn.Open();
                cmd.CommandText = "select To_Date from calendar where To_Date like '%" + year + "%' order by To_Date desc;";        //get the date from the last race of the year
                DateTime datelastrace = (DateTime)cmd.ExecuteScalar();                

                if(datelastrace < DateTime.Now)     //if the season has already ended show the info of the last race
                {
                    cmd.CommandText = "select min(RaceID) from calendar where To_Date like '%" + year + "%';";  //get minimum ID in the current year
                    minRaceID = (int)cmd.ExecuteScalar();
                    cmd.CommandText = "select max(RaceID) from calendar where To_Date like '%" + year + "%';";  //get maximum ID in the current year
                    nextRaceID = (int)cmd.ExecuteScalar();
                    maxRaceID = nextRaceID;
                    cmd.CommandText = "";
                }
                else       //if the hasn`t ended yet show the info for the next race
                {
                    cmd.CommandText = "select RaceID from calendar where To_Date >= '" + date + "' and To_Date like '%" + year + "%' order by To_Date asc;";    //get the next RaceID in the current year
                    nextRaceID = (int)cmd.ExecuteScalar();
                    cmd.CommandText = "select min(RaceID) from calendar where To_Date like '%" + year + "%';";  //get minimum ID in the current year
                    minRaceID = (int)cmd.ExecuteScalar();
                    cmd.CommandText = "select max(RaceID) from calendar where To_Date like '%" + year + "%';";  //get maximum ID in the current year
                    maxRaceID = (int)cmd.ExecuteScalar();
                    cmd.CommandText = "";
                }               
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        public static void CalendarInfo(int RaceID)         //saving Calendar-Data to global variables
        {
            try
            {
                conn.Open();
                cmd.CommandText = "select Country from calendar where RaceID = " + RaceID;
                country = cmd.ExecuteScalar().ToString();
                cmd.CommandText = "select Name from calendar where RaceID = " + RaceID;
                name = cmd.ExecuteScalar().ToString();
                cmd.CommandText = "select From_Date from calendar where RaceID = " + RaceID;
                fromDate = (DateTime)cmd.ExecuteScalar();
                cmd.CommandText = "select To_Date from calendar where RaceID = " + RaceID;
                toDate = (DateTime)cmd.ExecuteScalar();
                cmd.CommandText = "";
                conn.Close();
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }



        public static void DemonstrateData()
        {
            try
            {
                string salt = BCrypt.GenerateSalt();
                string hashedpassword = BCrypt.HashPassword("admin", salt);

                conn.Open();
                cmd.CommandText = "insert into login values ('admin', '" + hashedpassword + "', 1);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into drivers (Name, Country, WDC) values ('Max Verstappen', 'Netherlands', 2);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into drivers (Name, Country, WDC) values ('Sebastian Vettel', 'Germany', 4);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into drivers (Name, Country, WDC) values ('Lewis Hamilton', 'Great Britain', 7);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into drivers (Name, Country, WDC) values ('Fernando Alonso', 'Spain', 2);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into drivers (Name, Country, WDC) values ('Charles Leclerc', 'Monaco', 0);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into calendar values (1, 'Australia', 'FORMULA 1 ROLEX AUSTRALIAN GRAND PRIX 2023', '03.31.2023', '04.02.2023');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into calendar values (2, 'Azerbaijan', 'FORMULA 1 AZERBAIJAN GRAND PRIX 2023', '04.28.2023', '04.30.2023');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into calendar values (3, 'United States', 'FORMULA 1 CRYPTO.COM MIAMI GRAND PRIX 2023', '05.05.2023', '05.07.2023');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into calendar values (4, 'Italy', 'FORMULA 1 QATAR AIRWAYS GRAN PREMIO DEL MADE IN ITALY E DEL EMILIA-ROMAGNA 2023', '05.19.2023', '05.21.2023');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into calendar values (5, 'Monaco', 'FORMULA 1 GRAND PRIX DE MONACO 2023', '05.26.2023', '05.28.2023');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into calendar values (6, 'Spain', 'FORMULA 1 AWS GRAN PREMIO DE ESPAÑA 2023', '06.02.2023', '06.04.2023');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into calendar values (7, 'Canada', 'FORMULA 1 PIRELLI GRAND PRIX DU CANADA 2023', '06.16.2023', '06.18.2023');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into calendar values (8, 'Austria', 'FORMULA 1 GROSSER PREIS VON ÖSTERREICH 2023', '06.30.2023', '07.02.2023');";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
