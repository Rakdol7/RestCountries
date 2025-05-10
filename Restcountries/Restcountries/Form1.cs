using System.Text.Json.Nodes;
using Newtonsoft.Json;

namespace Restcountries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://restcountries.com/v3.1/name/" +(sender as Button).Text);
            HttpResponseMessage response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string risultato = await response.Content.ReadAsStringAsync();;

            List<Nazioni.Root> nazione = JsonConvert.DeserializeObject<List<Nazioni.Root>>(risultato);
            listBox1.Items.Clear();
            foreach (string confine in nazione[0].borders)
            {
                listBox1.Items.Add(confine);
            }
        }
    }
}
