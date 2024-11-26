using System.Collections.ObjectModel;
using System.Linq;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using WpfMvvmUA2.Models;

namespace WpfMvvmUA2.ViewModel
{
    
    public class MembreViewModel : INotifyPropertyChanged
    {
        // Déclaration de l'événement PropertyChanged pour implémenter INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

     
        protected virtual void OnPropertyChanged(string propertyName)
        {
            // Si l'événement PropertyChanged n'est pas null, le déclenche
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Collection observable des membres
        private ObservableCollection<Membre> _membres;

        // Propriété pour accéder et modifier la liste des membres
        public ObservableCollection<Membre> Membres
        {
            get { return _membres; }
            set
            {
                _membres = value;
                // Notifier les changements de la propriété Membres
                OnPropertyChanged(nameof(Membres));
            }
        }

        // Collection observable filtrée des membres
        private ObservableCollection<Membre> _filteredMembres;

        // Propriété pour accéder et modifier la liste filtrée des membres
        public ObservableCollection<Membre> FilteredMembres
        {
            get { return _filteredMembres; }
            set
            {
                _filteredMembres = value;
             
                OnPropertyChanged(nameof(FilteredMembres));
            }
        }

        // Méthode pour supprimer un membre
        public void DeleteMembre(Membre membre)
        {
            // Vérifier si le membre existe dans la collection Membres
            if (Membres.Contains(membre))
            {
                // Supprimer le membre de la collection Membres
                Membres.Remove(membre);
                // Mettre à jour la collection filtrée après suppression
                FilteredMembres = new ObservableCollection<Membre>(Membres);
            }
        }

        // Commande pour supprimer un membre, sera liée à un bouton dans l'interface
        public ICommand DeleteMembreCommand { get; }

       
        public MembreViewModel()
        {
            // Initialisation des collections Membres et FilteredMembres
            Membres = new ObservableCollection<Membre>();
            FilteredMembres = new ObservableCollection<Membre>(Membres);

            
            DeleteMembreCommand = new RelayCommand<Membre>(DeleteMembreWithConfirmation);
        }

        // Méthode pour ajouter un nouveau membre
        public void AddMembre(Membre nouveauMembre)
        {
            // Ajouter le nouveau membre à la collection Membres
            Membres.Add(nouveauMembre);
            // Mettre à jour la collection filtrée après ajout
            FilteredMembres = new ObservableCollection<Membre>(Membres);
        }

        // Méthode privée pour supprimer un membre avec une confirmation via MessageBox
        private void DeleteMembreWithConfirmation(Membre membre)
        {
            // Vérifier si le membre est nul
            if (membre == null) return;

            // Afficher une boîte de message pour confirmer la suppression
            var result = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer {membre.Nom} ?",
                "Confirmation de suppression",
                MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);

            // Si l'utilisateur confirme la suppression
            if (result == MessageBoxResult.OK)
            {
                // Supprimer le membre de la collection Membres
                Membres.Remove(membre);
                // Mettre à jour la collection filtrée après suppression
                FilteredMembres = new ObservableCollection<Membre>(Membres);
            }
        }

        // Méthode pour filtrer les membres en fonction d'une chaîne de caractères
        public void FilterMembres(string filter)
        {
            // Si le filtre est vide ou null, afficher tous les membres
            if (string.IsNullOrEmpty(filter))
            {
                FilteredMembres = new ObservableCollection<Membre>(Membres);
            }
            else
            {
                // Filtrer les membres par Nom, Prénom ou Rôle
                var filtered = Membres.Where(m =>
                    m.Nom.ToLower().Contains(filter.ToLower()) ||
                    m.Prenom.ToLower().Contains(filter.ToLower()) ||
                    m.Role.ToLower().Contains(filter.ToLower())
                ).ToList();

                // Mettre à jour la collection filtrée avec les résultats du filtrage
                FilteredMembres = new ObservableCollection<Membre>(filtered);
            }
        }
    }
}
