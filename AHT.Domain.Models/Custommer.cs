using AHT.Domain.Commons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AHT.Domain.Models
{
    public class Custommer : EntityBase<int>, IAggregateRoot
    {
        public virtual string Name { get; set; }

        public virtual string Phone { get; set; }

        public override string[] Validate()
        {
            throw new NotImplementedException();
        }
     }
}
