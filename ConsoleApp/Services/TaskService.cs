using System.Collections.Generic;
using System.Text;
using ConsoleApp.Entities;
using ConsoleApp.Interfaces;
using ConsoleApp.Repositories;

namespace ConsoleApp.Services
{
    //Nome:
    //Use Cases: AddTask, GetAllTasks



    public class TaskService
    {
        private ITaskRepository _repository;

        public TaskService(ITaskRepository repository)
        {
            _repository = repository;
        }

        public void AddTask(TaskItem item)
        {
            //Não pode cadastrar tarefa sem nome
            if (item.TaskName != "")
            {
                _repository.Create(item);
            }
        }

        public IEnumerable<TaskItem> GetTaskItems()
        {
            return _repository.ReadAll();
        }
    }
}
