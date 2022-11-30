using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Gosha.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display()]
        [MinLength(3)]
        [MaxLength(20)]
        public string? Name { get; set; }
        [MinLength(3)]
        [MaxLength(30)]
        public string? Surname { get; set; }
        [MinLength(3)]
        [MaxLength(50)]
        public string? Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        [MinLength(3)]
        [MaxLength(30)]
        public string? Email { get; set; }
        [DataType(DataType.DateTime)]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
    }
}
