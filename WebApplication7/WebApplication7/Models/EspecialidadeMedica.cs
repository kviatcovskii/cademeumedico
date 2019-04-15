using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class EspecialidadeMedica
    {
        public int EspecialidadeMedicaID { get; set; }
        public string Especialidade { get; set; }
        public int MedicoID { get; set; }

        [ForeignKey("EspecialidadeMedicaID")]
        public virtual Medico Medico { get; set; }

    }
}