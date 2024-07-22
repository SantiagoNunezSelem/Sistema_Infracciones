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
            string idInfraccion = "" + getIdInfraccion(codigo);

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

        // GUARDAR INFRACCION
        public static void GuardarInfraccion(List<string> datosInfraccion)
        {
            string query = "INSERT INTO Infraccion (codigo, nombre, descripcion, importe, esGrave) VALUES (@codigo, @nombre, @descripcion, @importe, @esGrave)";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", datosInfraccion[1]);
                        cmd.Parameters.AddWithValue("@Nombre", datosInfraccion[2]);
                        cmd.Parameters.AddWithValue("@Descripcion", datosInfraccion[3]);
                        cmd.Parameters.AddWithValue("@Importe", Convert.ToDecimal(datosInfraccion[4]));
                        cmd.Parameters.AddWithValue("@EsGrave", Convert.ToBoolean(datosInfraccion[5]));

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        //RECUPERAR INFRACCION
        public static bool RecuperarInfraccionDB(List<ArrayList> infracciones) //obtener lista de tipos de infracciones desde BDD
        {
            ArrayList infra;
            string query = "SELECT * FROM Infraccion";
            try
            {
                conn = new OleDbConnection(strCon);  //Crear instancia de la conexión
                conn.Open();
                da = new OleDbDataAdapter(query, conn); //Ejecuta la query
                ds = new DataSet();
                da.Fill(ds);  //Guardo la data obtenida

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    infra = new ArrayList();
                    IEnumerator enumerator = ds.Tables[0].Rows[i].ItemArray.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        infra.Add(enumerator.Current);
                    }
                    infracciones.Add(infra);
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

        //GUARDAR PAGO INFRACCION
        public static void GuardarPagoInfraccion(List<string> datosPagoInfraccion)
        {
            string query = "INSERT INTO PagoInfraccion (id, idInfraccion, idVehiculo, fechaInfraccion, importePagado, pagoCompletado) " +
                           "VALUES (@id, @idInfraccion, @idVehiculo, @fechaInfraccion, @importePagado, @pagoCompletado)";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idInfraccion", datosPagoInfraccion[1]);
                        cmd.Parameters.AddWithValue("@idVehiculo", datosPagoInfraccion[2]);
                        cmd.Parameters.AddWithValue("@fechaInfraccion", datosPagoInfraccion[3]);
                        cmd.Parameters.AddWithValue("@importePagado", datosPagoInfraccion[4]);
                        cmd.Parameters.AddWithValue("@pagoCompletado", datosPagoInfraccion[5]);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        //RECUPERAR PAGO INFRACCION
        public static bool RecuperarPagoInfraccionDB(List<ArrayList> pagos)
        {
            ArrayList pago;
            string query = "SELECT * FROM PagoInfraccion";
            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open();
                    using (OleDbDataAdapter da = new OleDbDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);  // Guardo la data obtenida

                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            pago = new ArrayList();
                            IEnumerator enumerator = ds.Tables[0].Rows[i].ItemArray.GetEnumerator();
                            while (enumerator.MoveNext())
                            {
                                pago.Add(enumerator.Current);
                            }
                            pagos.Add(pago);
                        }

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }



    }

}



