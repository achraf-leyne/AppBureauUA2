using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using WpfMvvmUA2.Views;


namespace WpfMvvmUA2.ViewModel
{
    public class AddProjectViewModel : INotifyPropertyChanged
    {
        private string _titre;
        private int _avancement;

        public string Titre
        {
            get => _titre;
            set
            {
                if (_titre != value)
                {
                    _titre = value;
                    OnPropertyChanged(nameof(Titre));
                }
            }
        }

        public int Avancement
        {
            get => _avancement;
            set
            {
                if (_avancement != value)
                {
                    _avancement = value;
                    OnPropertyChanged(nameof(Avancement));
                }
            }
        }

        private readonly ProjetsViewModel _projetsViewModel;

        public ICommand AddProjectCommand { get; set; }

        // Constructeur prenant ProjetsViewModel comme paramètre
        public AddProjectViewModel(ProjetsViewModel projetsViewModel)
        {
            _projetsViewModel = projetsViewModel;
            AddProjectCommand = new RelayCommand<object>(AddProject);
        }

        // Méthode pour ajouter le projet et fermer la fenêtre
        public void AddProject(object parameter)
        {
            // Ajouter le projet à la collection dans ProjetsViewModel
            _projetsViewModel.AddProject(Titre, Avancement);

            // Fermer la fenêtre AddProjets.xaml après l'ajout du projet
            Application.Current.Windows.OfType<AddProjets>().FirstOrDefault()?.Close();
        }

        // Implémentation de INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
