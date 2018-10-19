using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    public class Task
    {
        private string name;
        public Task(string name)
        {
            this.name = name;
        }

        public string getTaskName()
        {
            return name;
        }
    }
}
