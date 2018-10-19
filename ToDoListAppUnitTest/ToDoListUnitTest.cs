using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToDoListAppUnitTest
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


    }
}
