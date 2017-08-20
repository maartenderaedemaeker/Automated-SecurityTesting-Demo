using System;

namespace SecurityTestingDemo.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid SupervisorId { get; set; }
    }
}