using GitTeamStats.ViewModels;
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

namespace GitTeamStats.Views
{
    /// <summary>
    /// Interaction logic for CompareView.xaml
    /// </summary>
    public partial class CompareView : UserControl
    {
        public CompareView()
        {
            InitializeComponent();
        }

        private void Button_GraphClick(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).DataContext = new GraphVM();
        }

        private void Button_MainGridClick(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).DataContext = new MainGridVM();
        }
    }
}
