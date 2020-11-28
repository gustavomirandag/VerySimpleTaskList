using ConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Interfaces
{
    //Nome: Antonio
    public interface ITaskRepository
    {
        
        public void Create(TaskItem taskitem);

        public IEnumerable<TaskItem> ReadAll();

        

    }
}
