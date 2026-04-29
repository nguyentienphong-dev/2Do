using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Do
{
    public class ToDo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string IsCompleted { get; set; }

        public ToDo(string title, string description, DateTime dueDate)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = "Nincs kész";
        }

        public ToDo(string title, string description, DateTime dueDate, string isCompleted)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = isCompleted;
        }

        public static List<ToDo> ToDoList = new List<ToDo>(); 


        public static void Beolvas(string[] s)
        { 
            foreach (var item in s)
            {
                string [] parts = item.Split(';');
                ToDoList.Add(new ToDo(parts[0], parts[1], DateTime.Parse(parts[2]), parts[3]));
            }
        }

        public static void Mentes()
        {
            StreamWriter writer = new StreamWriter("todo.txt");
            foreach (var item in ToDoList)
            {
                writer.WriteLine($"{item.Title};{item.Description};{item.DueDate};{item.IsCompleted}");
            }
            writer.Close();
        }   
    }
}
