using Dolgozo_Nyilvantartas_Rest_Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Dolgozo_Nyilvantartas_Rest_Api_G
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Ablak megnyitása
        private async void Form1_Load(object sender, EventArgs e)
        {
            listBox_OsszesAdat.Items.Clear();
            string jsonString = await DolgozokNyilvantartasa();
            var dolgozok = JsonConvert.DeserializeObject<List<Dolgozo_Nyilvantartas_Rest_Api.Dolgozok>>(jsonString);
            foreach (var dolgozo in dolgozok)
            {
                listBox_OsszesAdat.Items.Add($"{dolgozo.Name} - {dolgozo.Position} - {dolgozo.Salary}$");
            }
        }

        //Dolgozók összes adatának kiírása
        private async Task<string> DolgozokNyilvantartasa()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://retoolapi.dev/Kc6xuH/data");
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();
                        var dolgozok = JsonConvert.DeserializeObject<List<Dolgozo_Nyilvantartas_Rest_Api.Dolgozok>>(jsonString);
                        return jsonString;
                    }
                    else
                    {
                        return "Hiba történt a csatlakozás során";
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        //Keresett dolgozó
        private async void button_DolgozoKeresese_Click(object sender, EventArgs e)
        {
            string KeresettDolgozo = textBox_DolgozoKeresese.Text;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"https://retoolapi.dev/Kc6xuH/data?name={KeresettDolgozo}");
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();
                        var dolgozok = JsonConvert.DeserializeObject<Dolgozok[]>(jsonString);
                        listBox_OsszesAdat.Items.Clear();
                        if (dolgozok.Length > 0)
                        {
                            foreach (var dolgozo in dolgozok)
                            {
                                listBox_OsszesAdat.Items.Add($"{dolgozo.Name} - {dolgozo.Position} - {dolgozo.Salary}$");
                            }
                        }
                        else
                        {
                            listBox_OsszesAdat.Items.Add("Nincs ilyen nevű dolgozó");
                        }
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Hiba történt a csatlakozás során!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt a szűrés során: " + ex.ToString());
                }
            }
        }
    }
}
