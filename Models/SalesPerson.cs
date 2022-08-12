using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SalesApp.Interfaces;

namespace SalesApp.Models
    
{
    internal class SalesPerson : BaseModel, IActive
    {
        [Required]
        public bool Active { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
        
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName).Trim();
            }
        }
        
        public virtual SalesRegion Region { get; set; }

        public virtual ObservableListSource<Sales> Sales { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal SalesTarget { get; set; }

        [Required]
        public int RegionId { get; set; }
    }
  
}
