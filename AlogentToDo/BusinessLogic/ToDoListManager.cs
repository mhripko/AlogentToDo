using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace AlogentToDo
{
    /// <summary>
    /// ToDoListManager will manage the loading and saving of our To Do list for us.
    /// </summary>
    class ToDoListManager : IToDoListManager
    {
        private readonly string file;
        private List<ToDo> todos;

        public ToDoListManager(string file)
        {
            this.file = file;
            LoadToDoList();
        }

        /// <summary>
        /// Load the To Do list from storage / repository.
        /// </summary>
        /// <returns></returns>
        private List<ToDo> LoadToDoList()
        {
            if (File.Exists(file))
            {
                // Let's open the existing to-do list...
                var serializer = new XmlSerializer(typeof(List<ToDo>));
                using (var s = File.OpenRead(file))
                {
                    todos = (List<ToDo>)serializer.Deserialize(s);
                }
            }
            else
            {
                // Let's create a starter To Do list that has one item...
                var defaultToDoList = new[]
                {
                    "Use ToDo app to add, edit, and delete my to do list.",
                };
                todos = defaultToDoList.Select(f => new ToDo() { Description = f, Id = 0, Title = "Start My List", DueDate = DateTime.Today }).ToList();
            }

            return todos;
        }

        public void LoadAll()
        {
            LoadToDoList();
        }

        /// <summary>
        /// Save the To Do List back to our storage/repository.
        /// </summary>
        public void Save()
        {
            //Write the todolist back to storage...
            var serializer = new XmlSerializer(typeof(List<ToDo>));
            using (var s = File.Create(file))
            {
                serializer.Serialize(s, todos);
            }
        }

        public IEnumerable<ToDo> ToDos { get { return todos; } }
    }

    internal interface IToDoListManager
    {
        void LoadAll();
        void Save();
        IEnumerable<ToDo> ToDos { get; }
    }
}
