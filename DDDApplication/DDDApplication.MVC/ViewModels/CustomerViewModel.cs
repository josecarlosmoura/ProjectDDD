using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DDDApplication.MVC.ViewModels
{
    public class CustomerViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter the name correctly.")]
        [MaxLength(255, ErrorMessage = "Max length of the {0} characters.")]
        [MinLength(2, ErrorMessage = "Min length of the {0} characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter the last name correctly.")]
        [MaxLength(255, ErrorMessage = "Max length of the {0} characters.")]
        [MinLength(2, ErrorMessage = "Min length of the {0} characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter the e-mail correctly.")]
        [MaxLength(255, ErrorMessage = "Max length of the {0} characters.")]
        [EmailAddress(ErrorMessage = "This is not e-mail valid.")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegistrationDate { get; set; }
        public bool Active { get; set; }
        public virtual IEnumerable<ProductViewModel> Products { get; set; }
    }
}