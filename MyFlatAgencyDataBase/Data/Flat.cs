//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFlatAgencyDataBase.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flat
    {
        public int Id { get; set; }
        public string FlatName { get; set; }
        public int FlatSize { get; set; }
        public int RoomsCount { get; set; }
        public string Address { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
