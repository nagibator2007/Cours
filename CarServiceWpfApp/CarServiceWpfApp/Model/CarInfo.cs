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
    
    public partial class CarInfo
    {
        public int CarInfo1 { get; set; }
        public int Car_Id_FK { get; set; }
        public int Clients_Id_FK { get; set; }
    
        public virtual Car Car { get; set; }
        public virtual Clients Clients { get; set; }
    }
}
