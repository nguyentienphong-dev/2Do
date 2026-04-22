using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace _2Do
{
    /// <summary>
    /// Interaction logic for Szerkesztes.xaml
    /// </summary>
    public partial class Szerkesztes : Window
    {
        public Szerkesztes()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            ToDo.ToDoList.Remove((ToDo)mainWindow.TaskListView.SelectedItem);
            ToDo.ToDoList.Add(new ToDo(TitleTextBox.Text, DescriptionTextBox.Text, DateTime.Parse(DeadLineTextBox.Text)));
            ToDo.Mentes();
            this.Close();
        }
    }
}
