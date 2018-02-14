using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SEGI.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }        
        public string Mae { get; set; }
        public string Pai { get; set; }
        public int Idade { get; set; }
        
    }
}
