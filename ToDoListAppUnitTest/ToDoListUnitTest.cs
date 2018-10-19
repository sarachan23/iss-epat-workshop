using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ToDoListApp
{
    [TestClass]
    public class ToDoListUnitTest
    {
        [TestInitialize()]
        public void Initialize()
        {
        }

        [TestCleanup()]
        public void Cleanup() { }

        [TestMethod]

        public void AddTask()
        {
            TaskList tasklist = new TaskList();
            Task task = new Task("test");

            tasklist.addTask(task);

            CollectionAssert.Contains(tasklist.getTaskList(), task);

            //Asserttasklist[0].getName() == "test";

        }

        [TestMethod]
        public void RemoveTask()
        {
            TaskList tasklist = new TaskList();
            Task task = new Task("test");
            Task task2 = new Task("test2");

            tasklist.addTask(task);
            tasklist.addTask(task2);

            tasklist.removeTask("test");
            CollectionAssert.DoesNotContain(tasklist.getTaskList(), task);

        }

        [TestMethod]
        public void UpdateTask()
        {
            TaskList tasklist = new TaskList();
            Task task = new Task("test");
            Task task2 = new Task("test2");

            tasklist.addTask(task);
            tasklist.addTask(task2);

            tasklist.updateTask("test", "test3");
            Assert.AreNotEqual(task.getTaskName(), "test");

        }

        [TestMethod]
        public void ViewTask()
        {
            TaskList tasklist = new TaskList();
            Task task = new Task("test");
            Task task2 = new Task("test2");

            tasklist.addTask(task);
            tasklist.addTask(task2);

            tasklist.updateTask("test", "test3");

            string testString = ("test3" + "\n" + "test2");

            Assert.AreEqual(tasklist.viewTasks(), testString);
        }

        [TestMethod]
        public void MarkTaskAsDone()
        {
            TaskList tasklist = new TaskList();
            Task task = new Task("test");
            Task task2 = new Task("test2");

            tasklist.addTask(task);
            tasklist.addTask(task2);

            tasklist.updateTask("test", "test3");

            tasklist.markDone("test3");

            Assert.AreEqual(tasklist.getTask("test3").getIsDone(), true);
        }

        [TestMethod]
        public void DeadlineTask()
        {
            TaskList tasklist = new TaskList();
            DateTime datetime = DateTime.Now;

            Task task = new Task("test", datetime);
            Task task2 = new Task("test2");

            tasklist.addTask(task);
            tasklist.addTask(task2);

            Assert.AreEqual(datetime.ToShortDateString(), tasklist.getTask("test").getDeadline().ToShortDateString());
        }

        [TestMethod]
        public void Priority()
        {
            TaskList tasklist = new TaskList();
            DateTime datetime = DateTime.Now;

            Task task = new Task("test", datetime);
            Task task2 = new Task("test2");

            tasklist.addTask(task);
            tasklist.addTask(task2);

            Assert.AreEqual(datetime.ToShortDateString(), tasklist.getTask("test").getDeadline().ToShortDateString());
        }
    }
}