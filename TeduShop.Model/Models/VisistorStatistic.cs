using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("VisistorStatistics")]
    public class VisistorStatistic
    {
        [Key]
        public Guid ID { get; set; }
        
        [Required]
        public DateTime VistedDate { get; set; }

        [MaxLength(50)]
        public string IPAddress { get; set; }
    }
}
