using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.OleDb;


namespace Capa_Datos
{
    public static class Datos
    {

        private static string strCon;
        private static OleDbCommand cmd = new OleDbCommand();
        private static OleDbDataAdapter da;
        private static OleDbConnection conn;
        private static DataSet ds;

        public static void setConnectionDBPath(string path)
        {
            string databasePath = path + "\\BDDInfraccionesTransito.accdb";
            strCon = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + databasePath;
        }

        //GUARDAR VEHICULO
        public static void GuardarVehiculo(List<string> datosVehiculo)
        {
            string query = "INSERT INTO Vehiculo (Dominio, DniPropietario, Modelo) VALUES (@Dominio, @DniPropietario, @Modelo)";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dominio", datosVehiculo[1]);
                        cmd.Parameters.AddWithValue("@dniPropietario", datosVehiculo[2]);
                        cmd.Parameters.AddWithValue("@modelo", datosVehiculo[3]);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        //RECUPERA VEHICULO
        public static bool RecuperarVehiculoDB(List<ArrayList> vehiculos) //obtener lista de vehiculos desde BDD
        {
            ArrayList vehi;
            string query = "SELECT * FROM Vehiculo";
            try
            {
                conn = new OleDbConnection(strCon);  //Crear instancia de la conexión
                conn.Open();
                da = new OleDbDataAdapter(query, conn); //Ejecuta la query
                ds = new DataSet();
                da.Fill(ds);  //Guardo la data obtenida

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    vehi = new ArrayList();
                    IEnumerator enumerator = ds.Tables[0].Rows[i].ItemArray.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        vehi.Add(enumerator.Current);
                    }
                    vehiculos.Add(vehi);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }







        ////connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath};Persist Security Info=False;";
        public static List<object> getVehiculosDB()
        {
            List<object> vehiculos = new List<object>();
            return vehiculos;
        }
    }
}
