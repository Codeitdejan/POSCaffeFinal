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
            this.label14 = new System.Windows.Forms.Label();
            this.lblOtpis = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Skladište:";
            // 
            // cbSkladiste
            // 
            this.cbSkladiste.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSkladiste.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSkladiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbSkladiste.FormattingEnabled = true;
            this.cbSkladiste.Location = new System.Drawing.Point(148, 20);
            this.cbSkladiste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSkladiste.Name = "cbSkladiste";
            this.cbSkladiste.Size = new System.Drawing.Size(241, 28);
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
            this.tabKartica.Location = new System.Drawing.Point(19, 124);
            this.tabKartica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabKartica.Name = "tabKartica";
            this.tabKartica.SelectedIndex = 0;
            this.tabKartica.Size = new System.Drawing.Size(1293, 706);
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
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1285, 668);
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
            this.groupBox3.Location = new System.Drawing.Point(950, 492);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(319, 161);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ukupno";
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblIzlaz.Location = new System.Drawing.Point(160, 59);
            this.lblIzlaz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(50, 20);
            this.lblIzlaz.TabIndex = 62;
            this.lblIzlaz.Text = "KOM";
            // 
            // lblUlaz
            // 
            this.lblUlaz.AutoSize = true;
            this.lblUlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblUlaz.Location = new System.Drawing.Point(160, 29);
            this.lblUlaz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUlaz.Name = "lblUlaz";
            this.lblUlaz.Size = new System.Drawing.Size(50, 20);
            this.lblUlaz.TabIndex = 9;
            this.lblUlaz.Text = "KOM";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 59);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(49, 20);
            this.label28.TabIndex = 61;
            this.label28.Text = "Izlaz:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(8, 29);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(48, 20);
            this.label29.TabIndex = 8;
            this.label29.Text = "Ulaz:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblMedjuskladisnice);
            this.groupBox2.Controls.Add(this.lblOtpis);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblIzdatnice);
            this.groupBox2.Controls.Add(this.lblOtpremnice);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblFakture);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.lblMaloprodaja);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(335, 491);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(607, 161);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izlaz";
            // 
            // lblIzdatnice
            // 
            this.lblIzdatnice.AutoSize = true;
            this.lblIzdatnice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblIzdatnice.Location = new System.Drawing.Point(213, 122);
            this.lblIzdatnice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIzdatnice.Name = "lblIzdatnice";
            this.lblIzdatnice.Size = new System.Drawing.Size(50, 20);
            this.lblIzdatnice.TabIndex = 62;
            this.lblIzdatnice.Text = "KOM";
            // 
            // lblOtpremnice
            // 
            this.lblOtpremnice.AutoSize = true;
            this.lblOtpremnice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblOtpremnice.Location = new System.Drawing.Point(213, 91);
            this.lblOtpremnice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOtpremnice.Name = "lblOtpremnice";
            this.lblOtpremnice.Size = new System.Drawing.Size(50, 20);
            this.lblOtpremnice.TabIndex = 62;
            this.lblOtpremnice.Text = "KOM";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 122);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 20);
            this.label21.TabIndex = 61;
            this.label21.Text = "Izdatnice:";
            // 
            // lblFakture
            // 
            this.lblFakture.AutoSize = true;
            this.lblFakture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblFakture.Location = new System.Drawing.Point(213, 60);
            this.lblFakture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFakture.Name = "lblFakture";
            this.lblFakture.Size = new System.Drawing.Size(50, 20);
            this.lblFakture.TabIndex = 62;
            this.lblFakture.Text = "KOM";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 91);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 20);
            this.label19.TabIndex = 61;
            this.label19.Text = "Otpremnice:";
            // 
            // lblMaloprodaja
            // 
            this.lblMaloprodaja.AutoSize = true;
            this.lblMaloprodaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaloprodaja.Location = new System.Drawing.Point(213, 30);
            this.lblMaloprodaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaloprodaja.Name = "lblMaloprodaja";
            this.lblMaloprodaja.Size = new System.Drawing.Size(50, 20);
            this.lblMaloprodaja.TabIndex = 9;
            this.lblMaloprodaja.Text = "KOM";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 60);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 20);
            this.label17.TabIndex = 61;
            this.label17.Text = "Fakture:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 30);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 20);
            this.label15.TabIndex = 8;
            this.label15.Text = "Maloprodaja:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblPrimke);
            this.groupBox1.Controls.Add(this.lblKalkulacije);
            this.groupBox1.Controls.Add(this.lblPocetnoStanje);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 491);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(315, 161);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ulaz";
            // 
            // lblMedjuskladisnice
            // 
            this.lblMedjuskladisnice.AutoSize = true;
            this.lblMedjuskladisnice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMedjuskladisnice.Location = new System.Drawing.Point(514, 60);
            this.lblMedjuskladisnice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedjuskladisnice.Name = "lblMedjuskladisnice";
            this.lblMedjuskladisnice.Size = new System.Drawing.Size(50, 20);
            this.lblMedjuskladisnice.TabIndex = 7;
            this.lblMedjuskladisnice.Text = "KOM";
            // 
            // lblPrimke
            // 
            this.lblPrimke.AutoSize = true;
            this.lblPrimke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrimke.Location = new System.Drawing.Point(209, 91);
            this.lblPrimke.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimke.Name = "lblPrimke";
            this.lblPrimke.Size = new System.Drawing.Size(50, 20);
            this.lblPrimke.TabIndex = 6;
            this.lblPrimke.Text = "KOM";
            // 
            // lblKalkulacije
            // 
            this.lblKalkulacije.AutoSize = true;
            this.lblKalkulacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblKalkulacije.Location = new System.Drawing.Point(209, 60);
            this.lblKalkulacije.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKalkulacije.Name = "lblKalkulacije";
            this.lblKalkulacije.Size = new System.Drawing.Size(50, 20);
            this.lblKalkulacije.TabIndex = 5;
            this.lblKalkulacije.Text = "KOM";
            // 
            // lblPocetnoStanje
            // 
            this.lblPocetnoStanje.AutoSize = true;
            this.lblPocetnoStanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPocetnoStanje.Location = new System.Drawing.Point(209, 30);
            this.lblPocetnoStanje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPocetnoStanje.Name = "lblPocetnoStanje";
            this.lblPocetnoStanje.Size = new System.Drawing.Size(50, 20);
            this.lblPocetnoStanje.TabIndex = 4;
            this.lblPocetnoStanje.Text = "KOM";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(321, 60);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Međuskladišnice:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 91);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Primke:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Kalkulacije:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Početno stanje:";
            // 
            // chbMediskladisnica
            // 
            this.chbMediskladisnica.AutoSize = true;
            this.chbMediskladisnica.Checked = true;
            this.chbMediskladisnica.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMediskladisnica.Location = new System.Drawing.Point(612, 52);
            this.chbMediskladisnica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbMediskladisnica.Name = "chbMediskladisnica";
            this.chbMediskladisnica.Size = new System.Drawing.Size(155, 24);
            this.chbMediskladisnica.TabIndex = 14;
            this.chbMediskladisnica.Text = "Međuskladišnice";
            this.chbMediskladisnica.UseVisualStyleBackColor = true;
            // 
            // chbInventura
            // 
            this.chbInventura.AutoSize = true;
            this.chbInventura.Checked = true;
            this.chbInventura.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbInventura.Location = new System.Drawing.Point(449, 80);
            this.chbInventura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbInventura.Name = "chbInventura";
            this.chbInventura.Size = new System.Drawing.Size(99, 24);
            this.chbInventura.TabIndex = 11;
            this.chbInventura.Text = "Inventura";
            this.chbInventura.UseVisualStyleBackColor = true;
            // 
            // chbPromjenaCijene
            // 
            this.chbPromjenaCijene.AutoSize = true;
            this.chbPromjenaCijene.Checked = true;
            this.chbPromjenaCijene.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPromjenaCijene.Location = new System.Drawing.Point(612, 23);
            this.chbPromjenaCijene.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbPromjenaCijene.Name = "chbPromjenaCijene";
            this.chbPromjenaCijene.Size = new System.Drawing.Size(151, 24);
            this.chbPromjenaCijene.TabIndex = 13;
            this.chbPromjenaCijene.Text = "Promjena cijene";
            this.chbPromjenaCijene.UseVisualStyleBackColor = true;
            // 
            // chbMaloprodaja
            // 
            this.chbMaloprodaja.AutoSize = true;
            this.chbMaloprodaja.Checked = true;
            this.chbMaloprodaja.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMaloprodaja.Location = new System.Drawing.Point(449, 52);
            this.chbMaloprodaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbMaloprodaja.Name = "chbMaloprodaja";
            this.chbMaloprodaja.Size = new System.Drawing.Size(122, 24);
            this.chbMaloprodaja.TabIndex = 7;
            this.chbMaloprodaja.Text = "Maloprodaja";
            this.chbMaloprodaja.UseVisualStyleBackColor = true;
            // 
            // chbKalkulacija
            // 
            this.chbKalkulacija.AutoSize = true;
            this.chbKalkulacija.Checked = true;
            this.chbKalkulacija.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbKalkulacija.Location = new System.Drawing.Point(449, 23);
            this.chbKalkulacija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbKalkulacija.Name = "chbKalkulacija";
            this.chbKalkulacija.Size = new System.Drawing.Size(83, 24);
            this.chbKalkulacija.TabIndex = 6;
            this.chbKalkulacija.Text = "Primka";
            this.chbKalkulacija.UseVisualStyleBackColor = true;
            // 
            // pbTrazi
            // 
            this.pbTrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTrazi.Image = global::PCPOS.Properties.Resources._1059;
            this.pbTrazi.Location = new System.Drawing.Point(791, 23);
            this.pbTrazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbTrazi.Name = "pbTrazi";
            this.pbTrazi.Size = new System.Drawing.Size(95, 80);
            this.pbTrazi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrazi.TabIndex = 58;
            this.pbTrazi.TabStop = false;
            this.pbTrazi.Click += new System.EventHandler(this.PbTrazi_Click);
            // 
            // dtpDoDatuma
            // 
            this.dtpDoDatuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDoDatuma.Location = new System.Drawing.Point(124, 63);
            this.dtpDoDatuma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDoDatuma.Name = "dtpDoDatuma";
            this.dtpDoDatuma.Size = new System.Drawing.Size(276, 26);
            this.dtpDoDatuma.TabIndex = 5;
            // 
            // dtpOdDatuma
            // 
            this.dtpOdDatuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpOdDatuma.Location = new System.Drawing.Point(124, 32);
            this.dtpOdDatuma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpOdDatuma.Name = "dtpOdDatuma";
            this.dtpOdDatuma.Size = new System.Drawing.Size(276, 26);
            this.dtpOdDatuma.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(15, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Do datuma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(15, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
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
            this.dgw.Location = new System.Drawing.Point(12, 127);
            this.dgw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgw.MultiSelect = false;
            this.dgw.Name = "dgw";
            this.dgw.RowHeadersWidth = 30;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(1257, 357);
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
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1285, 676);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1257, 380);
            this.dataGridView1.TabIndex = 43;
            // 
            // lblMpc
            // 
            this.lblMpc.AutoSize = true;
            this.lblMpc.BackColor = System.Drawing.Color.Transparent;
            this.lblMpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMpc.ForeColor = System.Drawing.Color.Black;
            this.lblMpc.Location = new System.Drawing.Point(919, 62);
            this.lblMpc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMpc.Name = "lblMpc";
            this.lblMpc.Size = new System.Drawing.Size(62, 20);
            this.lblMpc.TabIndex = 63;
            this.lblMpc.Text = "0.00 kn";
            // 
            // lblVpc
            // 
            this.lblVpc.AutoSize = true;
            this.lblVpc.BackColor = System.Drawing.Color.Transparent;
            this.lblVpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVpc.ForeColor = System.Drawing.Color.Black;
            this.lblVpc.Location = new System.Drawing.Point(919, 38);
            this.lblVpc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVpc.Name = "lblVpc";
            this.lblVpc.Size = new System.Drawing.Size(62, 20);
            this.lblVpc.TabIndex = 63;
            this.lblVpc.Text = "0.00 kn";
            // 
            // lblNbc
            // 
            this.lblNbc.AutoSize = true;
            this.lblNbc.BackColor = System.Drawing.Color.Transparent;
            this.lblNbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNbc.ForeColor = System.Drawing.Color.Black;
            this.lblNbc.Location = new System.Drawing.Point(919, 15);
            this.lblNbc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbc.Name = "lblNbc";
            this.lblNbc.Size = new System.Drawing.Size(62, 20);
            this.lblNbc.TabIndex = 63;
            this.lblNbc.Text = "0.00 kn";
            // 
            // lblStanje
            // 
            this.lblStanje.AutoSize = true;
            this.lblStanje.BackColor = System.Drawing.Color.Transparent;
            this.lblStanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblStanje.ForeColor = System.Drawing.Color.Black;
            this.lblStanje.Location = new System.Drawing.Point(556, 62);
            this.lblStanje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStanje.Name = "lblStanje";
            this.lblStanje.Size = new System.Drawing.Size(59, 20);
            this.lblStanje.TabIndex = 62;
            this.lblStanje.Text = "0 kom";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(436, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "Stanje:";
            // 
            // btnOpenRoba
            // 
            this.btnOpenRoba.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenRoba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenRoba.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenRoba.Image")));
            this.btnOpenRoba.Location = new System.Drawing.Point(356, 53);
            this.btnOpenRoba.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenRoba.Name = "btnOpenRoba";
            this.btnOpenRoba.Size = new System.Drawing.Size(47, 36);
            this.btnOpenRoba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOpenRoba.TabIndex = 61;
            this.btnOpenRoba.TabStop = false;
            this.btnOpenRoba.Click += new System.EventHandler(this.btnArtikli_Click);
            // 
            // txtImeArtikla
            // 
            this.txtImeArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtImeArtikla.Location = new System.Drawing.Point(560, 20);
            this.txtImeArtikla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImeArtikla.Name = "txtImeArtikla";
            this.txtImeArtikla.ReadOnly = true;
            this.txtImeArtikla.Size = new System.Drawing.Size(240, 26);
            this.txtImeArtikla.TabIndex = 60;
            // 
            // txtSifraArtikla
            // 
            this.txtSifraArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSifraArtikla.Location = new System.Drawing.Point(148, 54);
            this.txtSifraArtikla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSifraArtikla.Name = "txtSifraArtikla";
            this.txtSifraArtikla.Size = new System.Drawing.Size(205, 26);
            this.txtSifraArtikla.TabIndex = 2;
            this.txtSifraArtikla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSifraArtikla_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Šifra artikla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(433, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Naziv artikla:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(857, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "MPC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(857, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "VPC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(857, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
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
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 102);
            this.panel1.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(321, 30);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 63;
            this.label14.Text = "Otpis:";
            // 
            // lblOtpis
            // 
            this.lblOtpis.AutoSize = true;
            this.lblOtpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblOtpis.Location = new System.Drawing.Point(514, 30);
            this.lblOtpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOtpis.Name = "lblOtpis";
            this.lblOtpis.Size = new System.Drawing.Size(50, 20);
            this.lblOtpis.TabIndex = 64;
            this.lblOtpis.Text = "KOM";
            // 
            // frmKarticaRobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1328, 846);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabKartica);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lblOtpis;
        private System.Windows.Forms.Label label14;
    }
}