using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PCPOS.PosPrint
{
    internal class classPosPrintKuhinja
    {
        private static DataTable DTsetting = classSQL.select_settings("SELECT * FROM pos_print", "pos_print").Tables[0];
        private static DataTable DT = classSQL.select_settings("SELECT * FROM podaci_tvrtka", "podaci_tvrtka").Tables[0];
        private static DataTable DTpostavke = classSQL.select_settings("SELECT * FROM postavke", "postavke").Tables[0];
        private static DataTable DTrac;
        private static DataTable dt = classSQL.select("SELECT traje_do, popust, aktivnost FROM promocija1", "promocija1").Tables[0];
        public static string broj_narudzbe { get; set; }

        private static bool ima_stavke_za_kuhinju = false;

        private static string tekst;

        private static int RecLineChars = Convert.ToInt16(DTsetting.Rows[0]["broj_slova_na_racunu"].ToString()) + 2;

        private static string _1;
        private static string _2;
        private static string _3;

        //private static Image img_barcode = null;

        public static void PrintOnPrinter2(DataTable DTartikli, bool koristiPrinter3 = false, bool pijaca_i_trgovacka = false)
        {
            ima_stavke_za_kuhinju = false;
            tekst = "";
            string napomenaKolicina = "   ► ";
            try
            {
                if (DTsetting.Rows[0]["windows_printer_name2"].ToString() != "Nije instaliran" || DTsetting.Rows[0]["windows_printer_name3"].ToString() != "Nije instaliran")
                {
                    DTrac = DTartikli.Clone();
                    bool artiklZaPrint = false;
                    for (int i = 0; i < DTartikli.Rows.Count; i++)
                    {
                        string sql = string.Format(@"select
case when coalesce(grupa.printer3, 0) = 0 then false else true end as printer3, roba.id_podgrupa
from roba
left join grupa on roba.id_grupa = grupa.id_grupa where roba.sifra = '{0}';", DTartikli.Rows[i]["sifra_robe"].ToString());

                        DataSet dsPom = classSQL.select(sql, "pom");

                        bool printer3 = koristiPrinter3, dod = false;
                        int id_podgrupa = 2, pol = -1;

                        if (dsPom != null && dsPom.Tables.Count > 0 && dsPom.Tables[0] != null && dsPom.Tables[0].Rows.Count > 0)
                        {
                            try
                            {
                                bool.TryParse(dsPom.Tables[0].Rows[0]["printer3"].ToString(), out printer3);
                                int.TryParse(dsPom.Tables[0].Rows[0]["id_podgrupa"].ToString(), out id_podgrupa);
                            }
                            catch
                            {
                            }
                        }

                        int dodatak = 0;
                        int.TryParse(DTartikli.Rows[i]["dod"].ToString(), out dodatak);
                        int.TryParse(DTartikli.Rows[i]["id_podgrupa"].ToString(), out id_podgrupa);

                        if (dodatak > 0)
                            dod = true;

                        int.TryParse(DTartikli.Rows[i]["pol"].ToString(), out pol);

                        if (pijaca_i_trgovacka ? id_podgrupa != 2 : id_podgrupa == 2)
                        {
                            if (dod && artiklZaPrint)
                            {
                                DTrac.ImportRow(DTartikli.Rows[i]);
                            }
                            else if (dod == false && (pijaca_i_trgovacka ? true : printer3 == koristiPrinter3))
                            {
                                artiklZaPrint = true;
                                DTrac.ImportRow(DTartikli.Rows[i]);
                            }
                            else
                            {
                                artiklZaPrint = false;
                            }
                        }
                        else
                        {
                            artiklZaPrint = false;
                        }
                    }
                }
                else
                {
                    DTrac = DTartikli;
                }


                if (DTrac == null || DTrac.Rows.Count == 0)
                {
                    return;
                }

                DataTable DTt = classSQL.select("SELECT ime+' '+prezime AS zaposlenik FROM zaposlenici WHERE id_zaposlenik='" + Properties.Settings.Default.id_zaposlenik + "'", "zaposlenici").Tables[0];

                string title = "Kuhinja";
                if (pijaca_i_trgovacka)
                {
                    title = "Šank";
                }
                else if (!pijaca_i_trgovacka && koristiPrinter3)
                {
                    title = "Pizzerija";
                }


                PrintReceiptHeader(DateTime.Now, DTt.Rows[0]["zaposlenik"].ToString(), DTrac.Rows[0]["stol"].ToString(), title);

                string jelo = "";
                int polindex = -1;
                for (int i = 0; i < DTrac.Rows.Count; i++)
                {
                    string sql = string.Format(@"SELECT naziv, mpc
                                FROM roba
                                WHERE sifra = '{0}' AND " + (pijaca_i_trgovacka ? "id_podgrupa != '2'" : "id_podgrupa = '2'") + "; ", DTrac.Rows[i]["sifra_robe"].ToString());

                    DataTable DT = classSQL.select(sql, "roba").Tables[0];
                    if (DT.Rows.Count > 0 && Convert.ToInt32(DTrac.Rows[i]["dod"]) < 2)
                    {
                        if (DTrac.Rows[i]["jelo"].ToString() != jelo)
                        {
                            jelo = DTrac.Rows[i]["jelo"].ToString();
                            PrintTextLine("\r\n" + DTrac.Rows[i]["jelo"].ToString().ToUpper() + ":", false);
                        }
                        ima_stavke_za_kuhinju = true;
                        string artikl = DT.Rows[0]["naziv"].ToString();

                        int polaPolaIndex1 = -1, polaPolaIndex2 = -1;
                        int.TryParse(DTrac.Rows[i]["pol"].ToString(), out polaPolaIndex1);
                        if (i + 1 < DTrac.Rows.Count)
                        {
                            int.TryParse(DTrac.Rows[i + 1]["pol"].ToString(), out polaPolaIndex2);
                        }
                        if (((i + 1) <= (DTrac.Rows.Count - 1) && DTrac.Rows[i]["dod"].ToString() == "0" && DTrac.Rows[i + 1]["dod"].ToString() == "0") && (polaPolaIndex1 != polaPolaIndex2 || polaPolaIndex1 == -1 || DTrac.Rows[i]["pol"].ToString() == ""))
                        {
                            PrintLineItem(DTrac.Rows[i]["kolicina"].ToString(), artikl, true);
                        }
                        else
                        {
                            string kolicina = DTrac.Rows[i]["kolicina"].ToString();
                            if (DTrac.Rows[i]["dod"].ToString() == "1") //DODATAK
                            {
                                if (kolicina.Length == 1)
                                {
                                    kolicina += "  + ";
                                }
                                else if (kolicina.Length == 2)
                                {
                                    kolicina += " + ";
                                }
                                else
                                {
                                    kolicina += "+ ";
                                }
                            }
                            else if (DTrac.Rows[i]["dod"].ToString() == "2") //NAPOMENA
                            {
                                kolicina = napomenaKolicina;
                            }

                            if ((i + 1) <= (DTrac.Rows.Count - 1) && (Convert.ToInt32(DTrac.Rows[i + 1]["dod"].ToString()) > 0 || (Int32.TryParse(DTrac.Rows[i + 1]["pol"].ToString(), out polaPolaIndex1) && polaPolaIndex1 > -1)))
                            {
                                //PrintLineItem(kolicina, DTrac.Rows[i]["sifra_robe"].ToString() + " " + artikl, false);
                                PrintLineItem(kolicina, artikl, false);
                            }
                            else
                            {
                                //PrintLineItem(kolicina, DTrac.Rows[i]["sifra_robe"].ToString() + " " + artikl, true);
                                int a = -1, b = -1;
                                if (polindex >= 0 && i + 1 < DTrac.Rows.Count && Int32.TryParse(DTrac.Rows[i + 1]["pol"].ToString(), out a) && Int32.TryParse(DTrac.Rows[polindex]["pol"].ToString(), out b) && a == b && a > -1)
                                {
                                    PrintLineItem(kolicina, artikl, false);
                                }
                                else
                                {
                                    PrintLineItem(kolicina, artikl, true);
                                }
                            }
                        }
                        int polpol = -1;
                        if (int.TryParse(DTrac.Rows[i]["pol"].ToString(), out polpol))
                        {
                            polindex = i;
                        }
                    }
                    else if (Convert.ToInt32(DTrac.Rows[i]["dod"]) == 2)
                    {
                        //string kolicina = "   o ";
                        if (i + 1 < DTrac.Rows.Count && Convert.ToInt32(DTrac.Rows[i + 1]["dod"]) == 0)
                        {
                            PrintLineItem(napomenaKolicina, DTrac.Rows[i]["ime"].ToString(), true);
                        }
                        else
                        {
                            PrintLineItem(napomenaKolicina, DTrac.Rows[i]["ime"].ToString(), false);
                        }
                    }
                }

                PrintTextLine(new string('=', RecLineChars), false);

                for (int i = 0; i < Convert.ToInt16(DTsetting.Rows[0]["linija_praznih_bottom"].ToString()); i++)
                {
                    tekst += Environment.NewLine;
                }

                _2 = tekst;


            }
            finally
            {
                if (ima_stavke_za_kuhinju == true)
                {
                    if (DTpostavke.Rows[0]["bool_direct_print_kuhinja"].ToString() == "1")
                    {
                        if (pijaca_i_trgovacka)
                            printaj(4);
                        else
                        {
                            if (koristiPrinter3)
                                printaj(3);
                            else
                                printaj(2);
                        }
                    }
                    else
                    {
                        string msg = "Želite li poslati narudžbu u kuhinju?";
                        string ttl = "Kuhinja";
                        if (pijaca_i_trgovacka)
                        {
                            msg = "Želite li poslati narudžbu na šank?";
                            ttl = "Šank";
                        }

                        if (!pijaca_i_trgovacka && koristiPrinter3)
                        {
                            msg = "Želite li poslati narudžbu u pizzeriju?";
                            ttl = "Pizzerija";
                        }

                        if (MessageBox.Show(msg, ttl, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (pijaca_i_trgovacka)
                                printaj(4);
                            else
                            {
                                if (koristiPrinter3)
                                    printaj(3);
                                else
                                    printaj(2);
                            }
                        }
                    }
                }
            }
        }

        public static void PrintOnPrinter3(DataTable DTartikli)
        {
            PrintOnPrinter2(DTartikli, true);
            //ima_stavke_za_kuhinju = false;
            //tekst = "";
            //try
            //{
            //    DTrac = DTartikli;

            //    DataTable DTt = classSQL.select("SELECT ime+' '+prezime AS zaposlenik FROM zaposlenici WHERE id_zaposlenik='" + Properties.Settings.Default.id_zaposlenik + "'", "zaposlenici").Tables[0];

            //    PrintReceiptHeader(DateTime.Now, DTt.Rows[0]["zaposlenik"].ToString(), DTrac.Rows[0]["stol"].ToString());

            //    string jelo = "";
            //    //int a = 20;

            //    for (int i = 0; i < DTrac.Rows.Count; i++)
            //    {
            //        DataTable DT = classSQL.select("SELECT naziv,mpc FROM roba " +
            //            " LEFT JOIN grupa ON grupa.id_grupa=roba.id_grupa " +
            //            " WHERE sifra='" + DTrac.Rows[i]["sifra_robe"].ToString() + "' AND grupa.printer3 = '1'", "roba").Tables[0];

            //        if (DT.Rows.Count > 0)
            //        {
            //            if (DTrac.Rows[i]["jelo"].ToString() != jelo)
            //            {
            //                jelo = DTrac.Rows[i]["jelo"].ToString();
            //                PrintTextLine("\r\n" + DTrac.Rows[i]["jelo"].ToString().ToUpper() + ":", false);
            //            }
            //            ima_stavke_za_kuhinju = true;
            //            string artikl = DT.Rows[0]["naziv"].ToString();

            //            //PrintLineItem(DTrac.Rows[i]["sifra_robe"].ToString() + " " + artikl, Convert.ToDecimal(DT.Rows[0]["mpc"].ToString()).ToString("#0.00"), DTrac.Rows[i]["kolicina"].ToString());
            //            PrintLineItem(DTrac.Rows[i]["kolicina"].ToString(), DTrac.Rows[i]["sifra_robe"].ToString() + " " + artikl, true);
            //        }
            //    }

            //    PrintTextLine(new string('=', RecLineChars), false);

            //    for (int i = 0; i < Convert.ToInt16(DTsetting.Rows[0]["linija_praznih_bottom"].ToString()); i++)
            //    {
            //        tekst += Environment.NewLine;
            //    }

            //    _2 = tekst;
            //}
            //finally
            //{
            //    if (ima_stavke_za_kuhinju == true)
            //    {
            //        if (DTpostavke.Rows[0]["bool_direct_print_kuhinja"].ToString() == "1")
            //        {
            //            printaj(3);
            //        }
            //        else
            //        {
            //            if (MessageBox.Show("Želite li poslati narudžbu u kuhinju?", "Kuhinja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //            {
            //                printaj(3);
            //            }
            //        }
            //    }
            //}
        }


        public static void PrintOnPrinter1(DataTable DTartikli)
        {
            PrintOnPrinter2(DTartikli, true, true);
        }

        private static void PrintLineItem(string kolicina, string artikl, bool b)
        {
            int a = 24; //artikl
            //          int j = 8; //cijena
            int k = 5; //kolicina
            //a += 8;

            PrintText(TruncateAt(kolicina.PadRight(k), k, false), false);
            try
            {
                if (DTpostavke.Rows[0]["ispis_cijele_stavke"].ToString() != "1")
                {
                    PrintText(TruncateAt(artikl.PadRight(a), a, true), true);
                }
                else
                {
                    tekst += classOstalo.SvavkaZaPrinter(artikl, a);
                }
            }
            catch
            {
                PrintText(TruncateAt(artikl.PadRight(a), a, true), true);
            }

            //PrintText(TruncateAt(jmj.PadLeft(j), j));

            PrintText("\r\n", false);
            if (b)
                PrintTextLine(new string('=', RecLineChars), false);
        }

        private static void PrintLineItem(string artikl, string jmj, string kolicina)
        {
            int a = 24;
            int j = 8;
            int k = 5;

            try
            {
                if (DTpostavke.Rows[0]["ispis_cijele_stavke"].ToString() != "1")
                {
                    PrintText(TruncateAt(artikl.PadRight(a), a, true), true);
                }
                else
                {
                    tekst += classOstalo.SvavkaZaPrinter(artikl, a);
                }
            }
            catch
            {
                PrintText(TruncateAt(artikl.PadRight(a), a, true), true);
            }

            PrintText(TruncateAt(jmj.PadLeft(j), j, false), false);
            PrintText(TruncateAt(kolicina.PadLeft(k), k, false), false);
            PrintText("\r\n", false);
        }

        private static void PrintReceiptHeader(DateTime dateTime, string cashierName, string stol, string title = null)
        {
            DataTable DT = classSQL.select("SELECT naziv FROM stolovi WHERE id_stol='" + stol + "'", "stolovi").Tables[0];
            //if (broj_narudzbe != null) {
            //    DataTable dtNarudzbe = classSQL.select("select mjesto, ulica, kbr, telefon from caffe_narudzbe where id_stol = '" + stol + "' and broj_narudzbe = '" + broj_narudzbe + "';", "caffe_narudzbe").Tables[0];
            //    if (dtNarudzbe != null && dtNarudzbe.Rows.Count > 0) {
            //        PrintTextLine("Narudžba: " + broj_narudzbe, false);

            //        PrintTextLine("Mjesto: " + dtNarudzbe.Rows[0]["mjesto"], false);
            //        PrintTextLine("Ulica: " + dtNarudzbe.Rows[0]["ulica"], false);
            //        PrintTextLine("K. broj: " + dtNarudzbe.Rows[0]["kbr"], false);
            //        PrintTextLine("Telefon: " + dtNarudzbe.Rows[0]["telefon"], false);

            //    }
            //}
            if (title != null)
            {
                PrintTextLine(title, false);
            }

            DataSet adresa_narudzbe = classSQL.select("select * from adresa_dostave where id = (select id_adresa_dostave from na_stol where id_stol = '" + stol + "' limit 1)", "adresa_narudzbe");
            if (adresa_narudzbe != null && adresa_narudzbe.Tables.Count > 0 && adresa_narudzbe.Tables[0] != null && adresa_narudzbe.Tables[0].Rows.Count > 0)
            {
                PrintTextLine("Mjesto: " + adresa_narudzbe.Tables[0].Rows[0]["mjesto"], false);
                PrintTextLine("Ulica: " + adresa_narudzbe.Tables[0].Rows[0]["ulica"], false);
                PrintTextLine("K. broj: " + adresa_narudzbe.Tables[0].Rows[0]["kbr"], false);
                PrintTextLine("Telefon: " + adresa_narudzbe.Tables[0].Rows[0]["telefon"], false);
            }

            if (DT.Rows.Count > 0)
            {
                PrintTextLine("Stol: " + DT.Rows[0]["naziv"].ToString(), false);
            }
            PrintTextLine(String.Format("Blagajnik : {0}", cashierName), false);
            PrintTextLine("Datum: " + DateTime.Now, false);
            if (broj_narudzbe != null)
            {
                PrintTextLine("Broj narudžbe: " + broj_narudzbe, false);
            }
            _1 = tekst;
            tekst = "";

            int a = 24; //artikl
            //          int j = 8;  //cijena
            int k = 5;  //kolicina
            //a += 8;

            PrintTextLine(String.Empty, false);
            PrintText(TruncateAt("KOL".PadRight(k), k, false), false);
            PrintText(TruncateAt("STAVKA".PadRight(a), a, false), false);
            //PrintText(TruncateAt("KN".PadRight(j), j));
            PrintText("\r\n", false);
            PrintTextLine(new string('=', RecLineChars), false);

            broj_narudzbe = null;
        }

        private static void PrintText(string text, bool artikl)
        {
            if (text.Length <= RecLineChars)
                tekst += text;
            else if (text.Length > RecLineChars)
                tekst += TruncateAt(text, RecLineChars, artikl);
        }

        private static void PrintTextLine(string text, bool artikl)
        {
            if (text.Length < RecLineChars)
                tekst += text + Environment.NewLine;
            else if (text.Length > RecLineChars)
                tekst += TruncateAt(text, RecLineChars, artikl);
            else if (text.Length == RecLineChars)
                tekst += text + Environment.NewLine;
        }

        private static string TruncateAt(string text, int maxWidth, bool artikl)
        {
            string retVal = text;
            if (text.Length > maxWidth)
                retVal = text.Substring(0, maxWidth);

            return retVal;
        }

        private static void PrintPage(object o, PrintPageEventArgs e)
        {
            float height = 0;

            //header
            String drawString = _1;
            Font drawFont = new Font("MS Gothic", 14, FontStyle.Regular);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
            e.Graphics.DrawString(drawString, drawFont, drawBrush, 0, 0, drawFormat);
            SizeF stringSize = new SizeF();
            stringSize = e.Graphics.MeasureString(_1, drawFont);

            height = float.Parse(stringSize.Height.ToString()) + height;

            //stavke
            drawString = _2;
            drawFont = new Font("MS Gothic", 14, FontStyle.Bold);
            float y = height;
            float x = 0.0F;
            drawFormat = new StringFormat();
            e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
            stringSize = e.Graphics.MeasureString(_2, drawFont);

            height = float.Parse(stringSize.Height.ToString()) + height;

            if (e.HasMorePages)
            {
                e.HasMorePages = false;
            }

            if (height > e.PageSettings.PaperSize.Height)
            {
                PaperSize psNew = new System.Drawing.Printing.PaperSize("Racun", e.PageSettings.PrinterSettings.DefaultPageSettings.PaperSize.Width, (int)height + 1);
                Size sSize = new Size(psNew.Width, psNew.Height);

                e.PageSettings.PrinterSettings.DefaultPageSettings.PaperSize = psNew;
                e.PageSettings.PrinterSettings.DefaultPageSettings.Bounds.Inflate(sSize);
                e.PageSettings.PrinterSettings.DefaultPageSettings.PrintableArea.Inflate(sSize);
                e.PageSettings.PrinterSettings.DefaultPageSettings.PrinterSettings.DefaultPageSettings.PrintableArea.Inflate(sSize);

                e.PageSettings.PaperSize = psNew;

                e.PageSettings.Bounds.Inflate(sSize);

                e.PageBounds.Inflate(sSize);

                e.PageSettings.PrintableArea.Inflate(sSize);

                e.HasMorePages = true;
                e.Graphics.Clear(Color.White);
                e.Graphics.ResetClip();
                e.Graphics.Clip.MakeEmpty();
                //e.Graphics.Dispose();
                //e.Graphics.
            }
        }

        /// <summary>
        /// Broj printera 2 ili 3
        /// </summary>
        /// <param name="brojPrintera"></param>
        private static void printaj(int brojPrintera)
        {
            string printerName = "";
            if (brojPrintera == 4)
                printerName = DTsetting.Rows[0]["windows_printer_sank"].ToString();
            else if (brojPrintera == 3)
                printerName = DTsetting.Rows[0]["windows_printer_name3"].ToString();
            else if (brojPrintera == 2)
                printerName = DTsetting.Rows[0]["windows_printer_name2"].ToString();
            else
                printerName = DTsetting.Rows[0]["windows_printer_name"].ToString();

            PrintDocument printDoc = new PrintDocument();

            printDoc.PrinterSettings.PrinterName = printerName;

            string drawString = _1 + _2;

            if (DTpostavke.Rows[0]["direct_print"].ToString() == "1")
            {
                string ttx = _1 + _2 + _3;
                ttx = ttx.Replace("č", "c");
                ttx = ttx.Replace("Č", "C");
                ttx = ttx.Replace("ž", "z");
                ttx = ttx.Replace("Ž", "Z");
                ttx = ttx.Replace("ć", "c");
                ttx = ttx.Replace("Ć", "C");
                ttx = ttx.Replace("đ", "d");
                ttx = ttx.Replace("Đ", "D");
                ttx = ttx.Replace("š", "s");
                ttx = ttx.Replace("Š", "S");

                string GS = Convert.ToString((char)29);
                string ESC = Convert.ToString((char)27);

                string COMMAND = "";
                COMMAND = ESC + "@";
                COMMAND += GS + "V" + (char)1;

                RawPrinterHelper.SendStringToPrinter(printDoc.PrinterSettings.PrinterName, ttx + COMMAND);
            }
            else
            {
                if (!printDoc.PrinterSettings.IsValid)
                {
                    string msg = String.Format(
                       "Can't find printer \"{0}\".", printerName);
                    MessageBox.Show(msg, "Print Error");
                    return;
                }
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                printDoc.Print();
            }
        }
    }
}