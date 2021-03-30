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
using System.Resources;
using ShinyCounter.Properties;

namespace ShinyCounter {
    public partial class Form1 : Form {
        ResourceManager rm = Resources.ResourceManager;

        public Form1() {
            InitializeComponent();
            if(!Directory.Exists(".\\hunts"))
                Directory.CreateDirectory(".\\hunts");

            PreencherPokes();
            cmbPoke.SelectedIndex = 0;
            CmbPoke_SelectedIndexChanged(null, null);



            // Verificar se já existem hunts
            if (Directory.GetFiles(Yagami.pathHunts).Length > 0) {
                foreach(string file in Directory.GetFiles(Yagami.pathHunts, "*.HUNT")) {
                    FileInfo nf = new FileInfo(file);
                    cmbHunts.Items.Add(nf.Name.Replace(".hunt", string.Empty));
                }
                lblErro.Visible = false;
                btnContinuar.Enabled = true;
                cmbHunts.SelectedIndex = 0;
            } else {
                lblErro.Visible = true;
                btnContinuar.Enabled = false;
            }
            
        }

        private void PreencherPokes() {
            foreach(Pokemon p in Yagami.pokemons) {
                cmbPoke.Items.Add(p.Nome);
            }
        }

        private void BtnIniciar_Click(object sender, EventArgs e) {
            string arquivoH = Yagami.pathHunts + "\\" + NomePokemonArquivo() + ".hunt";
            string arquivoT = Yagami.pathHunts + "\\" + NomePokemonArquivo() + ".timer";
            string arquivoC = Yagami.pathHunts + "\\" + NomePokemonArquivo() + ".tcfg";

            if (!File.Exists(arquivoH)) {
                File.WriteAllText(arquivoH, "0");
                File.WriteAllText(arquivoT, "000:00:00");
                File.WriteAllText(arquivoC, "0,0,0");
            }
            
            Yagami.huntAtual = cmbPoke.SelectedItem.ToString();
            Yagami.arquivoHuntAtual = arquivoH;
            Yagami.arquivoTimerAtual = arquivoT;
            Yagami.arquivoTConfigAtual = arquivoC;

            new Contador().Show();
            Hide();
            

        }

        private void CmbPoke_SelectedIndexChanged(object sender, EventArgs e) {
            string poke = cmbPoke.SelectedItem.ToString().ToLower();
            poke = poke.Replace(".", "-");
            try {
                Bitmap myImage = (Bitmap)rm.GetObject(poke);
                pictureBox1.Image = myImage;
            } catch (Exception ex) {
                Bitmap myImage = (Bitmap)rm.GetObject("unknown");
                pictureBox1.Image = myImage;
            }
            
        }

        private string NomePokemonArquivo() {
            string poke = cmbPoke.SelectedItem.ToString();
            poke = poke.Replace(".", "-");
            return poke;
        }

        private string NomePokemonLista() {
            string poke = cmbHunts.SelectedItem.ToString();
            return poke;
        }

        private void BtnContinuar_Click(object sender, EventArgs e) {
            string arquivoH = Yagami.pathHunts + "\\" + NomePokemonLista() + ".hunt";
            string arquivoT = Yagami.pathHunts + "\\" + NomePokemonLista() + ".timer";
            string arquivoC = Yagami.pathHunts + "\\" + NomePokemonLista() + ".tcfg";

            if (!File.Exists(arquivoH)) {
                File.WriteAllText(arquivoH, "0");
                File.WriteAllText(arquivoT, "000:00:00");
                File.WriteAllText(arquivoC, "0,0,0");
            }

            Yagami.huntAtual = cmbHunts.SelectedItem.ToString();
            Yagami.arquivoHuntAtual = arquivoH;
            Yagami.arquivoTimerAtual = arquivoT;
            Yagami.arquivoTConfigAtual = arquivoC;

            new Contador().Show();
            Hide();

        }

        private void CmbHunts_SelectedIndexChanged(object sender, EventArgs e) {
            string poke = cmbHunts.SelectedItem.ToString().ToLower();
            poke = poke.Replace(".", "-");
            try {
                Bitmap myImage = (Bitmap)rm.GetObject(poke);
                pictureBox2.Image = myImage;
            } catch (Exception ex) {
                Bitmap myImage = (Bitmap)rm.GetObject("unknown");
                pictureBox2.Image = myImage;
            }
        }
    }
}
