using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2Do
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ToDo.Beolvas(System.IO.File.ReadAllLines("todo.txt"));
            TaskListBoxT();

        }

        private void TaskListBoxT()
        {
            TaskListView.Items.Clear();
            foreach (var item in ToDo.ToDoList)
            {
                TaskListView.Items.Add(item);
            }
            ToDo.Mentes();
        }

        private void NewTask_Click(object sender, RoutedEventArgs e)
        {
            Window newTaskWindow = new Hozzadaas();
            newTaskWindow.ShowDialog();
            TaskListBoxT();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            ToDo.Mentes();
            Environment.Exit(0);
        }

        private void Mentes_Click(object sender, RoutedEventArgs e)
        {
            ToDo.Mentes();
        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            if (TaskListView.SelectedItem != null)
            {
                ToDo.ToDoList.Remove((ToDo)TaskListView.SelectedItem);
                TaskListBoxT();
            }
        }

        private void EditTask_Click(object sender, RoutedEventArgs e)
        {
            if (TaskListView.SelectedItem != null)
            {
                ToDo selectedTask = (ToDo)TaskListView.SelectedItem;
                Window editWindow = new Szerkesztes()
                {
                    TitleTextBox = { Text = selectedTask.Title },
                    DescriptionTextBox = { Text = selectedTask.Description },
                    DeadLineTextBox = { SelectedDate = selectedTask.DueDate }
                };
                editWindow.ShowDialog();
                TaskListBoxT();
            }
        }
    }
}