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

        
        private string token;
        //public static string id_form = "YuE8Lp";
        public  AnswerTypeForm.RootObject json_answers;



        /*
         *retourne les formulaires au format json
         */

        public typeFormApi(string token)
        {
            this.token = token;
        }


        public FormTypeForm.RootObject getForms()
        {


            string url = "https://api.typeform.com/forms";
            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.TryAddWithoutValidation("authorization", "bearer " + token);

                string outputJson = getJson(url, token).Result;

                FormTypeForm.RootObject res = JsonConvert.DeserializeObject<FormTypeForm.RootObject>(outputJson);

                return res;
            }

        }

        public string getToken()
        {
            return token;
        }

        public void setToken(string token)
        {
            this.token = token;
        }

        /*
         * retourne un formulaire
         */
        public FormTypeForm.RootObject getForm(string id_form)
        {

            string url = "https://api.typeform.com/forms/" + id_form;
            string outputJson = getJson(url, token).Result;

            FormTypeForm.RootObject res = JsonConvert.DeserializeObject<FormTypeForm.RootObject>(outputJson);


            return res;
        }

        /*
         Retourne toute les réponses
         */
        public static AnswerTypeForm.RootObject getAnswers(string token, string id_form)
        {


            string url = "https://api.typeform.com/forms/" + id_form + "/responses";


            string outputJson = getJson(url, token).Result;
            AnswerTypeForm.RootObject res = JsonConvert.DeserializeObject<AnswerTypeForm.RootObject>(outputJson);
            return res;

        }

        /* 
         * envoie une requete http et retourne le résultat en JSON
         */
        public async static Task<string> getJson(string url, string token)
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
        public List<string> getQuestions(string id_form)
        {
            List<string> questions = new List<string>();


            FormTypeForm.RootObject json_form = getForm(id_form);
            foreach (FormTypeForm.Field field in json_form.fields)
            {
                if (field.title != null)
                {
                    questions.Add(field.title);
                    //Console.WriteLine("Question: " + field.title + " : " + field.id);
                }
                if (field.properties != null && field.properties.fields != null)
                {

                    foreach (FormTypeForm.Field sous_question in field.properties.fields)
                    {
                        questions.Add(sous_question.title);
                        //Console.WriteLine("Question: " + sous_question.title + " : " + sous_question.id);


                    }
                }
            }
            return questions;
        }

        public AnswerTypeForm.RootObject getJsonAnswers()
        {
            return json_answers;
        }

        public void setJsonAnswers(AnswerTypeForm.RootObject json_answers)
        {
            this.json_answers = json_answers;
        }

        /*retourne les noms des entreprises qui ont répondus */



        public InfoEntreprise getInfosEntrepriseByNom(string nom)
        {
            foreach(InfoEntreprise item in getInfosList())
            {
                if(item.getNomEntreprise() == nom)
                {
                    return item;
                }
            }
            return null;
        }




        /*
         * retourne un objet infoEntreprise completé par les réponses des entreprises
             */


        public List<InfoEntreprise> getInfosList()
        {
            //Récupère toutes les informations sur les entreprises.


            List<string> id_list = getEntreprisesIdList();
            List<InfoEntreprise> infos_list = new List<InfoEntreprise>();
            foreach(string id_entreprise in id_list)
            {
                infos_list.Add(getInfos(id_entreprise));
            }

            return infos_list;
            
        }
        public InfoEntreprise getInfos(string landing_id)
        {

            InfoEntreprise info_entreprise = new InfoEntreprise();

            /*
            info_entreprise.setNomEntreprise(getEntreprisesRep(landing_id,Formulaire1.id_question_nom_entreprise).FirstOrDefault());


            info_entreprise.setStatut(getEntreprisesRep(landing_id, Formulaire1.id_question_statut_commercial).FirstOrDefault());//facultatif, 
            info_entreprise.setNomContact(getEntreprisesRep(landing_id, Formulaire1.id_question_nom_contact).FirstOrDefault());
            info_entreprise.setPrenomContact(getEntreprisesRep(landing_id, Formulaire1.id_question_prenom_contact).FirstOrDefault());
            info_entreprise.setVille(getEntreprisesRep(landing_id, Formulaire1.id_question_commune).FirstOrDefault());
            info_entreprise.setCodePostal(getEntreprisesRep(landing_id, Formulaire1.id_question_code_postal).FirstOrDefault());


            info_entreprise.setDateEntreprise(getEntreprisesRep(landing_id, Formulaire1.id_question_date_creation).FirstOrDefault());
            */
            Formulaire1.AddInfos(info_entreprise, getJsonAnswers(), landing_id);
            //Formulair2.AddInfos(info_entreprise, getJsonAnswers(), landing_id);

            return info_entreprise;
        }


        public List<string> getEntreprisesIdList()
        {
            List<string> list_id_entreprises = new List<string>();
            if (json_answers != null && json_answers.items != null)
            {



                foreach (AnswerTypeForm.Item field in json_answers.items)
                {
                    if (field.answers != null )
                    {
                        if(!list_id_entreprises.Contains(field.landing_id))
                        {
                            list_id_entreprises.Add(field.landing_id);
                        }
                    }
                }
            }
            return list_id_entreprises;
        }


       



        public static List<string> getEntreprisesRep(AnswerTypeForm.RootObject json_answers, string landing_id, string id_question)
        {
            List<string> mylist = new List<string>();
            if (json_answers != null && json_answers.items != null)
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