using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Areas.Core.Models
{
    public abstract class EntityBase
    {
        [Key]
        public long Id { get; set; }

        public DateTime DataAdicao
        {
            get
            {
                return this.DataAdicao;
            }
            set
            {
                this.DataAdicao = DateTime.Now;
            }
        }
        public DateTime DataAlteracao { get; set; }
    }
}