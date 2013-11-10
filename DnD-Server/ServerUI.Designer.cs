namespace DnD {
    partial class ServerUI {
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
            this.dndlabel = new System.Windows.Forms.Label();
            this.currentPlayerList = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.adventureLogBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.msgEntryBox = new System.Windows.Forms.TextBox();
            this.sendMsgButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dndlabel
            // 
            this.dndlabel.AutoSize = true;
            this.dndlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dndlabel.Location = new System.Drawing.Point(197, 4);
            this.dndlabel.Name = "dndlabel";
            this.dndlabel.Size = new System.Drawing.Size(123, 53);
            this.dndlabel.TabIndex = 0;
            this.dndlabel.Text = "D&&D";
            // 
            // currentPlayerList
            // 
            this.currentPlayerList.Location = new System.Drawing.Point(12, 72);
            this.currentPlayerList.Name = "currentPlayerList";
            this.currentPlayerList.Size = new System.Drawing.Size(121, 153);
            this.currentPlayerList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connected Players:";
            // 
            // adventureLogBox
            // 
            this.adventureLogBox.BackColor = System.Drawing.SystemColors.Window;
            this.adventureLogBox.Location = new System.Drawing.Point(143, 73);
            this.adventureLogBox.Multiline = true;
            this.adventureLogBox.Name = "adventureLogBox";
            this.adventureLogBox.ReadOnly = true;
            this.adventureLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.adventureLogBox.Size = new System.Drawing.Size(345, 256);
            this.adventureLogBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adventure Log";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 244);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 152);
            this.treeView1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Monsters";
            // 
            // msgEntryBox
            // 
            this.msgEntryBox.Location = new System.Drawing.Point(143, 335);
            this.msgEntryBox.Multiline = true;
            this.msgEntryBox.Name = "msgEntryBox";
            this.msgEntryBox.Size = new System.Drawing.Size(289, 61);
            this.msgEntryBox.TabIndex = 3;
            this.msgEntryBox.TextChanged += new System.EventHandler(this.msgEntryBox_TextChanged);
            this.msgEntryBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msgEntryBox_KeyPress);
            // 
            // sendMsgButton
            // 
            this.sendMsgButton.Location = new System.Drawing.Point(438, 335);
            this.sendMsgButton.Name = "sendMsgButton";
            this.sendMsgButton.Size = new System.Drawing.Size(50, 61);
            this.sendMsgButton.TabIndex = 5;
            this.sendMsgButton.Text = "Send";
            this.sendMsgButton.UseVisualStyleBackColor = true;
            this.sendMsgButton.Click += new System.EventHandler(this.sendMsgButton_Click);
            // 
            // ServerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 408);
            this.Controls.Add(this.sendMsgButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msgEntryBox);
            this.Controls.Add(this.adventureLogBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.currentPlayerList);
            this.Controls.Add(this.dndlabel);
            this.Name = "ServerUI";
            this.Text = "DnD - Dungeon Master";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dndlabel;
        private System.Windows.Forms.TreeView currentPlayerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adventureLogBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox msgEntryBox;
        private System.Windows.Forms.Button sendMsgButton;
    }
    class Donaudampfschiffahrtsgesellschaftskapitän {
        public static void Wat() {
            Console.WriteLine("Wat");
        }
    }
}
