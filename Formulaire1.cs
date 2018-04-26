using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app_lp
{

        class Formulaire1 : FormulaireAbstract
        {
            new public const string id_question_nom_entreprise = "KA17sOqFVIRs";
            public const string id_question_activite = "vT94Udur6LMJ";
        
            public const string id_question_date_creation = "f3w8Ii7p0VOa";
            public const string id_question_statut_entreprise = "rLCJ9PsJ6sE3";
            public const string id_question_statut_commercial = "ex044se03tDA";
            public const string id_question_adresse1 = "bfyd1jJxP8H7";
            public const string id_question_code_postal = "gxrPRaKSzYpd";
            public const string id_question_commune = "U7ezEa0RKVs9";
            public const string id_question_nom_contact = "S8LVVheHTFP2";
            public const string id_question_prenom_contact = "cCIgtabVm6XW";

        






        public override void AddInfos(InfoEntreprise info_entreprise, string landing_id)
            {

                info_entreprise.nomEntreprise =  getEntreprisesRep( landing_id,  id_question_nom_entreprise).FirstOrDefault();


                info_entreprise.statut = getEntreprisesRep( landing_id,  id_question_statut_commercial).FirstOrDefault();//facultatif, 
                info_entreprise.nom_contact= getEntreprisesRep( landing_id,  id_question_nom_contact).FirstOrDefault();
                info_entreprise.prenom =  getEntreprisesRep( landing_id, id_question_prenom_contact).FirstOrDefault();
                info_entreprise.ville = getEntreprisesRep( landing_id,  id_question_commune).FirstOrDefault();
                info_entreprise.code_postal= getEntreprisesRep( landing_id, id_question_code_postal).FirstOrDefault();

                info_entreprise.date_creation= getEntreprisesRep( landing_id, id_question_date_creation).FirstOrDefault();


            }


        }
    }

