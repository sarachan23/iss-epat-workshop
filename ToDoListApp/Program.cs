using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    class Program
    {
        private static TaskList _taskList = null;

        static void Main(string[] args)
        {
            _taskList = new TaskList();

            bool exit = false;
            do
            {
                ShowMenu();
                int input = ReadInput();
                if (input == 9) exit = true;
            } while (!exit);

        }

        public static void ShowMenu()
        {
            Console.WriteLine("Welcome to To Do List Application");
            ShowCurrentList();
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. List all to do list");
            Console.WriteLine("2. Add new item");
            Console.WriteLine("3. Delete an item");
            Console.WriteLine("4. Mark an item as complete");
            Console.WriteLine("9. Quit");
            Console.WriteLine("Enter your choice: ");
        }

        public static int ReadInput()
        {
            int input;
            bool canParse = Int32.TryParse(Console.ReadLine(), out input);

            if (!canParse) input = 99; //if not a number, assign a default number which is invalid
            string userInput = null;
            switch (input)
            {
                case 1:
                    Console.WriteLine("Selected: 1");
                    ShowCurrentList();
                    break;
                case 2:
                    Console.WriteLine("Selected: 2");

                    Console.Write("Add task: ");
                    userInput = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(userInput))
                    {
                        Task t = new Task(userInput);
                        _taskList.addTask(t);
                    }

                    break;
                case 3:
                    Console.WriteLine("Selected: 3");

                    Console.Write("Remove task: ");
                    userInput = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(userInput))
                    {
                        _taskList.removeTask(userInput);
                    }
                    break;
                case 4:
                    Console.WriteLine("Selected: 4");

                    Console.Write("Mark task as done: ");
                    userInput = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(userInput))
                    {
                        Task task =_taskList.getTask(userInput);

                        task.markDone();
                    }
                    break;
                case 9:
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            return input;
        }

        public static void ShowCurrentList()
        {
            Console.WriteLine("=== List of tasks ===");
            //List<Task> list = _taskList.getTaskList();

            //foreach (Task s in list)
            //{
            //    Console.WriteLine(s.getTaskName());
            //}
            Console.WriteLine(_taskList.viewTasks());
        }
    }
}


