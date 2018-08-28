using QLSL2018.Data.Entities;
using QLSL2018.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLSL2018.Data.FF.Repositories
{
    public class FunctionRepository : EFRepository<Function, string>, IFunctionRepository
    {
        public FunctionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
