using GitTeamStats.Models;
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
    /// Interaction logic for ProjectView.xaml
    /// </summary>
    public partial class ProjectView : UserControl
    {
        public ProjectVM projectVM = new ProjectVM();
        private Grid container = new Grid();

        public ProjectView()
        {
            InitializeComponent();

            //projectVM.Projects = new List<Project>();
            //projectVM.Projects.Add(new Project("GitTeamStats", "A project to keep track of the "));
            //projectVM.Projects.Add(new Project("GitTeamStats", "A project to keep track of the "));
            //projectVM.Projects.Add(new Project("GitTeamStats", "A project to keep track of the "));
            //projectVM.Projects.Add(new Project("GitTeamStats", "A project to keep track of the "));
            
            //ColumnDefinition c1 = new ColumnDefinition();
            //c1.Width = new GridLength(33, GridUnitType.Star);
            //ColumnDefinition c2 = new ColumnDefinition();
            //c2.Width = new GridLength(33, GridUnitType.Star);
            //ColumnDefinition c3 = new ColumnDefinition();
            //c3.Width = new GridLength(33, GridUnitType.Star);
            //container.ColumnDefinitions.Add(c1);
            //container.ColumnDefinitions.Add(c2);
            //container.ColumnDefinitions.Add(c3);

            //if (projectVM.Projects != null)
            //{
            //    foreach (var project in projectVM.Projects)
            //    {
            //        var grid = new Grid();
            //        grid.Background = Brushes.Green;
            //        grid.Height = 55;
            //        grid.Width = 55;
                    
            //        grid.Children.Add(new Label { Content = project.Name });
            //        grid.Children.Add(new Label { Content = project.Description });
            //        this.Content = grid;
            //    }
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).DataContext = new MainGridVM();
        }
    }
}
