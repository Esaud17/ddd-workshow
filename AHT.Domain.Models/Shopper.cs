using AHT.Domain.Commons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.Domain.Models
{
    public class Shopper : EntityBase<int>, IAggregateRoot
    {
        public virtual Custommer Client { get; set; }

        public virtual List<Product> Products { get; set; }

        public virtual ShopperUID shoper { get; set; }

        public override string[] Validate()
        {
            throw new NotImplementedException();
        }
    }
}
