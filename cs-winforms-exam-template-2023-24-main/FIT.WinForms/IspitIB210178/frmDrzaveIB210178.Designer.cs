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
            btnNovaDržava = new Button();
            btnPrintaj = new Button();
            dgvDrzave = new DataGridView();
            Zastava = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            BrojGradova = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            btnGrad = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).BeginInit();
            SuspendLayout();
            // 
            // btnNovaDržava
            // 
            btnNovaDržava.Location = new Point(633, 29);
            btnNovaDržava.Name = "btnNovaDržava";
            btnNovaDržava.Size = new Size(133, 39);
            btnNovaDržava.TabIndex = 0;
            btnNovaDržava.Text = "Nova država";
            btnNovaDržava.UseVisualStyleBackColor = true;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(633, 389);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(133, 33);
            btnPrintaj.TabIndex = 1;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // dgvDrzave
            // 
            dgvDrzave.AllowUserToAddRows = false;
            dgvDrzave.AllowUserToDeleteRows = false;
            dgvDrzave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrzave.Columns.AddRange(new DataGridViewColumn[] { Zastava, Naziv, BrojGradova, Status, btnGrad });
            dgvDrzave.Location = new Point(12, 74);
            dgvDrzave.Name = "dgvDrzave";
            dgvDrzave.ReadOnly = true;
            dgvDrzave.RowHeadersWidth = 51;
            dgvDrzave.RowTemplate.Height = 29;
            dgvDrzave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrzave.Size = new Size(754, 309);
            dgvDrzave.TabIndex = 2;
            // 
            // Zastava
            // 
            Zastava.DataPropertyName = "Zastava";
            Zastava.HeaderText = "Zastava";
            Zastava.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Zastava.MinimumWidth = 6;
            Zastava.Name = "Zastava";
            Zastava.ReadOnly = true;
            Zastava.Width = 75;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Država";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // BrojGradova
            // 
            BrojGradova.DataPropertyName = "BrojGradova";
            BrojGradova.HeaderText = "Broj gradova";
            BrojGradova.MinimumWidth = 6;
            BrojGradova.Name = "BrojGradova";
            BrojGradova.ReadOnly = true;
            BrojGradova.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Aktivan";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // btnGrad
            // 
            btnGrad.DataPropertyName = "btnGrad";
            btnGrad.HeaderText = "";
            btnGrad.MinimumWidth = 6;
            btnGrad.Name = "btnGrad";
            btnGrad.ReadOnly = true;
            btnGrad.Text = "Gradovi";
            btnGrad.UseColumnTextForButtonValue = true;
            btnGrad.Width = 125;
            // 
            // frmDrzaveIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 459);
            Controls.Add(dgvDrzave);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaDržava);
            Name = "frmDrzaveIB210178";
            Text = "Države";
            Load += frmDrzaveIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovaDržava;
        private Button btnPrintaj;
        private DataGridView dgvDrzave;
        private DataGridViewImageColumn Zastava;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn BrojGradova;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn btnGrad;
    }
}