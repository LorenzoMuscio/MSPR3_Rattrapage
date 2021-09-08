﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPR3.Metiers
{
    /// <summary>
    /// Classe Salarie
    /// </summary>
    public class Salarie
    {

        private int id;
        private string prenom;
        private string nom;
        private DateTime dateNaiss;


        #region getters and setters
        public int Id { get => id; set => id = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public DateTime DateNaiss { get => dateNaiss; set => dateNaiss = value; }
        #endregion

        /// <summary>
        /// Constructeur de la classe Salarie
        /// </summary>
        /// <param name="id">id du salarié</param>
        /// <param name="prenom">prénom du salarié</param>
        /// <param name="nom"> nom du salarié</param>
        /// <param name="dateNaiss"> date de naissance du salarié</param>
        public Salarie(int id, string prenom, string nom, DateTime dateNaiss)
        {
            this.id = id;
            this.prenom = prenom;
            this.nom = nom;
            this.dateNaiss = dateNaiss;
        }

        
    }
}
