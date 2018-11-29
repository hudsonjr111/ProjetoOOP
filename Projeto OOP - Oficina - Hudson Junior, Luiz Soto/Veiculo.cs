using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_OOP___Oficina___Hudson_Junior__Luiz_Soto
{
    abstract class Veiculo
    {
        protected int _qtdRodas;
        public abstract void setQtdRodas();
        public int getQtdRodas() { return _qtdRodas; }

        private string tipoManutencao;
        public string TipoManutencao
        {
            get { return tipoManutencao; }
            set { tipoManutencao = value; }
        }

        private string estadoManutencao;
        public string EstadoManutencao
        {
            get { return estadoManutencao; }
            set { estadoManutencao = value; }
        }


        public Veiculo(string tipo, string estado)
        {
            tipoManutencao = tipo;
            estadoManutencao = estado;
        }
    }
}
