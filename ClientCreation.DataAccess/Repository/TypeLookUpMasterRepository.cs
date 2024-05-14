using ClientCreation.Data;
using ClientCreation.DataAccess.Repository.IRepository;
using ClientCreation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientCreation.DataAccess.Repository
{

    public class TypeLookUpMasterRepository : Repository<TypeLookUpMaster>, ITypeLookUpMasterRepository
    {
        private readonly RegistrationDbContext _db;

        public TypeLookUpMasterRepository(RegistrationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(TypeLookUpMaster obj)
        {
            _db.TypeLookUpMaster.Update(obj);
        }
    }

}
