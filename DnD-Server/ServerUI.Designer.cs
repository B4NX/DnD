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
            this.SuspendLayout();
            // 
            // playerList
            // 
            this.playerList.LineColor = System.Drawing.Color.Black;
            // 
            // monsterList
            // 
            this.monsterList.LineColor = System.Drawing.Color.Black;
            // 
            // ServerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 408);
            this.Name = "ServerUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerUI_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}