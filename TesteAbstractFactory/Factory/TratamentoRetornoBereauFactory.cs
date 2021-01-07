using System;
using System.Collections.Generic;
using System.Text;
using TesteAbstractFactory.Business;
using TesteAbstractFactory.Interface;
using TesteAbstractFactory.Model;

namespace TesteAbstractFactory.Factory
{
    public class TratamentoRetornoBereauFactory : ITratamento
    {
        private readonly DadosRetronadosWebhook _dadosRetornadosWebhook;

        public TratamentoRetornoBereauFactory(DadosRetronadosWebhook dados)
        {
            _dadosRetornadosWebhook = dados;

            Console.WriteLine("    Factory Bereau :: Criada Classe");

        }

        public string TratarDadosRetorno()
        {
            Console.WriteLine("    Factory Bereau :: Transforma Dados entre Webhook -> Bereau");
            Bereau modelo = new Bereau();

            Console.WriteLine("    Factory Bereau :: Instanciando Business Especifica");
            BereauBusiness _bussines = new BereauBusiness();


            Console.WriteLine("    Factory Bereau :: Salvando Dados");
            _bussines.Salvar(modelo);

            return "Dados Tratados com sucesso";
        }
    }
}
