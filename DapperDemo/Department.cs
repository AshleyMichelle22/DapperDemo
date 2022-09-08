using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    public class Department // calss represents table
    {

        // we create object using classes
        //each column from the Department table (DepartmentID and Name from SQL best buy)  will be a property
        public int DepartmentID { get; set; }
        public string Name { get; set; }
    }
}
