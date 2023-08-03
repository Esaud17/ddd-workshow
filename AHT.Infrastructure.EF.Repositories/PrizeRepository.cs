using AHT.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.Infrastructure.EF.Repositories
{
    public class PrizeRepository : IPrizesRepository
    {
        private readonly prizes_dbEntities _db;
        public PrizeRepository(prizes_dbEntities db)
        {
            if (db == null) throw new ArgumentNullException(nameof(db));
            _db = db;
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Domain.Models.Prize Get(int key)
        {
            throw new NotImplementedException();


        }

        public IQueryable<Domain.Models.Prize> GetAll()
        {
            //throw new NotImplementedException();
           var collection = this._db.prizesConfig;

            var result = new List<Domain.Models.Prize>();
            foreach (var item in collection)
            {
                result.Add(new Domain.Models.Prize()
                {
                    Title = item.title,
                    Description = item.description,
                    Id = (int)item.id
                });
            }

            return result.AsQueryable();
        }

        public void Insert(Domain.Models.Prize entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Models.Prize entity)
        {
            throw new NotImplementedException();
        }
    }
}
