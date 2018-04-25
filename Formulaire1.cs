using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Formulaire1: FormulaireAbstract
    {
       public const string id_question_nom_entreprise = "KA17sOqFVIRs";
        public const string id_question_activite = "vT94Udur6LMJ";

        /*static string id_question_perimetre = "tSnE2AtCvbha";
        static string id_question_secteur = "uTsD2ifReBgq";
        string id_question_ess = "jnLHDRBh9mUc";
        string id_question_stade_developpement = "qpk3VRSEbtXR";*/
        //   string id_question_element_previsionnels = "";
       public const string id_question_date_creation = "f3w8Ii7p0VOa";
        /*string id_question_reconnaissance = "bWUfRAYhdsx4";
        string id_question_clients = "gvkiTAtWDLkY";
        string id_question_adresse = "AKO7wyDZgRBQ";
        string id_question_statut = "mLxFMwNNEIHh";
        string id_question_statut_coopératif = "LwLDUTsoTBVK";*/
        public const string id_question_statut_entreprise = "rLCJ9PsJ6sE3";
       public const string id_question_statut_commercial = "ex044se03tDA";
        /* string id_question_association_fiscalisé = "heTubNAydq3H";
         string id_question_En_comptabilité = "m8M9bxnoSt2M";
         string id_question_En_juridique = "nRsWLFWXC7Uq";
         string id_question_En_rh = "LYYWK6iNmevB";
         string id_question_En_Informatique = "utrTfBtpiKId";
         string id_question_entreprenariat_ou_association = "q3YszEPwOM6F";
         string id_question_salarié = "btzcNRAx18k3";
         string id_question_contrat = "ewxi2rV8MiUY";
         string id_question_stage = "mUZVq1pB6qPM";
         string id_question_service_civique = "c5jmF4kpFVuq";
         string id_question_Benévole = "p12JSL5DY9F6";
         string id_question_comptabilité = "CtcjfJpuFM2p";
         string id_question_gestion = "gCR3GxRVYWQ3";
         string id_question_fiscalité = "yrxBmgbHDgct";*/
       public const string id_question_adresse1 = "bfyd1jJxP8H7";
        //string id_question_adresse2 = "E6Pn0cqLx2Dq";
        public const string id_question_code_postal = "gxrPRaKSzYpd";
        public const string id_question_commune = "U7ezEa0RKVs9";
        public const string id_question_nom_contact = "S8LVVheHTFP2";
        public const string id_question_prenom_contact = "cCIgtabVm6XW";
        /*string id_question_telephone_fixe = "iUWCBeGpSaFB";
        string id_question_telephone_portable = "ayrojLe06MRf";
        string id_question_mail = "Tedy3ZeXYKx7";
        string id_question_autre_personne = "TkBGskbttcCB";
        string id_question_nom_autre = "mRz70S6zA9Yx";
        string id_question_prenom_autre = "ffJNhpNdAScE";
        string id_question_telephone_fixe_autre = "b4II2N5DnO3k";
        string id_question_telephone_portable_autre = "czrYyGxepGx6";
        string id_question_mail_autre = "qfDXvgTDYFit";
        string id_question_comment_avez_vous_connu_finacoop = "b8RnVdQwe5ft";
        string id_question_avis_finacoop = "HidmYDYwat9o";
        string id_question_sociétaire_finacoop = "WsvJjioLHcll";
        string id_question_avis_du_formaulaire = "QOHi1qGOPWQv";
        string id_question_commentaire_ou_poeme = "RrPVEsv2iaQh"*/
        // private  string token = "C4yr7FzMfPjiXd6QRMt1ypPT1tUWMbYvk4UQgxdAnrmL";

        

        public List<string> getNomEntreprises(string id_form, AnswerTypeForm.RootObject json_answers)
        {
            List<string> nom_entreprises = new List<string>();
            //AnswerTypeForm.RootObject json_answers = getAnswers(id_form);


            foreach (AnswerTypeForm.Item field in json_answers.items)
            {
                if (field.answers != null)
                {
                    foreach (AnswerTypeForm.Answer answer in field.answers)
                    {
                        if (answer.field.id == Formulaire1.id_question_nom_entreprise)
                        {
                            if (answer.text != null)
                            {
                                nom_entreprises.Add(answer.text);
                                // Console.WriteLine("Nom de l' entreprise: " + answer.text  + "landing_id: " + field.landing_id);
                            }
                        }

                    }
                }
            }


            
            return nom_entreprises;

        }

        public static void AddInfos(InfoEntreprise info_entreprise, AnswerTypeForm.RootObject json_answers, string landing_id)
        {
            
            info_entreprise.setNomEntreprise(typeFormApi.getEntreprisesRep(json_answers, landing_id,  id_question_nom_entreprise).FirstOrDefault());


            info_entreprise.setStatut(typeFormApi.getEntreprisesRep(json_answers,  landing_id, id_question_statut_commercial).FirstOrDefault());//facultatif, 
            info_entreprise.setNomContact(typeFormApi.getEntreprisesRep(json_answers,landing_id, id_question_nom_contact).FirstOrDefault());
            info_entreprise.setPrenomContact(typeFormApi.getEntreprisesRep(json_answers, landing_id, id_question_prenom_contact).FirstOrDefault());
            info_entreprise.setVille(typeFormApi.getEntreprisesRep(json_answers,  landing_id, id_question_commune).FirstOrDefault());
            info_entreprise.setCodePostal(typeFormApi.getEntreprisesRep(json_answers, landing_id, id_question_code_postal).FirstOrDefault());

            info_entreprise.setDateEntreprise(typeFormApi.getEntreprisesRep(json_answers, landing_id, id_question_date_creation).FirstOrDefault());

            
        }


    }
}
