using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DDDApplication.MVC.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter the description correctly.")]
        [MaxLength(255, ErrorMessage = "Max length of the {0} characters.")]
        [MinLength(2, ErrorMessage = "Min length of the {0} characters.")]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Enter the value correctly.")]
        public decimal Valeu { get; set; }

        [DisplayName("Available?")]
        public bool Available { get; set; }
        public int CustomerId { get; set; }
        public virtual CustomerViewModel Customer { get; set; }
    }
}