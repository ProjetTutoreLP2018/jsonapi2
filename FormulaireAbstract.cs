using System;
using System.Collections.Generic;
using System.Text;

namespace app_lp
{
    abstract class FormulaireAbstract
    {
        public AnswerTypeForm.RootObject json_answers { get; set; }
        public  string id_question_nom_entreprise;


        public abstract  void AddInfos(InfoEntreprise info_entreprise,  string landing_id);


        public InfoEntreprise getInfosEntrepriseByNom(string nom)
        {
            foreach (InfoEntreprise item in getInfosList())
            {
                if (item.nomEntreprise == nom)
                {
                    return item;
                }
            }
            return null;
        }

        public List<InfoEntreprise> getInfosList()
        {
            //Récupère toutes les informations sur les entreprises.


            List<string> id_list = getEntreprisesIdList();
            List<InfoEntreprise> infos_list = new List<InfoEntreprise>();
            foreach (string id_entreprise in id_list)
            {
                infos_list.Add(getInfos(id_entreprise));
            }

            return infos_list;

        }

        public InfoEntreprise getInfos(string landing_id)
        {

            InfoEntreprise info_entreprise = new InfoEntreprise();


            AddInfos(info_entreprise, landing_id);

            return info_entreprise;
        }


        public List<string> getEntreprisesIdList()
        {
            List<string> list_id_entreprises = new List<string>();
            if (json_answers != null && json_answers.items != null)
            {
                foreach (AnswerTypeForm.Item field in json_answers.items)
                {
                    if (field.answers != null)
                    {
                        if (!list_id_entreprises.Contains(field.landing_id))
                        {
                            list_id_entreprises.Add(field.landing_id);
                        }
                    }
                }
            }
            return list_id_entreprises;
        }



        public  List<string> getEntreprisesRep(string landing_id,  string id_question)
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




        public List<string> getNomEntreprises(string id_question_nom_entreprise)
        {
            List<string> nom_entreprises = new List<string>();
            //AnswerTypeForm.RootObject json_answers = getAnswers(id_form);


            foreach (AnswerTypeForm.Item field in json_answers.items)
            {
                if (field.answers != null)
                {
                    foreach (AnswerTypeForm.Answer answer in field.answers)
                    {
                        if (answer.field.id == id_question_nom_entreprise)
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
    }
}
