﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Specflow_app.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public decimal Salary { get; set; }
    }
}