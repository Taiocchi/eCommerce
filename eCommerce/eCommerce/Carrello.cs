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

        private List<Prodotto> prodottiCarrello;

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
            if (prodotto == null)
                return;
            prodottiCarrello.Add(prodotto);
        }
        public void rimuoviProdotto(Prodotto prodotto)
        {
            if (prodotto == null)
                return;
            if(prodottiCarrello.IndexOf(prodotto)!=-1)
                prodottiCarrello.Remove(prodotto);
        }
        public void svuotaCarrello()
        {
            prodottiCarrello.Clear();
        }

        public Carrello(string identificativo)
        {
            this.identificativo = identificativo;
            prodottiCarrello = new List<Prodotto>();
        }
    }
}
