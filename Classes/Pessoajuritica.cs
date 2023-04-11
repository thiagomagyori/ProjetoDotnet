using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Projetoc_.Interfaces;

namespace Projetoc_.Classes
{
    public class Pessoajuritica : Pessoa, IPessoajuridica
    {

        public string? cnpj { get; set; }
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


//metodo que vai validar cnpj 
        public bool Validcnpj(string cnpj)
        {                                    //de 14 ou com ponto e barra
            bool checCnpj = Regex.IsMatch(cnpj, @"^(\d{14} | \d{2}.\d{3}.\d{3}/\d{4}-\d{2})$");

        if (checCnpj)
        {
            string subStringCnpj14 = cnpj.Substring(8,4);

           if (subStringCnpj14 == "0001")
           {
            return true;
           }

        }

           bool checCnpj18 = Regex.IsMatch(cnpj, @"^(\d{18} | \d{2}.\d{3}.\d{3}/\d{4}-\d{2})$");
              if (checCnpj18)
              {
                 string subStringCnpj18 = cnpj.Substring(11,4);

               if (subStringCnpj18 == "0001")
                {
                 return true;
                }
                
              }


           return false;

        }

        internal object ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}