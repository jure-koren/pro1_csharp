using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;

namespace Programiranje
{
    public partial class MainForm : Form
    {
        // ker je imenik mali ga imamo kar v spominu, za enostavnejse delo
        List<Oseba> osebe = new List<Oseba>();
        Oseba izbranaOseba = null;

        public MainForm()
        {
            InitializeComponent();
            // preberemo osebe iz datoteke
            naloziPodatke();
        }

        /// <summary>
        /// nalozimo podatke iz datoteke
        /// </summary>
        private void naloziPodatke()
        {
            try
            {
                // preberemo iz datoteke
                string jsonFile = potDoDatoteke();
                if (File.Exists(jsonFile))
                {
                    // branje iz json datoteke
                    string vsebina = File.ReadAllText(jsonFile);
                    var serializer = new JavaScriptSerializer();
                    // preberemo v objekte
                    osebe = serializer.Deserialize<List<Oseba>>(vsebina);

                    // pocistimo seznam
                    lstOsebe.Items.Clear();
                    // dodamo vse osebe na seznam
                    for (var i = 0; i < osebe.Count; i++)
                    {
                        lstOsebe.Items.Add(osebe[i]);
                    }
                    lblSeznamOseb.Text = "Seznam oseb (" + lstOsebe.Items.Count + "):";
                }
                else
                {
                    // nimamo datoteke, zacnemo s praznim seznamom
                    osebe = new List<Oseba>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri branju podatkov. Verjetno je datoteka poškodovana. Tehnični opis napake: " 
                    + Environment.NewLine + ex.ToString() );
            }
        }

        private void shraniPodatke()
        {
            try
            {

                // shranimo v json obliko
                var serializer = new JavaScriptSerializer();
                // pot do datoteke
                string jsonFile = potDoDatoteke();

                // zapišemo v datoteko
                var serializedOsebe = serializer.Serialize(osebe);
                File.WriteAllText(jsonFile, serializedOsebe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri shranjevanju podatkov. Tehnični opis napake: "
                    + Environment.NewLine + ex.ToString());
            }
        }

        /// <summary>
        /// datoteka za podatke
        /// </summary>
        /// <returns>pot do datoteke s podatki</returns>
        private string potDoDatoteke()
        {
            // shranjujemo v direktorij, kjer je exe, tako da imamo lahko imenik npr na usb kljucku
            string myPath = System.Windows.Forms.Application.StartupPath;
            // zaenkrat vse v eni datoteki... mozno, da bi razsirili na locene datoteke glede na vsebino
            string myFile = myPath + "\\osebe.json";
            return myFile;

        }

        /// <summary>
        /// shranimo trenutni zapis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShrani_Click(object sender, EventArgs e)
        {
            try
            {
                // preverimo vhodne podatke (potrebujemo najmanj ime)
                if (txtIme.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Prosimo, da vnesete ime za osebo.");
                }
                // preverimo še datum
                DateTime? rojDatum = null;
                System.Globalization.CultureInfo cultureinfo = new System.Globalization.CultureInfo("sl-SI");
                if (!txtRojDan.Text.Trim().Equals("")) {
                    // poskusimo prebrati datum
                    rojDatum = DateTime.Parse(txtRojDan.Text.Trim(), cultureinfo);
                }
                // preverimo, če je že v bazi
                if (aliOsebaZeObstaja(txtIme.Text, txtPriimek.Text, txtTelefon.Text))
                {
                    MessageBox.Show("Pozor: Oseba že obstaja v imeniku. Shranjevanje je preklicano.");
                    return;
                }
                else if (aliOsebaZeObstaja(txtIme.Text, txtPriimek.Text))
                {
                    MessageBox.Show("Obvestilo: Oseba morda že obstaja v imeniku.");
                }

                // dodajamo novo osebo ali urejamo obstoječo?
                if (izbranaOseba == null)
                {
                    // dodajamo novi zapis
                    Oseba novaOseba = new Oseba();
                    novaOseba.ime = txtIme.Text;
                    novaOseba.priimek = txtPriimek.Text;
                    novaOseba.telefon = txtTelefon.Text;
                    novaOseba.email = txtEmail.Text;
                    novaOseba.rojdan = rojDatum;

                    // dodamo na seznam oseb
                    osebe.Add(novaOseba);
                }
                else
                {
                    // urejamo obstoječi zapis
                    izbranaOseba.ime = txtIme.Text;
                    izbranaOseba.priimek = txtPriimek.Text;
                    izbranaOseba.telefon = txtTelefon.Text;
                    izbranaOseba.email = txtEmail.Text;
                    izbranaOseba.rojdan = rojDatum;                
                }

                // zapišemo v bazo
                shraniPodatke();
                // ponovno naložimo in s tem prikažemo na seznamu
                naloziPodatke();
                // počistimo vnosna polja in omogočimo naslednji vnos
                btnNovZapis_Click(sender, e);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri shranjevanju podatkov o osebi. Prosimo, če preverite vhodne podatke."
                    + Environment.NewLine + ex.ToString() );
            }
        }

