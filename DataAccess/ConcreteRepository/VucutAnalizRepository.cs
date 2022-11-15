using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ConcreteRepository
{
    public class VucutAnalizRepository : BaseRepository<VucutAnalizi>
    {
        public VucutAnalizRepository(DietQueryDBContext dietQueryDBContext) : base(dietQueryDBContext)
        {
        }
    }
}
