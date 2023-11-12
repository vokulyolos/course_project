using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    // Модель для проекта
    public class ProjectModel
    {
        public string ProjectName { get; set; }
        public ObservableCollection<TaskModel> Tasks { get; set; }
        public DateTime StartDate { get; set; }

        public string this[string columnName]
        {
            get
            {
                string result = null;
                if (columnName == "TaskName")
                {
                    if (string.IsNullOrEmpty(ProjectName))
                    {
                        result = "Имя задачи обязательно для заполнения.";
                    }
                }
                // Другие правила валидации
                return result;
            }
        }

        public string Error
        {
            get { return null; }
        }
    }
}
