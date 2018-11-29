using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_OOP___Oficina___Hudson_Junior__Luiz_Soto
{
    class Mecanica : iServicos
    {
        public Mecanica()
        {

        }

        public void Consertar(Veiculo veiculo)
        {
            veiculo.EstadoManutencao = "Consertado";
        }

        public void Trocar(Veiculo veiculo)
        {
            veiculo.EstadoManutencao = "Novo";
        }
    }
}