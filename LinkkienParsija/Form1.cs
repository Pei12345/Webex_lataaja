using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.IO;
using Microsoft.Win32;

namespace MoodleWebexLataaja
{
    public partial class Form1 : Form
    {
        string hrefPoistettavaOsa;
        List<string> parsitutLinkit = new List<string>();
        WebClient webClient;
        Latausjono<string> latausJono = new Latausjono<string>();
        string latauskansio = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\webex_lataukset";
        string latauksessa;




        public Form1()
        {
            InitializeComponent();
            textBox_latauskansio.Text = latauskansio;
            UusiWebClient();
        }

        private void button_parsi_Click(object sender, EventArgs e)
        {
            parsitutLinkit.Clear();
            listBox_parsitutLinkit.DataSource = null;
            hrefPoistettavaOsa = textBox_poistettavaOsa.Text;
            LisaaTekstiKonsoliin("Ladattu HTML", 2);
            LataaHtmlLinkit(textBox_lahde.Text);
            listBox_parsitutLinkit.DataSource = parsitutLinkit;
            LisaaTekstiKonsoliin("", 2);
            LatausNapitKaytossa();
        }

        private void LuoLataushakemisto()
        {
            if (!Directory.Exists(latauskansio))
                Directory.CreateDirectory(latauskansio);
        }

        private void LataaHtmlLinkit(string url)
        {
            try {
                var web = new HtmlWeb();
                var doc = web.Load(url);
                var htmlNodes = doc.DocumentNode.SelectNodes("//body//a");

                LisaaTekstiKonsoliin(doc.DocumentNode.OuterHtml.ToString(), 3);
                LisaaTekstiKonsoliin("Parsitaan linkit:", 2);

                if (doc != null && doc.DocumentNode != null && htmlNodes != null)
                    foreach (var node in htmlNodes)
                    {
                        string href = node.Attributes["href"].Value.ToString().Replace(hrefPoistettavaOsa, string.Empty);
                        LisaaTekstiKonsoliin("Parsittu linkki: " + href, 0);
                        parsitutLinkit.Add(href);
                    }
            }
            catch {  }
            }
        

        private void LisaaUrlLatausjonoon(string url)
        {
            if (!latausJono.Contains(url) && url != latauksessa)
            {
                latausJono.Enqueue(url);
                LisaaTekstiKonsoliin("Lisätty jonoon:" + url, 1);
            }
            else
                LisaaTekstiKonsoliin("Tiedosto " + url + " on jo jonossa!", 0);
            listBox_latausjono.DataSource = latausJono.ToList();
        }

        private void LisaaTekstiKonsoliin(string lisattavaTeksti, int rivivalit)
        {
            richTextBox_console.AppendText(lisattavaTeksti);

            for (int i = 0; i < rivivalit; i++)
                richTextBox_console.AppendText("\n");
            
            richTextBox_console.AppendText("\n");
        }

        private void AloitaLataus(string latauskansio)
        {            
            if (latausJono.Count > 0 && !webClient.IsBusy)
            {
                LuoLataushakemisto();
                Uri uri = new Uri(latausJono.Dequeue());
                string tiedostonimi = Path.GetFileName(uri.LocalPath);
                listBox_latausjono.DataSource = latausJono.ToList();
                latauksessa = uri.OriginalString;

                using (webClient)
                {                    
                    webClient.DownloadFileAsync(new Uri(uri.OriginalString), latauskansio + "\\" + tiedostonimi, tiedostonimi);
                }
            }
        }

        private void LatausValmis(AsyncCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            label_latausProsentti.Text = "";
            label_tiedosto.Text = "";
            listBox_latausjono.DataSource = latausJono.ToList();

            if (e.Cancelled)
            {
                LisaaTekstiKonsoliin("Lataaminen peruttu: " + e.UserState, 1);
                File.Delete(latauskansio + "\\" + e.UserState);
                webClient.Dispose();
                return;
            }

            if (e.Error != null)
            {
                LisaaTekstiKonsoliin("Virhe tiedoston lataamisessa", 1);

                return;
            }

            LisaaTekstiKonsoliin("Tiedosto ladattu: " + e.UserState, 1);            

            if (latausJono.Count > 0)
                AloitaLataus(latauskansio);
        }

        private void PeruutaKaikkiLataukset()
        {
            webClient.CancelAsync();
            latausJono.Clear();
        }

        private void LatausNapitKaytossa()
        {
            if (listBox_parsitutLinkit.Items.Count > 0)
            {
                button_lataaKaikki.Enabled = true;
                button_lataaValitut.Enabled = true;
            }
            else
            {
                button_lataaKaikki.Enabled = false;
                button_lataaValitut.Enabled = false;
            }
        }

        private void LisaaValitutLatausjonoon()
        {
            foreach (string url in listBox_parsitutLinkit.SelectedItems)
            {
                latausJono.Enqueue(url);
                LisaaTekstiKonsoliin("Lisätty jonoon:" + url, 1);
            }
        }

        private void UusiWebClient()
        {
            webClient = new WebClient();
            webClient.DownloadProgressChanged += wc_DownloadProgressChanged;
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);            
        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label_tiedosto.Text = e.UserState.ToString();
            label_latausProsentti.Text = e.ProgressPercentage.ToString() + "% " + e.BytesReceived / 1024 + " kt / " + e.TotalBytesToReceive / 1024 + " kt ladattu.";
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            LatausValmis(e);
        }

        private void richTextBox_console_TextChanged(object sender, EventArgs e)
        {
            richTextBox_console.SelectionStart = richTextBox_console.Text.Length;
            richTextBox_console.ScrollToCaret();
        }

        private void listBox_parsitutLinkit_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            string url = lb.SelectedItem.ToString();
            LisaaUrlLatausjonoon(url);

            AloitaLataus(textBox_latauskansio.Text);
        }

        private void button_peruutaLataus_Click(object sender, EventArgs e)
        {
            PeruutaKaikkiLataukset();
            LisaaTekstiKonsoliin("Latausjono tyhjennetty", 1);
        }

        private void button_peruutaNykyinenLataus_Click(object sender, EventArgs e)
        {
            webClient.CancelAsync();
            UusiWebClient();
            AloitaLataus(latauskansio);
        }

        private void button_lataaKaikki_Click(object sender, EventArgs e)
        {
            foreach (string url in parsitutLinkit)
            {
                latausJono.Enqueue(url);
                LisaaTekstiKonsoliin("Lisätty jonoon:" + url, 0);
            }
            LisaaTekstiKonsoliin("", 0);
            AloitaLataus(latauskansio);
        }

        private void textBox_latauskansio_TextChanged(object sender, EventArgs e)
        {
            latauskansio = textBox_latauskansio.Text;
        }

        private void button_poistaValittuJonosta_Click(object sender, EventArgs e)
        {
            string poistettava = listBox_latausjono.SelectedItem.ToString();
            latausJono.Remove(poistettava);
            LisaaTekstiKonsoliin("Poistettu jonosta: " + poistettava,1);
            listBox_latausjono.DataSource = latausJono.ToList();
        }

        private void button_lataaValitut_Click(object sender, EventArgs e)
        {
            LisaaValitutLatausjonoon();
            AloitaLataus(latauskansio);
        }


    }
}
