//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DFS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ImageServerInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImageServerInfo()
        {
            this.ImageInfo = new HashSet<ImageInfo>();
        }
    
        public int ServerId { get; set; }
        public string ServerName { get; set; }
        public string ServerUrl { get; set; }
        public string PicRootPath { get; set; }
        public int MaxPicCount { get; set; }
        public int CurPicAmount { get; set; }
        public bool FlgUsable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageInfo> ImageInfo { get; set; }
    }
}
