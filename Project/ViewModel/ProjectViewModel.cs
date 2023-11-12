using Project.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModel
{
    public class ProjectViewModel : INotifyPropertyChanged
    {
        private ProjectModel _selectedProject;

        public ObservableCollection<ProjectModel> Projects { get; set; }

        public ProjectModel SelectedProject
        {
            get { return _selectedProject; }
            set
            {
                _selectedProject = value;
                OnPropertyChanged("SelectedProject");
            }
        }

        // Возможно, здесь будут методы для загрузки и сохранения проектов

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
