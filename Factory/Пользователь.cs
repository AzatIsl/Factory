//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Factory
{
    using System;
    using System.Collections.Generic;
    
    public partial class Пользователь
    {
        public int idUser { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public Nullable<int> id_role { get; set; }
    
        public virtual Роли Роли { get; set; }
    }
}
