namespace DnD {
    partial class AddMonsterDialogue {
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
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.MaskedTextBox();
            this.hp = new System.Windows.Forms.MaskedTextBox();
            this.str = new System.Windows.Forms.MaskedTextBox();
            this.con = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dex = new System.Windows.Forms.MaskedTextBox();
            this.Int = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.wis = new System.Windows.Forms.MaskedTextBox();
            this.cha = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ac = new System.Windows.Forms.MaskedTextBox();
            this.fort = new System.Windows.Forms.MaskedTextBox();
            this.Ref = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.will = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.spd = new System.Windows.Forms.MaskedTextBox();
            this.okayBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(54, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(248, 20);
            this.name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add Monster";
            // 
            // race
            // 
            this.race.Location = new System.Drawing.Point(54, 63);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(248, 20);
            this.race.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Race:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Level:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "HP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Str:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Con:";
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(54, 88);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(108, 20);
            this.level.TabIndex = 3;
            this.level.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // hp
            // 
            this.hp.Location = new System.Drawing.Point(199, 88);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(103, 20);
            this.hp.TabIndex = 3;
            this.hp.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // str
            // 
            this.str.Location = new System.Drawing.Point(38, 16);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(49, 20);
            this.str.TabIndex = 3;
            this.str.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // con
            // 
            this.con.Location = new System.Drawing.Point(122, 16);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(53, 20);
            this.con.TabIndex = 3;
            this.con.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dex:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Int:";
            // 
            // dex
            // 
            this.dex.Location = new System.Drawing.Point(38, 42);
            this.dex.Name = "dex";
            this.dex.Size = new System.Drawing.Size(49, 20);
            this.dex.TabIndex = 3;
            this.dex.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // Int
            // 
            this.Int.Location = new System.Drawing.Point(122, 42);
            this.Int.Name = "Int";
            this.Int.Size = new System.Drawing.Size(53, 20);
            this.Int.TabIndex = 3;
            this.Int.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Wis:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(90, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Cha:";
            // 
            // wis
            // 
            this.wis.Location = new System.Drawing.Point(38, 68);
            this.wis.Name = "wis";
            this.wis.Size = new System.Drawing.Size(49, 20);
            this.wis.TabIndex = 3;
            this.wis.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // cha
            // 
            this.cha.Location = new System.Drawing.Point(122, 68);
            this.cha.Name = "cha";
            this.cha.Size = new System.Drawing.Size(53, 20);
            this.cha.TabIndex = 3;
            this.cha.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ac:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Fort:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Ref:";
            // 
            // ac
            // 
            this.ac.Location = new System.Drawing.Point(40, 15);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(53, 20);
            this.ac.TabIndex = 3;
            this.ac.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // fort
            // 
            this.fort.Location = new System.Drawing.Point(40, 41);
            this.fort.Name = "fort";
            this.fort.Size = new System.Drawing.Size(53, 20);
            this.fort.TabIndex = 3;
            this.fort.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // Ref
            // 
            this.Ref.Location = new System.Drawing.Point(40, 67);
            this.Ref.Name = "Ref";
            this.Ref.Size = new System.Drawing.Size(53, 20);
            this.Ref.TabIndex = 3;
            this.Ref.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Will";
            // 
            // will
            // 
            this.will.Location = new System.Drawing.Point(40, 93);
            this.will.Name = "will";
            this.will.Size = new System.Drawing.Size(53, 20);
            this.will.TabIndex = 3;
            this.will.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.will);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Ref);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.ac);
            this.groupBox1.Controls.Add(this.fort);
            this.groupBox1.Location = new System.Drawing.Point(199, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 122);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Defense";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cha);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Int);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.con);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.wis);
            this.groupBox2.Controls.Add(this.str);
            this.groupBox2.Controls.Add(this.dex);
            this.groupBox2.Location = new System.Drawing.Point(7, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 109);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ability Scores";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 233);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Spd:";
            // 
            // spd
            // 
            this.spd.Location = new System.Drawing.Point(60, 230);
            this.spd.Name = "spd";
            this.spd.Size = new System.Drawing.Size(59, 20);
            this.spd.TabIndex = 3;
            this.spd.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // okayBtn
            // 
            this.okayBtn.Location = new System.Drawing.Point(78, 262);
            this.okayBtn.Name = "okayBtn";
            this.okayBtn.Size = new System.Drawing.Size(75, 23);
            this.okayBtn.TabIndex = 6;
            this.okayBtn.Text = "Okay";
            this.okayBtn.UseVisualStyleBackColor = true;
            this.okayBtn.Click += new System.EventHandler(this.okayBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(159, 262);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // AddMonsterDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(314, 297);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okayBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.spd);
            this.Controls.Add(this.level);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.race);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMonsterDialogue";
            this.Text = "Add Monster";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox race;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox level;
        private System.Windows.Forms.MaskedTextBox hp;
        private System.Windows.Forms.MaskedTextBox str;
        private System.Windows.Forms.MaskedTextBox con;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox dex;
        private System.Windows.Forms.MaskedTextBox Int;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox wis;
        private System.Windows.Forms.MaskedTextBox cha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox ac;
        private System.Windows.Forms.MaskedTextBox fort;
        private System.Windows.Forms.MaskedTextBox Ref;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox will;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox spd;
        private System.Windows.Forms.Button okayBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}