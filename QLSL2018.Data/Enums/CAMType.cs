using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace QLSL2018.Data.Enums
{
    public enum CAMType
    {
        [Description("Chưa biết")]
        UnKnow = 0,
        [Description("Cố định")]
        FixAngle = 1,
        [Description("PTZ")]
        PTZ = 2
    }
}
