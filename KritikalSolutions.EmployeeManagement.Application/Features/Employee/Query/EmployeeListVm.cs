﻿using System;

namespace KritikalSolutions.EmployeeManagement.Application.Features.Employee.Query
{
    public class EmployeeListVm
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }

}
