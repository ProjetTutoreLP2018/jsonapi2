using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading;

namespace lot1api
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //nomEntreprise.Text = info.getNom();


        }

        private async void bValide_Click(object sender, EventArgs e)
        {
            
            typeFormApi.json_answers = await getAnswers(typeFormApi.id_form);
            InfoEntreprise info = typeFormApi.getInfos("65bc77c7c67c4297e8d6741c00d4c8ed");
            nomEntreprise.Text = info.getNom();
            if(info.getPerimetre() == "Départemental")
            {
                Dep.Checked = true;
            }
            else if(info.getPerimetre() == "Local")
            {
                Dep.Checked = true;
            }
            else if (info.getPerimetre() == "National")
            {
                Dep.Checked = true;
            }

            date_creation.Value = info.getDate();


            secteurs_textbox.Text = info.getSecteur();
            //date_creation = info.getDate();



        }
      
        public async static Task<AnswerTypeForm.RootObject> getAnswers(string id_form)
        {


            string url = "https://api.typeform.com/forms/" + id_form + "/responses";


            string outputJson = await getJson(url);
            AnswerTypeForm.RootObject res = JsonConvert.DeserializeObject<AnswerTypeForm.RootObject>(outputJson);
            return res;

        }
        public async static Task<string> getJson(string url)
        {
            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.TryAddWithoutValidation("authorization", "bearer " + "C4yr7FzMfPjiXd6QRMt1ypPT1tUWMbYvk4UQgxdAnrmL");

                var response = await client.GetAsync(url);
                Task<string> responseString = response.Content.ReadAsStringAsync();
                string outputJson = await responseString;
                return outputJson;
            }
        }

    }
}
