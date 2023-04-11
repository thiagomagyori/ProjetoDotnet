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



        //DateTime o metodo é bool então temos que informar se vai dar true e false
        public bool ValidarDate(DateTime DataNasc)
        {
          DateTime dataAtual = DateTime.Today;
         var idade = (dataAtual - DataNasc).TotalDays/365;

          if(idade >= 18){
            Console.WriteLine("Parabéns você tem disconto no seu seguro de carro e moto");
           return true;
          }else{
            Console.WriteLine("Você não tem desconto");
            return false;
          }

          
          
          
        throw new NotImplementedException();
        }

        //String
        public bool ValidarDate(string DataNasc)
        {
           //conversão implícita 
           if (DateTime.TryParse(DataNasc, out DateTime dataConvertida))
           {
               DateTime dataAtual = DateTime.Today;
               double idade = (dataAtual - dataConvertida).TotalDays / 365;

               if(idade >= 18){
               Console.WriteLine("Parabéns você tem disconto no seu seguro de carro e moto");
               return true;
          }else{
               Console.WriteLine("Você não tem desconto");
               return false;
          }

           
           }
           return false;
        }

        internal void Inserir(Pessoajuritica novaPjIn)
        {
            throw new NotImplementedException();
        }

        internal List<Pessoajuritica> LerArquivo()
        {
            throw new NotImplementedException();
        }
    }
}