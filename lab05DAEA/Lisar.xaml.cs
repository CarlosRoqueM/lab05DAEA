using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab05DAEA
{
    /// <summary>
    /// Lógica de interacción para Lisar.xaml
    /// </summary>
    public partial class Lisar : Window
    {
        public Lisar()
        {
            InitializeComponent();
            CargaDatos();
        }

        private void CargaDatos()
        {
            string ConnectionString = "Data Source= LAB1504-04\\SQLEXPRESS; Initial Catalog=lab05;" + "User Id = Carlos; Password=123456";

            List<Cliente> clientes = new List<Cliente>();

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("lisarClientes2", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string idCliente = reader.GetString("idCliente");
                    string NombreCompañia = reader.GetString("NombreCompañia");
                    string? NombreContacto = reader.GetString("NombreCompañia");
                    string? Direccion = reader.GetString("Direccion");
                    //string Region = reader.GetString("Region");
                    string? CodPostal = reader.GetString("CodPostal");
                    string? Pais = reader.GetString("Pais");
                    string? Telefono = reader.GetString("Telefono");
                    //string Fax = reader.GetString("Fax");


                    clientes.Add(new Cliente { idCliente = idCliente, NombreCompañia = NombreCompañia, NombreContacto = NombreContacto, Direccion = Direccion, CodPostal = CodPostal, Pais = Pais, Telefono  = Telefono });

                  
                }
                connection.Close();

                Number01.ItemsSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
