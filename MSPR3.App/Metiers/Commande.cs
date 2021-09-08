﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPR3.Metiers
{
    /// <summary>
    /// Classe Commande
    /// </summary>
    public class Commande
    {
        private int id;
        private DateTime date;
        private Dictionary<Produit, int> produits; // TODO A verifier avec la team


        # region getters and setters 
        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public Dictionary<Produit, int> Produits { get => produits; set => produits = value; }
        #endregion

        /// <summary>
        /// Construteur de la classe Commande
        /// </summary>
        /// <param name="id"> id d'une commande</param>
        /// <param name="date"> Date d'une commande</param>
        /// <param name="produits"> Liste des produits de la commande</param>
        public Commande(int id, DateTime date, Dictionary<Produit, int> produits)
        {
            this.id = id;
            this.date = date;
            this.produits = produits;
        }

        
    }
}
