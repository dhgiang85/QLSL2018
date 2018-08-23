using QLSL2018.Data.Enums;
using QLSL2018.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSL2018.Data.Entities
{
    [Table("DevGeocodes")]
    public class DevGeocode : DomainEntity<int>
    {
        public decimal? Lat { get; set; }
        public decimal? Lng { get; set; }
        public DeviceType DeviceType { get; set; }
        public CCTV CCTV { get; set; }

    }
}
