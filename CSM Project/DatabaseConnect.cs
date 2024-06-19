using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CSM_Project
{
    //public static string connectionString => "server=localhost:3306;database=GaraDB;user=root;password=huouthicao&voithito";
    internal class DatabaseConnect
    {
        private static readonly string connectionString = "server=127.0.0.1;database=GaraDB;user=root;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static DataTable ExecuteQuery(string query, MySqlParameter[] parameters = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static void ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
