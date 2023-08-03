using AHT.Domain.Commons.Repositories;
using AHT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.Domain.Repositories
{
    public interface IDiscountRepository: IRepository<Discount, int>
    {
    }
}
