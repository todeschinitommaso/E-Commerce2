using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    public class Alimentare : prodotto
    {
        public DateTime scadenza;
        public Alimentare(string id, string nome, string produttore, string descrizione, decimal prezzo, DateTime scadenza) : base(id, nome, produttore, descrizione, prezzo)
        {
            this.scadenza = scadenza;
        }

    }
}