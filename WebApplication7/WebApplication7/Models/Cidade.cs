//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication7.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Cidade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cidade()
        {
            this.Medico = new HashSet<Medico>();
        }
    
        public int id_cidade { get; set; }
        public Nullable<int> id_estado { get; set; }

        [Required(ErrorMessage = "OBRIGADO INFOMAR CIDADE")]
        [StringLength(30, ErrorMessage = "A CIDADE DEVE POSSUIR 30 CARACTERES")]
        public string cidade1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medico> Medico { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
