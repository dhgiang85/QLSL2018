
using QLSL2018.Data.Enums;
using QLSL2018.Data.Interfaces;
using QLSL2018.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace QLSL2018.Data.Entities
{
    [Table("CCTVs")]
    public class CCTV : DomainEntity<int>, ISwitchable
    {
        [Required]
        [Display(Name = "Tên CCTV")]
        [StringLength(256, MinimumLength = 2)]
        public string Name { get; set; }

        [Display(Name = "Địa Chỉ")]
        [StringLength(256)]
        public string Address { get; set; }

        [Display(Name = "IP")]
        [StringLength(15)]
        [RegularExpression(
            "^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$",
            ErrorMessage = "Invalid IP format")]
        public string IP { get; set; }

        [Display(Name = "Hãng sản xuất")]
        [StringLength(30, ErrorMessage = "Manufacturer must be under 30 characters.")]
        public string Manufacturer { get; set; }

        [StringLength(60, ErrorMessage = "Model must be under 60 characters.")]
        public string Model { get; set; }

        [Display(Name = "Năm lắp đặt")]
        [Range(1900, 2200)]
        public int YearInstall { get; set; }

        [Display(Name = "Ghi chú")]
        [StringLength(200, ErrorMessage = "Ghi chú must be under 200 characters.")]
        public string Note { get; set; }

        [Display(Name = "Map")]
        public bool Map { get; set; }

        public Status Status { get; set; }
        
        public CAMType CAMType { get; set; }

        [ForeignKey("OwerCCTV")]
        public int? OwerCCTVId { get; set; }
        public CCTVOwer OwerCCTV { get; set; }
        
        [ForeignKey("LocatyCCTV")]
        public int? LocatyCCTVId { get; set; }
        public virtual CCTVOwer LocatyCCTV { get; set; }


        [ForeignKey("DevGeocode")]
        public int? DevGeocodeId { get; set; }
        public DevGeocode DevGeocode { get; set; }

        public IList<CCTVZone> CCTVZones { get; set; }

        public virtual ICollection<CCTVStatus> CCTVStatuses { get; set; }
       
    }

    [Table("Zones")]
    public class Zone : DomainEntity<int>
    {
        [StringLength(60)]
        public string Name { get; set; }
        public IList<CCTVZone> CCTVZones { get; set; }
    }

    [Table("CCTVZones")]
    public class CCTVZone 
    {
        public int CCTVId { get; set; }
        public CCTV CCTV { get; set; }

        public int ZoneId { get; set; }
        public Zone Zone { get; set; }
    }

    [Table("CCTVOwers")]
    public class CCTVOwer : DomainEntity<int>
    {
        [StringLength(30)]
        public string Name { get; set; }

        [InverseProperty("OwerCCTV")]
        public virtual ICollection<CCTV> Ower { get; set; }
        [InverseProperty("LocatyCCTV")]
        public virtual ICollection<CCTV> Locaty { get; set; }
    }

    [Table("CCTVStatuses")]
    public class CCTVStatus : DomainEntity<int>, IEventTracking, IHasSoftDelete
    {

        [Display(Name = "Liên hệ")]
        [StringLength(200, ErrorMessage = "Người liên hệ không được quá 200 ký tự")]
        public string ContactName { get; set; }

        [Display(Name = "Nhân viên")]
        [StringLength(50)]
        public string OperatorName { get; set; }

        [Display(Name = "Chi tiết")]
        [StringLength(500, ErrorMessage = "Chi tiết không được quá 500 ký tự")]
        public string Details { get; set; }

        public bool Processed { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateProcessed { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateOccured { get; set; }

        public bool IsDeleted { get; set; }

        [ForeignKey("CCTV")]
        public int CCTVId { get; set; }
        public virtual CCTV CCTV { get; set; }


        [ForeignKey("CCTVError")]
        public int CCTVErrorId { get; set; }
        public virtual CCTVError CCTVError { get; set; }

    }

    [Table("CCTVErrors")]
    public class CCTVError : DomainEntity<int>
    {
        [StringLength(60)]
        public string Name { get; set; }

        public virtual ICollection<CCTVStatus> CCTVStatuses { get; set; }
    }
}
