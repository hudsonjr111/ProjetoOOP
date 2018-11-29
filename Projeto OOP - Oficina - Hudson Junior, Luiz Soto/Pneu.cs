using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_OOP___Oficina___Hudson_Junior__Luiz_Soto
{
    class Pneu : iServicos
    {
        public Pneu()
        {

        }

        public void Consertar(Veiculo veiculo)
        {
            veiculo.EstadoManutencao = "Remendado";
        }

        public void Trocar(Veiculo veiculo)
        {
            veiculo.EstadoManutencao = "Novo";
        }
    }
}
