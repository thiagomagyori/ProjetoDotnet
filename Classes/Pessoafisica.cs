using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projetoc_.Interfaces;

namespace Projetoc_.Classes
{
             

         //trazendo a heraça da classe pessoa e herdando herança da interface IPessoa
    public class Pessoafisica : Pessoa,IPessoafisica
    {
        public int cpf {get; set;}
        public DateTime dataNac {get; set;}

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDate(DateTime DataNasc)
        {
            throw new NotImplementedException();
        }
    }
}