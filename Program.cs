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
            formulaire_1.json_answers = typeFormApi.getAnswers(tp.token, "YuE8Lp");

            formulaire_2.json_answers = typeFormApi.getAnswers(tp.token, "OeFASu");

           InfoEntreprise t = FormulaireAbstract.getInfoEntrepriseForm1Form2(formulaire_1, formulaire_2, "finacoop");
            Console.WriteLine(t.effectif);
          
        }
    }
}