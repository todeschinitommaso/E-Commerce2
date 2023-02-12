using Esercitazione;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class PCancelleria : prodotto
    {
        public PCancelleria(string id, string nome, string prod, string descr, decimal prezzo) : base(id, nome, prod, descr, prezzo)
        {
        }

        public override void ApplicaS()
        {
            if (DateTime.Today.Day % 2 == 0)
                Sconto(3);
        }
    }
}