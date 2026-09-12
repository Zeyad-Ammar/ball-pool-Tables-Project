namespace poolTables
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ctrlPoolTable1 = new poolTables.ctrlPoolTable();
            this.SuspendLayout();
            // 
            // ctrlPoolTable1
            // 
            this.ctrlPoolTable1.hourlyRate = 100;
            this.ctrlPoolTable1.Location = new System.Drawing.Point(1, 1);
            this.ctrlPoolTable1.Name = "ctrlPoolTable1";
            this.ctrlPoolTable1.playerName = "player 1";
            this.ctrlPoolTable1.Size = new System.Drawing.Size(331, 342);
            this.ctrlPoolTable1.TabIndex = 0;
            this.ctrlPoolTable1.tableName = "Tabel 1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlPoolTable1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "كوكب البليردو";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPoolTable ctrlPoolTable1;
    }
}

