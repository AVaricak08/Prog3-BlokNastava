using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Fudbaler> listaClanova = new List<Fudbaler>();
        private string putanjaDoFajla = "igraci.csv";
        public Form1()
        {
            InitializeComponent();
            cmbGodine.Items.Add("15");
            cmbGodine.Items.Add("16");
            cmbGodine.Items.Add("17");
            cmbGodine.Items.Add("18");
            cmbGodine.Items.Add("19");
            cmbGodine.Items.Add("20");
            cmbGodine.Items.Add("21");
            cmbGodine.Items.Add("22");
            cmbGodine.Items.Add("23");
            cmbGodine.Items.Add("24");
            cmbGodine.Items.Add("25");
            cmbGodine.Items.Add("26");
            cmbGodine.Items.Add("27");
            cmbGodine.Items.Add("28");
            cmbGodine.Items.Add("29");
            cmbGodine.Items.Add("30");
            cmbGodine.Items.Add("31");
            cmbGodine.Items.Add("32");
            cmbGodine.Items.Add("33");
            cmbGodine.Items.Add("34");
            cmbGodine.Items.Add("35");
            cmbGodine.Items.Add("36");
            cmbGodine.Items.Add("37");
            cmbGodine.Items.Add("38");
            cmbGodine.Items.Add("39");
            cmbGodine.Items.Add("40");
            cmbGodine.Items.Add("41");
            cmbGodine.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeo.Items.Add("Golman");
            cmbDeo.Items.Add("Odbrana");
            cmbDeo.Items.Add("Srednji red");
            cmbDeo.Items.Add("Napad");
            cmbDeo.DropDownStyle = ComboBoxStyle.DropDownList;
            lsvLista.Columns.Add("Ime");
            lsvLista.Columns.Add("Prezime");
            lsvLista.Columns.Add("Pol");
            lsvLista.Columns.Add("Godine");
            lsvLista.Columns.Add("Deo Terena");
            lsvLista.Columns.Add("Pozicija");
            lsvLista.GridLines = true;
            lsvLista.View = View.Details;
            lsvLista.FullRowSelect = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void PostaviMojePodatke(Fudbaler clan)
        {
            lblMojiPodaci.Text = $"Презиме: {clan.Prezime}, Име: {clan.Ime}, Пол: {clan.Pol}, Године: {clan.Godine}, Део терена: {clan.DeoTerena}, Позиција: {clan.Pozicija}";
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (txtIme.Text == "" || txtPrezime.Text == "")
            {
                MessageBox.Show("Име и презиме су обавезна поља!");
                return;
            }

            string izabraniPol = rbtMuško.Checked ? "Мушки" : "Женски";

            Fudbaler noviClan = new Fudbaler(
                txtIme.Text,
                txtPrezime.Text,
                izabraniPol,
                int.Parse(cmbGodine.Text), 
                cmbDeo.Text,
                txtPozicija.Text
            );

            listaClanova.Add(noviClan);
            OsveziPrikaz();
            OcistiPolja();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (lsvLista.SelectedIndices.Count>0)
            {
                int indeks = lsvLista.SelectedIndices[0];

                string izabraniPol = rbtMuško.Checked ? "Мушки" : "Женски";

                listaClanova[indeks].Ime = txtIme.Text;
                listaClanova[indeks].Prezime = txtPrezime.Text;
                listaClanova[indeks].Pol = izabraniPol;
                listaClanova[indeks].Godine = int.Parse(cmbGodine.Text);
                listaClanova[indeks].DeoTerena = cmbDeo.Text;
                listaClanova[indeks].Pozicija = txtPozicija.Text;

                OsveziPrikaz();
                OcistiPolja();
                MessageBox.Show("Подаци успешно измењени!");
            }
            else
            {
                MessageBox.Show("Изаберите члана из листе ког желите да измените.");
            }
        }

        private void btnObriši_Click(object sender, EventArgs e)
        {
            if (lsvLista.SelectedIndices.Count > 0)
            {
                int indeks = lsvLista.SelectedIndices[0];

                listaClanova.RemoveAt(indeks);
                OsveziPrikaz();
                OcistiPolja();
                MessageBox.Show("Члан успешно обрисан.");
            }
            else
            {
                MessageBox.Show("Изаберите члана из табеле ког желите да обришете.");
            }
        }

        private void btnSačuvaj_Click(object sender, EventArgs e)
        {
            List<string> linijeZaUpis = new List<string>();

            foreach (Fudbaler clan in listaClanova)
            {
                linijeZaUpis.Add($"{clan.Ime};{clan.Prezime};{clan.Pol};{clan.Godine};{clan.DeoTerena};{clan.Pozicija}");
            }

            
            File.WriteAllLines(putanjaDoFajla, linijeZaUpis);

            MessageBox.Show("Подаци успешно сачувани у фајл!");
        }

        private void btnUčitaj_Click(object sender, EventArgs e)
        {
            
            if (!File.Exists(putanjaDoFajla))
            {
                MessageBox.Show("Не постоји сачуван фајл са подацима. Прво кликните на 'Сачувај'.");
                return;
            }

            

            // Читамо све линије које су раније снимљене кликом на дугме "Сачувај"
            string[] sveLinije = File.ReadAllLines(putanjaDoFajla);

            foreach (string linija in sveLinije)
            {
                string[] delovi = linija.Split(';');
                if (delovi.Length == 6)
                {
                    
                    Fudbaler ucitaniClan = new Fudbaler(
                        delovi[0],
                        delovi[1],
                        delovi[2],
                        int.Parse(delovi[3]),
                        delovi[4],
                        delovi[5]
                    );

                    
                    listaClanova.Add(ucitaniClan);

                    
                    ListViewItem novaStavka = new ListViewItem(ucitaniClan.Ime);
                    novaStavka.SubItems.Add(ucitaniClan.Prezime);
                    novaStavka.SubItems.Add(ucitaniClan.Pol);
                    novaStavka.SubItems.Add(ucitaniClan.Godine.ToString());
                    novaStavka.SubItems.Add(ucitaniClan.DeoTerena);
                    novaStavka.SubItems.Add(ucitaniClan.Pozicija);

                    novaStavka.Tag = ucitaniClan;

                    
                    lsvLista.Items.Add(novaStavka);
                }
            }

            MessageBox.Show("Подаци из фајла су успешно учитани и додати на крај табеле!");
        }

        private void btnObrada_Click(object sender, EventArgs e)
        {
            if (listaClanova.Count == 0)
            {
                MessageBox.Show("Листа је празна. Нема података за обраду.");
                return;
            }

            int ukupnoGodina = 0;
            int бројНападача = 0;

            foreach (Fudbaler clan in listaClanova)
            {
                ukupnoGodina += clan.Godine;
                if (clan.DeoTerena == "Napad")
                {
                    бројНападача++;
                }
            }

            double prosecneGodine = (double)ukupnoGodina / listaClanova.Count;

            string izvestaj = $"--- ИЗВЕШТАЈ КЛУБА ---\n\n" +
                              $"Укупан број чланова: {listaClanova.Count}\n" +
                              $"Просечна старост: {prosecneGodine:F2} година\n" +
                              $"Број играча у нападу: {бројНападача}";

            MessageBox.Show(izvestaj, "Обрада података", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void OsveziPrikaz()
        {
            lsvLista.Items.Clear();

            foreach (Fudbaler clan in listaClanova)
            {
                
                ListViewItem stavka = new ListViewItem(clan.Ime);
                stavka.SubItems.Add(clan.Prezime);
                stavka.SubItems.Add(clan.Pol);
                stavka.SubItems.Add(clan.Godine.ToString());
                stavka.SubItems.Add(clan.DeoTerena);
                stavka.SubItems.Add(clan.Pozicija);

                
                stavka.Tag = clan;

                lsvLista.Items.Add(stavka);
            }
        }
        private void OcistiPolja()
        {
            txtIme.Clear();
            txtPrezime.Clear();
            cmbGodine.SelectedIndex=-1;
            cmbDeo.SelectedIndex=-1;
            txtPozicija.Clear();
            rbtMuško.Checked = false;
            rbtŽensko.Checked = false;
        }

        private void lsvLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvLista.SelectedIndices.Count>0)
            {
                Fudbaler izabrani = (Fudbaler)lsvLista.SelectedItems[0].Tag;
                txtIme.Text = izabrani.Ime;
                txtPrezime.Text = izabrani.Prezime;
                cmbGodine.Text = izabrani.Godine.ToString();
                cmbDeo.Text = izabrani.DeoTerena;
                txtPozicija.Text = izabrani.Pozicija;

                
                if (izabrani.Pol == "Мушки")
                {
                    rbtMuško.Checked = true;
                }
                else
                {
                    rbtŽensko.Checked = true;
                }

                PostaviMojePodatke(izabrani);
            }
        }

        private void lblMojiPodaci_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
