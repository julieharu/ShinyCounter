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

namespace ShinyCounter {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Directory.CreateDirectory(".\\hunts");
            PreencherPokes();
            cmbPoke.SelectedIndex = 2;

            // Verificar se já existem hunts
            if(Directory.GetFiles(Yagami.pathHunts).Length > 0) {
                lblErro.Visible = false;
                btnContinuar.Enabled = true;
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

        }

        private void CmbPoke_SelectedIndexChanged(object sender, EventArgs e) {
            string poke = cmbPoke.SelectedItem.ToString().ToLower();
            poke = poke.Replace(".", string.Empty);
            try {
                pictureBox1.Image = Image.FromFile(".\\sprites\\" + poke + ".png");
            } catch (Exception ex) {
                pictureBox1.Image = Image.FromFile(".\\sprites\\unknown.png");
            }
            
        }
    }
}
