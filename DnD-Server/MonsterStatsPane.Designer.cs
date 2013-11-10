namespace DnD {
    partial class MonsterStatsPane {
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
            this.label1 = new System.Windows.Forms.Label();
            this.monsterNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cha = new System.Windows.Forms.Label();
            this.wis = new System.Windows.Forms.Label();
            this.intel = new System.Windows.Forms.Label();
            this.dex = new System.Windows.Forms.Label();
            this.con = new System.Windows.Forms.Label();
            this.str = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stats = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.spd = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.will = new System.Windows.Forms.Label();
            this.reflex = new System.Windows.Forms.Label();
            this.fort = new System.Windows.Forms.Label();
            this.ac = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dicebox = new System.Windows.Forms.GroupBox();
            this.d12 = new System.Windows.Forms.PictureBox();
            this.d10 = new System.Windows.Forms.PictureBox();
            this.d8b = new System.Windows.Forms.PictureBox();
            this.d8a = new System.Windows.Forms.PictureBox();
            this.d6 = new System.Windows.Forms.PictureBox();
            this.d4 = new System.Windows.Forms.PictureBox();
            this.monstersend = new System.Windows.Forms.Button();
            this.monsterinput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.stats.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.dicebox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d8b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d8a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monster - ";
            // 
            // monsterNameLabel
            // 
            this.monsterNameLabel.AutoSize = true;
            this.monsterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monsterNameLabel.Location = new System.Drawing.Point(106, 9);
            this.monsterNameLabel.Name = "monsterNameLabel";
            this.monsterNameLabel.Size = new System.Drawing.Size(150, 26);
            this.monsterNameLabel.TabIndex = 0;
            this.monsterNameLabel.Text = "<No Monster>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "HP:";
            // 
            // hp
            // 
            this.hp.AutoSize = true;
            this.hp.Location = new System.Drawing.Point(169, 16);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(13, 13);
            this.hp.TabIndex = 1;
            this.hp.Text = "0";
            this.hp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Level:";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(74, 16);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(13, 13);
            this.level.TabIndex = 1;
            this.level.Text = "0";
            this.level.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Str:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cha);
            this.groupBox1.Controls.Add(this.wis);
            this.groupBox1.Controls.Add(this.intel);
            this.groupBox1.Controls.Add(this.dex);
            this.groupBox1.Controls.Add(this.con);
            this.groupBox1.Controls.Add(this.str);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(9, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ability Scores";
            // 
            // cha
            // 
            this.cha.AutoSize = true;
            this.cha.Location = new System.Drawing.Point(65, 81);
            this.cha.Name = "cha";
            this.cha.Size = new System.Drawing.Size(13, 13);
            this.cha.TabIndex = 2;
            this.cha.Text = "0";
            this.cha.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // wis
            // 
            this.wis.AutoSize = true;
            this.wis.Location = new System.Drawing.Point(65, 68);
            this.wis.Name = "wis";
            this.wis.Size = new System.Drawing.Size(13, 13);
            this.wis.TabIndex = 2;
            this.wis.Text = "0";
            this.wis.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // intel
            // 
            this.intel.AutoSize = true;
            this.intel.Location = new System.Drawing.Point(65, 55);
            this.intel.Name = "intel";
            this.intel.Size = new System.Drawing.Size(13, 13);
            this.intel.TabIndex = 2;
            this.intel.Text = "0";
            this.intel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dex
            // 
            this.dex.AutoSize = true;
            this.dex.Location = new System.Drawing.Point(65, 42);
            this.dex.Name = "dex";
            this.dex.Size = new System.Drawing.Size(13, 13);
            this.dex.TabIndex = 2;
            this.dex.Text = "0";
            this.dex.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // con
            // 
            this.con.AutoSize = true;
            this.con.Location = new System.Drawing.Point(65, 29);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(13, 13);
            this.con.TabIndex = 2;
            this.con.Text = "0";
            this.con.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // str
            // 
            this.str.AutoSize = true;
            this.str.Location = new System.Drawing.Point(65, 16);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(13, 13);
            this.str.TabIndex = 2;
            this.str.Text = "0";
            this.str.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Cha:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Wis:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Int:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Dex:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Con:";
            // 
            // stats
            // 
            this.stats.Controls.Add(this.label19);
            this.stats.Controls.Add(this.spd);
            this.stats.Controls.Add(this.groupBox2);
            this.stats.Controls.Add(this.groupBox1);
            this.stats.Controls.Add(this.label2);
            this.stats.Controls.Add(this.level);
            this.stats.Controls.Add(this.hp);
            this.stats.Controls.Add(this.label4);
            this.stats.Location = new System.Drawing.Point(17, 38);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(203, 152);
            this.stats.TabIndex = 4;
            this.stats.TabStop = false;
            this.stats.Text = "Stats";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(169, 111);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "0";
            // 
            // spd
            // 
            this.spd.AutoSize = true;
            this.spd.Location = new System.Drawing.Point(118, 111);
            this.spd.Name = "spd";
            this.spd.Size = new System.Drawing.Size(29, 13);
            this.spd.TabIndex = 6;
            this.spd.Text = "Spd:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.will);
            this.groupBox2.Controls.Add(this.reflex);
            this.groupBox2.Controls.Add(this.fort);
            this.groupBox2.Controls.Add(this.ac);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(112, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(76, 76);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Defenses";
            // 
            // will
            // 
            this.will.AutoSize = true;
            this.will.Location = new System.Drawing.Point(57, 55);
            this.will.Name = "will";
            this.will.Size = new System.Drawing.Size(13, 13);
            this.will.TabIndex = 0;
            this.will.Text = "0";
            // 
            // reflex
            // 
            this.reflex.AutoSize = true;
            this.reflex.Location = new System.Drawing.Point(57, 42);
            this.reflex.Name = "reflex";
            this.reflex.Size = new System.Drawing.Size(13, 13);
            this.reflex.TabIndex = 0;
            this.reflex.Text = "0";
            // 
            // fort
            // 
            this.fort.AutoSize = true;
            this.fort.Location = new System.Drawing.Point(57, 29);
            this.fort.Name = "fort";
            this.fort.Size = new System.Drawing.Size(13, 13);
            this.fort.TabIndex = 0;
            this.fort.Text = "0";
            // 
            // ac
            // 
            this.ac.AutoSize = true;
            this.ac.Location = new System.Drawing.Point(57, 16);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(13, 13);
            this.ac.TabIndex = 0;
            this.ac.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Will:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Ref:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Fort:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "AC:";
            // 
            // dicebox
            // 
            this.dicebox.Controls.Add(this.d12);
            this.dicebox.Controls.Add(this.d10);
            this.dicebox.Controls.Add(this.d8b);
            this.dicebox.Controls.Add(this.d8a);
            this.dicebox.Controls.Add(this.d6);
            this.dicebox.Controls.Add(this.d4);
            this.dicebox.Location = new System.Drawing.Point(226, 38);
            this.dicebox.Name = "dicebox";
            this.dicebox.Size = new System.Drawing.Size(155, 152);
            this.dicebox.TabIndex = 5;
            this.dicebox.TabStop = false;
            this.dicebox.Text = "Dice";
            // 
            // d12
            // 
            this.d12.Location = new System.Drawing.Point(106, 106);
            this.d12.Name = "d12";
            this.d12.Size = new System.Drawing.Size(39, 38);
            this.d12.TabIndex = 0;
            this.d12.TabStop = false;
            // 
            // d10
            // 
            this.d10.Location = new System.Drawing.Point(35, 109);
            this.d10.Name = "d10";
            this.d10.Size = new System.Drawing.Size(39, 38);
            this.d10.TabIndex = 0;
            this.d10.TabStop = false;
            // 
            // d8b
            // 
            this.d8b.Location = new System.Drawing.Point(53, 63);
            this.d8b.Name = "d8b";
            this.d8b.Size = new System.Drawing.Size(39, 38);
            this.d8b.TabIndex = 0;
            this.d8b.TabStop = false;
            // 
            // d8a
            // 
            this.d8a.Location = new System.Drawing.Point(8, 63);
            this.d8a.Name = "d8a";
            this.d8a.Size = new System.Drawing.Size(39, 38);
            this.d8a.TabIndex = 0;
            this.d8a.TabStop = false;
            // 
            // d6
            // 
            this.d6.Location = new System.Drawing.Point(93, 19);
            this.d6.Name = "d6";
            this.d6.Size = new System.Drawing.Size(39, 38);
            this.d6.TabIndex = 0;
            this.d6.TabStop = false;
            // 
            // d4
            // 
            this.d4.Location = new System.Drawing.Point(21, 19);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(39, 38);
            this.d4.TabIndex = 0;
            this.d4.TabStop = false;
            // 
            // monstersend
            // 
            this.monstersend.Location = new System.Drawing.Point(332, 196);
            this.monstersend.Name = "monstersend";
            this.monstersend.Size = new System.Drawing.Size(50, 61);
            this.monstersend.TabIndex = 7;
            this.monstersend.Text = "Send";
            this.monstersend.UseVisualStyleBackColor = true;
            this.monstersend.Click += new System.EventHandler(this.monstersend_Click);
            // 
            // monsterinput
            // 
            this.monsterinput.Location = new System.Drawing.Point(17, 196);
            this.monsterinput.Multiline = true;
            this.monsterinput.Name = "monsterinput";
            this.monsterinput.Size = new System.Drawing.Size(309, 61);
            this.monsterinput.TabIndex = 6;
            this.monsterinput.TextChanged += new System.EventHandler(this.monsterinput_TextChanged);
            // 
            // MonsterStatsPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 265);
            this.Controls.Add(this.monstersend);
            this.Controls.Add(this.monsterinput);
            this.Controls.Add(this.dicebox);
            this.Controls.Add(this.stats);
            this.Controls.Add(this.monsterNameLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonsterStatsPane";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DnD - Monster Stats";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.stats.ResumeLayout(false);
            this.stats.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.dicebox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.d12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d8b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d8a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label monsterNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox stats;
        private System.Windows.Forms.Label str;
        private System.Windows.Forms.Label cha;
        private System.Windows.Forms.Label wis;
        private System.Windows.Forms.Label intel;
        private System.Windows.Forms.Label dex;
        private System.Windows.Forms.Label con;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ac;
        private System.Windows.Forms.Label will;
        private System.Windows.Forms.Label reflex;
        private System.Windows.Forms.Label fort;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label spd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox dicebox;
        private System.Windows.Forms.PictureBox d4;
        private System.Windows.Forms.PictureBox d6;
        private System.Windows.Forms.PictureBox d8a;
        private System.Windows.Forms.PictureBox d8b;
        private System.Windows.Forms.PictureBox d10;
        private System.Windows.Forms.PictureBox d12;
        private System.Windows.Forms.Button monstersend;
        private System.Windows.Forms.TextBox monsterinput;
    }
}