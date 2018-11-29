using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_OOP___Oficina___Hudson_Junior__Luiz_Soto
{
    class Oficina
    {
        private List<Veiculo> listaVeiculos = new List<Veiculo>();

        public List<Veiculo> getListaVeiculos()
        {
            return listaVeiculos;
        }

        private Veiculo _veiculo;
        public Veiculo _Veiculo()
        {
            return _veiculo;
        }

        private iServicos _servicos;

        public Oficina()
        {

        }

        public void RealizarInspecao(string tipo)
        {
            Console.WriteLine("Carro ou moto?");
            string aux = Console.ReadLine();
            if (aux == "carro")
            {
                _veiculo = new Carro(tipo, "velho");
                listaVeiculos.Add(_veiculo);
                listaVeiculos[0].setQtdRodas();
            }
            else
            {
                _veiculo = new Moto(tipo, "velho");
                listaVeiculos.Add(_veiculo);
                listaVeiculos[0].setQtdRodas();
            }
        }

        public void RealizarInspecao(string tipo1, string tipo2)
        {
            Console.WriteLine("Referente ao 1º veiculo");
            Console.WriteLine("Carro ou moto?");
            string aux = Console.ReadLine();
            if (aux == "carro")
            {
                _veiculo = new Carro(tipo1, "velho");
                listaVeiculos.Add(_veiculo);
                listaVeiculos[0].setQtdRodas();
            }
            else
            {
                _veiculo = new Moto(tipo1, "velho");                
                listaVeiculos.Add(_veiculo);
                listaVeiculos[0].setQtdRodas();
            }

            Console.WriteLine("Referente ao 2º veiculo");
            Console.WriteLine("Carro ou moto?");
            aux = Console.ReadLine();
            if (aux == "carro")
            {
                _veiculo = new Carro(tipo2, "velho");
                listaVeiculos.Add(_veiculo);
                listaVeiculos[1].setQtdRodas();
            }
            else
            {
                _veiculo = new Moto(tipo2, "velho");
                listaVeiculos.Add(_veiculo);
                listaVeiculos[1].setQtdRodas();
            }
        }

        public void RealizarServico()
        {
            int aux = 0;
            while (aux < listaVeiculos.Count())
            {
                if (listaVeiculos[aux].TipoManutencao == "pintura")
                {
                    _servicos = new Pintura();
                }
                else
                {
                    if (listaVeiculos[aux].TipoManutencao == "pneu")
                    {
                        _servicos = new Pneu();
                    }
                    else
                    {
                        _servicos = new Mecanica();
                    }
                }
            
                Console.WriteLine("Referente ao "+ (aux+1) +"º veiculo");
                Console.WriteLine("Deseja consertar ou trocar?");
                string modo = Console.ReadLine();
                if (modo == "consertar")
                {                    
                    _servicos.Consertar(listaVeiculos[aux]);
                }
                else
                {
                    _servicos.Trocar(listaVeiculos[aux]);
                }
                aux++;
            }
        }
    }
}
