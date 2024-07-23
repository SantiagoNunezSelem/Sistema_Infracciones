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

        public static int getIdInfraccionDB(string codigo)
        {
            int id = -1;
            try
            {
                using (OleDbConnection connection = new OleDbConnection(strCon))
                {
                    connection.Open();

                    string selectIdQuery = "SELECT Id FROM Infraccion WHERE Codigo = @Codigo";

                    using (OleDbCommand command = new OleDbCommand(selectIdQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Codigo", codigo);
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            id = Convert.ToInt32(result);
                        }
                    }
                    
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return id;
        }

        public static int getIdVehiculoDB(string dominio)
        {
            int id = -1;
            try
            {
                using (OleDbConnection connection = new OleDbConnection(strCon))
                {
                    connection.Open();

                    string selectIdQuery = "SELECT Id FROM Vehiculo WHERE Dominio = @Dominio";

                    using (OleDbCommand command = new OleDbCommand(selectIdQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Dominio", dominio);
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            id = Convert.ToInt32(result);
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return id;
        }

        public static int getDominioVehiculoDB(string idVehiculo)
        {
            int dominio = -1;
            try
            {
                using (OleDbConnection connection = new OleDbConnection(strCon))
                {
                    connection.Open();

                    string selectIdQuery = "SELECT Dominio FROM Vehiculo WHERE Id = @IdVehiculo";

                    using (OleDbCommand command = new OleDbCommand(selectIdQuery, connection))
                    {
                        command.Parameters.AddWithValue("@IdVehiculo", idVehiculo);
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            dominio = Convert.ToInt32(result);
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dominio;
        }

        public static int getCodigoInfraccionDB(string idInfraccion)
        {
            int codigo = -1;
            try
            {
                using (OleDbConnection connection = new OleDbConnection(strCon))
                {
                    connection.Open();

                    string selectIdQuery = "SELECT Codigo FROM Infraccion WHERE Id = @IdInfraccion";

                    using (OleDbCommand command = new OleDbCommand(selectIdQuery, connection))
                    {
                        command.Parameters.AddWithValue("@IdInfraccion", idInfraccion);
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            codigo = Convert.ToInt32(result);
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return codigo;
        }

        public static bool updateDataTipoInfraccion(ArrayList infraccion)
        {
            if (infraccion.Count != 4) // Verifica que el array contenga exactamente 4 elementos
            {
                return false;
            }

            string query = "UPDATE Infraccion SET nombre = @Nombre, descripcion = @Descripcion, importe = @Importe WHERE codigo = @Codigo";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", infraccion[1]);
                        cmd.Parameters.AddWithValue("@Descripcion", infraccion[2]);
                        cmd.Parameters.AddWithValue("@Importe", infraccion[3]);
                        cmd.Parameters.AddWithValue("@Codigo", infraccion[0]);

                        cmd.ExecuteNonQuery();
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

        public static bool eliminarTipoInfraccion(string codigo)
        {
            //Obtener el id de la infracción en la DB
            string idInfraccion = getIdInfraccionDB(codigo).ToString();

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
            string query = "INSERT INTO Infraccion (codigo, nombre, descripcion, importe, tipo) VALUES (@codigo, @nombre, @descripcion, @importe, @esGrave)";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", datosInfraccion[0]);
                        cmd.Parameters.AddWithValue("@nombre", datosInfraccion[1]);
                        cmd.Parameters.AddWithValue("@descripcion", datosInfraccion[2]);
                        cmd.Parameters.AddWithValue("@importe", Convert.ToDecimal(datosInfraccion[3]));
                        //cmd.Parameters.AddWithValue("@tipo", Convert.ToBoolean(datosInfraccion[4]));

                        // Convertir el valor del tipo a un booleano y luego a una cadena adecuada para la base de datos.
                        bool esLeve = datosInfraccion[4].Equals("leve", StringComparison.OrdinalIgnoreCase);
                        string tipoInfraccion = esLeve ? "leve" : "grave";
                        cmd.Parameters.AddWithValue("@tipo", tipoInfraccion);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar la infracción: " + ex.Message);
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
        public static bool GuardarPagoInfraccion(List<string> datosPagoInfraccion)
        {
            if (datosPagoInfraccion.Count != 6) // Verifica que el array contenga exactamente 5 elementos
            {
                return false;
            }

            string idInfraccion = getIdInfraccionDB(datosPagoInfraccion[1]).ToString();

            string idVehiculo = getIdVehiculoDB(datosPagoInfraccion[2]).ToString();

            string query = "INSERT INTO PagoInfraccion (Id, idInfraccion, idVehiculo, fechaInfraccion, importePagado, pagoCompletado) " +
                           "VALUES (@idPago, @idInfraccion, @idVehiculo, @fechaInfraccion, @importePagado, @pagoCompletado)";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idInfraccion", datosPagoInfraccion[0]);
                        cmd.Parameters.AddWithValue("@idInfraccion", idInfraccion);
                        cmd.Parameters.AddWithValue("@idVehiculo", idVehiculo);
                        cmd.Parameters.AddWithValue("@fechaInfraccion", Convert.ToDateTime(datosPagoInfraccion[3]));
                        cmd.Parameters.AddWithValue("@importePagado", Convert.ToDecimal(datosPagoInfraccion[4]));
                        cmd.Parameters.AddWithValue("@pagoCompletado", Convert.ToBoolean(datosPagoInfraccion[5]));

                        cmd.ExecuteNonQuery();
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

        public static bool updatePagoInfraccion(List<string> data)
        {
            if (data.Count != 6) // Verifica que el array contenga exactamente 6 elementos
            {
                return false;
            }

            string query = "UPDATE PagoInfraccion SET importePagado = @ImportePagado, pagoCompletado = @PagoCompletado WHERE Id = @IdPago";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ImportePagado", Convert.ToDecimal(data[4]));
                        cmd.Parameters.AddWithValue("@PagoCompletado", Convert.ToBoolean(data[5]));
                        cmd.Parameters.AddWithValue("@IdPago", data[0]);

                        cmd.ExecuteNonQuery();
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

        public static bool eliminarPagoInfraccion(string idPago)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(strCon))
                {
                    connection.Open();

                    string deletePagosQuery = "DELETE FROM PagoInfraccion WHERE Id = @idPago";

                    using (OleDbCommand command = new OleDbCommand(deletePagosQuery, connection))
                    {
                        command.Parameters.AddWithValue("@idPago", idPago);
                        command.ExecuteNonQuery();
                    }
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



