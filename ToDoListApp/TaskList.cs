using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    public class TaskList
    {
        private List<Task> tasklist;

        public TaskList()
        {
            tasklist = new List<Task>();
        }

        public void addTask(Task t)
        {
            tasklist.Add(t);
        }

        public void removeTask(string name)
        {
            foreach (Task task in tasklist)
            {
                if (task.getTaskName().Contains(name))
                {
                    tasklist.Remove(task);
                    break;
                }
            }
        }

        public void updateTask(string oldName, string newName)
        {
            foreach (Task task in tasklist)
            {
                if (task.getTaskName().Contains(oldName))
                {
                    task.setTaskName(newName);
                    break;
                }
            }
        }

        public string viewTasks()
        {
            string res = "";
            foreach(Task t in tasklist)
            {
                res += t.getTaskName() + "\n";
            }

            return res.Trim();
        }

        public List<Task> getTaskList()
        {
            return tasklist;
        }
    }
}
