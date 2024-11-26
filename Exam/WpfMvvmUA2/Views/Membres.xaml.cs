using System.Windows;
using System.Windows.Controls;
using WpfMvvmUA2.ViewModel;
using WpfMvvmUA2.Models; 
namespace WpfMvvmUA2.Views
{
  
    public partial class Membres : Page
    {
        // Déclaration du ViewModel utilisé dans cette vue
        private MembreViewModel _viewModel;

        
        public Membres()
        {
            InitializeComponent();  

            // Création d'une nouvelle instance de MembreViewModel
            _viewModel = new MembreViewModel();

           
            DataContext = _viewModel;
        }

        // Cette méthode est appelée chaque fois que le texte de la zone de texte de filtrage est modifié
        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            var filterText = FilterTextBox.Text.ToLower();

           
            var viewModel = (MembreViewModel)DataContext;

            
            viewModel.FilterMembres(filterText);
        }

        // Méthode qui s'exécute lorsque l'utilisateur clique sur le bouton "Ajouter un membre"
        private void AddMembreButton_Click(object sender, RoutedEventArgs e)
        {
            // Crée une nouvelle fenêtre AddMembre en passant le ViewModel pour gérer l'ajout d'un membre
            AddMembre addMembreWindow = new AddMembre(_viewModel);

          
            addMembreWindow.ShowDialog();
        }

        // Méthode appelée lors du clic sur le bouton "Supprimer"
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
           
            var button = sender as Button;

           
            var membre = button?.DataContext as Membre;

            // Si le membre n'est pas nul, procéder à la suppression
            if (membre != null)
            {
                // Affiche une boîte de message pour confirmer la suppression
                var result = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer {membre.Nom} ?",  
                "Confirmation de suppression",  
                    MessageBoxButton.OKCancel,  // Options de la boîte de message (OK et Annuler)
                    MessageBoxImage.Warning);   

                // Si l'utilisateur confirme (clique sur OK), supprimer le membre
                if (result == MessageBoxResult.OK)
                {
                
                    _viewModel.DeleteMembre(membre);
                }
            }
        }
    }
}
