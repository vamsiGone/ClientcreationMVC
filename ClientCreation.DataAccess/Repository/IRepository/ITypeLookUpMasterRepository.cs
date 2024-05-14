using ClientCreation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientCreation.DataAccess.Repository.IRepository
{
    public interface ITypeLookUpMasterRepository
    {
        public interface ITypeLookUpMasterRepository : IRepository<TypeLookUpMaster>
        {
            void Update(TypeLookUpMaster obj);

        }
    }
}
