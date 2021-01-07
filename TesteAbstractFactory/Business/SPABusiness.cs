using System;
using System.Collections.Generic;
using System.Text;
using TesteAbstractFactory.Interface;
using TesteAbstractFactory.Model;

namespace TesteAbstractFactory.Business
{
    public class SPABusiness : IBaseBusiness<SPA>
    {
        public void Salvar(SPA modelo)
        {
            Console.WriteLine($"      Business SPA  ::  Salvando o modelo");
        }
    }
}
