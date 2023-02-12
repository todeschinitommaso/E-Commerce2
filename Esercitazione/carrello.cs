using Esercitazione;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class carrello
    {
        private string _id;
        private prodotto[] _prodotti = new prodotto[100];

        public string Id
        {
            get
            {
                return _id;
            }

            private set
            {
                if (value != null)
                    _id = value;
                else
                    throw new Exception("Inserire un ID valido");
            }
        }

        public prodotto getProdotto(int i)
        {
            return _prodotti[i];
        }

        public carrello(string id)
        {
            this.Id = id;
            Svuota();
        }

        private int getNumProdotti()
        {
            int i = 0;
            while (i < _prodotti.Length && _prodotti[i] != null)
            {
                i++;
            }

            if (i != _prodotti.Length)
                return i;

            else
                throw new Exception("Il carrello è pieno");
        }

        public void Aggiungi(prodotto p)
        {
            if (p != null)
            {
                p.ApplicaS();
                _prodotti[getNumProdotti()] = p;
            }

            else
                throw new Exception("Inserire un prodotto valido");
        }

        public int Cerca(prodotto p)
        {
            int pos = -1;
            for (int i = 0; i < 99; i++)
            {
                if (_prodotti[i] == p)
                {
                    pos = i;
                }
            }
            return pos;
        }

        public void Svuota()
        {
            for (int i = 0; i < 100; i++)
            {
                _prodotti[i] = null;
            }
        }

        public prodotto Rimuovi(prodotto p)
        {
            int pos = Cerca(p);
            if (pos != -1)
            {
                _prodotti[pos] = null;

                for (int i = pos; i < 99; i++)
                {
                    _prodotti[i] = _prodotti[i + 1];
                }
                return p;
            }

            else
                throw new Exception("Prodotto non esistente");
        }

        public decimal Calctot()
        {
            decimal tot = 0;
            for (int i = 0; i < 99; i++)
            {
                if (_prodotti[i] != null)
                {
                    tot += _prodotti[i].Prezzo;
                }
            }
            return tot;
        }

        public decimal Calctots()
        {
            decimal tot = 0;
            for (int i = 0; i < 99; i++)
            {
                if (_prodotti[i] != null)
                {
                    tot += _prodotti[i].Scontato;
                }
            }

            int c = 0;
            for (int i = 0; i < 99; i++)
            {
                if (_prodotti[i] != null)
                {
                    if (_prodotti[i].GetType() == typeof(PElettronico))
                    {
                        c = 1;
                    }
                }
            }

            if (c == 1)
            {
                tot -= tot * (5 / 100);
            }
            return tot;
        }
    }
}
