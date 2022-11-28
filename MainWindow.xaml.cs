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
using System.Collections.ObjectModel;

namespace WpfApp17
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Binding b = new Binding();
            b.Source = sldSource;
            b.Path = new PropertyPath("Value");
            b.Mode = BindingMode.TwoWay;
            txtTarget.SetBinding(TextBlock.FontSizeProperty, b);

        }

        private void btnLarge_Click(object sender, RoutedEventArgs e)
        {
            txtTarget.FontSize = 60;
        }

        private void btnNormal_OnClick(object sender, RoutedEventArgs e)
        {
            sldSource.Value = 30;
        }

        private void MainWindow_OnUnloaded(object sender, RoutedEventArgs e)
        {
            BindingOperations.ClearAllBindings(txtTarget);
            //или
            BindingOperations.ClearBinding(txtTarget, TextBlock.FontSizeProperty);
        }
    }
}
