using LINQ_CRUD.Gestion_PedidosDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
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


namespace LINQ_CRUD
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DataClasses1DataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();
            string miConexion = ConfigurationManager.ConnectionStrings[
                           "LINQ_CRUD.Properties.Settings.LinqCrudSql"
                           ].ConnectionString;

            dataContext = new DataClasses1DataContext(miConexion);

            //InsertaEmpresas();

            InsertaEmpleados();

        }

        public void InsertaEmpresas()
        {

            // Temporalmente. Antes de insertar las tabla borralas para que no se dupliquen

            //dataContext.ExecuteCommand("delete from Empresa");


            Empresa pildorasInformaticas = new Empresa();

            pildorasInformaticas.Nombre = "Píldoras Informáticas";

            // Insertamos el registro

            dataContext.Empresa.InsertOnSubmit(pildorasInformaticas);

            // Añado una nueva empresa

            Empresa empresaGoogle = new Empresa();

            empresaGoogle.Nombre = "Google";

            dataContext.Empresa.InsertOnSubmit(empresaGoogle);




            dataContext.SubmitChanges();

            // Mostramos en el grid de Xaml de WPF

            Principal.ItemsSource = dataContext.Empresa;
        }

        public void InsertaEmpleados()
        {
            Empresa pildorasInformaticas = dataContext.Empresa.First(em => em.Nombre.Equals("Píldoras Informáticas"));

            Empresa empresaGoogle = dataContext.Empresa.First(em => em.Nombre.Equals("Google"));

            List<Empleado> listaEmpleados = new List<Empleado>();

            listaEmpleados.Add(new Empleado { Nombre = "Juan", Apellido = "García", EmpresaId = pildorasInformaticas.Id });

            listaEmpleados.Add(new Empleado { Nombre = "Ana", Apellido = "Martín", EmpresaId = empresaGoogle.Id });

            listaEmpleados.Add(new Empleado { Nombre = "María", Apellido = "López", EmpresaId = empresaGoogle.Id });

            listaEmpleados.Add(new Empleado { Nombre = "Antonio", Apellido = "Fernández", EmpresaId = pildorasInformaticas.Id });


            dataContext.Empleado.InsertAllOnSubmit(listaEmpleados);

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.Empleado;


        }
    }
     
}
