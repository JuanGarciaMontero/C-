using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace GestionPedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Conexion a BD SQL Server. Primero añadir Origen de datos la BD

            string miConexion = ConfigurationManager.ConnectionStrings["GestionPedidos.Properties.Settings.Gestion_PedidosConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);

            MuestraClientes();

            MuestraTodosPedidos();

        }

        private void MuestraClientes()
        {

            try
            {
                string consulta = "SELECT * FROM Cliente";

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

                using (miAdaptadorSql)
                {
                    DataTable clientesTabla = new DataTable();

                    miAdaptadorSql.Fill(clientesTabla);

                    listaClientes.DisplayMemberPath = "nombre";
                    listaClientes.SelectedValuePath = "Id";
                    listaClientes.ItemsSource = clientesTabla.DefaultView;

                }
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void MuestraPedidos()
        {

            try
            {

                // Consulta Paramétrica. Pasar al adaptador al nuevo comando para tratar la consulta paramétrica

                string consulta = "SELECT * FROM Pedido P INNER JOIN Cliente C ON C.Id = P.cCliente WHERE C.Id = @ClienteId";

                // SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

                SqlCommand sqlComando = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);


                using (miAdaptadorSql)
                {

                    // Con el método AddWithValue eleguimos que valor mostramos en nuestro caso con @ClienteId
                    // Al elegir el cliente por id muestra la fecha del pedido

                    sqlComando.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);

                    DataTable pedidosTabla = new DataTable();

                    miAdaptadorSql.Fill(pedidosTabla);

                    pedidosCliente.DisplayMemberPath = "fechaPedido";
                    pedidosCliente.SelectedValuePath = "Id";
                    pedidosCliente.ItemsSource = pedidosTabla.DefaultView;

                }
            }catch(Exception e)
            {

                MessageBox.Show(e.ToString());

            }
        }

        private void MuestraTodosPedidos()
        {

            try
            {

                // Consulta SQL de Campo nuevo calculado

                string consulta = "SELECT *, CONCAT(cCliente, ' ' , fechaPedido, ' ' , formaPago) AS INFOCOMPLETA FROM Pedido";

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

                using (miAdaptadorSql)
                {

                    DataTable pedidosTabla = new DataTable();

                    miAdaptadorSql.Fill(pedidosTabla);

                    todosPedidos.DisplayMemberPath = "INFOCOMPLETA";
                    todosPedidos.SelectedValuePath = "Id";
                    todosPedidos.ItemsSource = pedidosTabla.DefaultView;


                }
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }


        /*private void listaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // MessageBox.Show("Has hecho click en un cliente");

            MuestraPedidos();
        }*/

        SqlConnection miConexionSql;

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                // MessageBox.Show(todosPedidos.SelectedValue.ToString());

                string consulta = "DELETE FROM Pedido WHERE Id=@PEDIDOID";

                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

                miConexionSql.Open();

                miSqlCommand.Parameters.AddWithValue("@PEDIDOID", todosPedidos.SelectedValue);

                miSqlCommand.ExecuteNonQuery();

                MuestraTodosPedidos();

                MuestraPedidos();

                miConexionSql.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

                // MessageBox.Show(todosPedidos.SelectedValue.ToString());

                string consulta = "INSERT INTO Cliente (nombre) VALUES (@nombre)";

                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

                miConexionSql.Open();

                //  Con la siguiente instrucción se dice que coja el nombre(texto) del Label "insertaCliente y lo lleve a la variable @nombre para que con la sentencia SQL inserte el registro.

                miSqlCommand.Parameters.AddWithValue("@nombre", insertaCliente.Text);

                miSqlCommand.ExecuteNonQuery();

                MuestraClientes();

                miConexionSql.Close();

                // Borrar despues de insertar lo que hay en el label

                insertaCliente.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {

                // MessageBox.Show(todosPedidos.SelectedValue.ToString());

                string consulta = "DELETE FROM Cliente WHERE Id=@CLIENTEID";

                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

                miConexionSql.Open();

                miSqlCommand.Parameters.AddWithValue("@CLIENTEID", listaClientes.SelectedValue);

                miSqlCommand.ExecuteNonQuery();

                MuestraTodosPedidos();

                MuestraPedidos();

                MuestraClientes();

                miConexionSql.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listaClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MuestraPedidos();
        }
    }
}
