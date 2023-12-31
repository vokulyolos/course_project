﻿using Project.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void AddProject(string projectName, DateTime startDate)
        {
            Projects.Add(new ProjectModel
            {
                ProjectName = projectName,
                StartDate = startDate,
                Tasks = new ObservableCollection<TaskModel>()
            });
        }


        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
