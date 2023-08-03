using AHT.Domain.Commons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.Domain.Models
{
    public class Product : EntityBase<int>, IAggregateRoot
    {

        public virtual string Sku { get; set; }
        public virtual string Name { get; set; }
        public override string[] Validate()
        {
            throw new NotImplementedException();
        }
    }
}
