using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Resources;
using ShinyCounter.Properties;
using System.Timers;

namespace ShinyCounter {
    public partial class Contador : Form {
        ResourceManager rm = Resources.ResourceManager;
        System.Timers.Timer aTimer = new System.Timers.Timer();
        Bitmap myImage;
        private int counter, increase, decrease, sec, min, hour;
        private string sSec, sMin, sHour;

        private void Contador_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private string timerTotal;
        private bool timerOn = true;

        private void BtnTimer_Click(object sender, EventArgs e) {
            if(timerOn) {
                aTimer.Stop();
                btnTimer.Text = "Ligar Timer";
                timerOn = false;
            } else {
                aTimer.Start();
                btnTimer.Text = "Desligar Timer";
                timerOn = true;
            }
        }

        

        public Contador() {
            InitializeComponent();
            lblCounter.Text = File.ReadAllText(Yagami.arquivoHuntAtual);
            lblTimer.Text = File.ReadAllText(Yagami.arquivoTimerAtual);
            lblPokeHunt.Text = Yagami.huntAtual;

            string poke = Yagami.huntAtual.ToLower();
            poke = poke.Replace(".", "-");
            myImage = (Bitmap)rm.GetObject(poke);
            picPokemon.Image = myImage;

            counter = int.Parse(lblCounter.Text);

            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;

            // Retomar Timer
            string tConfig = File.ReadAllText(Yagami.arquivoTConfigAtual);
            string[] smh = tConfig.Split(',');
            hour = int.Parse(smh[0]);
            min = int.Parse(smh[1]);
            sec = int.Parse(smh[2]);

        }

        private void BtnDown_Click(object sender, EventArgs e) {
            decrease = (int)numDown.Value;
            counter -= decrease;

            if (counter < 0)
                counter = 0;

            lblCounter.Text = counter.ToString();
            File.WriteAllText(Yagami.arquivoHuntAtual, counter.ToString());

        }

        private void BtnUp_Click(object sender, EventArgs e) {
            increase = (int)numUp.Value;
            counter += increase;
            lblCounter.Text = counter.ToString();
            File.WriteAllText(Yagami.arquivoHuntAtual, counter.ToString());

        }

        private void OnTimedEvent(object source, ElapsedEventArgs e) {
            sec++;
            if (sec > 59) {
                min += 1;
                sec = 0;
            }

            if(min > 59) {
                hour += 1;
                min = 0;
            }

            if (sec > 9)
                sSec = sec.ToString();
            else
                sSec = "0" + sec;

            if (min > 9)
                sMin = min.ToString();
            else
                sMin = "0" + min;

            if (hour > 9)
                sHour = hour.ToString();
            else
                sHour = "0" + hour;

            timerTotal = sHour + ":" + sMin + ":" + sSec;
            

            if (lblTimer.InvokeRequired) {
                lblTimer.Invoke(new MethodInvoker(() => {
                    lblTimer.Text = timerTotal;
                }));

            } else {
                lblTimer.Text = timerTotal;
            }

            File.WriteAllText(Yagami.arquivoTConfigAtual, hour + "," + min + "," + sec);
            File.WriteAllText(Yagami.arquivoTimerAtual, timerTotal);

        }
    }
}
