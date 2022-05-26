using CRMobster.View;
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

namespace CRMobster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        UserControlDados user1;
        UserControlDados2 user2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            ClientesView clienteView = new ClientesView();

            clienteView.Show();
        }



        //internal void SwitchScreen(object sender)
        //{
        //    var screen = ((UserControl)sender);

        //    if (screen != null)
        //    {
        //        gridSecundario.Children.Clear();
        //        gridSecundario.Children.Add(screen);
        //    }
        //}

        private void btnProdutos_Click(object sender, RoutedEventArgs e)
        {
            
            if (user2 == null)
            {
                user2 = new UserControlDados2();
                gridSecundario.Children.Clear();
                gridSecundario.Children.Add(user2);
            }
            else
            {
                gridSecundario.Children.Clear();
                user2.Visibility = Visibility.Visible;
            }
        }
    }
}
