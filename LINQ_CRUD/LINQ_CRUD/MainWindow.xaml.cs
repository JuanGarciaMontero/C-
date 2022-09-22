using LINQ_CRUD.Gestion_PedidosDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.IO;
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

            //InsertaEmpleados();

            //InsertaCargos();

            //InsertaEmpleadoCargo();

            //ActualizaEmpleado();

            ElimanaEmpleado();

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

        public void InsertaCargos()
        {
            dataContext.Cargo.InsertOnSubmit(new Cargo { NombreCampo = "Director/a" });

            dataContext.Cargo.InsertOnSubmit(new Cargo { NombreCampo = "Administrativo/a" });

            dataContext.SubmitChanges();

            Principal.ItemsSource=dataContext.Cargo;
        }

        public void InsertaEmpleadoCargo()
        {
            /*Empleado Juan=dataContext.Empleado.First(em =>em.Nombre.Equals("Juan"));*/

           /* Empleado Ana = dataContext.Empleado.First(em => em.Nombre.Equals("Ana"));

            Empleado Maria = dataContext.Empleado.First(em => em.Nombre.Equals("María"));

            Empleado Antonio = dataContext.Empleado.First(em => em.Nombre.Equals("Antonio"));

            Cargo cDirector = dataContext.Cargo.First(cg => cg.NombreCampo.Equals("Director/a"));
           
            Cargo cAdtvo= dataContext.Cargo.First(cg => cg.NombreCampo.Equals("Administrativo/a"));
           */

            /*
            CargoEmpleado cargoJuan = new CargoEmpleado();

            cargoJuan.Empleado = Juan;

            cargoJuan.CargoId = cDirector.Id;
            */

            
            // Lo mismo todo junto con Nombre y cargo. 

            List<CargoEmpleado> listaCargoEmpleados = new List<CargoEmpleado>();

            listaCargoEmpleados.Add(new CargoEmpleado {Empleado= dataContext.Empleado.First(em => em.Nombre.Equals("Ana")),
            Cargo= dataContext.Cargo.First(cg => cg.NombreCampo.Equals("Director/a"))});

            listaCargoEmpleados.Add(new CargoEmpleado {Empleado= dataContext.Empleado.First(em => em.Nombre.Equals("María")),
            Cargo= dataContext.Cargo.First(cg => cg.NombreCampo.Equals("Administrativo/a"))});

            listaCargoEmpleados.Add(new CargoEmpleado {Empleado= dataContext.Empleado.First(em => em.Nombre.Equals("Antonio")),
            Cargo= dataContext.Cargo.First(cg => cg.NombreCampo.Equals("Director/a"))});


            // Lo mismo teniendo los Nombre y el cargo

            /* listaCargoEmpleados.Add(new CargoEmpleado { Empleado = Ana, Cargo = cDirector });

             listaCargoEmpleados.Add(new CargoEmpleado { Empleado = Maria, Cargo = cAdtvo });

             listaCargoEmpleados.Add(new CargoEmpleado { Empleado = Antonio, Cargo = cDirector });
            */


            // Sabiendo los Id Cargo y Id Empleados

            /*listaCargoEmpleados.Add(new CargoEmpleado { CargoId=1, EmpleadoId=2});

            listaCargoEmpleados.Add(new CargoEmpleado { CargoId = 2, EmpleadoId =3});

            listaCargoEmpleados.Add(new CargoEmpleado { CargoId = 1, EmpleadoId = 4});
            */

            dataContext.CargoEmpleado.InsertAllOnSubmit(listaCargoEmpleados);


            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.CargoEmpleado;


        
        }

        public void ActualizaEmpleado()
        {
            Empleado Maria = dataContext.Empleado.First(em => em.Nombre.Equals("María"));

            Maria.Nombre = "María Angeles";

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.Empleado;

        }

        public void ElimanaEmpleado()
        {
            Empleado Juan = dataContext.Empleado.First(em => em.Nombre.Equals("Juan"));

            dataContext.Empleado.DeleteOnSubmit(Juan);


            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.Empleado;

        }



    }
     
}
