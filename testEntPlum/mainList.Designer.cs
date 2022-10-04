
namespace testEntPlum
{
    partial class mainList
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
            this.button1 = new System.Windows.Forms.Button();
            this.cldDataLogowania = new System.Windows.Forms.MonthCalendar();
            this.grdLogowania = new System.Windows.Forms.DataGridView();
            this.cmbGniazdo = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńHasłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdLogowania)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(707, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pobierz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cldDataLogowania
            // 
            this.cldDataLogowania.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cldDataLogowania.Location = new System.Drawing.Point(513, 27);
            this.cldDataLogowania.Name = "cldDataLogowania";
            this.cldDataLogowania.TabIndex = 1;
            // 
            // grdLogowania
            // 
            this.grdLogowania.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdLogowania.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLogowania.Location = new System.Drawing.Point(12, 27);
            this.grdLogowania.Name = "grdLogowania";
            this.grdLogowania.Size = new System.Drawing.Size(489, 411);
            this.grdLogowania.TabIndex = 2;
            // 
            // cmbGniazdo
            // 
            this.cmbGniazdo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGniazdo.FormattingEnabled = true;
            this.cmbGniazdo.Items.AddRange(new object[] {
            "Szlifiernia/Spawalnia",
            "Montaż"});
            this.cmbGniazdo.Location = new System.Drawing.Point(513, 201);
            this.cmbGniazdo.Name = "cmbGniazdo";
            this.cmbGniazdo.Size = new System.Drawing.Size(188, 21);
            this.cmbGniazdo.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmieńHasłoToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // zmieńHasłoToolStripMenuItem
            // 
            this.zmieńHasłoToolStripMenuItem.Name = "zmieńHasłoToolStripMenuItem";
            this.zmieńHasłoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zmieńHasłoToolStripMenuItem.Text = "Zmień hasło";
            this.zmieńHasłoToolStripMenuItem.Click += new System.EventHandler(this.zmieńHasłoToolStripMenuItem_Click);
            // 
            // mainList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbGniazdo);
            this.Controls.Add(this.grdLogowania);
            this.Controls.Add(this.cldDataLogowania);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowania";
            ((System.ComponentModel.ISupportInitialize)(this.grdLogowania)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar cldDataLogowania;
        private System.Windows.Forms.DataGridView grdLogowania;
        private System.Windows.Forms.ComboBox cmbGniazdo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńHasłoToolStripMenuItem;
    }
}