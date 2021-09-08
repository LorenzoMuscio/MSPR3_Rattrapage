﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPR3.Metiers
{
    /// <summary>
    /// CLasse Produit
    /// </summary>
    public class Produit
    {
        private int id;
        private string designation;
        private int quantite;
        private double prix;


        #region getters and setters
        public int Id { get => id; set => id = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public double Prix { get => prix; set => prix = value; }
        #endregion

        /// <summary>
        /// Constructeur de la classe Produit
        /// </summary>
        /// <param name="id">Id du produit </param>
        /// <param name="designation">Désignation du produit</param>
        /// <param name="quantite">Quantite disponible pour un produit</param>
        /// <param name="prix">Prix d'un produit</param>
        public Produit(int id, string designation, int quantite, double prix)
        {
            this.id = id;
            this.designation = designation;
            this.quantite = quantite;
            this.prix = prix;
        }
    }
}
