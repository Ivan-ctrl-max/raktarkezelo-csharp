using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Raktarkezelo
{
    public partial class Main : Form
    {
        List<Termek> raktar = new List<Termek>();

        public Main()
        {
            InitializeComponent();
        }

        private void btnHozaad_Click(object sender, EventArgs e)
        {
            try
            {
                string nev = Nev.Text;
                int ar = int.Parse(Ar.Text); 
                int db = (int)numDb.Value; 

                Termek ujTermek = new Termek(nev, ar, db);

                raktar.Add(ujTermek);

                Frissitst();


                btnMentes_Click(sender, e);

                Nev.Clear();
                Ar.Clear();
                numDb.Value = 0;
            }
            catch
            {
                MessageBox.Show("Kérlek, töltsd ki megfelelően a mezőket!");
            }

        }
        private void Frissitst()
        {
            dgvRaktar.DataSource = null;
            dgvRaktar.DataSource = raktar;

            int ossz = 0;
            foreach (var t in raktar)
            {
                ossz += t.GetOsszErtek();
            }
            label1.Text = $"Összérték: {ossz} Ft";
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("raktar.txt", false))
                {
                    foreach (var t in raktar)
                    {
                        sw.WriteLine($"{t.Nev};{t.Ar};{t.Darab}");
                    }
                }

                MessageBox.Show("A raktárkészlet sikeresen mentve a raktar.txt fájlba!",
                                "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a mentés során: " + ex.Message,
                                "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("raktar.txt"))
                {
                    string[] sorok = File.ReadAllLines("raktar.txt");

                    foreach (var sor in sorok)
                    {
                        if (!string.IsNullOrWhiteSpace(sor))
                        {
                            string[] adatok = sor.Split(';');

                            string nev = adatok[0];
                            int ar = int.Parse(adatok[1]);
                            int db = int.Parse(adatok[2]);

                            Termek betoltottTermek = new Termek(nev, ar, db);

                            raktar.Add(betoltottTermek);
                        }
                    }
                    Frissitst();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a betöltés során: " + ex.Message);
            }
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            if (dgvRaktar.SelectedRows.Count > 0)
            {
                var valasz = MessageBox.Show("Biztosan törlöd?", "Megerősítés", MessageBoxButtons.YesNo);
                if (valasz == DialogResult.Yes)
                {
                    Termek kijelolt = (Termek)dgvRaktar.SelectedRows[0].DataBoundItem;
                    raktar.Remove(kijelolt);

                    Frissitst();
                    btnMentes_Click(sender, e); 
                }
            }
        }
    }
}
