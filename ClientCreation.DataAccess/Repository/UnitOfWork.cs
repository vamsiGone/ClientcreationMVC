using ClientCreation.Data;
using ClientCreation.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientCreation.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RegistrationDbContext _db;

        public UnitOfWork(RegistrationDbContext db)
        {
            _db = db;
            RegistrationCheckList = new RegistrationRepository(_db);
            TypeLookUpMaster = new TypeLookUpMasterRepository(_db);
        }
        public IRegistrationRepository RegistrationCheckList { get; private set; }
        public ITypeLookUpMasterRepository TypeLookUpMaster { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