        /// <summary>
        /// gremo cez vse osebe in preverimo, če ta oseba že obstaja
        /// </summary>
        /// <param name="ime"></param>
        /// <param name="priimek"></param>
        /// <param name="telefon"></param>/// 
        /// <returns></returns>
        private bool aliOsebaZeObstaja(string ime, string priimek, string telefon)
        {
            int i = 0;
            while (i < osebe.Count)
            {
                // preverjamo samo ime in priimek
                if (telefon == null && osebe[i].ime.Equals(ime, StringComparison.CurrentCultureIgnoreCase)
                    && osebe[i].priimek.Equals(priimek, StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
                else if (osebe[i].telefon.Equals(telefon)
                    && osebe[i].ime.Equals(ime, StringComparison.CurrentCultureIgnoreCase)
                    && osebe[i].priimek.Equals(priimek, StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
                else
                {
                    i++;
                }
            }
            return false;
        }

        // preverimo, če oseba že obstaja
        private bool aliOsebaZeObstaja(string ime, string priimek)
        {
            // kličemo kar zgornjo funkcijo
            return aliOsebaZeObstaja(ime, priimek, null);
        }

        /// <summary>
        /// nov zapis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovZapis_Click(object sender, EventArgs e)
        {
            txtIme.Text = "";
            txtPriimek.Text = "";
            txtTelefon.Text = "";
            txtEmail.Text = "";
            txtRojDan.Text = "";

            // način za vnos nove osebe v imenik
            izbranaOseba = null;

            lblNaslov.Text = "Dodajanje zapisa v bazo:";

            // onemogočimo brisanje
            btnBrisanje.Visible = false;
        }


        /// <summary>
        /// klik na gumb za urejanje osebe v imeniku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstOsebe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // urejanje obstoječega zapisa
            izbranaOseba = lstOsebe.SelectedItem as Oseba;
            if (izbranaOseba != null)
            {
                // prikažemo podatke
                txtIme.Text = izbranaOseba.ime;
                txtPriimek.Text = izbranaOseba.priimek;
                txtTelefon.Text = izbranaOseba.telefon;
                txtEmail.Text = izbranaOseba.email;
                txtRojDan.Text = String.Format("{0:dd.MM.yyyy}", izbranaOseba.rojdan);
                // prikažemo naslov, da urejamo
                lblNaslov.Text = "Urejanje zapisa: ";
                // omogočimo brisanje
                btnBrisanje.Visible = true;
            }
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            // klicemo funkcijo za sortiranje
            sortList(cbSort.Text, true);
            // v prihodnosti bi lahko razširili tudi na obratno sortiranje
        }

        /// <summary>
        /// sortiramo seznam glede na vhodne parametre
        /// </summary>
        /// <param name="sortBy">podatek po katerem sortiramo: Ime, Priimek, Telefon, ...</param>
        /// <param name="ascending">če sortiramo padajoče ali naraščajoče</param>
        private void sortList(string sortBy, bool ascending)
        {
            // pripravimo nov list, ki bo sortiran
            List<Oseba> items;
            items = lstOsebe.Items.OfType<Oseba>().ToList();
            lstOsebe.Items.Clear();
            lstOsebe.Sorted = false;
            // sortiramo po izbranih kriterijih
            if (sortBy == "Ime")
            {
                if (ascending)
                    lstOsebe.Items.AddRange(items.OrderBy(i => i.ime).ToArray()); 
                else
                    lstOsebe.Items.AddRange(items.OrderByDescending(i => i.ime).ToArray()); 
            }
            else if (sortBy == "Priimek")
            {
                if (ascending)
                    lstOsebe.Items.AddRange(items.OrderBy(i => i.priimek).ToArray());
                else
                    lstOsebe.Items.AddRange(items.OrderByDescending(i => i.priimek).ToArray());
            }
            else if (sortBy == "Telefon")
            {
                if (ascending)
                    lstOsebe.Items.AddRange(items.OrderBy(i => i.telefon).ToArray());
                else
                    lstOsebe.Items.AddRange(items.OrderByDescending(i => i.telefon).ToArray());
            }
            else if (sortBy == "Roj. dan")
            {
                if (ascending)
                    lstOsebe.Items.AddRange(items.OrderBy(i => i.rojdan).ToArray());
                else
                    lstOsebe.Items.AddRange(items.OrderByDescending(i => i.rojdan).ToArray());
            }
            else if (sortBy == "Email")
            {
                if (ascending)
                    lstOsebe.Items.AddRange(items.OrderBy(i => i.email).ToArray());
                else
                    lstOsebe.Items.AddRange(items.OrderByDescending(i => i.email).ToArray());
            }
            else
            {
                MessageBox.Show("Sortiranje po tem polju še ni predvideno.");
            }
        }

        // gumb za brisanje zapisa
        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            // pogledamo, katera oseba je izbrana
            izbranaOseba = lstOsebe.SelectedItem as Oseba;
            if (izbranaOseba != null)
            {
                DialogResult dialogResult = MessageBox.Show("Ali ste prepričani?", "Brisanje", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    // preklic
                    return;
                }

                // gremo čez osebe in poiščemo pravilno osebo
                int i = 0;
                while (i < osebe.Count)
                {
                    if (osebe[i].Equals(izbranaOseba) )
                    {
                        osebe.RemoveAt(i);
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
                // shranimo in ponovno preberemo
                shraniPodatke();
                naloziPodatke();
                // damo možnost vnosa nove osebe
                btnNovZapis_Click(sender, e);
            }
        }

        private void btnBrisiVse_Click(object sender, EventArgs e)
        {
            // brišemo vse
            if (osebe.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ali ste prepričani, da želite izbrisati vse?", 
                    "Brisanje vseh zapisov", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    // preklic
                    return;
                }

                osebe = new List<Oseba>();
                // shranimo in ponovno preberemo
                shraniPodatke();
                naloziPodatke();
                // damo možnost vnosa nove osebe
                btnNovZapis_Click(sender, e);
            }
        }

        private void btnIskanje_Click(object sender, EventArgs e)
        {

            
                DialogResult dialogResult = MessageBox.Show("Ali ste prepričani?", "Brisanje", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    // preklic
                    return;
                }

                // gremo čez osebe in poiščemo pravilno osebo
                int i = 0;
                while (i < osebe.Count)
                {
                    if (osebe[i].Equals(izbranaOseba))
                    {
                        osebe.RemoveAt(i);
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
                // shranimo in ponovno preberemo
                shraniPodatke();
                naloziPodatke();
                // damo možnost vnosa nove osebe
                btnNovZapis_Click(sender, e);
            

        }

        private void btnNajdi_Click(object sender, EventArgs e)
        {
            string iskanje = txtIskanje.Text;

            // gremo čez osebe in poiščemo pravilno osebo
            Oseba oseba;
            int i = 0;
            while (i < lstOsebe.Items.Count)
            {
                // preverjamo samo ime in priimek
                oseba = lstOsebe.Items[i] as Oseba;
                if (oseba.ime.IndexOf(iskanje, StringComparison.OrdinalIgnoreCase) >= 0
                    || oseba.priimek.IndexOf(iskanje, StringComparison.OrdinalIgnoreCase) >= 0
                    || oseba.telefon.IndexOf(iskanje, StringComparison.OrdinalIgnoreCase) >= 0
                    )
                {
                    // označimo iskano osebo
                    lstOsebe.SelectedIndex = i;
                    return;
                }
                else
                {
                    i++;
                }
            }
            // zgleda nismo našli nič
            MessageBox.Show("Nisem našel iskane osebe. Prosimo, preverite vhodne parametre.");
        }
    }




    // class za interno uporabo
    public class Oseba
    {
        // nabor lastnosti objekta
        public string ime { get; set; }
        public string priimek { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public DateTime? rojdan { get; set; }

        /// <summary>
        /// vrnemo tekstovni prikaz objekta
        /// </summary>
        /// <returns>ime osebe</returns>
        public override string ToString()
        {
            return priimek + " " + ime + ": " + telefon;
        }

    }
}


        
