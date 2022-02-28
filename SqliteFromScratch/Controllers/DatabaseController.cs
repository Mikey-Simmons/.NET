using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using SqliteFromScratch.Models;

namespace SqliteFromScratch.Controllers
{
    //mvc 
    [Route("api/[Controller]")]
    public class DatabaseController : Controller
    {
        //api database 
        [HttpGet]
       public List<Employee> GetData() {

    // employees will be populated with the result of the query.
    List<Employee> employees = new List<Employee>();
    //GetFullPath will return a string to complete the absolute path.
    string dataSource ="Data Source=" + Path.GetFullPath("chinook.db");
    using(SqliteConnection conn = new SqliteConnection(dataSource)){
        conn.Open();
        //string sql is the string that will run the sql command
        string sql =$"select* from employees limit 20";
        // command combines the connection and the command string and creates the query
        using(SqliteCommand command = new SqliteCommand(sql,conn)){
        //reader allows you to read each value that comes back and do something with it.
        using(SqliteDataReader reader = command.ExecuteReader()){
            while (reader.Read()){
                //map the data to the model.
                Employee newEmployee = new Employee() {
                        EmployeeId = reader.GetInt32(0),
                        LastName = reader.GetString(1),
                        FirstName = reader.GetString(2),
                        Title = reader.GetString(3),
                        //ReportsTo = reader.GetInt32(4),
                        BirthDate = reader.GetDateTime(5),
                        HireDate = reader.GetDateTime(6),
                        Address = reader.GetString(7),
                        City= reader.GetString(8),
                        State= reader.GetString(9),  
                        Country=reader.GetString(10),
                        PostalCode=reader.GetString(11),
                        Phone= reader.GetString(12),
                        Fax= reader.GetString(13),
                        Email= reader.GetString(14)              
            };
            // add each one to the list.
                employees.Add(newEmployee);
        }
        }

        conn.Close();
    }
    return employees;
} 
    }
}
}