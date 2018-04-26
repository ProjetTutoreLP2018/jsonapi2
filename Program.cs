using System;
using System.Collections.Generic;
using System.Text;

namespace app_lp
{
    class Program
    {
        static void Main(string[] args)
        {
            //RootObject json_forms = getForms().Result;

            typeFormApi tp = new typeFormApi("C4yr7FzMfPjiXd6QRMt1ypPT1tUWMbYvk4UQgxdAnrmL");
            Formulaire1 formulaire_1 = new Formulaire1();
            Formulaire2 formulaire_2 = new Formulaire2();
            tp.getForms();
            FormTypeForm.RootObject json_form = tp.getForm("YuE8Lp");
            
            FormTypeForm.RootObject json_forms = tp.getForms();
            //List<string> d= getEntreprisesRep();
            formulaire_1.json_answers = typeFormApi.getAnswers(tp.getToken(), "YuE8Lp");

            formulaire_2.json_answers = typeFormApi.getAnswers(tp.getToken(), "OeFASu");
            


            //AnswerTypeForm.RootObject l = formulaire_2.json_answers;

            //

            //typeFormApi.json_answers = typeFormApi.getForms();

            //tp.setJsonAnswers();
            //List<string>questions =  tp.getQuestions("YuE8Lp"); 

            //AnswerTypeForm.RootObject json_answers = typeFormApi.getAnswers(typeFormApi.id_form);
            //"Y83NJ0CQrBsq" form

            //tp.getQuestions("OeFASu");

            /*foreach (string f in formulaire_1.getNomEntreprises(Formulaire1.id_question_nom_entreprise))
            {
                Console.WriteLine(f);
            }*/
            /*foreach (string f in tp.getQuestions("OeFASu"))
            {
                Console.WriteLine(f);
            }*/



            InfoEntreprise info_entreprise2 = formulaire_1.getInfosEntrepriseByNom("finacoop");

            /*foreach(string t in tp.getNomEntreprises("YuE8Lp"))
            {
                Console.WriteLine("Nom de l' entreprise: " + t);
            }*/

            /*foreach(string t in tp.getEntreprisesIdList())
            {
                Console.WriteLine("listes des id: " + t);
            }*/


            foreach (InfoEntreprise info_entreprise in formulaire_2.getInfosList())
            {
                Console.WriteLine(info_entreprise.ca);
            }

            InfoEntreprise info = formulaire_1.getInfos("5f1ccad09db138f184034ce06ba87f74");
            //Console.WriteLine(info.getNomEntreprise());

            //Console.WriteLine(info.getNomEntreprise());
            // getNomEntreprises(id_question_nom_entreprise);
            //getEntreprisesRep();
            //getInfoEntreprise("5f1ccad09db138f184034ce06ba87f74", "KA17sOqFVIRs");
            //getQuestions();
            //   getInfos("5f1ccad09db138f184034ce06ba87f74");
            //getQuestions();
            //getNomEntreprise("KA17sOqFVIRs", "5f1ccad09db138f184034ce06ba87f74");

            //Console.WriteLine(info.getNomEntreprise());
            Console.ReadKey();
        }
    }
}
