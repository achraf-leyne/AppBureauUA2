using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using WpfMvvmUA2.Models;
using WpfMvvmUA2.Commands;

namespace WpfMvvmUA2.ViewModel
{
    public class ProjetsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Projet> Projets { get; set; }
        private ObservableCollection<Projet> AllProjets { get; set; }  // Liste complète des projets
        public ICommand AddProjectCommand { get; set; }
        public ICommand DeleteProjectCommand { get; set; }

        public ProjetsViewModel()
        {
            Projets = new ObservableCollection<Projet>();
            AllProjets = new ObservableCollection<Projet>();  
            DeleteProjectCommand = new RelayCommand<Projet>(DeleteProject);
        }

        // Méthode pour ajouter un projet
        public void AddProject(string titre, int avancement)
        {
            var newProject = new Projet { Nom = titre, Avancement = avancement };
            Projets.Add(newProject);
            AllProjets.Add(newProject);  
            OnPropertyChanged(nameof(Projets));
        }

        // Méthode pour supprimer un projet
        private void DeleteProject(Projet projet)
        {
            MessageBoxResult result = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer le projet '{projet.Nom}' ?",
                                                      "Confirmation", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Projets.Remove(projet);
                AllProjets.Remove(projet);  
                OnPropertyChanged(nameof(Projets));
            }
        }

        // Méthode pour filtrer les projets
        public void FilterProjects(string filterText)
        {
            if (string.IsNullOrWhiteSpace(filterText))  
            {
                Projets = new ObservableCollection<Projet>(AllProjets);  // Afficher tous les projets
            }
            else
            {
                var filteredProjects = AllProjets.Where(p => p.Nom.ToLower().Contains(filterText.ToLower())).ToList();
                Projets = new ObservableCollection<Projet>(filteredProjects);  // Afficher les projets filtrés
            }
            OnPropertyChanged(nameof(Projets));
        }

        // Implémentation de INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
