using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_OOP___Oficina___Hudson_Junior__Luiz_Soto
{
    class Program
    {
        static void Main(string[] args)
        {
            Oficina _oficina = new Oficina();

            Console.WriteLine("Digite a quantidade de Inspecões: ");
            int qtdInspecao = 0;
            try
            {
                qtdInspecao = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite em numeral!");
            }
            if (qtdInspecao == 1)
            {
                Console.WriteLine("Digite o tipo de manutenção: ");
                _oficina.RealizarInspecao(Console.ReadLine());
            }
            else
            {
                if (qtdInspecao == 2)
                {
                    Console.WriteLine("Digite o tipo da 1ª manutencao: ");
                    string tipo1 = Console.ReadLine();
                    Console.WriteLine("Digite o tipo da 2ª manutencao: ");
                    string tipo2 = Console.ReadLine();
                    _oficina.RealizarInspecao(tipo1, tipo2);
                }
            }
            
            _oficina.RealizarServico();

            for(int i = 0; i < _oficina.getListaVeiculos().Count(); i++)
            {
                Console.WriteLine(_oficina.getListaVeiculos()[i].EstadoManutencao);

                Console.WriteLine(_oficina.getListaVeiculos()[i].getQtdRodas());
            }            

            Console.ReadKey();
        }
    }
}
