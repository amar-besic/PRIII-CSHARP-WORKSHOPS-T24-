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
            tbNaziv = new TextBox();
            btnSacuvaj = new Button();
            cbAktivan = new CheckBox();
            label2 = new Label();
            err = new ErrorProvider(components);
            ofdZastava = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 44);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(378, 200);
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            pbZastava.DoubleClick += pbZastava_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 1;
            label1.Text = "Zastava:";
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(12, 270);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(365, 27);
            tbNaziv.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(296, 344);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(12, 303);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(80, 24);
            cbAktivan.TabIndex = 4;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 247);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Naziv";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // ofdZastava
            // 
            ofdZastava.FileName = "ofdZastava";
            // 
            // frmNovaDržavaIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 385);
            Controls.Add(cbAktivan);
            Controls.Add(btnSacuvaj);
            Controls.Add(tbNaziv);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbZastava);
            Name = "frmNovaDržavaIB210178";
            Text = "frmNovaDržavaIB210178";
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label label1;
        private TextBox tbNaziv;
        private Button btnSacuvaj;
        private CheckBox cbAktivan;
        private Label label2;
        private ErrorProvider err;
        private OpenFileDialog ofdZastava;
    }
}