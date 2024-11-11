using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    internal class Carrello
    {
        private string identificativo;

        private List<Prodotto> prodottiCarrello = new List<prodotto>();

        public List<Prodotto> ProdottiCarrello
        {
            get { return prodottiCarrello; }
        }
        public string Identificativo
        {
            get { return identificativo; }
        }
        public void aggiungiProdotto(Prodotto prodotto)
        {
            prodottiCarrello.Add(prodotto);
        }
        public void rimuoviProdotto(Prodotto prodotto)
        {
            prodottiCarrello.Remove(prodotto);
        }
        public void svuotaCarrello()
        {
            prodottiCarrello.Clear();
        }
    }
}
