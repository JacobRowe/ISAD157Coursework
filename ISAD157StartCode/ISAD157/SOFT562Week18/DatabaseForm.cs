using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SOFT562Week18
{
    public partial class DatabaseForm : Form
    {
        //Runs first
        public DatabaseForm()
        {
            InitializeComponent();

            //Set first data grid to fill with all users at start of program

            //String containing connection info specified in DBconnect.cs
            string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

            //Create a connection to the MySQL Server database
            using (MySqlConnection connection =
                new MySqlConnection(connectionString))
            {
                //Query to retrieve all the records in the users table
                string query = "SELECT * FROM isad157_jrowe.users";

                //Opens a database connection with the property settings from ConnectionString
                connection.Open();

                //Submit the SQL statement, in the form of the string query and the connection, to be executed
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // The MySqlDataAdapter represents a set of data commands
                // and a database connection that are used to fill a
                // dataset and update a MySQL database.
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                //Creates new data table called userDataTable for binding to data grid later
                DataTable userDataTable = new DataTable();
                //Fills the MySqlDataAdapter sqlDA with the data table freindDataTable
                sqlDA.Fill(userDataTable);

                // Bind the user table to the Data Grid View users
                dataGridViewUsers.DataSource = userDataTable;

            } //End of connection to MySql Server Database
        }

        //Runs when the selected index of the drop down menu comboBoxQueryChoice changes
        private void comboBoxQueryChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxQueryChoice.SelectedIndex == 0)
            {
                //String containing connection info specified in DBconnect.cs
                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                //Create a connection to the MySQL Server database
                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    //value for the currently selected index of the row, plus one so the user id matches with the value
                    int currentRow = dataGridViewUsers.CurrentCell.RowIndex + 1;

                    //Query to retrieve all the records in the freindships table where the user id or the reciver user id 
                    //is the currently selected row index, aka the selected user in the data grid
                    string query1 = "SELECT * FROM isad157_jrowe.freindships WHERE user_id = " + currentRow;
                    //Opens a database connection with the property settings from ConnectionString
                    connection.Open();

                    //Submit the SQL statement, in the form of the string query and the connection, to be executed
                    MySqlCommand cmd = new MySqlCommand(query1, connection);

                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    //Creates new data table called freindDataTable for binding to data grid later
                    DataTable freindDataTable = new DataTable();
                    //Fills the MySqlDataAdapter sqlDA with the data table freindDataTable
                    sqlDA.Fill(freindDataTable);

                    //Attatches the freind data table to the Data Grid View other.
                    dataGridViewOther.DataSource = freindDataTable;

                    //Query to retrive user_id, first_name and last_name from the users table where the user_id 
                    //is equal to the friend_id from freindships table where the user_id is equal to the current selected user
                    //
                    //AKA, shows freind info contextual to what user has been selected and who they are freinds with
                    string query2 = "SELECT user_id, first_name, last_name FROM isad157_jrowe.users WHERE user_id = ANY (SELECT friend_id FROM isad157_jrowe.freindships WHERE user_id = " + currentRow + ")";

                    //Submit the SQL statement, in the form of the string query and the connection, to be executed
                    MySqlCommand cmd2 = new MySqlCommand(query2, connection);

                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database
                    MySqlDataAdapter sqlDA2 = new MySqlDataAdapter(cmd2);
                    //Creates new data table called freindInfoDataTable for binding to data grid later
                    DataTable freindInfoDataTable = new DataTable();
                    //Fills the MySqlDataAdapter sqlDA with the data table freindInfoDataTable
                    sqlDA2.Fill(freindInfoDataTable);

                    //Attatches the freindInfo data table to the Data Grid View freindInfo.
                    dataGridViewFreindInfo.DataSource = freindInfoDataTable;
                }//End of connection to MySql Server Database
            }

            else if (comboBoxQueryChoice.SelectedIndex == 1)
            {
                //String containing connection info specified in DBconnect.cs
                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                //Create a connection to the MySQL Server database
                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    //value for the currently selected index of the row, plus one so the user id matches with the value
                    int currentRow = dataGridViewUsers.CurrentCell.RowIndex + 1;

                    //Query to retrieve all the records in the workplace table where the user id or the reciver user id 
                    //is the currently selected row index, aka the selected user in the data grid
                    string query = "SELECT * FROM isad157_jrowe.workplace WHERE user_id = " + currentRow;

                    //Opens a database connection with the property settings from ConnectionString
                    connection.Open();

                    //Submit the SQL statement, in the form of the string query and the connection, to be executed
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    //Creates new data table called workPlaceDataTable for binding to data grid later
                    DataTable workPlaceDataTable = new DataTable();
                    //Fills the MySqlDataAdapter sqlDA with the data table workPlaceDataTable
                    sqlDA.Fill(workPlaceDataTable);

                    //Attatches the workplace data table to the Data Grid View other.
                    dataGridViewOther.DataSource = workPlaceDataTable;
                }//End of connection to MySql Server Database
            }

            else if (comboBoxQueryChoice.SelectedIndex == 2)
            {
                //String containing connection info specified in DBconnect.cs
                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                //Create a connection to the MySQL Server database
                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    //value for the currently selected index of the row, plus one so the user id matches with the value
                    int currentRow = dataGridViewUsers.CurrentCell.RowIndex + 1;

                    //Query to retrieve all the records in the school table where the user id or the reciver user id 
                    //is the currently selected row index, aka the selected user in the data grid
                    string query = "SELECT * FROM isad157_jrowe.school WHERE user_id = " + currentRow;

                    //Opens a database connection with the property settings from ConnectionString
                    connection.Open();

                    //Submit the SQL statement, in the form of the string query and the connection, to be executed
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    //Creates new data table called schoolDataTable for binding to data grid later
                    DataTable schoolDataTable = new DataTable();
                    //Fills the MySqlDataAdapter sqlDA with the data table schoolDataTable
                    sqlDA.Fill(schoolDataTable);

                    //Attatches the school data table to the Data Grid View other.
                    dataGridViewOther.DataSource = schoolDataTable;
                }//End of connection to MySql Server Database
            }

            else if (comboBoxQueryChoice.SelectedIndex == 3)
            {
                //String containing connection info specified in DBconnect.cs
                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                //Create a connection to the MySQL Server database
                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    //value for the currently selected index of the row, plus one so the user id matches with the value
                    int currentRow = dataGridViewUsers.CurrentCell.RowIndex + 1;

                    //Query to retrieve all the records in the messages table where the user id or the reciver user id 
                    //is the currently selected row index, aka the selected user in the data grid
                    string query = "SELECT * FROM isad157_jrowe.messages WHERE user_id = " + currentRow + " OR  reciver_user_id = " + currentRow;

                    //Opens a database connection with the property settings from ConnectionString
                    connection.Open();

                    //Submit the SQL statement, in the form of the string query and the connection, to be executed
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    //Creates new data table called messagesDataTable for binding to data grid later
                    DataTable messagesDataTable = new DataTable();
                    //Fills the MySqlDataAdapter sqlDA with the data table messagesDataTable
                    sqlDA.Fill(messagesDataTable);

                    //Attatches the messages data table to the Data Grid View other.
                    dataGridViewOther.DataSource = messagesDataTable;
                }//End of connection to MySql Server Database
            }
        }
    }
}

