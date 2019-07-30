namespace PCPOS
{
    partial class frmKarticaRobe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKarticaRobe));
            this.label1 = new System.Windows.Forms.Label();
            this.cbSkladiste = new System.Windows.Forms.ComboBox();
            this.tabKartica = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.lblUlaz = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIzdatnice = new System.Windows.Forms.Label();
            this.lblOtpremnice = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblFakture = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblMaloprodaja = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMedjuskladisnice = new System.Windows.Forms.Label();
            this.lblPrimke = new System.Windows.Forms.Label();
            this.lblKalkulacije = new System.Windows.Forms.Label();
            this.lblPocetnoStanje = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chbMediskladisnica = new System.Windows.Forms.CheckBox();
            this.chbInventura = new System.Windows.Forms.CheckBox();
            this.chbPromjenaCijene = new System.Windows.Forms.CheckBox();
            this.chbMaloprodaja = new System.Windows.Forms.CheckBox();
            this.chbKalkulacija = new System.Windows.Forms.CheckBox();
            this.pbTrazi = new System.Windows.Forms.PictureBox();
            this.dtpDoDatuma = new System.Windows.Forms.DateTimePicker();
            this.dtpOdDatuma = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.sifra_robe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMpc = new System.Windows.Forms.Label();
            this.lblVpc = new System.Windows.Forms.Label();
            this.lblNbc = new System.Windows.Forms.Label();
            this.lblStanje = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOpenRoba = new System.Windows.Forms.PictureBox();
            this.txtImeArtikla = new System.Windows.Forms.TextBox();
            this.txtSifraArtikla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabKartica.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrazi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenRoba)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Skladište:";
            // 
            // cbSkladiste
            // 
            this.cbSkladiste.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSkladiste.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSkladiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbSkladiste.FormattingEnabled = true;
            this.cbSkladiste.Location = new System.Drawing.Point(111, 16);
            this.cbSkladiste.Name = "cbSkladiste";
            this.cbSkladiste.Size = new System.Drawing.Size(182, 24);
            this.cbSkladiste.TabIndex = 1;
            // 
            // tabKartica
            // 
            this.tabKartica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabKartica.Controls.Add(this.tabPage1);
            this.tabKartica.Controls.Add(this.tabPage2);
            this.tabKartica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabKartica.ItemSize = new System.Drawing.Size(45, 30);
            this.tabKartica.Location = new System.Drawing.Point(14, 101);
            this.tabKartica.Name = "tabKartica";
            this.tabKartica.SelectedIndex = 0;
            this.tabKartica.Size = new System.Drawing.Size(970, 574);
            this.tabKartica.TabIndex = 3;
            this.tabKartica.SelectedIndexChanged += new System.EventHandler(this.tabKartica_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.chbMediskladisnica);
            this.tabPage1.Controls.Add(this.chbInventura);
            this.tabPage1.Controls.Add(this.chbPromjenaCijene);
            this.tabPage1.Controls.Add(this.chbMaloprodaja);
            this.tabPage1.Controls.Add(this.chbKalkulacija);
            this.tabPage1.Controls.Add(this.pbTrazi);
            this.tabPage1.Controls.Add(this.dtpDoDatuma);
            this.tabPage1.Controls.Add(this.dtpOdDatuma);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dgw);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(962, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kartica";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblIzlaz);
            this.groupBox3.Controls.Add(this.lblUlaz);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Location = new System.Drawing.Point(496, 399);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 131);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ukupno";
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblIzlaz.Location = new System.Drawing.Point(160, 49);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(42, 17);
            this.lblIzlaz.TabIndex = 62;
            this.lblIzlaz.Text = "KOM";
            // 
            // lblUlaz
            // 
            this.lblUlaz.AutoSize = true;
            this.lblUlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblUlaz.Location = new System.Drawing.Point(160, 24);
            this.lblUlaz.Name = "lblUlaz";
            this.lblUlaz.Size = new System.Drawing.Size(42, 17);
            this.lblUlaz.TabIndex = 9;
            this.lblUlaz.Text = "KOM";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(9, 49);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(40, 17);
            this.label28.TabIndex = 61;
            this.label28.Text = "Izlaz:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 24);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(40, 17);
            this.label29.TabIndex = 8;
            this.label29.Text = "Ulaz:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblIzdatnice);
            this.groupBox2.Controls.Add(this.lblOtpremnice);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.lblFakture);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.lblMaloprodaja);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(251, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 131);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izlaz";
            // 
            // lblIzdatnice
            // 
            this.lblIzdatnice.AutoSize = true;
            this.lblIzdatnice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblIzdatnice.Location = new System.Drawing.Point(160, 99);
            this.lblIzdatnice.Name = "lblIzdatnice";
            this.lblIzdatnice.Size = new System.Drawing.Size(42, 17);
            this.lblIzdatnice.TabIndex = 62;
            this.lblIzdatnice.Text = "KOM";
            // 
            // lblOtpremnice
            // 
            this.lblOtpremnice.AutoSize = true;
            this.lblOtpremnice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblOtpremnice.Location = new System.Drawing.Point(160, 74);
            this.lblOtpremnice.Name = "lblOtpremnice";
            this.lblOtpremnice.Size = new System.Drawing.Size(42, 17);
            this.lblOtpremnice.TabIndex = 62;
            this.lblOtpremnice.Text = "KOM";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 99);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 17);
            this.label21.TabIndex = 61;
            this.label21.Text = "Izdatnice:";
            // 
            // lblFakture
            // 
            this.lblFakture.AutoSize = true;
            this.lblFakture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblFakture.Location = new System.Drawing.Point(160, 49);
            this.lblFakture.Name = "lblFakture";
            this.lblFakture.Size = new System.Drawing.Size(42, 17);
            this.lblFakture.TabIndex = 62;
            this.lblFakture.Text = "KOM";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 74);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 17);
            this.label19.TabIndex = 61;
            this.label19.Text = "Otpremnice:";
            // 
            // lblMaloprodaja
            // 
            this.lblMaloprodaja.AutoSize = true;
            this.lblMaloprodaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaloprodaja.Location = new System.Drawing.Point(160, 24);
            this.lblMaloprodaja.Name = "lblMaloprodaja";
            this.lblMaloprodaja.Size = new System.Drawing.Size(42, 17);
            this.lblMaloprodaja.TabIndex = 9;
            this.lblMaloprodaja.Text = "KOM";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 17);
            this.label17.TabIndex = 61;
            this.label17.Text = "Fakture:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Maloprodaja:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblMedjuskladisnice);
            this.groupBox1.Controls.Add(this.lblPrimke);
            this.groupBox1.Controls.Add(this.lblKalkulacije);
            this.groupBox1.Controls.Add(this.lblPocetnoStanje);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(9, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 131);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ulaz";
            // 
            // lblMedjuskladisnice
            // 
            this.lblMedjuskladisnice.AutoSize = true;
            this.lblMedjuskladisnice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMedjuskladisnice.Location = new System.Drawing.Point(157, 99);
            this.lblMedjuskladisnice.Name = "lblMedjuskladisnice";
            this.lblMedjuskladisnice.Size = new System.Drawing.Size(42, 17);
            this.lblMedjuskladisnice.TabIndex = 7;
            this.lblMedjuskladisnice.Text = "KOM";
            // 
            // lblPrimke
            // 
            this.lblPrimke.AutoSize = true;
            this.lblPrimke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrimke.Location = new System.Drawing.Point(157, 74);
            this.lblPrimke.Name = "lblPrimke";
            this.lblPrimke.Size = new System.Drawing.Size(42, 17);
            this.lblPrimke.TabIndex = 6;
            this.lblPrimke.Text = "KOM";
            // 
            // lblKalkulacije
            // 
            this.lblKalkulacije.AutoSize = true;
            this.lblKalkulacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblKalkulacije.Location = new System.Drawing.Point(157, 49);
            this.lblKalkulacije.Name = "lblKalkulacije";
            this.lblKalkulacije.Size = new System.Drawing.Size(42, 17);
            this.lblKalkulacije.TabIndex = 5;
            this.lblKalkulacije.Text = "KOM";
            // 
            // lblPocetnoStanje
            // 
            this.lblPocetnoStanje.AutoSize = true;
            this.lblPocetnoStanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPocetnoStanje.Location = new System.Drawing.Point(157, 24);
            this.lblPocetnoStanje.Name = "lblPocetnoStanje";
            this.lblPocetnoStanje.Size = new System.Drawing.Size(42, 17);
            this.lblPocetnoStanje.TabIndex = 4;
            this.lblPocetnoStanje.Text = "KOM";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Međuskladišnice:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Primke:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Kalkulacije:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Početno stanje:";
            // 
            // chbMediskladisnica
            // 
            this.chbMediskladisnica.AutoSize = true;
            this.chbMediskladisnica.Checked = true;
            this.chbMediskladisnica.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMediskladisnica.Location = new System.Drawing.Point(459, 42);
            this.chbMediskladisnica.Name = "chbMediskladisnica";
            this.chbMediskladisnica.Size = new System.Drawing.Size(131, 21);
            this.chbMediskladisnica.TabIndex = 14;
            this.chbMediskladisnica.Text = "Međuskladišnice";
            this.chbMediskladisnica.UseVisualStyleBackColor = true;
            // 
            // chbInventura
            // 
            this.chbInventura.AutoSize = true;
            this.chbInventura.Checked = true;
            this.chbInventura.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbInventura.Location = new System.Drawing.Point(337, 65);
            this.chbInventura.Name = "chbInventura";
            this.chbInventura.Size = new System.Drawing.Size(86, 21);
            this.chbInventura.TabIndex = 11;
            this.chbInventura.Text = "Inventura";
            this.chbInventura.UseVisualStyleBackColor = true;
            // 
            // chbPromjenaCijene
            // 
            this.chbPromjenaCijene.AutoSize = true;
            this.chbPromjenaCijene.Checked = true;
            this.chbPromjenaCijene.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPromjenaCijene.Location = new System.Drawing.Point(459, 19);
            this.chbPromjenaCijene.Name = "chbPromjenaCijene";
            this.chbPromjenaCijene.Size = new System.Drawing.Size(128, 21);
            this.chbPromjenaCijene.TabIndex = 13;
            this.chbPromjenaCijene.Text = "Promjena cijene";
            this.chbPromjenaCijene.UseVisualStyleBackColor = true;
            // 
            // chbMaloprodaja
            // 
            this.chbMaloprodaja.AutoSize = true;
            this.chbMaloprodaja.Checked = true;
            this.chbMaloprodaja.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMaloprodaja.Location = new System.Drawing.Point(337, 42);
            this.chbMaloprodaja.Name = "chbMaloprodaja";
            this.chbMaloprodaja.Size = new System.Drawing.Size(105, 21);
            this.chbMaloprodaja.TabIndex = 7;
            this.chbMaloprodaja.Text = "Maloprodaja";
            this.chbMaloprodaja.UseVisualStyleBackColor = true;
            // 
            // chbKalkulacija
            // 
            this.chbKalkulacija.AutoSize = true;
            this.chbKalkulacija.Checked = true;
            this.chbKalkulacija.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbKalkulacija.Location = new System.Drawing.Point(337, 19);
            this.chbKalkulacija.Name = "chbKalkulacija";
            this.chbKalkulacija.Size = new System.Drawing.Size(70, 21);
            this.chbKalkulacija.TabIndex = 6;
            this.chbKalkulacija.Text = "Primka";
            this.chbKalkulacija.UseVisualStyleBackColor = true;
            // 
            // pbTrazi
            // 
            this.pbTrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTrazi.Image = global::PCPOS.Properties.Resources._1059;
            this.pbTrazi.Location = new System.Drawing.Point(593, 19);
            this.pbTrazi.Name = "pbTrazi";
            this.pbTrazi.Size = new System.Drawing.Size(71, 65);
            this.pbTrazi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrazi.TabIndex = 58;
            this.pbTrazi.TabStop = false;
            this.pbTrazi.Click += new System.EventHandler(this.PbTrazi_Click);
            // 
            // dtpDoDatuma
            // 
            this.dtpDoDatuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDoDatuma.Location = new System.Drawing.Point(93, 51);
            this.dtpDoDatuma.Name = "dtpDoDatuma";
            this.dtpDoDatuma.Size = new System.Drawing.Size(208, 23);
            this.dtpDoDatuma.TabIndex = 5;
            // 
            // dtpOdDatuma
            // 
            this.dtpOdDatuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpOdDatuma.Location = new System.Drawing.Point(93, 26);
            this.dtpOdDatuma.Name = "dtpOdDatuma";
            this.dtpOdDatuma.Size = new System.Drawing.Size(208, 23);
            this.dtpOdDatuma.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(11, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Do datuma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(11, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Od datuma:";
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.AllowUserToDeleteRows = false;
            this.dgw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgw.BackgroundColor = System.Drawing.Color.White;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifra_robe,
            this.naziv,
            this.kolicina,
            this.datum,
            this.dokument});
            this.dgw.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgw.Location = new System.Drawing.Point(9, 103);
            this.dgw.MultiSelect = false;
            this.dgw.Name = "dgw";
            this.dgw.RowHeadersWidth = 30;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(943, 290);
            this.dgw.TabIndex = 42;
            // 
            // sifra_robe
            // 
            this.sifra_robe.FillWeight = 70F;
            this.sifra_robe.HeaderText = "Šifra robe";
            this.sifra_robe.Name = "sifra_robe";
            // 
            // naziv
            // 
            this.naziv.HeaderText = "Naziv";
            this.naziv.Name = "naziv";
            // 
            // kolicina
            // 
            this.kolicina.FillWeight = 50F;
            this.kolicina.HeaderText = "Količina";
            this.kolicina.Name = "kolicina";
            // 
            // datum
            // 
            this.datum.HeaderText = "Datum";
            this.datum.Name = "datum";
            // 
            // dokument
            // 
            this.dokument.HeaderText = "Dokument";
            this.dokument.Name = "dokument";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(962, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trenutno stanje na skladištima";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(9, 23);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.Size = new System.Drawing.Size(943, 309);
            this.dataGridView1.TabIndex = 43;
            // 
            // lblMpc
            // 
            this.lblMpc.AutoSize = true;
            this.lblMpc.BackColor = System.Drawing.Color.Transparent;
            this.lblMpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMpc.ForeColor = System.Drawing.Color.Black;
            this.lblMpc.Location = new System.Drawing.Point(689, 50);
            this.lblMpc.Name = "lblMpc";
            this.lblMpc.Size = new System.Drawing.Size(55, 17);
            this.lblMpc.TabIndex = 63;
            this.lblMpc.Text = "0.00 kn";
            // 
            // lblVpc
            // 
            this.lblVpc.AutoSize = true;
            this.lblVpc.BackColor = System.Drawing.Color.Transparent;
            this.lblVpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVpc.ForeColor = System.Drawing.Color.Black;
            this.lblVpc.Location = new System.Drawing.Point(689, 31);
            this.lblVpc.Name = "lblVpc";
            this.lblVpc.Size = new System.Drawing.Size(55, 17);
            this.lblVpc.TabIndex = 63;
            this.lblVpc.Text = "0.00 kn";
            // 
            // lblNbc
            // 
            this.lblNbc.AutoSize = true;
            this.lblNbc.BackColor = System.Drawing.Color.Transparent;
            this.lblNbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNbc.ForeColor = System.Drawing.Color.Black;
            this.lblNbc.Location = new System.Drawing.Point(689, 12);
            this.lblNbc.Name = "lblNbc";
            this.lblNbc.Size = new System.Drawing.Size(55, 17);
            this.lblNbc.TabIndex = 63;
            this.lblNbc.Text = "0.00 kn";
            // 
            // lblStanje
            // 
            this.lblStanje.AutoSize = true;
            this.lblStanje.BackColor = System.Drawing.Color.Transparent;
            this.lblStanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblStanje.ForeColor = System.Drawing.Color.Black;
            this.lblStanje.Location = new System.Drawing.Point(417, 50);
            this.lblStanje.Name = "lblStanje";
            this.lblStanje.Size = new System.Drawing.Size(51, 17);
            this.lblStanje.TabIndex = 62;
            this.lblStanje.Text = "0 kom";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(327, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 62;
            this.label9.Text = "Stanje:";
            // 
            // btnOpenRoba
            // 
            this.btnOpenRoba.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenRoba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenRoba.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenRoba.Image")));
            this.btnOpenRoba.Location = new System.Drawing.Point(267, 43);
            this.btnOpenRoba.Name = "btnOpenRoba";
            this.btnOpenRoba.Size = new System.Drawing.Size(35, 29);
            this.btnOpenRoba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOpenRoba.TabIndex = 61;
            this.btnOpenRoba.TabStop = false;
            this.btnOpenRoba.Click += new System.EventHandler(this.btnArtikli_Click);
            // 
            // txtImeArtikla
            // 
            this.txtImeArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtImeArtikla.Location = new System.Drawing.Point(420, 16);
            this.txtImeArtikla.Name = "txtImeArtikla";
            this.txtImeArtikla.ReadOnly = true;
            this.txtImeArtikla.Size = new System.Drawing.Size(181, 23);
            this.txtImeArtikla.TabIndex = 60;
            // 
            // txtSifraArtikla
            // 
            this.txtSifraArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSifraArtikla.Location = new System.Drawing.Point(111, 44);
            this.txtSifraArtikla.Name = "txtSifraArtikla";
            this.txtSifraArtikla.Size = new System.Drawing.Size(155, 23);
            this.txtSifraArtikla.TabIndex = 2;
            this.txtSifraArtikla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSifraArtikla_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Šifra artikla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(325, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Naziv artikla:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(643, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "MPC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(643, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "VPC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(643, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "NBC:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMpc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblVpc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblNbc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblStanje);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnOpenRoba);
            this.panel1.Controls.Add(this.cbSkladiste);
            this.panel1.Controls.Add(this.txtImeArtikla);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSifraArtikla);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 83);
            this.panel1.TabIndex = 44;
            // 
            // frmKarticaRobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(996, 687);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabKartica);
            this.Name = "frmKarticaRobe";
            this.Text = "Kartica robe";
            this.Load += new System.EventHandler(this.frmKartica_Load);
            this.tabKartica.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrazi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenRoba)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSkladiste;
        private System.Windows.Forms.TabControl tabKartica;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pbTrazi;
        private System.Windows.Forms.DateTimePicker dtpDoDatuma;
        private System.Windows.Forms.DateTimePicker dtpOdDatuma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtImeArtikla;
        private System.Windows.Forms.TextBox txtSifraArtikla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbMediskladisnica;
        private System.Windows.Forms.CheckBox chbInventura;
        private System.Windows.Forms.CheckBox chbPromjenaCijene;
        private System.Windows.Forms.CheckBox chbMaloprodaja;
        private System.Windows.Forms.CheckBox chbKalkulacija;
        private System.Windows.Forms.PictureBox btnOpenRoba;
        private System.Windows.Forms.Label lblMpc;
        private System.Windows.Forms.Label lblVpc;
        private System.Windows.Forms.Label lblNbc;
        private System.Windows.Forms.Label lblStanje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifra_robe;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokument;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMedjuskladisnice;
        private System.Windows.Forms.Label lblPrimke;
        private System.Windows.Forms.Label lblKalkulacije;
        private System.Windows.Forms.Label lblPocetnoStanje;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFakture;
        private System.Windows.Forms.Label lblMaloprodaja;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblIzdatnice;
        private System.Windows.Forms.Label lblOtpremnice;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.Label lblUlaz;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
    }
}