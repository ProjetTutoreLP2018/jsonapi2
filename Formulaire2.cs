using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app_lp
{
    class Formulaire2 : FormulaireAbstract
    {
        new public const string id_question_nom_entreprise = "t8sY49V9KNrO";
        //public const string id_question_raison_sociale = "t8sY49V9KNrO";
        public const string id_question_annee_exercice = "UvkGZwgvv4ew";
        public const string id_question_presentation = "XHnKoFryrUed";
        public const string id_question_nom = "Y83NJ0CQrBsq";
        public const string id_question_prenom = "Fiy3q2cF7KVk";
        public const string id_question_fonction = "m9RIpcje7Yox";
        public const string id_question_ca = "g0WUh9KgPBBM";
        public const string id_question_effectif = "FkDtid1fRnsF";
        public const string id_question_organisation_comptable = "UZqEjku87mzV";
        public const string id_question_volume_recette = "nXMR214HsT9T";
        public const string id_question_date_immatriculation = "eJ0ffCVbctSs";
        public const string id_question_lieu_immatriculation = "SFiOJCnku9bF";



        


        public override void AddInfos(InfoEntreprise info_entreprise,  string landing_id)
        {
            info_entreprise.ca = getEntreprisesRep(landing_id, id_question_ca).FirstOrDefault();
            info_entreprise.annee_exercice = getEntreprisesRep(landing_id, id_question_annee_exercice).FirstOrDefault();
            info_entreprise.raison_sociale = getEntreprisesRep(landing_id, id_question_nom_entreprise).FirstOrDefault();
            info_entreprise.fonction = getEntreprisesRep(landing_id, id_question_fonction).FirstOrDefault();
            info_entreprise.effectif = getEntreprisesRep(landing_id, id_question_effectif).FirstOrDefault();
            
        }



    }
}
