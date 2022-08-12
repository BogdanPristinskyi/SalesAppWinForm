using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesApp.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;

namespace SalesApp.Models
{
    internal class SalesRegion : BaseModel, IActive
    {
        [Required]
        public bool Active { get; set; }

        [Required]
        [StringLength(3)]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        // The sales people in this sale region

        public ObservableListSource<SalesPerson> People { get; set; }

        // The sales made in this sales region
        public ObservableListSource<Sales> Sales { get; set; }

        // The dollar sales target of the sales region
        [Required]
        [Range(0, double.MaxValue)]
        public decimal SalesTarget { get; set; }

    }
    class ObservableListSource<T> : ObservableCollection<T>, IListSource
        where T : BaseModel
    {
        private IBindingList _bindingList;

        bool IListSource.ContainsListCollection {  get { return false; } }

        IList IListSource.GetList()
        {
            return _bindingList ?? (_bindingList = this.ToBindingList());
        }
    }
}
