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
    /// Interaction logic for MainGridView.xaml
    /// </summary>
    public partial class MainGridView : UserControl
    {
        public MainGridVM Contributors { get; set; }

        public MainGridView()
        {
            InitializeComponent();

            Contributors = new MainGridVM();
            Contributors.contributors = new List<CustomContributor>();
            List<string> commits = new List<string>();
            commits.Add("commitA");
            commits.Add("commitB");
            commits.Add("commitC");
            commits.Add("commitD");
            Contributors.contributors.Add(new CustomContributor("Bob", "Bob@Bob.com", "A test Commit", commits));
            Contributors.contributors.Add(new CustomContributor("Jim", "Jim@Jim.com", "A test Commit", commits));
            Contributors.contributors.Add(new CustomContributor("Joe", "Joe@Joe.com", "A test Commit", commits));
            Contributors.contributors.Add(new CustomContributor("George", "George@George.com", "A test Commit", commits));
        }

        private void Button_GraphClick(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).DataContext = new GraphVM();
        }

        private void Button_CompareClick(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).DataContext = new CompareVM();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }
    }
}
