using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    public class Cancelleria : prodotto
    {
        public int _grammatura;
        public string _funzionamento;

        public Cancelleria(string id, string nome, string prod, string descr, decimal prezzo, int grammatura, string funzionamento) : base(id, nome, prod, descr, prezzo)
        {
            Grammatura = grammatura;
            Funzionamento = funzionamento;
        }

        public string Funzionamento
        {
            get
            {
                return _funzionamento;
            }
            private set
            {
                if (value != null)
                    _funzionamento = value;
                else
                    throw new Exception("Inserire un funzionamento valido");
            }
        }
        public int Grammatura
        {
            get
            {
                return _grammatura;
            }
            set
            {
                if (value > 0)
                    _grammatura = value;
                else
                    throw new Exception("Grammatura errata");
            }
        }

        public decimal CalcolaPrezzoScontato()
        {
            decimal prezzoScontato = Prezzo;
            if (DateTime.Today.Day % 2 == 0)
                prezzoScontato -= Prezzo * 0.05m;
            return prezzoScontato;
        }
    }
}

