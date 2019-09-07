using System;
namespace webapi2dot2.Models
{
    public class Employee
    {
        public Employee()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Dept Department { get; set; }
    }
}
