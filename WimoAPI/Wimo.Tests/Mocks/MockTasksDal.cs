using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Wimo.Dal.Interfaces;
using Wimo.Data.Entities;

namespace Wimo.Tests.Mocks
{
    public class MockTasksDal : Mock<ITasksDal>
    {
        public MockTasksDal MockGetTasks()
        {
            Setup(x => x.GetTasks()).Returns(new List<Task>()
            {
                new Task
                {
                    TaskId = 1,
                    TaskKey = "test1",
                    CreatedOn = DateTime.Now,
                    Courier = "Wimo",
                    DriverName = "Soli",
                    DeliveryDate = DateTime.Today,
                    Status = "pending"
                },
                new Task
                {
                    TaskId = 2,
                    TaskKey = "test2",
                    CreatedOn = DateTime.Now.AddDays(-5),
                    Courier = "Wimo",
                    DriverName = "Soli",
                    DeliveryDate = DateTime.Today,
                    Status = "completed"
                },
                new Task
                {
                    TaskId = 3,
                    TaskKey = "test3",
                    CreatedOn = DateTime.Now.AddDays(-2),
                    Courier = "Wimo",
                    DriverName = "Soli",
                    DeliveryDate = DateTime.Today,
                    Status = "failed"
                }
            });
            return this;
        }
    }
}
