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
    
    public partial class Store
    {
        public Store()
        {
            this.Spare = new HashSet<Spare>();
        }
    
        public int Srore_Id { get; set; }
        public string Store_ProductName { get; set; }
    
        public virtual ICollection<Spare> Spare { get; set; }
    }
}
