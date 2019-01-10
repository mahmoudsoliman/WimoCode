using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Wimo.Core;
using Wimo.Data.Entities;
using Wimo.Tests.Mocks;

namespace Wimo.Tests
{
    [TestClass]
    public class TasksCoreTests
    {
        [TestMethod]
        public void TestGetDefault()
        {
            var tasksDalMock = new MockTasksDal().MockGetTasks();
            var tasksCore = new TasksCore(tasksDalMock.Object);
            List<Task> result = tasksCore.GetTasks(0).ToList();
            Assert.AreEqual(result[0].TaskId, 1);
            Assert.AreEqual(result[1].TaskId, 2);
            Assert.AreEqual(result[2].TaskId, 3);
        }

        [TestMethod]
        public void TestGetSortByStatus()
        {
            var tasksDalMock = new MockTasksDal().MockGetTasks();
            var tasksCore = new TasksCore(tasksDalMock.Object);
            List<Task> result = tasksCore.GetTasks(1).ToList();
            Assert.AreEqual(result[0].TaskId, 2);
            Assert.AreEqual(result[1].TaskId, 3);
            Assert.AreEqual(result[2].TaskId, 1);
        }

        [TestMethod]
        public void TestGetSortByDate()
        {
            var tasksDalMock = new MockTasksDal().MockGetTasks();
            var tasksCore = new TasksCore(tasksDalMock.Object);
            List<Task> result = tasksCore.GetTasks(2).ToList();
            Assert.AreEqual(result[0].TaskId, 1);
            Assert.AreEqual(result[1].TaskId, 3);
            Assert.AreEqual(result[2].TaskId, 2);
        }
    }
}
