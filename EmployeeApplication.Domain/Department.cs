﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Domain
{
    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }
    }
}
