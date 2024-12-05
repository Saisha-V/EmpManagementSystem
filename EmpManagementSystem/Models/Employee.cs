using System.ComponentModel.DataAnnotations;

namespace EmpManagementSystem.Models
{
    public class Employee
    {
        [Required]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Role { get; set; }
        public string? Manager { get; set; }
        public DateTime DateOfJoining { get; set; }
    }

}
