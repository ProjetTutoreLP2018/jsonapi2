using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;



namespace ConsoleApp1
{

    public class Settings
    {
        class Main
        {
            


           static void Mymain(string[] args)
            {
                //RootObject json_forms = getForms().Result;

                typeFormApi.getForms();
                FormTypeForm.RootObject json_form = typeFormApi.getForm(typeFormApi.id_form);
                //List<string> d= getEntreprisesRep();

                //

                typeFormApi.json_answers = typeFormApi.getAnswers(typeFormApi.id_form);

                //AnswerTypeForm.RootObject json_answers = typeFormApi.getAnswers(typeFormApi.id_form);

                /*foreach (string f in getEntreprisesRep("5f1ccad09db138f184034ce06ba87f74", "vT94Udur6LMJ"))
                {
                    Console.WriteLine(f);
                }*/


                //Console.WriteLine(getNomEntreprise("5f1ccad09db138f184034ce06ba87f74"));
                InfoEntreprise info = typeFormApi.getInfos("5f1ccad09db138f184034ce06ba87f74");


                Console.WriteLine(info.getNom());
                // getNomEntreprises(id_question_nom_entreprise);
                //getEntreprisesRep();
                //getInfoEntreprise("5f1ccad09db138f184034ce06ba87f74", "KA17sOqFVIRs");
                //getQuestions();
                //   getInfos("5f1ccad09db138f184034ce06ba87f74");
                //getQuestions();
                //getNomEntreprise("KA17sOqFVIRs", "5f1ccad09db138f184034ce06ba87f74");
                Console.ReadKey();
            }
        }
    }
}