namespace FIT.WinForms.IspitIB210178
{
    partial class frmDrzaveIB210178
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
            dgvDrzave = new DataGridView();
            btnNovaDrzava = new Button();
            btnPrintaj = new Button();
            Zastava = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            brojGradova = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            btnGradovi = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).BeginInit();
            SuspendLayout();
            // 
            // dgvDrzave
            // 
            dgvDrzave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrzave.Columns.AddRange(new DataGridViewColumn[] { Zastava, Naziv, brojGradova, Status, btnGradovi });
            dgvDrzave.Location = new Point(12, 66);
            dgvDrzave.Name = "dgvDrzave";
            dgvDrzave.RowHeadersWidth = 51;
            dgvDrzave.RowTemplate.Height = 29;
            dgvDrzave.Size = new Size(766, 293);
            dgvDrzave.TabIndex = 0;
            // 
            // btnNovaDrzava
            // 
            btnNovaDrzava.Location = new Point(637, 31);
            btnNovaDrzava.Name = "btnNovaDrzava";
            btnNovaDrzava.Size = new Size(141, 29);
            btnNovaDrzava.TabIndex = 1;
            btnNovaDrzava.Text = "Nova država";
            btnNovaDrzava.UseVisualStyleBackColor = true;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(637, 365);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(141, 29);
            btnPrintaj.TabIndex = 1;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // Zastava
            // 
            Zastava.DataPropertyName = "Zastava";
            Zastava.HeaderText = "Zastava";
            Zastava.MinimumWidth = 6;
            Zastava.Name = "Zastava";
            Zastava.Width = 75;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Država";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            // 
            // brojGradova
            // 
            brojGradova.DataPropertyName = "brojGradova";
            brojGradova.HeaderText = "Broj gradova";
            brojGradova.MinimumWidth = 6;
            brojGradova.Name = "brojGradova";
            brojGradova.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Aktivan";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 80;
            // 
            // btnGradovi
            // 
            btnGradovi.DataPropertyName = "btnGradovi";
            btnGradovi.HeaderText = "";
            btnGradovi.MinimumWidth = 6;
            btnGradovi.Name = "btnGradovi";
            btnGradovi.Width = 125;
            // 
            // frmDrzaveIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaDrzava);
            Controls.Add(dgvDrzave);
            Name = "frmDrzaveIB210178";
            Text = "Države";
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDrzave;
        private Button btnNovaDrzava;
        private Button btnPrintaj;
        private DataGridViewImageColumn Zastava;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn brojGradova;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn btnGradovi;
    }
}