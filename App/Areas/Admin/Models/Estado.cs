using App.Areas.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace App.Areas.Admin.Models
{
    [Table("Estado")]
    public class Estado : EntityBase
    {
        [Column("Descricao"), 
        StringLength(2, ErrorMessage = "Descrição pode conter somente 50 (cinquenta) caracteres"),
        MinLength(2, ErrorMessage = "Descrição deve conter mais que 2 (dois) caracteres"),
        MaxLength(50, ErrorMessage = "Descrição deve conter no máximo 50 (cinquenta) caracteres")]
        public string Descricao { get; set; }

        [Column("Sigla"), 
        StringLength(2, ErrorMessage = "Sigla pode conter somente 2 (dois) caracteres"), 
        MinLength(2, ErrorMessage = "Informe no mínimo duas letras"),
        MaxLength(2, ErrorMessage = "Informe no máximo duas letras")]
        public string Sigla { get; set; }

        [Column("CodigoIbge"),
        MinLength(2, ErrorMessage = "Informe no mínimo 2 (dois) números"),
        MaxLength(2, ErrorMessage = "Informe no máximo 2 (dois) números")]
        public long CodigoIbge { get; set; }
    }
}