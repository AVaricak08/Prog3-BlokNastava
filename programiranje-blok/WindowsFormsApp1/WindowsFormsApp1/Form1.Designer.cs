namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblPol = new System.Windows.Forms.Label();
            this.lblGodine = new System.Windows.Forms.Label();
            this.lblDeo = new System.Windows.Forms.Label();
            this.lblPozicija = new System.Windows.Forms.Label();
            this.lsvLista = new System.Windows.Forms.ListView();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.rbtMuško = new System.Windows.Forms.RadioButton();
            this.rbtŽensko = new System.Windows.Forms.RadioButton();
            this.cmbGodine = new System.Windows.Forms.ComboBox();
            this.cmbDeo = new System.Windows.Forms.ComboBox();
            this.txtPozicija = new System.Windows.Forms.TextBox();
            this.lblMojiPodaci = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObriši = new System.Windows.Forms.Button();
            this.btnSačuvaj = new System.Windows.Forms.Button();
            this.btnUčitaj = new System.Windows.Forms.Button();
            this.btnObrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(12, 36);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(46, 25);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(12, 68);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(90, 25);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPol.Location = new System.Drawing.Point(15, 102);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(43, 25);
            this.lblPol.TabIndex = 2;
            this.lblPol.Text = "Pol";
            // 
            // lblGodine
            // 
            this.lblGodine.AutoSize = true;
            this.lblGodine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGodine.Location = new System.Drawing.Point(15, 137);
            this.lblGodine.Name = "lblGodine";
            this.lblGodine.Size = new System.Drawing.Size(81, 25);
            this.lblGodine.TabIndex = 3;
            this.lblGodine.Text = "Godine";
            // 
            // lblDeo
            // 
            this.lblDeo.AutoSize = true;
            this.lblDeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeo.Location = new System.Drawing.Point(15, 171);
            this.lblDeo.Name = "lblDeo";
            this.lblDeo.Size = new System.Drawing.Size(125, 25);
            this.lblDeo.TabIndex = 4;
            this.lblDeo.Text = "Deo Terena";
            // 
            // lblPozicija
            // 
            this.lblPozicija.AutoSize = true;
            this.lblPozicija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPozicija.Location = new System.Drawing.Point(15, 205);
            this.lblPozicija.Name = "lblPozicija";
            this.lblPozicija.Size = new System.Drawing.Size(87, 25);
            this.lblPozicija.TabIndex = 5;
            this.lblPozicija.Text = "Pozicija";
            // 
            // lsvLista
            // 
            this.lsvLista.HideSelection = false;
            this.lsvLista.Location = new System.Drawing.Point(406, 12);
            this.lsvLista.Name = "lsvLista";
            this.lsvLista.Size = new System.Drawing.Size(509, 326);
            this.lsvLista.TabIndex = 6;
            this.lsvLista.UseCompatibleStateImageBehavior = false;
            this.lsvLista.SelectedIndexChanged += new System.EventHandler(this.lsvLista_SelectedIndexChanged);
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(139, 34);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(140, 29);
            this.txtIme.TabIndex = 7;
            this.txtIme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.Location = new System.Drawing.Point(139, 68);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(140, 29);
            this.txtPrezime.TabIndex = 8;
            this.txtPrezime.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rbtMuško
            // 
            this.rbtMuško.AutoSize = true;
            this.rbtMuško.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMuško.Location = new System.Drawing.Point(99, 101);
            this.rbtMuško.Name = "rbtMuško";
            this.rbtMuško.Size = new System.Drawing.Size(84, 28);
            this.rbtMuško.TabIndex = 9;
            this.rbtMuško.TabStop = true;
            this.rbtMuško.Text = "Muško";
            this.rbtMuško.UseVisualStyleBackColor = true;
            // 
            // rbtŽensko
            // 
            this.rbtŽensko.AutoSize = true;
            this.rbtŽensko.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtŽensko.Location = new System.Drawing.Point(238, 103);
            this.rbtŽensko.Name = "rbtŽensko";
            this.rbtŽensko.Size = new System.Drawing.Size(91, 28);
            this.rbtŽensko.TabIndex = 10;
            this.rbtŽensko.TabStop = true;
            this.rbtŽensko.Text = "Žensko";
            this.rbtŽensko.UseVisualStyleBackColor = true;
            // 
            // cmbGodine
            // 
            this.cmbGodine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGodine.FormattingEnabled = true;
            this.cmbGodine.Location = new System.Drawing.Point(139, 130);
            this.cmbGodine.Name = "cmbGodine";
            this.cmbGodine.Size = new System.Drawing.Size(121, 32);
            this.cmbGodine.TabIndex = 11;
            // 
            // cmbDeo
            // 
            this.cmbDeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeo.FormattingEnabled = true;
            this.cmbDeo.Location = new System.Drawing.Point(139, 164);
            this.cmbDeo.Name = "cmbDeo";
            this.cmbDeo.Size = new System.Drawing.Size(121, 32);
            this.cmbDeo.TabIndex = 12;
            // 
            // txtPozicija
            // 
            this.txtPozicija.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPozicija.Location = new System.Drawing.Point(139, 202);
            this.txtPozicija.Name = "txtPozicija";
            this.txtPozicija.Size = new System.Drawing.Size(164, 29);
            this.txtPozicija.TabIndex = 13;
            // 
            // lblMojiPodaci
            // 
            this.lblMojiPodaci.AutoSize = true;
            this.lblMojiPodaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMojiPodaci.Location = new System.Drawing.Point(73, 385);
            this.lblMojiPodaci.Name = "lblMojiPodaci";
            this.lblMojiPodaci.Size = new System.Drawing.Size(16, 24);
            this.lblMojiPodaci.TabIndex = 14;
            this.lblMojiPodaci.Text = "-";
            this.lblMojiPodaci.Click += new System.EventHandler(this.lblMojiPodaci_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesi.Location = new System.Drawing.Point(13, 257);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(89, 30);
            this.btnUnesi.TabIndex = 15;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(117, 257);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(89, 30);
            this.btnIzmeni.TabIndex = 16;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObriši
            // 
            this.btnObriši.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObriši.Location = new System.Drawing.Point(13, 293);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(89, 30);
            this.btnObriši.TabIndex = 17;
            this.btnObriši.Text = "Obriši";
            this.btnObriši.UseVisualStyleBackColor = true;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // btnSačuvaj
            // 
            this.btnSačuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSačuvaj.Location = new System.Drawing.Point(214, 257);
            this.btnSačuvaj.Name = "btnSačuvaj";
            this.btnSačuvaj.Size = new System.Drawing.Size(89, 30);
            this.btnSačuvaj.TabIndex = 18;
            this.btnSačuvaj.Text = "Sačuvaj";
            this.btnSačuvaj.UseVisualStyleBackColor = true;
            this.btnSačuvaj.Click += new System.EventHandler(this.btnSačuvaj_Click);
            // 
            // btnUčitaj
            // 
            this.btnUčitaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUčitaj.Location = new System.Drawing.Point(117, 293);
            this.btnUčitaj.Name = "btnUčitaj";
            this.btnUčitaj.Size = new System.Drawing.Size(89, 30);
            this.btnUčitaj.TabIndex = 19;
            this.btnUčitaj.Text = "Učitaj";
            this.btnUčitaj.UseVisualStyleBackColor = true;
            this.btnUčitaj.Click += new System.EventHandler(this.btnUčitaj_Click);
            // 
            // btnObrada
            // 
            this.btnObrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrada.Location = new System.Drawing.Point(214, 293);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(89, 30);
            this.btnObrada.TabIndex = 20;
            this.btnObrada.Text = "Obrada";
            this.btnObrada.UseVisualStyleBackColor = true;
            this.btnObrada.Click += new System.EventHandler(this.btnObrada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.btnObrada);
            this.Controls.Add(this.btnUčitaj);
            this.Controls.Add(this.btnSačuvaj);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.lblMojiPodaci);
            this.Controls.Add(this.txtPozicija);
            this.Controls.Add(this.cmbDeo);
            this.Controls.Add(this.cmbGodine);
            this.Controls.Add(this.rbtŽensko);
            this.Controls.Add(this.rbtMuško);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lsvLista);
            this.Controls.Add(this.lblPozicija);
            this.Controls.Add(this.lblDeo);
            this.Controls.Add(this.lblGodine);
            this.Controls.Add(this.lblPol);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.Label lblGodine;
        private System.Windows.Forms.Label lblDeo;
        private System.Windows.Forms.Label lblPozicija;
        private System.Windows.Forms.ListView lsvLista;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.RadioButton rbtMuško;
        private System.Windows.Forms.RadioButton rbtŽensko;
        private System.Windows.Forms.ComboBox cmbGodine;
        private System.Windows.Forms.ComboBox cmbDeo;
        private System.Windows.Forms.TextBox txtPozicija;
        private System.Windows.Forms.Label lblMojiPodaci;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.Button btnSačuvaj;
        private System.Windows.Forms.Button btnUčitaj;
        private System.Windows.Forms.Button btnObrada;
    }
}

