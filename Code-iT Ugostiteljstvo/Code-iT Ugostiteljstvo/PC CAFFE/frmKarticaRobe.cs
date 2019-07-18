using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace PCPOS
{
    public partial class frmKarticaRobe : Form
    {
        private DataSet DSMT = new DataSet();
        private DataTable DTitems_sort = new DataTable();
        private DataTable DTRoba;

        private decimal ukupnoStanje { get; set; }
        private decimal pocetnoStanje = 0;
        private decimal kalkulacijeStanje = 0;
        private decimal primkeStanje = 0;
        private decimal medjuskladisniceStanje = 0;
        private decimal maloprodajaStanje = 0;
        private decimal faktureStanje = 0;
        private decimal otpremniceStanje = 0;
        private decimal izdatniceStanje = 0;

        public frmMenu MainFormMenu { get; set; }

        public frmKarticaRobe()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            this.BackColor = Class.Postavke.backGround;
        }

        private void frmKartica_Load(object sender, EventArgs e)
        {
            fillComboBox();
            this.Paint += new PaintEventHandler(Class.Postavke.changeBackground);
        }

        private void fillComboBox()
        {
            DTitems_sort.Columns.Add("Šifra");
            DTitems_sort.Columns.Add("Naziv");
            DTitems_sort.Columns.Add("Količina");
            DTitems_sort.Columns.Add("JMJ");
            DTitems_sort.Columns.Add("NBC");
            DTitems_sort.Columns.Add("VPC");
            DTitems_sort.Columns.Add("Datum");
            DTitems_sort.Columns.Add("Dokumenat");

            //fill mjTroška
            DSMT = classSQL.select("SELECT * FROM skladiste", "skladiste");
            cbSkladiste.DataSource = DSMT.Tables[0];
            cbSkladiste.DisplayMember = "skladiste";
            cbSkladiste.ValueMember = "id_skladiste";
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillGrid()
        {
            if (dgw.Rows.Count > 0)
                RefreshGrid();

            ukupnoStanje = 0;
            pocetnoStanje = 0;
            kalkulacijeStanje = 0;
            primkeStanje = 0;
            medjuskladisniceStanje = 0;
            maloprodajaStanje = 0;
            faktureStanje = 0;
            otpremniceStanje = 0;
            izdatniceStanje = 0;

            Pocetno();
            Maloprodaja();
            Fakture();
            Primke();
            Kalkulacije();
            Medjuskladisnica();
            Otpremnice();

            dgw.Sort(dgw.Columns[3], System.ComponentModel.ListSortDirection.Ascending);

            SetSeparateAmounts();
            SetTotalAmount();
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetTotalAmount()
        {
            lblStanje.Text = ukupnoStanje.ToString("#0.00") + " kom";
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetSeparateAmounts()
        {
            lblPocetnoStanje.Text = pocetnoStanje.ToString("#0.00");
            lblKalkulacije.Text = kalkulacijeStanje.ToString("#0.00");
            lblPrimke.Text = primkeStanje.ToString("#0.00");
            lblMedjuskladisnice.Text = medjuskladisniceStanje.ToString("#0.00");
            lblMaloprodaja.Text = maloprodajaStanje.ToString("#0.00");
            lblFakture.Text = faktureStanje.ToString("#0.00");
            lblOtpremnice.Text = otpremniceStanje.ToString("#0.00");
            lblIzdatnice.Text = izdatniceStanje.ToString("#0.00");
        }

        /// <summary>
        /// 
        /// </summary>
        private void RefreshGrid()
        {
            dgw.Rows.Clear();
            dgw.Refresh();
        }

        #region Documents

        /// <summary>
        /// 
        /// </summary>
        private void Pocetno()
        {
            DataTable dataTable = Global.Database.GetDocument(txtSifraArtikla.Text, "pocetno", "id", "datum", "sifra");
            AddRowsToGrid(dataTable, "Početno");
        }

        /// <summary>
        /// 
        /// </summary>
        private void Maloprodaja()
        {
            DataTable dataTable = Global.Database.GetDocumentItems(txtSifraArtikla.Text, "racuni", "broj_racuna", "racun_stavke", "broj_racuna", "datum_racuna", "sifra_robe");
            AddRowsToGrid(dataTable, "Maloprodaja", false);
        }

        /// <summary>
        /// 
        /// </summary>
        private void Fakture()
        {
            DataTable dataTable = Global.Database.GetDocumentItems(txtSifraArtikla.Text, "fakture", "broj_fakture", "faktura_stavke", "broj_fakture", "date", "sifra");
            AddRowsToGrid(dataTable, "Faktura", false);
        }

        /// <summary>
        /// 
        /// </summary>
        private void Primke()
        {
            DataTable dataTable = GetPrimkaOrKalkulacija(false);
            AddRowsToGrid(dataTable, "Primka");
        }

        /// <summary>
        /// 
        /// </summary>
        private void Kalkulacije()
        {
            DataTable dataTable = GetPrimkaOrKalkulacija(true);
            AddRowsToGrid(dataTable, "Kalkulacija");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isKalkulacija"></param>
        /// <returns></returns>
        private DataTable GetPrimkaOrKalkulacija(bool isKalkulacija)
        {
            DateTime date = Global.Database.GetPocetnoDate();
            string query = $@"SELECT primka.broj_primke AS sifra_dokument
                                ,roba_prodaja.sifra
	                            ,roba_prodaja.naziv
	                            ,primka.datum AS datum
	                            ,primka_stavke.kolicina AS dokument_kolicina
	                            ,caffe_normativ.kolicina AS normativ_kolicina
                            FROM primka 
                            LEFT JOIN primka_stavke ON primka_stavke.broj_primke = primka.broj_primke
                            LEFT JOIN caffe_normativ ON caffe_normativ.sifra = primka_stavke.sifra
                            LEFT JOIN roba_prodaja ON roba_prodaja.sifra = primka_stavke.sifra
                            WHERE roba_prodaja.sifra = '{txtSifraArtikla.Text}' AND primka.datum >= '{date.ToString("dd-MM-yyyy HH:mm")}' AND primka.is_kalkulacija = {(isKalkulacija ? "TRUE" : "FALSE")} AND primka_stavke.is_kalkulacija = {(isKalkulacija ? "TRUE" : "FALSE")}";
            return classSQL.select(query, "primka").Tables[0];
        }

        /// <summary>
        /// 
        /// </summary>
        private void Medjuskladisnica()
        {
            DataTable dataTable = Global.Database.GetDocumentItems(txtSifraArtikla.Text, "meduskladisnica", "broj", "meduskladisnica_stavke", "broj", "datum", "sifra");
            AddRowsToGrid(dataTable, "Međuskladišnica", false);
        }

        private void Otpremnice()
        {
            DataTable dataTable = Global.Database.GetDocumentItems(txtSifraArtikla.Text, "otpremnice", "broj_otpremnice", "otpremnica_stavke", "broj_otpremnice", "datum", "sifra_robe");
            AddRowsToGrid(dataTable, "Otpremnica", false);
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="documentName"></param>
        private void AddRowsToGrid(DataTable dataTable, string documentName, bool add = true)
        {
            if (dataTable?.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    decimal.TryParse(row["dokument_kolicina"].ToString().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal dokumentKolicina);
                    decimal.TryParse(row["normativ_kolicina"].ToString().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal normativKolicina);

                    decimal ukupnoKolicina = dokumentKolicina * (normativKolicina != 0 ? normativKolicina : 1);

                    int index = dgw.Rows.Add();
                    dgw.Rows[index].Cells["sifra_robe"].Value = row["sifra"].ToString();
                    dgw.Rows[index].Cells["naziv"].Value = row["naziv"].ToString();
                    dgw.Rows[index].Cells["kolicina"].Value = ukupnoKolicina.ToString("#0.00");
                    dgw.Rows[index].Cells["datum"].Value = DateTime.Parse(row["datum"].ToString());
                    dgw.Rows[index].Cells["dokument"].Value = row["sifra_dokument"].ToString() + ". " + documentName;

                    CalculateAmount(ukupnoKolicina, documentName, add);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="add"></param>
        private void CalculateAmount(decimal amount, string documentName, bool add)
        {
            if (!add || (!add && amount < 0))
                amount *= -1;

            // Calculate amounts separately
            switch (documentName)
            {
                case "Početno":
                    pocetnoStanje += amount;
                    break;
                case "Maloprodaja":
                    maloprodajaStanje += amount;
                    break;
                case "Faktura":
                    faktureStanje += amount;
                    break;
                case "Primka":
                    primkeStanje += amount;
                    break;
                case "Kalkulacija":
                    kalkulacijeStanje += amount;
                    break;
                case "Međuskladišnica":
                    medjuskladisniceStanje += amount;
                    break;
                case "Otpremnica":
                    otpremniceStanje += amount;
                    break;
            }

            ukupnoStanje += amount;
        }

        /// <summary>
        /// 
        /// </summary>
        private void SelectRoba()
        {
            frmRobaTrazi roba_trazi = new frmRobaTrazi();
            roba_trazi.ShowDialog();
            string propertis_sifra = Properties.Settings.Default.id_roba.Replace(" ", "");
            if (propertis_sifra != "")
            {
                string sql = "";
                if (cbSkladiste.SelectedValue.ToString() == "1")
                {
                    sql = "SELECT " +
                        " roba.sifra," +
                        " roba.naziv," +
                        " roba_prodaja.porez," +
                        " roba_prodaja.nc," +
                        " roba_prodaja.kolicina," +
                        " roba_prodaja.vpc" +
                        " FROM roba " +
                        " LEFT JOIN roba_prodaja ON roba.sifra=roba_prodaja.sifra" +
                        " WHERE roba.sifra='" + propertis_sifra + "'";
                }
                else
                {
                    sql = "SELECT " +
                    " roba.sifra," +
                    " roba.naziv," +
                    " roba_prodaja.porez," +
                    " roba_prodaja.nc," +
                    " roba_prodaja.kolicina," +
                    " roba_prodaja.vpc" +
                    " FROM roba " +
                    " LEFT JOIN roba_prodaja ON roba.sifra=roba_prodaja.sifra" +
                    " WHERE roba.sifra='" + propertis_sifra + "' AND roba_prodaja.id_skladiste='" + cbSkladiste.SelectedValue + "'";
                }

                DTRoba = classSQL.select(sql, "roba").Tables[0];
                if (DTRoba.Rows.Count > 0)
                {
                    txtSifraArtikla.Text = DTRoba.Rows[0]["sifra"].ToString();
                    txtImeArtikla.Text = DTRoba.Rows[0]["naziv"].ToString();
                    lblStanje.Text = DTRoba.Rows[0]["kolicina"].ToString();
                    lblNbc.Text = Convert.ToDouble(DTRoba.Rows[0]["nc"].ToString()).ToString("#0.00");
                    lblVpc.Text = Convert.ToDouble(DTRoba.Rows[0]["vpc"].ToString()).ToString("#0.00");
                    lblMpc.Text = Convert.ToDouble((Convert.ToDouble(DTRoba.Rows[0]["vpc"].ToString()) * Convert.ToDouble(DTRoba.Rows[0]["porez"].ToString()) / 100) + Convert.ToDouble(DTRoba.Rows[0]["vpc"].ToString())).ToString("#0.00");
                }
                else
                {
                    MessageBox.Show("Za ovu šifru ne postoj artikl na odabranome skladistu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void Search()
        {
            if (!string.IsNullOrWhiteSpace(txtSifraArtikla.Text))
                FillGrid();
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
            SelectRoba();
        }

        private void tabKartica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabKartica.SelectedIndex == 1)
            {
                string sql = "SELECT " +
                    " roba_prodaja.sifra AS [Šifra]," +
                    " skladiste.skladiste AS [Skladište]," +
                    " roba_prodaja.kolicina AS [Količina]," +
                    " roba_prodaja.nc AS [NBC]," +
                    " roba_prodaja.vpc AS [VPC]" +
                    " FROM skladiste" +
                    " INNER JOIN roba_prodaja ON roba_prodaja.id_skladiste=skladiste.id_skladiste" +
                    " WHERE roba_prodaja.sifra='" + txtSifraArtikla.Text + "'";

                //dataGridView1.DataSource = classSQL.select(sql, "skladiste").Tables[0];
            }
        }

        private void PbTrazi_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void TxtSifraArtikla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

    }
}