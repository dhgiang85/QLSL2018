using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace QLSL2018.Data.Enums
{
    public enum DeviceType
    {
        
        [Description("Đèn tín hiệu")]
        TL = 0,        
        [Description("Bảng quang báo")]
        VMS = 1,
        [Description("Camera")]
        CAM = 3,
        [Description("Trạm cân")]
        WIM = 2
    }
}
