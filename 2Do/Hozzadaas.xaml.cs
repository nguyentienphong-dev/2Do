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
    /// Interaction logic for Hozzadaas.xaml
    /// </summary>
    public partial class Hozzadaas : Window
    {
        public Hozzadaas()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ToDo.ToDoList.Add(new ToDo(TitleTextBox.Text, DescriptionTextBox.Text, DateTime.Parse(DeadLineTextBox.Text)));
            this.Close();
        }
    }
}
