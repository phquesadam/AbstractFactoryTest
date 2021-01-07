using System;
using System.Collections.Generic;
using System.Text;
using TesteAbstractFactory.Interface;
using TesteAbstractFactory.Model;

namespace TesteAbstractFactory.Factory
{
    public class TratamentoFactory
    {
        //Abstract Factory
        //Vai criar uma Factory que sabe tratar os dados especificos com base em uma propriedade
        //No caso o ID da fila

        public static ITratamento CriarClasseTratamentoWebhook(DadosRetronadosWebhook dados)
        {
            Console.WriteLine("  AbstractFactory :: Selecionando a Factory de Tratamento com base na Fila");

            switch (dados.Dados.Fila)
            {
                case 1:
                    Console.WriteLine("  AbstractFactory :: Selecionado a Factory Bereau");
                    return new TratamentoRetornoBereauFactory(dados);

                case 2:
                    Console.WriteLine("  AbstractFactory :: Selecionado a Factory SPA");
                    return new TratamentoRetornoSPAFactory(dados);

                default:
                    throw new ArgumentException("Tratamento não reconhecido");
            }

        }

    }
}
