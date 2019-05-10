using Specflow_app.Models;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using Specflow_app.Controllers;
using System.Web.Http;

namespace SpecflowTest
{
    [Binding]
    public class TestFeatSteps
    {
      public static  List<EmployeeModel> empList = new List<EmployeeModel>();
        public string Connect = @"Data Source=PCZ-EE210680\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True";
        EmployeeController instance = new EmployeeController(empList);
        List<EmployeeModel> data = new List<EmployeeModel>();
        [Given(@"I have list of all employees")]
        public void  GivenIHaveListOfAllEmployees()
        {
            data = instance.GatAllData();
           
        }
        
        //[Then(@"the result should be list of all Emploees")]
        //public IEnumerable<EmployeeModel> ThenTheResultShouldBeListOfAllEmploees()
        //{
           
        //}
    }
}
