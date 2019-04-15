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

    public partial class Pais
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pais()
        {
            this.Estado = new HashSet<Estado>();
        }
    
        public int id_pais { get; set; }


        [Required(ErrorMessage = "OBRIGADO INFOMAR PAIS")]
        [StringLength(20, ErrorMessage = "O PAIS DEVE POSSUIR 20 CARACTERES")]
        public string pais1 { get; set; }



        [Required(ErrorMessage = "OBRIGADO INFOMAR SIGLA")]
        [StringLength(2, ErrorMessage = "A SIGLA DEVE POSSUIR 2 CARACTERES")]
        public string sigla { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estado> Estado { get; set; }
    }
}
