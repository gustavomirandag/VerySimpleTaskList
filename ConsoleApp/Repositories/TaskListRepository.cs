using ConsoleApp.Entities;
using ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Repositories
{
    //Nome: Antonio
    public class TaskListRepository : ITaskRepository
    {


        //Representa o Banco de Dados em uma Lista
        private static List<TaskItem> TaskItems = new List<TaskItem>();

        public void Create(TaskItem taskItem)
        {
            TaskItems.Add(taskItem);
        }

        public IEnumerable<TaskItem> ReadAll()
        {
            return TaskItems;
        }
    }
}
