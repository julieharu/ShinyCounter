
namespace ShinyCounter {
    partial class Contador {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contador));
            this.lblPokeHunt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picPokemon = new System.Windows.Forms.PictureBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.numUp = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTimer = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.numDown = new System.Windows.Forms.NumericUpDown();
            this.btnDown = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUp)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPokeHunt
            // 
            this.lblPokeHunt.AutoSize = true;
            this.lblPokeHunt.Font = new System.Drawing.Font("Power Red and Green", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPokeHunt.Location = new System.Drawing.Point(78, 19);
            this.lblPokeHunt.Name = "lblPokeHunt";
            this.lblPokeHunt.Size = new System.Drawing.Size(113, 33);
            this.lblPokeHunt.TabIndex = 4;
            this.lblPokeHunt.Text = "Venusaur";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picPokemon);
            this.panel1.Controls.Add(this.lblPokeHunt);
            this.panel1.Location = new System.Drawing.Point(15, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 65);
            this.panel1.TabIndex = 8;
            // 
            // picPokemon
            // 
            this.picPokemon.Image = global::ShinyCounter.Properties.Resources.venusaur;
            this.picPokemon.Location = new System.Drawing.Point(0, 1);
            this.picPokemon.Name = "picPokemon";
            this.picPokemon.Size = new System.Drawing.Size(69, 64);
            this.picPokemon.TabIndex = 0;
            this.picPokemon.TabStop = false;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(11, 169);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(230, 48);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "Aumentar [+]";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Power Red and Green", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCounter.Location = new System.Drawing.Point(14, 18);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(28, 33);
            this.lblCounter.TabIndex = 6;
            this.lblCounter.Text = "0";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numUp
            // 
            this.numUp.Location = new System.Drawing.Point(314, 187);
            this.numUp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUp.Name = "numUp";
            this.numUp.Size = new System.Drawing.Size(120, 30);
            this.numUp.TabIndex = 1;
            this.numUp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnTimer);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.numDown);
            this.panel2.Controls.Add(this.btnDown);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.numUp);
            this.panel2.Controls.Add(this.btnUp);
            this.panel2.Location = new System.Drawing.Point(15, 120);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(449, 296);
            this.panel2.TabIndex = 9;
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(302, 87);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(132, 29);
            this.btnTimer.TabIndex = 14;
            this.btnTimer.Text = "Desligar Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.BtnTimer_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ShinyCounter.Properties.Resources.minun;
            this.pictureBox3.Location = new System.Drawing.Point(247, 224);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 61);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // numDown
            // 
            this.numDown.Location = new System.Drawing.Point(314, 255);
            this.numDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDown.Name = "numDown";
            this.numDown.Size = new System.Drawing.Size(120, 30);
            this.numDown.TabIndex = 10;
            this.numDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(11, 237);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(230, 48);
            this.btnDown.TabIndex = 11;
            this.btnDown.Text = "Diminuir [-]";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ShinyCounter.Properties.Resources.plusle;
            this.pictureBox2.Location = new System.Drawing.Point(247, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 61);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.lblCounter);
            this.panel3.Controls.Add(this.lblTimer);
            this.panel3.Location = new System.Drawing.Point(11, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 66);
            this.panel3.TabIndex = 8;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Power Red and Green", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.Location = new System.Drawing.Point(291, 18);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTimer.Size = new System.Drawing.Size(120, 33);
            this.lblTimer.TabIndex = 13;
            this.lblTimer.Text = "000:00:00";
            // 
            // menuConfig
            // 
            this.menuConfig.Enabled = false;
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(96, 20);
            this.menuConfig.Text = "Configurações";
            // 
            // menuSobre
            // 
            this.menuSobre.Enabled = false;
            this.menuSobre.Name = "menuSobre";
            this.menuSobre.Size = new System.Drawing.Size(49, 20);
            this.menuSobre.Text = "Sobre";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConfig,
            this.menuSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(476, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Contador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Power Red and Green", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Contador";
            this.Text = "Contador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Contador_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUp)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPokeHunt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPokemon;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.NumericUpDown numUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown numDown;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ToolStripMenuItem menuConfig;
        private System.Windows.Forms.ToolStripMenuItem menuSobre;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}