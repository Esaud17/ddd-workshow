using AHT.Domain.Commons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.Domain.Models
{
    public class ShopperUID : ValueObjectBase
    {
        public string UID { get; set; }
        public override string[] Validate()
        {
            throw new NotImplementedException();
        }
    }
}
