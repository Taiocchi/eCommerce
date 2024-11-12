using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    internal class Prodotto
    {
        private string marca;
        private string modello;
        private double prezzo;
        private string identificativo;

        public string Marca
        {
            get { return marca; }
        }
        public string Modello
        {
            get { return modello; }
        }
        public double Prezzo
        {
            get { return prezzo; }
            set { prezzo = value; }
        }
        public string Identificativo
        {
            get { return identificativo; }
        }

        public Prodotto(string marca, string modello, string identificativo)
        {
            this.marca = marca;
            this.modello = modello;
            this.identificativo = identificativo;
        }
    }
}
