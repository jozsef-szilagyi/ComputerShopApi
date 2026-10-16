using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComputerShopAPI.Models
{
    public class Computer
    {
        [Key]
        
        public int Id { get; set; }

        [MaxLength(37)]
        public string Brand { get; set; }

        [MaxLength(30)]
        public string Type { get; set; }

        public double Display {  get; set; }
        public int Memory { get; set; }
        public DateTime CreatedTime { get; set; }

        [Column(TypeName = "char(36)")]
        [MaxLength(36)]
        public string OsId { get; set; }


    }
}
