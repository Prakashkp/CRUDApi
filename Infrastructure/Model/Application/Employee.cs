using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Model.Application
{
    [Index(nameof(Employee.EmployeeCode), IsUnique =true)]
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
}
