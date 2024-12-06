using System.ComponentModel.DataAnnotations;

namespace EmpManagementSystem.Models
{
    public class Employee
    {
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string? Role { get; set; }
        public string? Manager { get; set; }
        [Required]
        public DateTime DateOfJoining { get; set; }
    }

}
