using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOAP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        SqlConnection con;

        private SqlConnection conectar()
        {
            try
            {
                string connectionString = "SERVER=DESKTOP-18G7NRO\\SQLEXPRESS; DATABASE=SOAPBD; Integrated Security=True;";

                con = new SqlConnection(connectionString);
                con.Open();

            }
            catch (Exception ex)
            {
                throw;
            }

            return con;
        }

        public DataSet SP_LISTARPRODUCTO()
        {
            try
            {

                conectar();
                DataSet DST = new DataSet();
                SqlDataAdapter DA = new SqlDataAdapter("SP_LISTARPRODUCTO", conectar());
                DA.Fill(DST, "product");
                con.Close();
                return DST;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en SP_LISTARPRODUCTO: {ex.Message}");
                return null;
            }
           

        }

        public void SP_INSERTARPRODUCTO(Producto prod)
        {           

            conectar();
            SqlCommand cmd = new SqlCommand("SP_INSETARPRODUCTO", conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            cmd.Parameters.Add("@detail", SqlDbType.VarChar).Value = prod.detail;
            cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = prod.quantity;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = prod.price;
            cmd.Parameters.Add("@dates", SqlDbType.Date).Value = prod.dates;

            try {
            
                cmd.ExecuteNonQuery();
                con.Close();

            } catch(Exception) { 
                
            }
        }

        public void SP_ACTUALIZARPRODUCTO(Producto prod)
        {
            conectar();
            SqlCommand cmd = new SqlCommand("SP_ACTUALIZARPRODUCTO", conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = prod.id;
            cmd.Parameters.Add("@detail", SqlDbType.VarChar).Value = prod.detail;
            cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = prod.quantity;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = prod.price;
            cmd.Parameters.Add("@dates", SqlDbType.Date).Value = prod.dates;

            try
            {

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception)
            {

            }
        }

        public void SP_ELIMINARPRODUCTO(Producto prod)
        {
            conectar();
            SqlCommand cmd = new SqlCommand("SP_ELIMINARPRODUCTO", conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = prod.id;

            try
            {

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception)
            {

            }
        }

        public DataSet SP_BUSCARPRODUCTO(Producto prod)
        {

            conectar();
            DataSet DST = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter("SP_BUSCARPRODUCTO", conectar());
            DA.SelectCommand.CommandType = CommandType.StoredProcedure;
            DA.SelectCommand.Parameters.Add("@letra", SqlDbType.VarChar).Value = prod.detail;
            DA.Fill(DST, "product");
            con.Close();
            return DST;

        }

    }

}
