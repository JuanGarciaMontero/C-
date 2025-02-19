﻿using System;
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

namespace ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> listaPob = new List<Poblaciones>();

            listaPob.Add(new Poblaciones() { Poblacion1="Madrid", Poblacion2="Barcelona", Temperatura1=15, Temperatura2=17, DiferenciaTem=2});

            listaPob.Add(new Poblaciones() { Poblacion1 = "Valencia", Poblacion2 = "Alicante", Temperatura1=19, Temperatura2=22, DiferenciaTem=3});

            listaPob.Add(new Poblaciones() { Poblacion1 = "Málaga", Poblacion2 = "Bilbao", Temperatura1=20, Temperatura2=14, DiferenciaTem=6});

            listaPob.Add(new Poblaciones() { Poblacion1 = "Sevilla", Poblacion2 = "Coruña", Temperatura1=22, Temperatura2=12, DiferenciaTem=10});


            listaPoblaciones.ItemsSource = listaPob;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (listaPoblaciones.SelectedItem != null) { 

                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + " ºC " + "  <--->  " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + " ºC " + "\n" + "La diferencia de temperaturas es: " + (listaPoblaciones.SelectedItem as Poblaciones).DiferenciaTem + " ºC ");
            }
            else
            {
                MessageBox.Show("Selecciona primero un elemento");
            }
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {

                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + " ºC " + "  <--->  " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + " ºC " + "\n" + "La diferencia de temperaturas es: " + (listaPoblaciones.SelectedItem as Poblaciones).DiferenciaTem + " ºC ");
            }
            else
            {
                MessageBox.Show("Selecciona primero un elemento. Pincha en la barra de diferencias para selccionar");
            }
        }
    }

    public class Poblaciones
    {

        public string Poblacion1 { get; set; }

        public int Temperatura1 { get; set; }

        public string Poblacion2 { get; set; }

        public int Temperatura2 { get; set; }

        public int DiferenciaTem { get; set; }


    }
}
