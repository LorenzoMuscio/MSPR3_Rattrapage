﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPR3.Metiers
{
    /// <summary>
    /// Classe Service
    /// </summary>
    public class Service
    {
        private int id;
        private string designation;
        private List<Salarie> salaries;

        #region getters and setters

        public int Id { get => id; set => id = value; }
        public string Designation { get => designation; set => designation = value; }
        public List<Salarie> Salaries { get => salaries; set => salaries = value; }

        #endregion

        /// <summary>
        /// Constructeur de la classe Service
        /// </summary>
        /// <param name="id">Id du service</param>
        /// <param name="designation">Désignation du service</param>
        /// <param name="salaries">Liste des salariés du service</param>
        public Service(int id, string designation, List<Salarie> salaries)
        {
            this.id = id;
            this.designation = designation;
            this.salaries = salaries;
        }


    }
}
