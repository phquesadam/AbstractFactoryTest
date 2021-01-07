using System;
using System.Collections.Generic;
using System.Text;
using TesteAbstractFactory.Business;
using TesteAbstractFactory.Interface;
using TesteAbstractFactory.Model;

namespace TesteAbstractFactory.Factory
{
    public class TratamentoRetornoSPAFactory : ITratamento
    {
        private readonly DadosRetronadosWebhook _dadosRetornadosWebhook;

        public TratamentoRetornoSPAFactory(DadosRetronadosWebhook dados)
        {
            _dadosRetornadosWebhook = dados;

            Console.WriteLine("    Factory SPA :: Criada Classe");
        }

        public string TratarDadosRetorno()
        {
            Console.WriteLine("    Factory SPA :: Transforma Dados entre Webhook -> Bereau");
            SPA modelo = new SPA();

            Console.WriteLine("    Factory SPA  :: Instanciando Business Especifica");
            SPABusiness _bussines = new SPABusiness();


            Console.WriteLine("    Factory SPA :: Salvando Dados");
            _bussines.Salvar(modelo);

            return "Dados Tratados com sucesso";

        }
    }
}
