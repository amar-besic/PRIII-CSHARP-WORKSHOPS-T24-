namespace FIT.WinForms.IspitIB210178
{
    partial class frmNovaDrzavaIB210178
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
            btnSacuvaj = new Button();
            chbStatus = new CheckBox();
            tbNaziv = new TextBox();
            pbZastava = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(301, 339);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(134, 29);
            btnSacuvaj.TabIndex = 0;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // chbStatus
            // 
            chbStatus.AutoSize = true;
            chbStatus.Location = new Point(29, 297);
            chbStatus.Name = "chbStatus";
            chbStatus.Size = new Size(80, 24);
            chbStatus.TabIndex = 1;
            chbStatus.Text = "Aktivan";
            chbStatus.UseVisualStyleBackColor = true;
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(29, 264);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(406, 27);
            tbNaziv.TabIndex = 2;
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(29, 51);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(406, 175);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 3;
            pbZastava.TabStop = false;
            pbZastava.DoubleClick += pbZastava_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 241);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Naziv:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 18);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 5;
            label2.Text = "Zastava:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovaDrzavaIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 380);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbZastava);
            Controls.Add(tbNaziv);
            Controls.Add(chbStatus);
            Controls.Add(btnSacuvaj);
            Name = "frmNovaDrzavaIB210178";
            Text = "Podaci o državi";
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSacuvaj;
        private CheckBox chbStatus;
        private TextBox tbNaziv;
        private PictureBox pbZastava;
        private Label label1;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider err;
    }
}