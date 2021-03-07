using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiskonVehicleCRUDOperations.Models
{
    [Table("Vehicle")]
    public partial class Vehicle
    {
        public int Id { get; set; }

        [StringLength(50)]
        [RegularExpression(@"^(0[1-9]|[1-7][0-9]|8[01])(([A-Z])(\d{4,5})|([A-Z]{2})(\d{3,4})|([A-Z]{3})(\d{2}))$",  ErrorMessage = "Plate should be in Turkey Standard Format")]
        public string Plate { get; set; }

        [Required]
        public string NickName { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        public int ModelYear { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Color { get; set; }

        public bool IsActive { get; set; }
    }
}
