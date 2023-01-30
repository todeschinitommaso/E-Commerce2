using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    public class Alimentare : prodotto
    {
        private DateTime _scadenza;
        private decimal _scontato;
        private string[] _ingredienti;

        public Alimentare(string id, string nome, string prod, string descr, decimal prezzo, DateTime scadenza) : base(id, nome, prod, descr, prezzo)
        {
            Scadenza = scadenza;
            Scontato = prezzo;
            _ingredienti = new string[10];
        }

        public DateTime Scadenza
        {
            get
            {
                return _scadenza;
            }
            private set
            {
                if (value > DateTime.Today)
                    _scadenza = value;
                else
                    throw new Exception("Inserire un codice valido");
            }
        }
        public decimal Scontato
        {
            get
            {
                return _scontato;
            }
            set
            {
                if (value > 0)
                    _scontato = value;
                else
                    throw new Exception("Il prezzo deve essere positivo");
            }
        }
        public void ApplicaS()
        {
            if (DateTime.Today.DayOfWeek - Scadenza.DayOfWeek < 7)
            {
                Scontato = 0.5m * Prezzo;
            }
        }

        public void Carica(string a, string b, string c, string d, string e, string f, string g, string h, string i, string l)
        {
            _ingredienti[0] = a;
            _ingredienti[1] = b;
            _ingredienti[2] = c;
            _ingredienti[3] = d;
            _ingredienti[4] = e;
            _ingredienti[5] = f;
            _ingredienti[6] = g;
            _ingredienti[7] = h;
            _ingredienti[8] = i;
            _ingredienti[9] = l;
        }

    }
}