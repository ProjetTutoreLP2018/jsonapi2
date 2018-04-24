using ConsoleApp1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class typeFormApi
    {
        static string[] id_list = { "KA17sOqFVIRs", "vT94Udur6LMJ", "ke2j3H4gyMFX", "tSnE2AtCvbha", "uTsD2ifReBgq", "jnLHDRBh9mUc", "qpk3VRSEbtXR", "BDmQoDqmH8RW", "f3w8Ii7p0VOa", "bWUfRAYhdsx4", "gvkiTAtWDLkY", "AKO7wyDZgRBQ", "mLxFMwNNEIHh", "LwLDUTsoTBVK", "rLCJ9PsJ6sE3", "ex044se03tDA", "heTubNAydq3H", "m8M9bxnoSt2M", "nRsWLFWXC7Uq", "LYYWK6iNmevB", "utrTfBtpiKId", "q3YszEPwOM6F", "btzcNRAx18k3", "ewxi2rV8MiUY", "mUZVq1pB6qPM", "c5jmF4kpFVuq", "p12JSL5DY9F6", "CtcjfJpuFM2p", "gCR3GxRVYWQ3", "yrxBmgbHDgct", "bfyd1jJxP8H7", "E6Pn0cqLx2Dq", "gxrPRaKSzYpd", "U7ezEa0RKVs9", "S8LVVheHTFP2", "cCIgtabVm6XW", "iUWCBeGpSaFB", "ayrojLe06MRf", "Tedy3ZeXYKx7", "TkBGskbttcCB", "mRz70S6zA9Yx", "ffJNhpNdAScE", "b4II2N5DnO3k", "czrYyGxepGx6", "qfDXvgTDYFit", "b8RnVdQwe5ft", "HidmYDYwat9o", "WsvJjioLHcll", "QOHi1qGOPWQv", "RrPVEsv2iaQh" };

        static string id_question_nom_entreprise = "KA17sOqFVIRs";
        string id_question_activite = "vT94Udur6LMJ";
        string id_question_valeurs_entreprise = "vT94Udur6LMJ";
        static string id_question_perimetre = "tSnE2AtCvbha";
        static string id_question_secteur = "uTsD2ifReBgq";
        string id_question_ess = "jnLHDRBh9mUc";
        string id_question_stade_developpement = "qpk3VRSEbtXR";
        //   string id_question_element_previsionnels = "";
        static string id_question_date_creation = "f3w8Ii7p0VOa";
        string id_question_reconnaissance = "bWUfRAYhdsx4";
        string id_question_clients = "gvkiTAtWDLkY";
        string id_question_adresse = "AKO7wyDZgRBQ";
        string id_question_statut = "mLxFMwNNEIHh";
        string id_question_statut_coopératif = "LwLDUTsoTBVK";
        string id_question_statut_entreprise = "rLCJ9PsJ6sE3";
       static string id_question_statut_commercial = "ex044se03tDA";
        string id_question_association_fiscalisé = "heTubNAydq3H";
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
        string id_question_fiscalité = "yrxBmgbHDgct";
        string id_question_adresse1 = "bfyd1jJxP8H7";
        string id_question_adresse2 = "E6Pn0cqLx2Dq";
        static string id_question_code_postal = "gxrPRaKSzYpd";
        static string id_question_commune = "U7ezEa0RKVs9";
        static string id_question_nom_contact = "S8LVVheHTFP2";
        static string id_question_prenom_contact = "cCIgtabVm6XW";
        string id_question_telephone_fixe = "iUWCBeGpSaFB";
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
        string id_question_commentaire_ou_poeme = "RrPVEsv2iaQh";
        public static string token = "C4yr7FzMfPjiXd6QRMt1ypPT1tUWMbYvk4UQgxdAnrmL";
        public static string id_form = "YuE8Lp";
        public static AnswerTypeForm.RootObject json_answers;



        /*
         *retourne les formulaires au format json
         */
        public static FormTypeForm.RootObject getForms()
        {


            string url = "https://api.typeform.com/forms";
            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.TryAddWithoutValidation("authorization", "bearer " + token);

                string outputJson = getJson(url).Result;

                FormTypeForm.RootObject res = JsonConvert.DeserializeObject<FormTypeForm.RootObject>(outputJson);

                return res;
            }

        }

        /*
         * retourne un formulaire
         */
        public static FormTypeForm.RootObject getForm(string id_form)
        {

            string url = "https://api.typeform.com/forms/" + id_form;
            string outputJson = getJson(url).Result;

            FormTypeForm.RootObject res = JsonConvert.DeserializeObject<FormTypeForm.RootObject>(outputJson);


            return res;
        }

        /*
         Retourne toute les réponses
         */
        public static AnswerTypeForm.RootObject getAnswers(string id_form)
        {


            string url = "https://api.typeform.com/forms/" + id_form + "/responses";


            string outputJson = getJson(url).Result;
            AnswerTypeForm.RootObject res = JsonConvert.DeserializeObject<AnswerTypeForm.RootObject>(outputJson);
            return res;

        }

        /* 
         * envoie une requete http et retourne le résultat en JSON
         */
        public async static Task<string> getJson(string url)
        {
            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.TryAddWithoutValidation("authorization", "bearer " + token);

                var response = await client.GetAsync(url);
                Task<string> responseString = response.Content.ReadAsStringAsync();
                string outputJson = await responseString;
                return outputJson;
            }
        }


        /*Retourne toute les sous-questions*/
        public static void getQuestions()
        {
            FormTypeForm.RootObject json_form = getForm(id_form);
            foreach (FormTypeForm.Field field in json_form.fields)
            {
                if (field.title != null)
                {
                    Console.WriteLine("Question: " + field.title + " : " + field.id);
                }
                if (field.properties != null && field.properties.fields != null)
                {
                    
                    foreach (FormTypeForm.Field sous_question in field.properties.fields)
                    {
                        Console.WriteLine("Question: " + sous_question.title + " : " + sous_question.id);


                    }
                }
            }

        }


        /*retourne les noms des entreprises qui ont répondus */
        public static void getNomEntreprises(string id_question)
        {
            AnswerTypeForm.RootObject json_answers = getAnswers(id_form);


            foreach (AnswerTypeForm.Item field in json_answers.items)
            {
                if (field.answers != null)
                {


                    foreach (AnswerTypeForm.Answer answer in field.answers)
                    {
                        if (answer.field.id == id_question)
                        {
                            if (answer.text != null)
                            {
                                Console.WriteLine("Nom de l' entreprise: " + answer.text  + "landing_id: " + field.landing_id);
                            }
                        }

                    }
                }
            }

        }


        public static string getNomEntreprise(string landing_id)
        {
            List<string> reponses = new List<string>();



            reponses = getEntreprisesRep(landing_id, id_question_nom_entreprise);

            if (reponses != null)
                return reponses[0];
            return null;

        }




        /*
         * retourne un objet infoEntreprise completé par les réponses des entreprises
             */
        public static InfoEntreprise getInfos(string landing_id)
        {

            InfoEntreprise info_entreprise = new InfoEntreprise();
            info_entreprise.setNomEntreprise(getEntreprisesRep(landing_id, id_question_nom_entreprise));
            //info_entreprise.setSecteurEntreprise(getEntreprisesRep(landing_id, id_question_secteur));
            //info_entreprise.setPerimetreEntreprise(getEntreprisesRep(landing_id, id_question_perimetre));


            info_entreprise.setStatut(getEntreprisesRep(landing_id, id_question_statut_commercial));//facultatif, 
            info_entreprise.setNomContact(getEntreprisesRep(landing_id, id_question_nom_contact));
            info_entreprise.setPrenomContact(getEntreprisesRep(landing_id, id_question_prenom_contact));
            info_entreprise.setVille(getEntreprisesRep(landing_id, id_question_commune));
            info_entreprise.setCodePostal(getEntreprisesRep(landing_id, id_question_code_postal));
            

            info_entreprise.setDateEntreprise(getEntreprisesRep(landing_id, id_question_date_creation));
            //A finir
            return info_entreprise;
        }



        /*


             */
        public static List<string> getEntreprisesRep(string landing_id, string id_question)
        {
            List<string> mylist = new List<string>();
            if (json_answers.items != null)
            {



                foreach (AnswerTypeForm.Item field in json_answers.items)
                {
                    if (field.answers != null)
                    {


                        foreach (AnswerTypeForm.Answer answer in field.answers)
                        {

                            if (answer != null && field.landing_id == landing_id && answer.field.id == id_question)
                            {
                                if (answer.choice != null)
                                {
                                    mylist.Add(answer.choice.label);

                                }

                                else if (answer.choices != null)
                                {
                                    foreach (string choix in answer.choices.labels)
                                    {
                                        mylist.Add(choix);

                                    }
                                }

                                if (answer.text != null)
                                {
                                    mylist.Add(answer.text);
                                }

                                if (answer.url != null)
                                {
                                    mylist.Add(answer.url);
                                }

                                if (answer.boolean != null)
                                {

                                    mylist.Add(answer.boolean.ToString());
                                }

                                if (answer.number != null)
                                {
                                    mylist.Add(answer.number.ToString());
                                }

                                if (answer.date != null)
                                {
                                    mylist.Add(answer.date.ToString());
                                }

                                if (answer.email != null)
                                {
                                    mylist.Add(answer.email);
                                }

                                if (answer.file_url != null)
                                {
                                    mylist.Add(answer.file_url);
                                }

                            }

                        }
                    }



                }



            }
            else
            {
                Console.WriteLine("Pas de réponses");


            }




            return mylist;
        }
    }
}
