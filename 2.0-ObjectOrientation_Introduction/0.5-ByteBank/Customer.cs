using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._5_ByteBank
{
    public class Customer
    {
        //  Changes made according to teacher's instructions!
        private string _cpf;

        public string Name { get; set; }
        public string CPF 
        {
            get 
            {
                return _cpf;
            }
            set
            {
                //  Type here your validation!
                _cpf = value;
            } 
        }
        public string Profession { get; set; }
    }
}
