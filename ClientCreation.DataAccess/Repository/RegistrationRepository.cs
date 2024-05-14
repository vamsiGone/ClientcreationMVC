using ClientCreation.Data;
using ClientCreation.DataAccess.Repository.IRepository;
using ClientCreation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClientCreation.DataAccess.Repository.RegistrationRepository;

namespace ClientCreation.DataAccess.Repository
{

    public class RegistrationRepository : Repository<RegistrationCheckList>, IRegistrationRepository
    {
        private readonly RegistrationDbContext _db;

        public RegistrationRepository(RegistrationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(RegistrationCheckList obj)
        {
            _db.RegistrationCheckList.Update(obj);
        }
    }

}
