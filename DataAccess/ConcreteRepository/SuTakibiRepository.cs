using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ConcreteRepository
{
    public class SuTakibiRepository : BaseRepository<SuTakibi>
    {
        public SuTakibiRepository(DietQueryDBContext dietQueryDBContext) : base(dietQueryDBContext)
        {
        }
    }
}
