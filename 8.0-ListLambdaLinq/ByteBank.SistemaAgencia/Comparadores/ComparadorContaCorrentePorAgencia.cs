using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {            
            if (x == null)
            {
                return 10;
            }
            
            if (y == null)
            {
                return 11;
            }

            return x.Agencia.CompareTo(y.Agencia);
            /*
             * 
            
            //  Mesma lógica de comparação que o return acima;
              if (x.Agencia < y.Agencia)
            {
                return -1;
            }

            if (x.Agencia == y.Agencia)
            {
                return 0;
            }

            return 1;
             
             *
             */
        }
    }
}
