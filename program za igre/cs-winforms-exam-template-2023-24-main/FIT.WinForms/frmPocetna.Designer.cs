using System;
using System.Drawing;
using System.Windows.Forms;

namespace FIT.WinForms
{
    public partial class frmPocetna : Form
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
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.DarkBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Arial", 14F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(63, 48);
            button5.Name = "button5";
            button5.Size = new Size(97, 67);
            button5.TabIndex = 0;
            button5.Text = "MEGA DRIVE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += BtnIgre_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkBlue;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Arial", 14F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(41, 131);
            button6.Name = "button6";
            button6.Size = new Size(129, 42);
            button6.TabIndex = 0;
            button6.Text = "GENESIS";
            button6.UseVisualStyleBackColor = false;
            button6.Click += BtnIgre_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkBlue;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Arial", 14F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(385, 148);
            button7.Name = "button7";
            button7.Size = new Size(94, 39);
            button7.TabIndex = 0;
            button7.Text = "ATARI";
            button7.UseVisualStyleBackColor = false;
            button7.Click += BtnIgre_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkBlue;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Arial", 14F, FontStyle.Bold);
            button8.ForeColor = Color.White;
            button8.Location = new Point(176, 16);
            button8.Name = "button8";
            button8.Size = new Size(186, 39);
            button8.TabIndex = 0;
            button8.Text = "PlayStation 1";
            button8.UseVisualStyleBackColor = false;
            button8.Click += BtnIgre_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 14F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(325, 61);
            button1.Name = "button1";
            button1.Size = new Size(138, 67);
            button1.TabIndex = 0;
            button1.Text = "SUPER NITENDO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnIgre_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Arial", 14F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(190, 80);
            button2.Name = "button2";
            button2.Size = new Size(72, 48);
            button2.TabIndex = 0;
            button2.Text = "NES";
            button2.UseVisualStyleBackColor = false;
            button2.Click += BtnIgre_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Arial", 14F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(226, 134);
            button3.Name = "button3";
            button3.Size = new Size(103, 69);
            button3.TabIndex = 0;
            button3.Text = "GAME BOY";
            button3.UseVisualStyleBackColor = false;
            button3.Click += BtnIgre_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.LightSkyBlue;
            button9.Dock = DockStyle.Bottom;
            button9.FlatAppearance.BorderSize = 0;
            button9.Font = new Font("Impact", 22F, FontStyle.Bold);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(0, 223);
            button9.Name = "button9";
            button9.Size = new Size(551, 99);
            button9.TabIndex = 1;
            button9.Text = "ALL GAMES";
            button9.UseVisualStyleBackColor = false;
            // 
            // frmPocetna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.bg_pocetna;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(551, 322);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button7);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(button5);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPocetna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GAME AME tuduh";
            Load += frmPocetna_Load;
            ResumeLayout(false);
        }

        #endregion

        // Event handler za klik na dugme
        private void BtnIgre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dobrodošli u IGRE!");
        }
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button9;
    }
}
