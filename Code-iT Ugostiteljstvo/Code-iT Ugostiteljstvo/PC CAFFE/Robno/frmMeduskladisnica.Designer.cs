﻿namespace PCPOS.Robno
{
    partial class frmMeduskladisnica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeduskladisnica));
            this.label2 = new System.Windows.Forms.Label();
            this.txtIzradio = new System.Windows.Forms.TextBox();
            this.rtbNapomena = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.rb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_stavka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.nmGodina = new System.Windows.Forms.NumericUpDown();
            this.cbPoslovnica = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifra_robe = new System.Windows.Forms.TextBox();
            this.lblNaDan = new System.Windows.Forms.Label();
            this.bgSinkronizacija = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPoslovnicaUposlovnicu = new System.Windows.Forms.ComboBox();
            this.cbSkl = new System.Windows.Forms.ComboBox();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.btnDeleteAllFaktura = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOpenRoba = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSveFakture = new System.Windows.Forms.Button();
            this.btnNoviUnos = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGodina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenRoba)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(369, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 179;
            this.label2.Text = "Izradio:";
            // 
            // txtIzradio
            // 
            this.txtIzradio.BackColor = System.Drawing.Color.White;
            this.txtIzradio.Font = new System.Drawing.Font("Arial", 10F);
            this.txtIzradio.Location = new System.Drawing.Point(466, 37);
            this.txtIzradio.Name = "txtIzradio";
            this.txtIzradio.ReadOnly = true;
            this.txtIzradio.Size = new System.Drawing.Size(277, 23);
            this.txtIzradio.TabIndex = 7;
            this.txtIzradio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIzradio_KeyDown);
            // 
            // rtbNapomena
            // 
            this.rtbNapomena.Enabled = false;
            this.rtbNapomena.Font = new System.Drawing.Font("Arial", 10F);
            this.rtbNapomena.Location = new System.Drawing.Point(466, 66);
            this.rtbNapomena.Name = "rtbNapomena";
            this.rtbNapomena.Size = new System.Drawing.Size(277, 69);
            this.rtbNapomena.TabIndex = 10;
            this.rtbNapomena.Text = "";
            this.rtbNapomena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbNapomena_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(369, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 177;
            this.label3.Text = "Napomena:";
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.AllowUserToDeleteRows = false;
            this.dgw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rb,
            this.sifra,
            this.naziv,
            this.kolicina,
            this.pdv,
            this.nbc,
            this.ukupno,
            this.id_stavka,
            this.pnp,
            this.pp});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgw.GridColor = System.Drawing.Color.Gainsboro;
            this.dgw.Location = new System.Drawing.Point(12, 271);
            this.dgw.MultiSelect = false;
            this.dgw.Name = "dgw";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgw.RowHeadersWidth = 30;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgw.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(960, 358);
            this.dgw.TabIndex = 12;
            this.dgw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellClick);
            this.dgw.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellEndEdit);
            // 
            // rb
            // 
            this.rb.FillWeight = 30F;
            this.rb.HeaderText = "RB";
            this.rb.Name = "rb";
            this.rb.ReadOnly = true;
            // 
            // sifra
            // 
            this.sifra.FillWeight = 80F;
            this.sifra.HeaderText = "Šifra robe";
            this.sifra.Name = "sifra";
            this.sifra.ReadOnly = true;
            // 
            // naziv
            // 
            this.naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.naziv.FillWeight = 105.5838F;
            this.naziv.HeaderText = "Naziv";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            // 
            // kolicina
            // 
            this.kolicina.FillWeight = 70F;
            this.kolicina.HeaderText = "Količina";
            this.kolicina.Name = "kolicina";
            // 
            // pdv
            // 
            this.pdv.HeaderText = "PDV";
            this.pdv.Name = "pdv";
            this.pdv.ReadOnly = true;
            // 
            // nbc
            // 
            this.nbc.HeaderText = "NBC";
            this.nbc.Name = "nbc";
            this.nbc.ReadOnly = true;
            // 
            // ukupno
            // 
            this.ukupno.HeaderText = "Ukupno";
            this.ukupno.Name = "ukupno";
            this.ukupno.ReadOnly = true;
            // 
            // id_stavka
            // 
            this.id_stavka.HeaderText = "id_stavka";
            this.id_stavka.Name = "id_stavka";
            this.id_stavka.Visible = false;
            // 
            // pnp
            // 
            this.pnp.HeaderText = "pnp";
            this.pnp.Name = "pnp";
            this.pnp.Visible = false;
            // 
            // pp
            // 
            this.pp.HeaderText = "pp";
            this.pp.Name = "pp";
            this.pp.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(31, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 168;
            this.label1.Text = "Broj unosa:";
            // 
            // txtBroj
            // 
            this.txtBroj.BackColor = System.Drawing.Color.White;
            this.txtBroj.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBroj.Location = new System.Drawing.Point(124, 10);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(121, 23);
            this.txtBroj.TabIndex = 1;
            this.txtBroj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBroj_KeyDown);
            // 
            // nmGodina
            // 
            this.nmGodina.BackColor = System.Drawing.Color.White;
            this.nmGodina.Font = new System.Drawing.Font("Arial", 10F);
            this.nmGodina.Location = new System.Drawing.Point(246, 10);
            this.nmGodina.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmGodina.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nmGodina.Name = "nmGodina";
            this.nmGodina.Size = new System.Drawing.Size(85, 23);
            this.nmGodina.TabIndex = 2;
            this.nmGodina.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nmGodina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBroj_KeyDown);
            // 
            // cbPoslovnica
            // 
            this.cbPoslovnica.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPoslovnica.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPoslovnica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoslovnica.Enabled = false;
            this.cbPoslovnica.Font = new System.Drawing.Font("Arial", 10F);
            this.cbPoslovnica.FormattingEnabled = true;
            this.cbPoslovnica.Location = new System.Drawing.Point(123, 35);
            this.cbPoslovnica.Name = "cbPoslovnica";
            this.cbPoslovnica.Size = new System.Drawing.Size(209, 24);
            this.cbPoslovnica.TabIndex = 3;
            this.cbPoslovnica.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSkladiste_KeyDown);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Enabled = false;
            this.dtpDatum.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpDatum.Location = new System.Drawing.Point(124, 87);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(207, 23);
            this.dtpDatum.TabIndex = 4;
            this.dtpDatum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDatum_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(31, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 170;
            this.label4.Text = "Datum:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 10F);
            this.label17.Location = new System.Drawing.Point(31, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 16);
            this.label17.TabIndex = 173;
            this.label17.Text = "Iz poslovnice:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.Location = new System.Drawing.Point(6, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 185;
            this.label6.Text = "Šifra artikla:";
            // 
            // txtSifra_robe
            // 
            this.txtSifra_robe.Enabled = false;
            this.txtSifra_robe.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSifra_robe.Location = new System.Drawing.Point(9, 25);
            this.txtSifra_robe.Name = "txtSifra_robe";
            this.txtSifra_robe.Size = new System.Drawing.Size(237, 23);
            this.txtSifra_robe.TabIndex = 11;
            this.txtSifra_robe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifra_robe_KeyDown);
            // 
            // lblNaDan
            // 
            this.lblNaDan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNaDan.AutoSize = true;
            this.lblNaDan.BackColor = System.Drawing.Color.Transparent;
            this.lblNaDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaDan.Location = new System.Drawing.Point(23, 648);
            this.lblNaDan.Name = "lblNaDan";
            this.lblNaDan.Size = new System.Drawing.Size(0, 13);
            this.lblNaDan.TabIndex = 191;
            // 
            // bgSinkronizacija
            // 
            this.bgSinkronizacija.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgSinkronizacija_DoWork);
            this.bgSinkronizacija.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgSinkronizacija_RunWorkerCompleted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.Location = new System.Drawing.Point(31, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 173;
            this.label5.Text = "U poslovnicu:";
            // 
            // cbPoslovnicaUposlovnicu
            // 
            this.cbPoslovnicaUposlovnicu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPoslovnicaUposlovnicu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPoslovnicaUposlovnicu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoslovnicaUposlovnicu.Enabled = false;
            this.cbPoslovnicaUposlovnicu.Font = new System.Drawing.Font("Arial", 10F);
            this.cbPoslovnicaUposlovnicu.FormattingEnabled = true;
            this.cbPoslovnicaUposlovnicu.Location = new System.Drawing.Point(123, 61);
            this.cbPoslovnicaUposlovnicu.Name = "cbPoslovnicaUposlovnicu";
            this.cbPoslovnicaUposlovnicu.Size = new System.Drawing.Size(209, 24);
            this.cbPoslovnicaUposlovnicu.TabIndex = 3;
            this.cbPoslovnicaUposlovnicu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSkladiste_KeyDown);
            // 
            // cbSkl
            // 
            this.cbSkl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSkl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSkl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkl.Enabled = false;
            this.cbSkl.Font = new System.Drawing.Font("Arial", 10F);
            this.cbSkl.FormattingEnabled = true;
            this.cbSkl.Location = new System.Drawing.Point(466, 7);
            this.cbSkl.Name = "cbSkl";
            this.cbSkl.Size = new System.Drawing.Size(277, 24);
            this.cbSkl.TabIndex = 194;
            // 
            // lblUkupno
            // 
            this.lblUkupno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUkupno.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUkupno.ForeColor = System.Drawing.Color.Black;
            this.lblUkupno.Location = new System.Drawing.Point(24, 3);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUkupno.Size = new System.Drawing.Size(269, 23);
            this.lblUkupno.TabIndex = 195;
            this.lblUkupno.Text = "Ukupno: 0.00 kn";
            // 
            // btnDeleteAllFaktura
            // 
            this.btnDeleteAllFaktura.BackColor = System.Drawing.Color.White;
            this.btnDeleteAllFaktura.Enabled = false;
            this.btnDeleteAllFaktura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.btnDeleteAllFaktura.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteAllFaktura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteAllFaktura.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDeleteAllFaktura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllFaktura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteAllFaktura.Image = global::PCPOS.Properties.Resources.Recyclebin_Empty;
            this.btnDeleteAllFaktura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAllFaktura.Location = new System.Drawing.Point(556, 12);
            this.btnDeleteAllFaktura.Name = "btnDeleteAllFaktura";
            this.btnDeleteAllFaktura.Size = new System.Drawing.Size(156, 40);
            this.btnDeleteAllFaktura.TabIndex = 193;
            this.btnDeleteAllFaktura.Text = "Obriši dokumenat";
            this.btnDeleteAllFaktura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAllFaktura.UseVisualStyleBackColor = false;
            this.btnDeleteAllFaktura.Click += new System.EventHandler(this.btnDeleteAllFaktura_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisi.BackColor = System.Drawing.Color.White;
            this.btnObrisi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.btnObrisi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btnObrisi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnObrisi.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnObrisi.Image = global::PCPOS.Properties.Resources.Close;
            this.btnObrisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisi.Location = new System.Drawing.Point(825, 21);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(130, 30);
            this.btnObrisi.TabIndex = 192;
            this.btnObrisi.Text = "   Obriši stavku";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnOpenRoba
            // 
            this.btnOpenRoba.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenRoba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenRoba.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenRoba.Image")));
            this.btnOpenRoba.Location = new System.Drawing.Point(247, 19);
            this.btnOpenRoba.Name = "btnOpenRoba";
            this.btnOpenRoba.Size = new System.Drawing.Size(39, 31);
            this.btnOpenRoba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOpenRoba.TabIndex = 186;
            this.btnOpenRoba.TabStop = false;
            this.btnOpenRoba.Click += new System.EventHandler(this.btnOpenRoba_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::PCPOS.Properties.Resources.Actions_application_exit_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(842, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Izlaz      ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSveFakture
            // 
            this.btnSveFakture.BackColor = System.Drawing.Color.White;
            this.btnSveFakture.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.btnSveFakture.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btnSveFakture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnSveFakture.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSveFakture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSveFakture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSveFakture.Image = global::PCPOS.Properties.Resources._10591;
            this.btnSveFakture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSveFakture.Location = new System.Drawing.Point(420, 12);
            this.btnSveFakture.Name = "btnSveFakture";
            this.btnSveFakture.Size = new System.Drawing.Size(130, 40);
            this.btnSveFakture.TabIndex = 16;
            this.btnSveFakture.Text = "Svi dokumenti";
            this.btnSveFakture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSveFakture.UseVisualStyleBackColor = false;
            this.btnSveFakture.Click += new System.EventHandler(this.btnSveFakture_Click);
            // 
            // btnNoviUnos
            // 
            this.btnNoviUnos.BackColor = System.Drawing.Color.White;
            this.btnNoviUnos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.btnNoviUnos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btnNoviUnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnNoviUnos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNoviUnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoviUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNoviUnos.Image = global::PCPOS.Properties.Resources.folder_open_icon;
            this.btnNoviUnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoviUnos.Location = new System.Drawing.Point(12, 12);
            this.btnNoviUnos.Name = "btnNoviUnos";
            this.btnNoviUnos.Size = new System.Drawing.Size(130, 40);
            this.btnNoviUnos.TabIndex = 13;
            this.btnNoviUnos.Text = "Novi unos   ";
            this.btnNoviUnos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNoviUnos.UseVisualStyleBackColor = false;
            this.btnNoviUnos.Click += new System.EventHandler(this.btnNoviUnos_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.White;
            this.btnOdustani.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.btnOdustani.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btnOdustani.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnOdustani.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOdustani.Image = global::PCPOS.Properties.Resources.undo;
            this.btnOdustani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustani.Location = new System.Drawing.Point(148, 12);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(130, 40);
            this.btnOdustani.TabIndex = 45;
            this.btnOdustani.Text = "Odustani   ";
            this.btnOdustani.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.White;
            this.btnSpremi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.btnSpremi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btnSpremi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnSpremi.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSpremi.Image = ((System.Drawing.Image)(resources.GetObject("btnSpremi.Image")));
            this.btnSpremi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpremi.Location = new System.Drawing.Point(284, 12);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(130, 40);
            this.btnSpremi.TabIndex = 15;
            this.btnSpremi.Text = "Spremi   ";
            this.btnSpremi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.Location = new System.Drawing.Point(369, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 196;
            this.label7.Text = "Skladište:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblUkupno);
            this.panel1.Location = new System.Drawing.Point(677, 635);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 34);
            this.panel1.TabIndex = 197;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtBroj);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbSkl);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpDatum);
            this.panel2.Controls.Add(this.cbPoslovnica);
            this.panel2.Controls.Add(this.cbPoslovnicaUposlovnicu);
            this.panel2.Controls.Add(this.nmGodina);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.rtbNapomena);
            this.panel2.Controls.Add(this.txtIzradio);
            this.panel2.Location = new System.Drawing.Point(12, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 144);
            this.panel2.TabIndex = 198;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnOpenRoba);
            this.panel3.Controls.Add(this.txtSifra_robe);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnObrisi);
            this.panel3.Location = new System.Drawing.Point(12, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 57);
            this.panel3.TabIndex = 199;
            // 
            // frmMeduskladisnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(984, 668);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteAllFaktura);
            this.Controls.Add(this.lblNaDan);
            this.Controls.Add(this.dgw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSveFakture);
            this.Controls.Add(this.btnNoviUnos);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Name = "frmMeduskladisnica";
            this.Text = "Međuskladišnica između poslovnica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPovratRobe_FormClosing);
            this.Load += new System.EventHandler(this.frmMeduskladisnica_Load);
            this.Shown += new System.EventHandler(this.frmPovratRobe_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGodina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenRoba)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtIzradio;
        private System.Windows.Forms.RichTextBox rtbNapomena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSveFakture;
        private System.Windows.Forms.Button btnNoviUnos;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.NumericUpDown nmGodina;
        private System.Windows.Forms.ComboBox cbPoslovnica;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox btnOpenRoba;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifra_robe;
        private System.Windows.Forms.Label lblNaDan;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDeleteAllFaktura;
        private System.ComponentModel.BackgroundWorker bgSinkronizacija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPoslovnicaUposlovnicu;
        private System.Windows.Forms.ComboBox cbSkl;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn rb;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupno;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_stavka;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnp;
        private System.Windows.Forms.DataGridViewTextBoxColumn pp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}