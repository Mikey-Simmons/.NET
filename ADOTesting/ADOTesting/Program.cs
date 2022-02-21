using System;
using System.Data;
namespace ADOTestTest
{
    class Program
    {
        public static void Main()
        {
            //interfaces exposed by ADO.NET
            System.Data.IDbConnection conn;
            //conn = new someClassThatImplementsIdbConnection;
            //what is this class
            // called database provider
            //the only one u have to pick is the connection
            //mysql sqllite sqlserver
            //this is the main decision that you have to make! you have to decide ur db vendor.
            //select db
            //you must select connection string
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = "Server=localhost;Database=adn103movies;uid=root;";
            //this is the minimum config for db connection
            // properties: ConnectionString
            //                              state 
            conn.Open();
            IDbCommand Comm;
            // bad example
          // Comm = new MySql.Data.MySqlClient.MySqlCommand
          //good example the selection as to ur provider is only made by the connection
          Comm = conn.CreateCommand();

           

        }
    }
}