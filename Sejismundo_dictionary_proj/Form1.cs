using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;


namespace Sejismundo_dictionary_proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void IUSDictionary_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void searchbtn_Click(object sender, EventArgs e)
        {
            string word = searchbx.Text.Trim();

            if (string.IsNullOrEmpty(word))
            {
                MessageBox.Show("Please enter a word to search.");
                return;
            }

            await FetchAndDisplayWordData(word);
        }

        private async Task FetchAndDisplayWordData(string word)
        {
            string url = $"https://api.dictionaryapi.dev/api/v2/entries/en/{word}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    JArray data = JArray.Parse(jsonResponse);

                    resultbx.Items.Clear();

                    foreach (var item in data)
                    {
                        string wordText = item["word"]?.ToString();
                        var meanings = item["meanings"];
                        foreach (var meaning in meanings)
                        {
                            string partOfSpeech = meaning["partOfSpeech"]?.ToString();
                            var definitions = meaning["definitions"];
                            foreach (var definition in definitions)
                            {
                                string definitionText = definition["definition"]?.ToString();
                                string example = definition["example"]?.ToString();
                                var synonyms = definition["synonyms"];

                                resultbx.Items.Add($"Word: {wordText}");
                                resultbx.Items.Add($"Part of Speech: {partOfSpeech}");
                                resultbx.Items.Add($"Definition: {definitionText}");
                                if (!string.IsNullOrEmpty(example))
                                {
                                    resultbx.Items.Add($"Example: {example}");
                                }
                                if (synonyms != null && synonyms.HasValues)
                                {
                                    resultbx.Items.Add($"Synonyms: {string.Join(", ", synonyms)}");
                                }
                                resultbx.Items.Add(""); 
                            }
                            var genralSynonyms = meaning["synonyms"];
                            if (genralSynonyms != null && genralSynonyms.HasValues) 
                            { 
                                resultbx.Items.Add($"Synonyms: {string.Join(",", genralSynonyms)}");
                            }
                        }
                    }
                }
                catch (HttpRequestException)
                {
                    MessageBox.Show("Sorry pal, we couldn't find definitions for the word you were looking for.");
                }
            }
        }

    }
}