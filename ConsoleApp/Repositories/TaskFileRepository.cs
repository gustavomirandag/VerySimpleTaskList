using ConsoleApp.Entities;
using ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp.Repositories
{
    //Nome: Gustavo
    public class TaskFileRepository : ITaskRepository
    {
        public void Create(TaskItem taskitem)
        {
            var file = new StreamWriter(@"D:\Dados\taskItems.txt",true);
            file.WriteLine(taskitem.TaskName);
            file.Close();
        }

        public IEnumerable<TaskItem> ReadAll()
        {
            var taskItems = new List<TaskItem>();

            var file = new StreamReader(@"D:\Dados\taskItems.txt");
            var taskName = file.ReadLine();
            while (!String.IsNullOrEmpty(taskName))
            {
                var newTaskItem = new TaskItem();
                newTaskItem.TaskName = taskName;
                taskItems.Add(newTaskItem);
                taskName = file.ReadLine();
            }
            file.Close();

            return taskItems;
        }
    }
}
