//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDuAn.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CongViec
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CongViec()
        {
            this.DuAns = new HashSet<DuAn>();
        }
    
        public string MaCongViec { get; set; }
        public string TenCongViec { get; set; }
        public string NoiDungCongViec { get; set; }
        public string ListNhomPhuTrach { get; set; }
        public Nullable<int> ChiPhi { get; set; }
        public Nullable<System.DateTime> DuKienHoanThanh { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<int> TienDo { get; set; }
        public Nullable<System.DateTime> NgayHoanThanh { get; set; }
       
        public virtual Nhom Nhom { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DuAn> DuAns { get; set; }
    }
}
