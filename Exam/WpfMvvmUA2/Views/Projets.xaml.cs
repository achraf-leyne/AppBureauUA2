using System.Windows;
using System.Windows.Controls;
using WpfMvvmUA2.ViewModel;

namespace WpfMvvmUA2.Views
{
    public partial class Projets : Page
    {
        private readonly ProjetsViewModel _viewModel;

        public Projets()
        {
            InitializeComponent();
            _viewModel = new ProjetsViewModel();
            DataContext = _viewModel;
        }

        private void OpenAddProjetsWindow()
        {
            // Créer une instance d'AddProjectViewModel avec le ViewModel de Projets
            var addProjectViewModel = new AddProjectViewModel(_viewModel); 
            var addProjetsWindow = new AddProjets(addProjectViewModel); // Passez addProjectViewModel au constructeur
            addProjetsWindow.ShowDialog();
        }

        private void AddProjectButton_Click(object sender, RoutedEventArgs e)
        {
            // Crée une instance d'AddProjectViewModel en passant le ProjetsViewModel actuel
            var addProjectViewModel = new AddProjectViewModel(_viewModel); 
            var addProjetsWindow = new AddProjets(addProjectViewModel); // Crée une fenêtre AddProjets avec le ViewModel

            addProjetsWindow.ShowDialog(); // Ouvre la fenêtre AddProjets
        }
        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filterText = FilterTextBox.Text.ToLower();

            // Applique le filtre 
            _viewModel.FilterProjects(filterText);

        }
    }
}


