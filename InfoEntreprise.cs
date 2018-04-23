using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
     stocke les informations d' une entreprise.
         */
    class InfoEntreprise
    {
        //private string landing_id;


        private string nomEntreprise;
        private string activite;
        private string valeurs;
        private string perimetre;
        private string secteur;
        private string stade_developpement;
        private string element_previsionnel;
        private string date_creation;
        private string reconnaissance;
        private string clients;
        private string adresse;
        private string statut;
        private string statut_coopératif;
        private string statut_entreprise;
        private string statut_commercial;
        private string association_fiscalise;
        private string en_comptabilite;
            
        private string en_juridique;
        private string en_rh;
        private string en_informatique;
        private string entreprenariat_ou_association;
        private string salarie;
        private string contrat;
        private string stage;
        private string service_civique;
        private string benevole;

        private string gestion;
        private string fiscalité;
        private string adresse1;
        private string adresse2;
        private string code_postal;
        private string commune;
        private string nom;
        private string prenom;
        private string telephone_fixe;
        private string telephone_portable;
        private string mail;
        private string autre_personne;
        private string nom_autre;
        private string prenom_autre;
        private string telephone_fixe_autre;
        private string telephone_portable_autre;
        private string mail_autre;
        private string comment_avez_vous_connu_finacoop;
        private string avis_finacoop;
        /* string id_question_sociétaire_finacoop = "WsvJjioLHcll";
            string id_question_avis_du_formaulaire = "QOHi1qGOPWQv";
            string id_question_commentaire_ou_poeme = "RrPVEsv2iaQh";*/



        Dictionary<string, string> list;

        public InfoEntreprise()
        {

        }

        /*public static void getInfos()
        {
         
            getInfoEntreprise("5f1ccad09db138f184034ce06ba87f74", "KA17sOqFVIRs");
        }*/

        public string getNom()
        {
            return nomEntreprise;
        }

        public void setNomEntreprise(List<string> reponses)
        {
            if(reponses != null)
            {
                this.nomEntreprise = reponses[0];
            }
            
        }
        public string getSecteur()
        {
            return this.secteur;
        }
        public string getPerimetre()
        {
            return this.perimetre;
        }
        public DateTime getDate()
        {
            return DateTime.ParseExact(date_creation, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }
        public void setSecteurEntreprise(List<string> reponses) {
            if (reponses != null)
                this.secteur = reponses[0];
       }
        public void setPerimetreEntreprise(List<string> reponses)
        {
            if (reponses != null)
                this.perimetre = reponses[0];
        }
       public void setDateEntreprise(List<string> reponses)
        {
            if (reponses != null)
            {
                this.date_creation = reponses[0];
            }
                
        }


    }
}