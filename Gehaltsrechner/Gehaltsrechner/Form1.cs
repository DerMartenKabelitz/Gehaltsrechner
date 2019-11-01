using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gehaltsrechner
{
    public partial class Form1 : Form
    {
        public event EventHandler OnTimerHasTickcked;
        private Einstellungen einstellungen;


        public Form1()
        {
            InitializeComponent();
            textBox_Anzeige.Text = 0.ToString();
            txtBoxStundenlohn.Text = 4.47.ToString();
            einstellungen = new Einstellungen(Convert.ToDouble(txtBoxStundenlohn.Text));
        }

        private void Btn_startTimer_Click(object sender, EventArgs e)
        {
            if(timer_laufendeZeit.Enabled == false)
            {
                timer_laufendeZeit.Start();
            }
        }

        private void TextBox_Anzeige_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            double anzeigeTextDouble = Convert.ToDouble(textBox_Anzeige.Text);

            textBox_Anzeige.Text = String.Format("{0:0.00}", (anzeigeTextDouble + einstellungen.SekundenLohn).ToString());
            btn_SnickersCounter.Text = ((int)anzeigeTextDouble).ToString();

            double nachKommaWert = anzeigeTextDouble - Math.Truncate(anzeigeTextDouble);
            progressBar1.Value = Convert.ToInt32(nachKommaWert * 100);  
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_FillProgressBar_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 10;
        }

        private void Btn_aktStundenlohn_Click(object sender, EventArgs e)
        {
            einstellungen.OnStundenlohnUpdated += einstellungen.a_OnStundenLohnUpdated;
            einstellungen.UpdateStundenlohn(Convert.ToDouble(txtBoxStundenlohn.Text));          
        }

        private void btn_SnickersCounter_TextChanged(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
        }

        private void btn_Tagesabschluss_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tagesabschluss geclicked");
            Tagesabschluss tagesabschluss = new Tagesabschluss();
            tagesabschluss.Datum = DateTime.Now;
            tagesabschluss.Tagesgehalt = Convert.ToDouble(textBox_Anzeige.Text);

            //TODO Methode save to Database hier ausführen.
        }

        private void btn_stopTimer_Click(object sender, EventArgs e)
        {
            timer_laufendeZeit.Stop();
        }
    }
}
