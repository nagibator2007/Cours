//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarServiceWpfApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Services
    {
        public Services()
        {
            this.ServicesInfo = new HashSet<ServicesInfo>();
        }
    
        public int Service_Id { get; set; }
        public string Services_Name { get; set; }
        public string Services_Count { get; set; }
    
        public virtual ICollection<ServicesInfo> ServicesInfo { get; set; }
    }
}
