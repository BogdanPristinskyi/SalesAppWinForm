using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.Models
{
    internal class Sales : BaseModel
    {
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
        
        [Required]
        public virtual SalesPerson Person { get; set; }

        [Required]
        public int PersonId { get; set; }

        [Required]
        public virtual SalesRegion Region { get; set; }

        [Required]
        public int RegionId { get; set; }
        

       
    }
}
