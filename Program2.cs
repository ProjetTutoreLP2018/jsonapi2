using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //RootObject json_forms = getForms().Result;

            typeFormApi.getForms();
            FormTypeForm.RootObject json_form = typeFormApi.getForm(typeFormApi.id_form);
            //FormTypeForm.RootObject json_forms = typeFormApi.getForms();
            //List<string> d= getEntreprisesRep();

            //

            //typeFormApi.json_answers = typeFormApi.getForms();



            typeFormApi.json_answers = typeFormApi.getAnswers(typeFormApi.id_form);
            //typeFormApi.getQuestions();
            //AnswerTypeForm.RootObject json_answers = typeFormApi.getAnswers(typeFormApi.id_form);

            //typeFormApi.getNomEntreprises("Y83NJ0CQrBsq");

            /*foreach (string f in typeFormApi.getEntreprisesRep("5f1ccad09db138f184034ce06ba87f74", "YuE8Lp"))
            {
                Console.WriteLine(f);
            }*/


            //Console.WriteLine(getNomEntreprise("5f1ccad09db138f184034ce06ba87f74"));
            InfoEntreprise info = typeFormApi.getInfos("5f1ccad09db138f184034ce06ba87f74");


            //Console.WriteLine(info.getNom());
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
