using System.Collections.ObjectModel;
using WpfMvvmUA2.Models;

namespace WpfMvvmUA2
{
    public static class ProjectManager
    {
        public static ObservableCollection<Projet> Projects { get; set; } = new ObservableCollection<Projet>();

        public static void AddProject(Projet project)
        {
            Projects.Add(project);
        }
    }
}
