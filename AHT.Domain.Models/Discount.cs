using AHT.Domain.Commons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.Domain.Models
{
    public class Discount : EntityBase<int>, IAggregateRoot
    {
        //public virtual Prize prize { get; set; }
        public virtual string TypeDiscount { get; set; }
        public virtual string ValueDiscount { get; set; }
        public override string[] Validate()
        {
            throw new NotImplementedException();
        }
    }
}
