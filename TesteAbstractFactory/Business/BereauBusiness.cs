using System;
using System.Collections.Generic;
using System.Text;
using TesteAbstractFactory.Interface;
using TesteAbstractFactory.Model;

namespace TesteAbstractFactory.Business
{
    public class BereauBusiness : IBaseBusiness<Bereau>
    {
        public void Salvar(Bereau modelo)
        {
            Console.WriteLine($"      Business Bereau  ::  Salvando o modelo");
        }
    }
}
