using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Requests
{
    public class DepartmentAddRequest
    {
        [Required]
        [StringLength(500, MinimumLength = 2)]
        public string DepartmentName { get; set; }
    }
}
