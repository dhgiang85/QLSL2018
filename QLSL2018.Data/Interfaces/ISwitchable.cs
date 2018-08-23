using QLSL2018.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLSL2018.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
