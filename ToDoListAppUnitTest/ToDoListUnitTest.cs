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
            _list = new ToDoList();
        }

        [TestCleanup()]
        public void Cleanup() { }

        [TestMethod]
        public void AddNewToDoItemTest()
        {
        }

        [TestMethod]

        public void AddTask()
        {
            List<Task> tasklist = new List<Task>();
            Task task = new Task("test");

            tasklist.Add(task);

            Assert.AreEqual(tasklist[0].getTaskName(), "test");

            //Asserttasklist[0].getName() == "test";

        }


    }
}