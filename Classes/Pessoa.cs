using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projetoc_.Interfaces;

namespace Projetoc_.Classes
{
    public abstract class Pessoa : IPessoa
    {

     //atributos, IPessoa

     //get set pode ser alterado e consultado "?" diz que a variavel nome está sendo carregada vazia
     public string? nome {get; set;}

     public Endereco? endereco {get; set;}

     public float rendimento {get; set;}



        //herança da IPessoa
        public abstract float CalcularImposto(float rendimento);

    }
}