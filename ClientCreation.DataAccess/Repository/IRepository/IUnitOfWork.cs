using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientCreation.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IRegistrationRepository RegistrationCheckList { get; }
        ITypeLookUpMasterRepository TypeLookUpMaster { get; }
        void Save();
    }
}
