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

            typeFormApi tp = new typeFormApi("C4yr7FzMfPjiXd6QRMt1ypPT1tUWMbYvk4UQgxdAnrmL");

            tp.getForms();
            FormTypeForm.RootObject json_form = tp.getForm("YuE8Lp");
            //FormTypeForm.RootObject json_forms = typeFormApi.getForms();
            //List<string> d= getEntreprisesRep();

            //

            //typeFormApi.json_answers = typeFormApi.getForms();

            tp.setJsonAnswers(typeFormApi.getAnswers(tp.getToken(), "YuE8Lp"));
            //List<string>questions =  tp.getQuestions("YuE8Lp"); 

            //AnswerTypeForm.RootObject json_answers = typeFormApi.getAnswers(typeFormApi.id_form);

            //typeFormApi.getNomEntreprises("Y83NJ0CQrBsq");

            /*foreach (string f in tp.getEntreprisesRep("5f1ccad09db138f184034ce06ba87f74", "vT94Udur6LMJ"))
            {
                Console.WriteLine(f);
            }*/


            InfoEntreprise info_entreprise2 = tp.getInfosEntrepriseByNom("finacoop");

            /*foreach(string t in tp.getNomEntreprises("YuE8Lp"))
            {
                Console.WriteLine("Nom de l' entreprise: " + t);
            }*/

            /*foreach(string t in tp.getEntreprisesIdList())
            {
                Console.WriteLine("listes des id: " + t);
            }*/


            foreach (InfoEntreprise info_entreprise in tp.getInfosList())
            {
                Console.WriteLine(info_entreprise.getNomEntreprise());
            }

            //InfoEntreprise info = tp.getInfos("5f1ccad09db138f184034ce06ba87f74");
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
