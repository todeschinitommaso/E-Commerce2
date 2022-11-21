using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    public class carrello
    {

        private string _id;

        private prodotto[] prodotti = new prodotto[100];

        private int counter;

        public carrello(string id)
        {
            Id = id;
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public void Aggiungi(prodotto p)
        {
            p.Id = prodotti[counter].Id;
            counter++;
        }
        public void Rimuovi(prodotto p)
        {
            p.Id = prodotti[counter].Id;
            counter--;
        }
        public int getProdotti()
        {
            return counter;
        }
        public void Svuota()
        {
            for (int i = 0; i < counter; i++)
                prodotti[i] = null;
            counter = 0;
        }
    }
}
