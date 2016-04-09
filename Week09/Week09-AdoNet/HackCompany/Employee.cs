using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackCompanyLib
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public int? ManagerId { get; set; }
        public int? DepartmentId { get; set; }

        public Employee(int id, string firstName, string lastName, string email, DateTime birthDate, int? managerId, int? depId)
        {
            this.EmployeeId = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.ManagerId = managerId;
            this.DepartmentId = depId;
        }
    }


}
