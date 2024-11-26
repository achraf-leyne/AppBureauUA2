using System.Windows;
using WpfMvvmUA2.ViewModel;
using WpfMvvmUA2.Models; 

namespace WpfMvvmUA2.Views
{
    public partial class AddMembre : Window
    {
        private MembreViewModel _viewModel;

        public AddMembre(MembreViewModel viewModel)
        {
            InitializeComponent();

            // Référence du ViewModel

            _viewModel = viewModel;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Créer un nouvel objet Membre à partir des informations saisies
            Membre nouveauMembre = new Membre
            {
                Nom = NomTextBox.Text,
                Prenom = PrenomTextBox.Text,
                Role = RoleTextBox.Text,
                Email = EmailTextBox.Text
            };

            // Ajouter le nouveau membre au ViewModel
            _viewModel.AddMembre(nouveauMembre);

            // Fermer la fenêtre après l'ajout
            this.Close();
        }
    }
}
