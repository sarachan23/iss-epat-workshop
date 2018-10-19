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

        public Task(string name, DateTime deadline)
        {
            this.name = name;
            this.deadline = deadline;
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

        public DateTime getDeadline()
        {
            return deadline;
        }

        public bool getIsDone()
        {
            return isDone;
        }
    }
}
