using Specflow_app.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dapper;

namespace Specflow_app.Controllers
{
    public class EmployeeController : ApiController
    {

        public string Connect = @"Data Source=PCZ-EE210680\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True";
        List<EmployeeModel> employees = new List<EmployeeModel>();
        public EmployeeController(List<EmployeeModel> employees)
        {
            this.employees = employees;
        }
        [HttpGet]
        public List<EmployeeModel> GatAllData()
        {
            List<EmployeeModel> data = new List<EmployeeModel>();
            using (IDbConnection con = new SqlConnection(Connect))
            {
                data = con.Query<EmployeeModel>("Select * from Employees").ToList();
                if(data == null)
                {
                    return null;
                }
            }
            return data;
        }
    }
}
