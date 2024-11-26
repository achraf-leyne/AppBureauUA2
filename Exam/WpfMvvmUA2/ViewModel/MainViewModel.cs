using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfMvvmUA2.Commands;
using WpfMvvmUA2.Models;
using WpfMvvmUA2.Views;

namespace WpfMvvmUA2.ViewModel
{
    public class MainViewModel
    {

        // Collection de projets
        public ObservableCollection<Projets> Projets { get; set; }

        // Commande pour afficher la fenêtre d'ajout de projet
        public ICommand ShowAddProjectWindowCommand { get; set; }

        // Instance de ProjetsViewModel pour gérer les projets
        public ProjetsViewModel ProjetsViewModel { get; set; }

        public MainViewModel()
        {

            // Initialisation de la liste de projets (exemple vide ici)
            Projets = new ObservableCollection<Projets>();

            // Initialisation de l'instance ProjetsViewModel
            ProjetsViewModel = new ProjetsViewModel();

            // Initialisation de la commande avec les méthodes de vérification et d'exécution
            ShowAddProjectWindowCommand = new MyICommand(ExecuteShowAddProjectWindow, CanExecuteShowAddProjectWindow);
        }

        // Méthode qui vérifie si la commande peut être exécutée (ici, elle est toujours vraie)
        private bool CanExecuteShowAddProjectWindow(object obj)
        {
            return true;
        }

        // Méthode qui ouvre la fenêtre d'ajout de projet
        private void ExecuteShowAddProjectWindow(object obj)
        {
            // Crée une instance de AddProjectViewModel et passe ProjetsViewModel en paramètre
            var addProjectViewModel = new AddProjectViewModel(ProjetsViewModel);

            // Crée une instance de la fenêtre AddProjets en passant le viewModel approprié
            AddProjets addProjectWindow = new AddProjets(addProjectViewModel);

            // Affiche la fenêtre
            addProjectWindow.Show();
        }
    }
}
