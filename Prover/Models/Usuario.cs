using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Prover.Models
{
    [Table("Usuario")]

    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Id")]

        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]

        public string Nome { get; set; }

        [Column("Telefone")]
        [Display(Name = "Telefone")]

        public string Telefone { get; set; }

        [Column("data")]
        [Display(Name = "data")]

        public DateTime Data { get; set; }

        [Column("sexo")]
        [Display(Name = "Sexo")]

        public string Sexo { get; set; }

        [Column("ativo")]
        [Display(Name = "Ativo")]

        public bool Ativo { get; set; }

        [ForeignKey("Cargo")]
       public int CargoId { get; set; }

       public Cargo Cargo { get; set; }
    }
}
