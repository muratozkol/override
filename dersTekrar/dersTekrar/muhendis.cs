using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersTekrar
{
    internal class muhendis:Personel
    {
        string birim;
        public String Birim
        {
            get { return birim; }
            set => birim = value;
        }
    }
}
