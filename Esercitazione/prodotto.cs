﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public abstract class prodotto
    {
        private string _id;
        private string _nome;
        private string _produttore;
        private decimal _prezzo;
        private string _descrizione;
        private decimal _scontato;

        public prodotto(string id, string nome, string prod, string descr, decimal prezzo)
        {
            Id = id;
            Nome = nome;
            Produttore = prod;
            Descrizione = descr;
            Prezzo = prezzo;
            Scontato = prezzo;
        }

        public virtual string[] TuString()
        {
            string[] p = { Id, Nome, Produttore, Convert.ToString(Prezzo), Convert.ToString(Scontato), "", Descrizione };
            return p;
        }

        public bool Equals(prodotto p)
        {
            if (p == null) return false;

            if (this == p) return true;

            return (this.Id == p.Id);
        }

        public decimal Prezzo
        {
            get
            {
                return _prezzo;
            }

            set
            {
                if (value > 0)
                    _prezzo = value;
                else
                    throw new Exception("Inserire un prezzo valido");
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
                    throw new Exception("Inserire un prezzo valido");
            }
        }

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

        public string Nome
        {
            get
            {
                return _nome;
            }

            private set
            {
                if (value != null)
                    _nome = value;
                else
                    throw new Exception("Inserire un nome valido");
            }
        }

        public string Produttore
        {
            get
            {
                return _produttore;
            }

            private set
            {
                if (value != null)
                    _produttore = value;
                else
                    throw new Exception("Inserire un produttore valido");
            }
        }

        public string Descrizione
        {
            get
            {
                return _descrizione;
            }

            private set
            {
                if (value != null)
                    _descrizione = value;
                else
                    throw new Exception("Inserire una descrizione valida");
            }
        }

        public void Sconto(decimal discount)
        {
            if (Scontato == Prezzo)
            {
                if (discount > 0)
                    Scontato -= Prezzo * (discount / 100);
                else
                    throw new Exception("Sconto non valido");
            }
        }

        public virtual void ApplicaS()
        {
            Scontato = Prezzo;
        }
    }
}