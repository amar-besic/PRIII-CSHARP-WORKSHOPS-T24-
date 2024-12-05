namespace FIT.WinForms.IspitIB210178
{
    partial class frmNovaDržavaIB210178
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
            components = new System.ComponentModel.Container();
            pbZastava = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            tbNaziv = new TextBox();
            cbAktivan = new CheckBox();
            btnSacuvaj = new Button();
            ofdZastava = new OpenFileDialog();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(26, 39);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(381, 194);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            pbZastava.DoubleClick += pictureBox1_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 1;
            label1.Text = "Zastava:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 250);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Naziv:";
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(26, 273);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.PlaceholderText = "Država";
            tbNaziv.Size = new Size(381, 27);
            tbNaziv.TabIndex = 2;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(26, 306);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(80, 24);
            cbAktivan.TabIndex = 3;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(296, 329);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(111, 29);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // ofdZastava
            // 
            ofdZastava.FileName = "ofdZastava";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovaDržavaIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 370);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbAktivan);
            Controls.Add(tbNaziv);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbZastava);
            Name = "frmNovaDržavaIB210178";
            Text = "Podaci o državi";
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label label1;
        private Label label2;
        private TextBox tbNaziv;
        private CheckBox cbAktivan;
        private Button btnSacuvaj;
        private OpenFileDialog ofdZastava;
        private ErrorProvider err;
    }
}