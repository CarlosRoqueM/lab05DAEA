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
using System.Windows.Shapes;

namespace lab05DAEA
{
    /// <summary>
    /// Lógica de interacción para Opciones.xaml
    /// </summary>
    public partial class Opciones : Window
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void ListarBtn_Click(object sender, RoutedEventArgs e)
        {
            Lisar listar = new Lisar();
            listar.Show();
            Close();
        }

        private void EliminarBtn_Click(object sender, RoutedEventArgs e)
        {
            Eliminar eliminar = new Eliminar();
            eliminar.Show();
            Close();
        }

        private void InsertarBtn_Click(object sender, RoutedEventArgs e)
        {
            Crear crear = new Crear();  
            crear.Show();   
            Close();
        }
    }
}
