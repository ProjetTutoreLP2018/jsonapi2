using app_lp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //RootObject json_forms = getForms().Result;



            typeFormApi tp = new typeFormApi("C4yr7FzMfPjiXd6QRMt1ypPT1tUWMbYvk4UQgxdAnrmL");
            Formulaire1 formulaire_1 = new Formulaire1();
            Formulaire2 formulaire_2 = new Formulaire2();


            //List<string> d= getEntreprisesRep();
            formulaire_1.json_answers = typeFormApi.getAnswers(tp.token, "IJSPAB").Result;

            formulaire_2.json_answers = typeFormApi.getAnswers(tp.token, "OeFASu").Result;

            //InfoEntreprise l = formulaire_1.getInfosEntrepriseByNom("SCIC G5-T FRANCE ( Groupement de 5 réseaux en lien avec les terrioitres )");

            //tp.getQuestions("IJSPAB");

            foreach (InfoEntreprise info in formulaire_1.getInfoEntreprises())
            {
                Console.WriteLine(info.activites);
            }

            InfoEntreprise t = FormulaireAbstract.getInfoEntrepriseForm1Form2(formulaire_1, formulaire_2, "edeni ");
            //Console.WriteLine(t.effectif);
            Console.ReadKey();

        }
    }
}