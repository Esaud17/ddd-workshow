using AHT.Application.Prizes.Interfaces;
using AHT.CrossCuting.Commons.AHTLogger;
using AHT.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.Application.Prizes
{
    public class PrizeApplication: IPrizeApplication
    {
        private readonly PrizesDomainService _prizesDomainService1;
        public PrizeApplication(PrizesDomainService prizesDomainService) {

            if (prizesDomainService == null) throw new ArgumentNullException(nameof(prizesDomainService));
            _prizesDomainService1 = prizesDomainService;
        }

        [LoggerAttribute]
        public void excecute()
        {
            //var x = _prizesDomainService1.GetAllPrizes();

            _prizesDomainService1.AddPrizes();

        }
    }
}
