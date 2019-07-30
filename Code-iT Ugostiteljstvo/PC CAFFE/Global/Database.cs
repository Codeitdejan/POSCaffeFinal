using System;
using System.Data;

namespace PCPOS.Global
{
    public static class Database
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sifra"></param>
        /// <returns></returns>
        public static DataTable GetRoba(string sifra = null)
        {
            string query = $@"SELECT * FROM roba {(sifra != null ? $"WHERE sifra = '{sifra}'" : "")}";
            return classSQL.select(query, "roba").Tables[0];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable GetSkladisteByName(string name)
        {
            string query = $"SELECT * FROM skladiste WHERE skladiste.skladiste = '{name}'";
            return classSQL.select(query, "skladiste").Tables[0];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="articleId"></param>
        /// <returns></returns>
        public static DataTable GetKalkulacijaByArticleId(string articleId)
        {
            string query = $"SELECT * FROM primka_stavke WHERE sifra = '{articleId}' AND is_kalkulacija = TRUE ORDER BY id_stavka DESC LIMIT 1";
            return classSQL.select(query, "primka_stavke").Tables[0];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DateTime GetPocetnoDate()
        {
            string query = $@"SELECT datum FROM pocetno";
            DataTable dataTable = classSQL.select(query, "pocetno").Tables[0];
            if (dataTable.Rows.Count > 0)
                return DateTime.Parse(dataTable.Rows[0]["datum"].ToString());
            else
                return new DateTime(DateTime.Now.Year, 1, 1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DataTable GetPodgrupe()
        {
            string query = $"SELECT * FROM podgrupa";
            return classSQL.select(query, "podgrupa").Tables[0];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="tableName"></param>
        /// <param name="dateColumnName"></param>
        /// <param name="articleColumnName"></param>
        /// <returns></returns>
        public static DataTable GetDocument(string code, string tableName, string tableId, string dateColumnName, string articleCodeColumnName)
        {
            DateTime date = GetPocetnoDate();
            string query = $@"SELECT {tableName}.{tableId} AS sifra_dokument 
                                ,roba_prodaja.sifra
	                            ,roba_prodaja.naziv
                                ,{tableName}.{dateColumnName} AS datum
	                            ,{tableName}.kolicina AS dokument_kolicina
	                            ,caffe_normativ.kolicina AS normativ_kolicina
                            FROM {tableName} 
                            LEFT JOIN caffe_normativ ON caffe_normativ.sifra = {tableName}.{articleCodeColumnName}
                            LEFT JOIN roba_prodaja ON roba_prodaja.sifra = {tableName}.{articleCodeColumnName}
                            WHERE roba_prodaja.sifra = '{code}' AND {tableName}.{dateColumnName} >= '{date.ToString("dd-MM-yyyy HH:mm")}'";
            return classSQL.select(query, tableName).Tables[0];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="tableName"></param>
        /// <param name="tableId"></param>
        /// <param name="itemsTableName"></param>
        /// <param name="itemsId"></param>
        /// <param name="dateColumnName"></param>
        /// <param name="articleCodeColumnName"></param>
        /// <returns></returns>
        public static DataTable GetDocumentItems(string code, string tableName, string tableId, string itemsTableName, string itemsId, string dateColumnName, string articleCodeColumnName)
        {
            DateTime date = GetPocetnoDate();
            string query = $@"SELECT {tableName}.{tableId} AS sifra_dokument
                                ,roba_prodaja.sifra
	                            ,roba_prodaja.naziv
                                ,{tableName}.{dateColumnName} AS datum
	                            ,{itemsTableName}.kolicina AS dokument_kolicina
	                            ,caffe_normativ.kolicina AS normativ_kolicina
                            FROM {tableName} 
                            LEFT JOIN {itemsTableName} ON {itemsTableName}.{itemsId} = {tableName}.{tableId}
                            LEFT JOIN caffe_normativ ON caffe_normativ.sifra = {itemsTableName}.{articleCodeColumnName}
                            LEFT JOIN roba_prodaja ON roba_prodaja.sifra = {itemsTableName}.{articleCodeColumnName}
                            WHERE roba_prodaja.sifra = '{code}' AND {tableName}.{dateColumnName} >= '{date.ToString("dd-MM-yyyy HH:mm")}'";
            return classSQL.select(query, tableName).Tables[0];
        }
    }
}
