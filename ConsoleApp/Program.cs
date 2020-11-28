using ConsoleApp.Entities;
using ConsoleApp.Repositories;
using ConsoleApp.Services;
using System;

namespace ConsoleApp
{
    class Program
    {
        //Tarefas
        //1 - Criar a entidade "TaskItem"
        //2 - Criar o seviço "TaskService"
        //3 - Criar a interface "ITaskRepository" (apenas create e readAll)
        //4 - Criar o repositório "TaskListRepository"

        static void Main(string[] args)
        {
            var service = new TaskService(new TaskListRepository());
            var option = 0;

            do
            {
                Console.WriteLine();
                Console.WriteLine("##### MENU #####");
                Console.WriteLine("1 - Cadastrar Tarefa");
                Console.WriteLine("2 - Imprimir Tarefas");
                Console.WriteLine("3 - Sair");
                option = int.Parse(Console.ReadLine());
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("Digite o nome da tarefa:");
                    var name = Console.ReadLine();
                    var newTask = new TaskItem();
                    newTask.TaskName = name;
                    service.AddTask(newTask);
                }
                else if(option == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("###### TAREFAS ######");
                    var taskItems = service.GetTaskItems();
                    foreach(var taskItem in taskItems)
                    {
                        Console.WriteLine(" - " + taskItem.TaskName);
                    }
                }

            } while (option != 3);


        }
    }
}
