using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Data.SqlServerCe;

namespace PCPOS.SQL
{
    class SQLusklada_skladista
    { 
        public string unesiStavkeUskladeRobe(DataTable dataTable)
        {
            if (classSQL.remoteConnectionString == "")
            {
                if (classSQL.connection.State.ToString() == "Closed")
                {
                    classSQL.connection.Open();
                }
                SqlCeCommand sqlCeCommand = classSQL.connection.CreateCommand();
                try
                {
                    sqlCeCommand.CommandText = @"INSERT INTO usklada_robe_stavke(usklada_id,roba_id,nova_kolicina,stara_kolicina) VALUES(@usklada_id,@roba_id,@nova_kolicina,@stara_kolicina";
                    sqlCeCommand.Parameters.Add("@usklada_id", SqlDbType.Int);
                    sqlCeCommand.Parameters.Add("@roba_id", SqlDbType.Int);
                    sqlCeCommand.Parameters.Add("@nova_kolicina", SqlDbType.Float);
                    sqlCeCommand.Parameters.Add("@stara_kolicina", SqlDbType.Float);
                    sqlCeCommand.Prepare();
                    for(int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        sqlCeCommand.Parameters["@usklada_id"].Value = dataTable.Rows[i]["@usklada_id"].ToString();
                        sqlCeCommand.Parameters["@roba_id"].Value = dataTable.Rows[i]["@roba_id"].ToString();
                        sqlCeCommand.Parameters["@nova_kolicina"].Value = float.Parse(dataTable.Rows[i]["@nova_kolicina"].ToString());
                        sqlCeCommand.Parameters["@stara_kolicina"].Value = float.Parse(dataTable.Rows[i]["@stara_kolicina"].ToString());
                        sqlCeCommand.ExecuteNonQuery();
                    }
                }
                catch(SqlCeException ex)
                {
                    classSQL.connection.Close();
                    return ex.ToString();
                }
                finally
                {
                    classSQL.connection.Close();
                }
                return "";
            }
            else
            {
                if (classSQL.remoteConnection.State.ToString() == "Closed")
                {
                    classSQL.remoteConnection.Open();
                }
                NpgsqlCommand npgsqlCommand = classSQL.remoteConnection.CreateCommand();
                try
                {
                    for(int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        string CommandText = @"INSERT INTO usklada_robe_stavke(usklada_id,roba_id,nova_kolicina,stara_kolicina) 
                                            VALUES(" + int.Parse(dataTable.Rows[i]["usklada_id"].ToString()) + ","
                                                    + int.Parse(dataTable.Rows[i]["roba_id"].ToString()) + ","
                                                    + float.Parse(dataTable.Rows[i]["nova_kolicina"].ToString()) + ","
                                                    + float.Parse(dataTable.Rows[i]["stara_kolicina"].ToString());
                        NpgsqlCommand comm = new NpgsqlCommand(CommandText, classSQL.remoteConnection);
                        comm.ExecuteNonQuery();
                    }
                }
                catch(NpgsqlException ex)
                {
                    classSQL.connection.Close();
                    return ex.ToString();
                }
                finally
                {
                    classSQL.connection.Close();
                }
                return "";
            }
        }
    }
}
