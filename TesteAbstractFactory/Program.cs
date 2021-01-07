using System;
using TesteAbstractFactory.Factory;
using TesteAbstractFactory.Interface;
using TesteAbstractFactory.Model;

namespace TesteAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Client :: Instanciando Objeto do Bereau");
            DadosRetronadosWebhook retornoBereau = new DadosRetronadosWebhook()
            {
                Identification = new object(),
                Dados = new DadosRetorno()
                {
                    Fila = 1,
                    Retorno = "Bereau é dificil de escrever, mas vim pelo webhook"
                }
            };

            Console.WriteLine("Client :: Obtendo a Factory que sabe converter o dados Retorno em Bereau");
            ITratamento _classeTratamentoBereau = TratamentoFactory.CriarClasseTratamentoWebhook(retornoBereau);

            Console.WriteLine("Client :: Tratando os dados do Bereau");
            _classeTratamentoBereau.TratarDadosRetorno();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Client :: Instanciando Objeto do SPA");
            DadosRetronadosWebhook retornoSPA = new DadosRetronadosWebhook()
            {
                Identification = new object(),
                Dados = new DadosRetorno()
                {
                    Fila = 2,
                    Retorno = "Dados de Entrada vindos do webhook para o SPA"
                }
            };

            Console.WriteLine("Client :: Obtendo a Factory que sabe converter o dados Retorno em SPA");
            ITratamento _classeTratamentoSPA = TratamentoFactory.CriarClasseTratamentoWebhook(retornoSPA);

            Console.WriteLine("Client :: Tratando os dados do SPA");
            _classeTratamentoSPA.TratarDadosRetorno();


            Console.ReadLine();

        }

    }
}
