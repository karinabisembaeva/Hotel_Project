﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    
    class DBConnect
    {
        private MySqlConnection connection = new MySqlConnection("datasource = localhost; port=3306;username=root;password=;database=hotel");

        //function to return our connection

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        //function to open the connection
        public void OpenCon()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        //function to close the connection
        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
