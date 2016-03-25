using App.Areas.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace App.Areas.Admin.Models
{
    [Table("Cidade")]
    public class Cidade : EntityBase
    {
        [Column("Descricao"),
        StringLength(2, ErrorMessage = "Descrição pode conter somente 50 (cinquenta) caracteres"),
        MinLength(2, ErrorMessage = "Descrição deve conter mais que 2 (dois) caracteres"),
        MaxLength(50, ErrorMessage = "Descrição deve conter no máximo 50 (cinquenta) caracteres")]
        public string Descricao { get; set; }

        public long UF { get; set; }
        [ForeignKey("Id")]
        public List<Estado> Estado { get; set; }

        [Column("CodigoIbge"),
        MinLength(2, ErrorMessage = "Informe no mínimo 2 (dois) números"),
        MaxLength(2, ErrorMessage = "Informe no máximo 2 (dois) números")]
        public long CodigoIbge { get; set; }
    }
}