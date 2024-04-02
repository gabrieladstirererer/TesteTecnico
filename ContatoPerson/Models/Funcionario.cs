using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContatoPerson.Models
{
    public class Funcionario
    {
        // Models
        public int id { get; set; }
        public string  Nome { get; set; }
        public string DataNascimento { get; set; }
        public string  CPF { get; set; }
        public string  Endereco { get; set; }
        public string  Sexo { get; set; }
       
    }
}
