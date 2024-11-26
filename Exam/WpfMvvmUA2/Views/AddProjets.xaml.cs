using System.Windows;
using WpfMvvmUA2.ViewModel;

namespace WpfMvvmUA2.Views
{
    public partial class AddProjets : Window
    {
        // Le ViewModel passé à la fenêtre
        public AddProjectViewModel ViewModel { get; set; }

        public AddProjets(AddProjectViewModel addProjectViewModel)
        {
            InitializeComponent();
            ViewModel = addProjectViewModel;
            this.DataContext = ViewModel;
        }
    }
}
