using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    public class Currency
    {
        [Required]
        [Display (Name = "Currency Amount in €")]
        public decimal valueInput {  get; set; }
        [Display (Name = "Resulting Currency in $")]
        public decimal valueOutput { get; set; }

     
    }
}
