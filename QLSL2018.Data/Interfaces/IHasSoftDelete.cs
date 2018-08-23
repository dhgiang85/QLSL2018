using System;
using System.Collections.Generic;
using System.Text;

namespace QLSL2018.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { set; get; }
    }
}
