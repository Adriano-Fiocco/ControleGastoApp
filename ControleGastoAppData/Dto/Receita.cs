using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastoAppData.Dto
{
    public class Receita
    {
        public int CodReceita { get; set; }
        public int CodPessoa { get; set; }
        public double ValorRenda { get; set; }
        public string TipoRenda { get; set; }

        public Receita(int codPessoa, int quantRenda, double valorRenda, string tipoRenda)
        {
            CodPessoa = codPessoa;
            ValorRenda = valorRenda;
            TipoRenda = TipoRenda;
        }
        public Receita()
        {

        }

    }
}
