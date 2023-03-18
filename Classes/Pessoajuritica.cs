using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projetoc_.Interfaces;

namespace Projetoc_.Classes
{
    public class Pessoajuritica : Pessoa, IPessoajuridica
    {

        public int cnpj { get; set; }
        public string? razaoSocial { get; set; }



        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                float res = rendimento * 0.03f;
                return res;

            }
            else if (rendimento > 3000 && rendimento <= 6000)
            {
                float res = rendimento * 0.05f;
                return res;

            }
            else if (rendimento > 600 && rendimento <= 10000)
            {
                float res = rendimento * 0.07f;
                return res;
            }
            else
            {
                float res = rendimento * 0.09f;
                return res;
            }


        }

        public bool Validcnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}