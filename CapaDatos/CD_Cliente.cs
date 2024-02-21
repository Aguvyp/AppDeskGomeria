using CapaEntidad;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Cliente
    {
        string cadenaconexion = "Server=127.0.0.1;User id=root;Password=Agu43766205;Port=3306;database=gomeria";

        public void Crear(CE_Cliente cl)
        {
            MySqlConnection myConecction = new MySqlConnection(cadenaconexion);
            myConecction.Open();

            string Query = "INSERT INTO Cliente (Nombre, Localidad, Telefono, Vehiculo, TrabajoRealizado) VALUES " +
                            "('" + cl.Nombre + "','" + cl.Localidad + "','" + cl.Telefono + "','" + cl.Vehiculo + "','" + cl.TrabajoRealizado + "');";

            MySqlCommand mySqlCommand = new MySqlCommand(Query, myConecction);
            mySqlCommand.ExecuteNonQuery();
            myConecction.Close();
            MessageBox.Show("Cliente creado");
        }

        public void Editar(CE_Cliente cl)
        {
            MySqlConnection mySqlConecction = new MySqlConnection(cadenaconexion);
            mySqlConecction.Open();

            string Query = "UPDATE Cliente SET Nombre='" + cl.Nombre + "', Localidad='" + cl.Localidad + "', Telefono='" + cl.Telefono + "', Vehiculo='" + cl.Vehiculo + "', TrabajoRealizado='" + cl.TrabajoRealizado + "';";

            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConecction);
            mySqlCommand.ExecuteNonQuery();
            mySqlConecction.Close();
            MessageBox.Show("Edicion completada");
        }

        public void Eliminar(CE_Cliente cl)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaconexion);
            mySqlConnection.Open();

            string QUery = "DELETE FROM Cliente WHERE IdCliente=" + cl.IdCliente + ";";
            MySqlCommand mysqlCommand = new MySqlCommand(QUery, mySqlConnection);
            mysqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Cliente eliminado");
        }

        public DataSet Listar()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaconexion);
            mySqlConnection.Open();

            string Query = "SELECT * FROM Cliente";

            MySqlDataAdapter adaptador;
            DataSet dataSet = new DataSet();
            adaptador = new MySqlDataAdapter(Query, mySqlConnection);
            adaptador.Fill(dataSet, "table");

            return dataSet;
        }

        public DataSet Filtrar(CE_Cliente cl)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaconexion);
            mySqlConnection.Open();

            string Query = "SELECT * FROM Cliente WHERE Nombre LIKE '%" + cl.Filtro + "%';";

            MySqlDataAdapter adaptador;
            DataSet dataSet = new DataSet();
            adaptador = new MySqlDataAdapter(Query, mySqlConnection);
            adaptador.Fill(dataSet, "table");

            mySqlConnection.Close();

            return dataSet;
        }

        public DataSet BuscarPorID(CE_Cliente cl)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaconexion);
            mySqlConnection.Open();

            string Query = "SELECT * FROM Cliente WHERE IdCLiente =" + cl.IdCliente + ";";

            MySqlDataAdapter adaptador;
            DataSet dataSet = new DataSet();
            adaptador = new MySqlDataAdapter(Query, mySqlConnection);
            adaptador.Fill(dataSet, "table");

            mySqlConnection.Close();

            return dataSet;
        }
    }
}
