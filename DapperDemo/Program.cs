using System;
using System.Data; // IDBConnection Interface avaliable in this namespace
using System.IO;
using MySql.Data.MySqlClient;// installed myself
using Microsoft.Extensions.Configuration;// installed me
using DapperDemo;


//^^^^MUST HAVE USING DIRECTIVES^^^^

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
string connString = config.GetConnectionString("DefaultConnection");// setting the connection-- called this in the json file name of json
IDbConnection conn = new MySqlConnection(connString);

// Created an instance of the configuration, setting base path to Net 6 current directory, added json file to that dir, building it out as object called config.
// //Allows us to connect to database

var repo = new DapperDepartmetnRepository(conn);

//var departments = repo.GetAllDepartments();
//foreach (var item in departments)
//{
//    Console.WriteLine($"DepartmentID {item.DepartmentID} ");
//    Console.WriteLine($" Department Name {item.Name}");
//    Console.WriteLine();
//}

Console.WriteLine(" Enter a new Department");
var userInput = Console.ReadLine();          // Enters a new Department
repo.InsertDepartment(userInput);

var departments2 = repo.GetAllDepartments();                // get all the departments

foreach (var item in departments2)
{
    Console.WriteLine($"DepartmentID {item.DepartmentID} ");
    Console.WriteLine($" Department Name {item.Name}");
    Console.WriteLine();
}
