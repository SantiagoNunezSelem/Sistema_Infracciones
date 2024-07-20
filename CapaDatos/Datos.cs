using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;


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
            string databasePath = path + "\\Sistema_Infracciones_DB.mdb";
            strCon = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + databasePath;
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
                        cmd.Parameters.AddWithValue("@Dominio", datosVehiculo[0]);
                        cmd.Parameters.AddWithValue("@DniPropietario", datosVehiculo[1]);
                        cmd.Parameters.AddWithValue("@Modelo", datosVehiculo[2]);

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

        public static int getIdInfraccion(string codigo)
        {
            int id = -1;
            try
            {
                using (OleDbConnection connection = new OleDbConnection(strCon))
                {
                    connection.Open();

                    string deletePagosQuery = "SELECT Id FROM Infraccion WHERE Codigo = @Codigo";

                    using (OleDbCommand command = new OleDbCommand(deletePagosQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Codigo", codigo);
                        id = command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch
            {

            }
            return id;
            
        }

        public static bool eliminarTipoInfraccion(string codigo)
        {
            //Obtener el id de la infracción en la DB
            string idInfraccion = getIdInfraccion(codigo);

            try
            {
                using (OleDbConnection connection = new OleDbConnection(strCon))
                {
                    connection.Open();

                    // Paso 1: Eliminar los pagos de infracción asociados
                    string deletePagosQuery = "DELETE FROM PagoInfraccion WHERE idInfraccion = @idInfraccion";

                    using (OleDbCommand command = new OleDbCommand(deletePagosQuery, connection))
                    {
                        command.Parameters.AddWithValue("@idInfraccion", idInfraccion);
                        command.ExecuteNonQuery();
                    }

                    // Paso 2: Eliminar la infracción
                    string deleteInfraccionQuery = "DELETE FROM Infraccion WHERE id = @idInfraccion";

                    using (OleDbCommand command = new OleDbCommand(deleteInfraccionQuery, connection))
                    {
                        command.Parameters.AddWithValue("@idInfraccion", idInfraccion);
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
