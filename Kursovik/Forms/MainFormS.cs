using Kursovik.Classes;
using Kursovik.Forms.Profiles;
using Kursovik.Model;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovik.Forms
{
    public partial class MainForm_Sotrudnik_ : Form
    {
        public static string loginCurrent;
        private static int Counters = 0;
        public List<Client> clients = new List<Client>();
        ClientFromDb clientFromDb = new ClientFromDb();
        public MainForm_Sotrudnik_()
        {
            InitializeComponent();
            dg_clients.Columns[0].DataPropertyName = "clientid";
            dg_clients.Columns[1].DataPropertyName = "typeid";
            dg_clients.Columns[2].DataPropertyName = "phone";
            dg_clients.Columns[3].DataPropertyName = "email";
        }

        private void MainForm_Sotrudnik__Load(object sender, EventArgs e)
        {
            if ( Counters == 0) { 
            string text = "Добрый день, " + Authorisation.currentUser.name;
            string outputFilePath = "/Audio/output2.wav";
            using (var synth = new SpeechSynthesizer())
            {
                synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior, 0);

                var voices = synth.GetInstalledVoices(new CultureInfo("ru-RU"));

                synth.Volume = 50; 
                synth.SetOutputToWaveFile(outputFilePath); 
                synth.Speak(text);
            }

            using (WaveFileReader waveReader = new WaveFileReader(outputFilePath))
            {
                using (WaveOut waveOut = new WaveOut())
                {
                    waveOut.Init(waveReader);
                    waveOut.Play();
                    waveOut.PlaybackStopped += (s, a) =>
                    {
                        waveOut.Dispose();
                    };
                    while (waveOut.PlaybackState == PlaybackState.Playing)
                    {
                        Application.DoEvents();
                    }
                }
            }
                Counters++;
            }



            fIOToolStripMenuItem.Text = Authorisation.currentUser.surname + Authorisation.currentUser.name;
            ViewAllClients();

        }

        private void ViewAllClients()
        {
            clients = clientFromDb.getAllClients();
            dg_clients.DataSource = clients;
        }

        private void выйтиИзСистемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorisation authorisation = new Authorisation();
            this.Close();
            authorisation.Show();
        }

        private void dg_clients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGrid;
           //loginCurrent = dg_clients.SelectedRows..Value.ToString();
            //MessageBox.Show(loginCurrent);
        }

        private void btn_restOrders_Click(object sender, EventArgs e)
        {

        }

        private void buttonAutorisation_Click(object sender, EventArgs e)
        {
            MagazineAutorization magazineAutorization = new MagazineAutorization();
            this.Hide();
            magazineAutorization.Show();
        }

        private void редактироватьПрофильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileSotrudnik profile = new ProfileSotrudnik();
            this.Hide();
            profile.Show();
        }
    }
}
