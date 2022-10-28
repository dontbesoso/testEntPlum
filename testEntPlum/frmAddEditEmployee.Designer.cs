
namespace testEntPlum
{
    partial class frmAddEditEmployee
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
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.lblNumerKarty = new System.Windows.Forms.Label();
            this.lblNazwaPracownika = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnZamknij
            // 
            this.btnZamknij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZamknij.Location = new System.Drawing.Point(127, 107);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(66, 23);
            this.btnZamknij.TabIndex = 0;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(199, 107);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(85, 23);
            this.btnAddSave.TabIndex = 1;
            this.btnAddSave.Text = "Zapisz zmiany";
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // lblNumerKarty
            // 
            this.lblNumerKarty.AutoSize = true;
            this.lblNumerKarty.Location = new System.Drawing.Point(20, 24);
            this.lblNumerKarty.Name = "lblNumerKarty";
            this.lblNumerKarty.Size = new System.Drawing.Size(64, 13);
            this.lblNumerKarty.TabIndex = 2;
            this.lblNumerKarty.Text = "Numer karty";
            // 
            // lblNazwaPracownika
            // 
            this.lblNazwaPracownika.AutoSize = true;
            this.lblNazwaPracownika.Location = new System.Drawing.Point(27, 56);
            this.lblNazwaPracownika.Name = "lblNazwaPracownika";
            this.lblNazwaPracownika.Size = new System.Drawing.Size(57, 13);
            this.lblNazwaPracownika.TabIndex = 3;
            this.lblNazwaPracownika.Text = "Pracownik";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(90, 21);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(194, 20);
            this.txtCardNumber.TabIndex = 4;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(90, 53);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(194, 20);
            this.txtEmployeeName.TabIndex = 5;
            // 
            // frmAddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 155);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblNazwaPracownika);
            this.Controls.Add(this.lblNumerKarty);
            this.Controls.Add(this.btnAddSave);
            this.Controls.Add(this.btnZamknij);
            this.MaximizeBox = false;
            this.Name = "frmAddEditEmployee";
            this.Text = "Dodaj / Edytuj pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.Label lblNumerKarty;
        private System.Windows.Forms.Label lblNazwaPracownika;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtEmployeeName;
    }
}