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
        DateTime deadline;
        private int priority;
        private bool isDone = false;

        public Task(string name)
        {
            this.name = name;
        }

        public string getTaskName()
        {
            return name;
        }

        public string setTaskName(string newName)
        {
            this.name = newName;
            return this.name;
        }

        public void markDone()
        {
            this.isDone = true;
        }

        public bool getIsDone()
        {
            return isDone;
        }
    }
}
