using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projetoc_.Interfaces;

namespace Projetoc_.Classes
{
    public class Pessoa : IPessoa
    {
        //herança da IPessoa
        public float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}