using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione
{
    public class Elettronico:prodotto
    {
        public string _codice;
        public decimal _scontato;
        public Elettronico(string id, string nome, string produttore, string descrizione, decimal prezzo, string codice, decimal scontato) : base(id, nome, produttore, descrizione, prezzo)
        {
            Codice = codice;
            Scontato = prezzo;
        }
        public string Codice
        {
            get
            {
                return _codice;
            }
            private set
            {
                if (value != null)
                    _codice = value;
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

            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                Scontato = 0.95m * Prezzo;
            }
        }
    }
}
