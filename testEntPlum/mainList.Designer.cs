
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
            ((System.ComponentModel.ISupportInitialize)(this.grdLogowania)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(707, 192);
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
            this.cldDataLogowania.Location = new System.Drawing.Point(513, 18);
            this.cldDataLogowania.Name = "cldDataLogowania";
            this.cldDataLogowania.TabIndex = 1;
            // 
            // grdLogowania
            // 
            this.grdLogowania.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdLogowania.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLogowania.Location = new System.Drawing.Point(12, 18);
            this.grdLogowania.Name = "grdLogowania";
            this.grdLogowania.Size = new System.Drawing.Size(489, 420);
            this.grdLogowania.TabIndex = 2;
            // 
            // cmbGniazdo
            // 
            this.cmbGniazdo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGniazdo.FormattingEnabled = true;
            this.cmbGniazdo.Items.AddRange(new object[] {
            "Szlifiernia/Spawalnia",
            "Montaż"});
            this.cmbGniazdo.Location = new System.Drawing.Point(513, 193);
            this.cmbGniazdo.Name = "cmbGniazdo";
            this.cmbGniazdo.Size = new System.Drawing.Size(188, 21);
            this.cmbGniazdo.TabIndex = 3;
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
            this.Name = "mainList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowania";
            ((System.ComponentModel.ISupportInitialize)(this.grdLogowania)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar cldDataLogowania;
        private System.Windows.Forms.DataGridView grdLogowania;
        private System.Windows.Forms.ComboBox cmbGniazdo;
    }
}