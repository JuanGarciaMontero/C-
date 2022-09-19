using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace GestionPedidos
{
    /// <summary>
    /// Lógica de interacción para Actualiza.xaml
    /// </summary>
    public partial class Actualiza : Window
    {

        private int z;

        public Actualiza(int elId)
        {
            InitializeComponent();

            z = elId;

            string miConexion = ConfigurationManager.ConnectionStrings["GestionPedidos.Properties.Settings.Gestion_PedidosConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                // MessageBox.Show(todosPedidos.SelectedValue.ToString());

                string consulta = "UPDATE Cliente SET nombre=@nombre WHERE Id=" + z;

                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

                miConexionSql.Open();

                //  Con la siguiente instrucción se dice que coja el nombre(texto) del Label "insertaCliente y lo lleve a la variable @nombre para que con la sentencia SQL inserte el registro.

                miSqlCommand.Parameters.AddWithValue("@nombre", cuadroActualiza.Text);

                miSqlCommand.ExecuteNonQuery();

                miConexionSql.Close();

                // Cierra la ventana actual

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        SqlConnection miConexionSql;
    }
}
