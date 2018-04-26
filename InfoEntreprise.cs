﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace app_lp
{
    class InfoEntreprise
    {
    /// <summary>
    /// cette classe permet de renseigner les informations de l'entreprise
    /// </summary>

        public string nomEntreprise { get; set; } //raison sociale
        public string activite { get; set; }
        public string date_creation;
        public string adresse { get; set; }
        public string statut { get; set; }

        public string statut_commercial;//forme juridique
        public string association_fiscalise { get; set; }

        public string adresse1 { get; set; }
        public string code_postal { get; set; }
        public string ville { get; set; }
        public string nom_contact { get; set; }
        public string prenom { get; set; }
        public string id_session { get; set; }


        public string raison_sociale { get; set; }
        public string annee_exercice;
        public string presentation { get; set; }

        public string fonction { get; set; }
        public string ca { get; set; }
        public string effectif { get; set; }
        public string organisation_comptable { get; set; }
        public string volume_recette { get; set; }
        public string date_immatriculation { get; set; }
        public string lieu_immatriculation { get; set; }







        public DateTime getDate()
        {
            return DateTime.ParseExact(date_creation, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }







    }
}