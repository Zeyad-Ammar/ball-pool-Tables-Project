namespace poolTables
{
    partial class ctrlPoolTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gbTable = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // gbTable
            // 
            this.gbTable.BackgroundImage = global::poolTables.Properties.Resources.pexels_marc_barcelona_2573466_37068565;
            this.gbTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbTable.Controls.Add(this.label1);
            this.gbTable.Controls.Add(this.lbPlayerName);
            this.gbTable.Controls.Add(this.lbTimer);
            this.gbTable.Controls.Add(this.btnEnd);
            this.gbTable.Controls.Add(this.btnStart);
            this.gbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTable.Location = new System.Drawing.Point(0, 0);
            this.gbTable.Name = "gbTable";
            this.gbTable.Size = new System.Drawing.Size(331, 342);
            this.gbTable.TabIndex = 0;
            this.gbTable.TabStop = false;
            this.gbTable.Text = "Table";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(6, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time:";
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.AutoSize = true;
            this.lbPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayerName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerName.ForeColor = System.Drawing.Color.Gold;
            this.lbPlayerName.Location = new System.Drawing.Point(20, 49);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(166, 32);
            this.lbPlayerName.TabIndex = 3;
            this.lbPlayerName.Text = "Player Name";
            this.lbPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.BackColor = System.Drawing.Color.Transparent;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.Azure;
            this.lbTimer.Location = new System.Drawing.Point(131, 224);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(182, 46);
            this.lbTimer.TabIndex = 2;
            this.lbTimer.Text = "00:00:00";
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Transparent;
            this.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEnd.FlatAppearance.BorderSize = 3;
            this.btnEnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEnd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(176, 288);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(142, 48);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.BorderSize = 3;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(13, 288);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(142, 48);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ctrlPoolTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTable);
            this.Name = "ctrlPoolTable";
            this.Size = new System.Drawing.Size(331, 342);
            this.Load += new System.EventHandler(this.ctrlPoolTable_Load);
            this.gbTable.ResumeLayout(false);
            this.gbTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTable;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbPlayerName;
        private System.Windows.Forms.Label label1;
    }
}
