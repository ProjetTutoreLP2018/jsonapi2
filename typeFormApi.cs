using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;

namespace app_lp
{
    class typeFormApi
    {


        private string token;
        //public static string id_form = "YuE8Lp";
        //public AnswerTypeForm.RootObject json_answers;



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

        /*public AnswerTypeForm.RootObject getJsonAnswers()
        {
            return json_answers;
        }

        public void setJsonAnswers(AnswerTypeForm.RootObject json_answers)
        {
            this.json_answers = json_answers;
        }*/

        /*retourne les noms des entreprises qui ont répondus */



        



        /*
         * retourne un objet infoEntreprise completé par les réponses des entreprises
             */


       
    }
}
