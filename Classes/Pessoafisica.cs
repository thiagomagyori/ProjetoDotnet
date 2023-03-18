using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projetoc_.Interfaces;

namespace Projetoc_.Classes
{


    //trazendo a heraça da classe pessoa e herdando herança da interface IPessoa
    public class Pessoafisica : Pessoa, IPessoafisica
    {
        public int cpf { get; set; }
        public DateTime dataNac { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;

            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                float res = (rendimento / 100) * 2;
                return res;

            }
            else if (rendimento > 3500 && rendimento <= 6000)
            {
                float res = (rendimento / 100) * 3.5f;
                return res;
            }
            else
            {
                float res = (rendimento / 100) * 5;
                return res;
            }


        }



        //DateTime
        public bool ValidarDate(DateTime DataNasc)
        {
         throw new NotImplementedException();
        }

        //String
        public bool ValidarDate(string DataNasc)
        {
            throw new NotImplementedException();
        }
    }
}