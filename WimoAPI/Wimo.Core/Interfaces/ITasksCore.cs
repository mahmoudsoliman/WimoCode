using System;
using System.Collections.Generic;
using System.Text;
using Wimo.Data.Entities;

namespace Wimo.Core.Interfaces
{
    public interface ITasksCore
    {
        IEnumerable<Task> GetTasks(int sortingTypeId = 0);
        Task GetTaskByTaskKey(string taskKey);
        Task CreateTask(Task task);
        bool UpdateStatus(string taskKey, string status);
        Task DeleteTask(string taskKey);
    }
}
