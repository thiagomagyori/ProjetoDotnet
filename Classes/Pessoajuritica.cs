using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projetoc_.Interfaces;

namespace Projetoc_.Classes
{
    public class Pessoajuritica : Pessoa, IPessoajuridica
    {

     public int cnpj {get; set;}
     public string? razaoSocial {get; set;}



        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool Validcnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}