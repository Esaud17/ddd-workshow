using AHT.CrossCuting.Commons.AHTLogger;
using AHT.Domain.Models;
using AHT.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.Domain.Services
{
    public class PrizesDomainService
    {
        private readonly IPrizesRepository _prizesRepository;

       public PrizesDomainService(IPrizesRepository prizesRepository) {

            if (prizesRepository == null) throw new ArgumentNullException(nameof(prizesRepository));
            _prizesRepository = prizesRepository;
        }

        
        public List<Prize> GetAllPrizes()
        {
            return this._prizesRepository.GetAll().ToList();
        }

        
        public Prize AddPrizes()
        {
            var test = new Prize();

            test.Validate();

            return test;
        }



    }
}
