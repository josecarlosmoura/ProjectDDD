using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDDApplication.Domain.Entites
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Valeu { get; set; }
        public bool Available { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
