using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class TicketDatos
    {
        public async Task<DataTable> DevolverListaAsync()
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM ticket";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();
                        dt.Load(dr);
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return dt;
        }

        public async Task<bool> InsertarAsync(Ticket ticket)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO ticket VALUES (@idTicket, @Precio, @Descuento, @Impuesto, @Total, @Usuario, @Fecha";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.Int32).Value = ticket.idTicket;
                        comando.Parameters.Add("@Nombre", MySqlDbType.Decimal).Value = ticket.Precio;
                        comando.Parameters.Add("@Clave", MySqlDbType.Decimal).Value = ticket.Descuento;
                        comando.Parameters.Add("@Correo", MySqlDbType.Decimal).Value = ticket.Impuesto;
                        comando.Parameters.Add("@Rol", MySqlDbType.Decimal).Value = ticket.Total;
                        comando.Parameters.Add("@EstActivo", MySqlDbType.VarChar, 50).Value = ticket.Usuario;
                        comando.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = ticket.Fecha;

                        await comando.ExecuteNonQueryAsync();
                        inserto = true;
                    }
                }
            }
            catch (Exception)
            {

            }
            return inserto;
        }

        public async Task<bool> ActualizarAsync(Ticket ticket)
        {
            bool actualizo = false;
            try
            {
                string sql = "UPDATE usuario SET @Precio, @Descuento, @Impuesto, @Total, @Usuario, @Fecha WHERE idTicke=@idTicke;";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.Int32).Value = ticket.idTicket;
                        comando.Parameters.Add("@Nombre", MySqlDbType.Decimal).Value = ticket.Precio;
                        comando.Parameters.Add("@Clave", MySqlDbType.Decimal).Value = ticket.Descuento;
                        comando.Parameters.Add("@Correo", MySqlDbType.Decimal).Value = ticket.Impuesto;
                        comando.Parameters.Add("@Rol", MySqlDbType.Decimal).Value = ticket.Total;
                        comando.Parameters.Add("@EstActivo", MySqlDbType.VarChar, 50).Value = ticket.Usuario;
                        comando.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = ticket.Fecha;

                        await comando.ExecuteNonQueryAsync();
                        actualizo = true;
                    }
                }
            }
            catch (Exception)
            {

            }
            return actualizo;

        }

        public async Task<bool> EliminarAsync(string idTicket)
        {
            bool elimino = false;
            try
            {
                string sql = "DELET FROM usuario WHERE idTicket = @idTicket;";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@idTicket", MySqlDbType.VarChar, 20).Value = idTicket;

                        await comando.ExecuteNonQueryAsync();
                        elimino = true;
                    }
                }
            }
            catch (Exception)
            {

            }
            return elimino;

        }

        public async Task<Ticket> GetPorTicket(int idTicket)
        {
            Ticket ticket = new Ticket();
            try
            {
                string sql = "SELECT * FROM ticket WHERE idTicket = @idTicket;";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@idTicket", MySqlDbType.Int32).Value = idTicket;

                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();
                        if (dr.Read())
                        {
                            
                            ticket.idTicket = Convert.ToInt32(dr["idTicket"]);
                            ticket.Usuario = dr["Usuario"].ToString();
                            ticket.Precio = Convert.ToInt32(dr["Precio"]);
                            ticket.Impuesto = Convert.ToInt32(dr["Impuesto"]);
                            ticket.Descuento = Convert.ToInt32(dr["Descuento"]);
                            ticket.Total = Convert.ToInt32(dr["Total"]);
                               
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            return ticket;
        }
    }
}
