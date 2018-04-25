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


        private string nomEntreprise { get; set; } //raison sociale
        private string activite { get; set; }
        private string date_creation;
        private string adresse { get; set; }
        private string statut { get; set; }

        private string statut_commercial;//forme juridique
        private string association_fiscalise { get; set; }

        private string adresse1 { get; set; }
        private string code_postal { get; set; }
        private string ville { get; set; }
        private string nom_contact { get; set; }
        private string prenom { get; set; }
        private string id_session { get; set; }


        private string raison_sociale { get; set; }
        private string annee_exercice;
        private string presentation { get; set; }

        private string fonction { get; set; }
        private string ca { get; set; }
        private string effectif { get; set; }
        private string organisation_comptable { get; set; }
        private string volume_recette { get; set; }
        private string date_immatriculation { get; set; }
        private string lieu_immatriculation { get; set; }


        
        /*public static void getInfos()
        {
         
            getInfoEntreprise("5f1ccad09db138f184034ce06ba87f74", "KA17sOqFVIRs");
        }*/

            public string getIdSession()
        {
            return id_session;
        }

        public void setIdSession(string id_session)
        {
            this.id_session = id_session;
        }

        public string getFormeJuridique()
        {
            return statut_commercial;
        }

        public void setFormeJuridique(string reponse)
        {
            
                this.statut_commercial = reponse;
            
        }

        public string getNomEntreprise()
        {
            return nomEntreprise;
        }
        

        public string getNomContact()
        {
            return nom_contact;
        }

        public void setNomContact(string reponse)
        {
            if (reponse != null)
            {
                this.nom_contact = reponse;
            }
        }


        public string getPrenomContact()
        {
            return prenom;
        }

        public void setPrenomContact( string reponse)
        {
            if (reponse != null)
            {
                this.prenom = reponse;
            }
        }




        public string getStatut()
        {
            return statut;
        }
        public void setStatut(string reponse)
        {
            if ((reponse != null))
            {
                this.statut = reponse;
            }
        }

        public string getVille()
        {
            return ville;
        }

        public void setVille(string reponse)
        {
            if (reponse != null)
            {
                this.ville= reponse;
            }
        }

        public void setNomEntreprise(string reponse)
        {
            if (reponse != null)
            {
                this.nomEntreprise = reponse;
            }

        }


        public string getCodePostal()
        {
            return code_postal;
        }


        public void setCodePostal(string reponse)
        {
            if (reponse != null)
            {
                this.code_postal = reponse;
            }

        }

        public string getActivite()
        {
            return activite;
        }

        public DateTime getDate()
        {
            return DateTime.ParseExact(date_creation, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }

        
        public void setDateEntreprise(string reponse)
        {
            if (reponse != null)
            {
                this.date_creation = reponse;
            }

        }


        public string getRaisonSociale()
        {
            return raison_sociale;
        }

        public void setRaisonSociale(string raison_sociale)
        {
            this.raison_sociale = raison_sociale;
        }

        public string getAnneeExercice()
        {
            return annee_exercice;
        }

        public void setAnneeExercice(string annee_exercice)
        {
            this.annee_exercice = annee_exercice;
        }

        public string getPresentation()
        {
            return presentation;
        }

        public void setPresentation(string presentation)
        {
            this.presentation = presentation;
        }

        

        public string getPrenom()
        {
            return prenom;
        }

        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
        }

        public string getFonction()
        {
            return fonction;
        }

        public void setFonction(string fonction)
        {
            this.fonction = fonction;
        }

        public string getCa()
        {
            return ca;
        }

        public void setCa(string ca)
        {
            this.ca = ca;
        }

        public string getEffectif()
        {
            return effectif;
        }

        public void setEffectif(string effectif)
        {
            this.effectif = effectif;
        }

        public string getOrganisationComptable()
        {
            return organisation_comptable;
        }

        public void setOrganisationComptable(string organisation_comptable)
        {
            this.organisation_comptable = organisation_comptable;
        }

        public string getVolumeRecette()
        {
            return volume_recette;
        }

        public void setVolumeRecette(string volume_recette)
        {
            this.volume_recette = volume_recette;
        }

        public string getDateImmatriculation()
        {
            return date_immatriculation;
        }

        public void setDateImmatriculation(string date_immatriculation)
        {
            this.date_immatriculation = date_immatriculation;
        }

        public string getLieuImmatriculation()
        {
            return lieu_immatriculation;
        }

        public void setLieuImmatriculation(string lieu_immatriculation)
        {
            this.lieu_immatriculation = lieu_immatriculation;
        }


    }
}