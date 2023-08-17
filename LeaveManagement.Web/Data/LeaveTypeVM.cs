using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Data
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name= "Leave Type Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name="Default Number of Days")]
        [Required]
        [Range(0,100,ErrorMessage ="Please enter a valid number")]
        public int DefaultDays { get; set; }

    }
}
