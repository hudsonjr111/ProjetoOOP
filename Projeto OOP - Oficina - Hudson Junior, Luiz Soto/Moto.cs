using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_OOP___Oficina___Hudson_Junior__Luiz_Soto
{
    class Moto : Veiculo
    {
        public Moto(string tipo, string estado) : base(tipo, estado)
        {

        }

        public override void setQtdRodas()
        {
            _qtdRodas = 2;
        }
    }
}
