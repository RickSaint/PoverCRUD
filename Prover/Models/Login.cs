using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Prover.Models
{
    [Table("Login")]

    public class Login
    {
        [Column("Id")]
        [Display(Name = "Name")]

        public int Id { get; set; }

        [Column("Detalhes")]
        [Display(Name = "Detalhes")]

        public string Detalhes { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]

        public string Email { get; set; }
    }
}
