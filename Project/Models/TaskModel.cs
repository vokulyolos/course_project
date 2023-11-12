using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    // Модель для задачи
    public class TaskModel : IDataErrorInfo
    {
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }

        public string this[string columnName]
        {
            get
            {
                string result = null;
                if (columnName == "TaskName")
                {
                    if (string.IsNullOrEmpty(TaskName))
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
