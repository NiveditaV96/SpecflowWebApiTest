using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Specflow_app.Models;
using System.Collections.Generic;
using Specflow_app.Controllers;

namespace SpecflowTest
{
    [TestClass]
    public class EmployeeControllerTest
    {
        [TestMethod]
        public void GetAllEmployees_ShouldReturnAllEmployeesList()
        {
            List<EmployeeModel> listEmp = GetTestEmployees();
            var contr = new EmployeeController(listEmp);
            var result = contr.GatAllData() as List<EmployeeModel>;
            Assert.AreEqual(listEmp.Count, result.Count);
           // Assert.AreSame(listEmp, result);
            

        }

        private List<EmployeeModel> GetTestEmployees()
        {
            var testEmployees = new List<EmployeeModel>();
            testEmployees.Add(new EmployeeModel { ID = 1, FirstName = "Demo1", LastName = "last1", Gender="F",Salary=1000});
            testEmployees.Add(new EmployeeModel { ID = 2, FirstName = "Demo2", LastName = "last2", Gender = "F", Salary = 1000 });
            testEmployees.Add(new EmployeeModel { ID = 3, FirstName = "Demo3", LastName = "last3", Gender = "F", Salary = 1000 });
            testEmployees.Add(new EmployeeModel { ID = 4, FirstName = "Demo4", LastName = "last4", Gender = "F", Salary = 1000 });
            testEmployees.Add(new EmployeeModel { ID = 5, FirstName = "Demo5", LastName = "last5", Gender = "F", Salary = 1000 });
            testEmployees.Add(new EmployeeModel { ID = 6, FirstName = "Demo6", LastName = "last6", Gender = "F", Salary = 1000 });
            testEmployees.Add(new EmployeeModel { ID = 7, FirstName = "Demo7", LastName = "last7", Gender = "F", Salary = 1000 });


            return testEmployees;
        }
    }
}
