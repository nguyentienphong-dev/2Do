using System;
using System.Collections.Generic;
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
        public bool IsCompleted { get; set; }

        public ToDo(string title, string description, DateTime dueDate)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false;
        }

        public ToDo(string title, string description, DateTime dueDate, bool isCompleted)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = isCompleted;
        }

        public static List<ToDo> ToDoList = new List<ToDo>(); 

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }

        public static void Beolvas(string[] s)
        { 
            foreach (var item in s)
            {
                string [] parts = item.Split(';');
                ToDoList.Add(new ToDo(parts[0], parts[1], DateTime.Parse(parts[2]), bool.Parse(parts[3])));
            }
        }

        public static void Mentes()
        {
            List<string> lines = new List<string>();
            foreach (var item in ToDoList)
            {
                lines.Add($"{item.Title};{item.Description};{item.DueDate};{item.IsCompleted}");
            }
            System.IO.File.WriteAllLines("todo.txt", lines);
        }   
    }
}
