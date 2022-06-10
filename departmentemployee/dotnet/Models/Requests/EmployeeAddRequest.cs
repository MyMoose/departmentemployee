using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Requests
{
    public class EmployeeAddRequest
    {
        [Required]
        [StringLength(500, MinimumLength = 2)]
        public string EmployeeName { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 2)]
        public string Department { get; set; }       

        [Required]
        [StringLength(500, MinimumLength = 2)]
        public string PhotoFileName { get; set; }

    }
}
