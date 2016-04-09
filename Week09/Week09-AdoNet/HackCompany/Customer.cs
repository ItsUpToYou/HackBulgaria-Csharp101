using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackCompanyLib
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public int? ManagerId { get; set; }
        public int? DepartmentId { get; set; }

        public Customer(int id, string firstName, string lastName, string email, DateTime birthDate, int? managerId, int? depId)
        {
            this.EmployeeId = id;
            this.firstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.ManagerId = managerId;
            this.DepartmentId = depId;
        }
    }
}
