using System.ComponentModel.DataAnnotations;
using WebApplication1.Models.Interfaces;

namespace WebApplication1.Models.Requests
{
    public class DepartmentUpdateRequest: DepartmentAddRequest
    {
        public int DepartmentId { get; set; }
       
    }
}
