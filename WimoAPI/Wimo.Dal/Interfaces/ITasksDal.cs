using System;
using System.Collections.Generic;
using System.Text;
using Wimo.Data.Entities;

namespace Wimo.Dal.Interfaces
{
    public interface ITasksDal
    {
        IEnumerable<Task> GetTasks();
        Task GetTaskByTaskKey(string taskKey);
        Task CreateTask(Task task);
        bool UpdateStatus(string taskKey, string status);
        Task DeleteTask(string taskKey);
    }
}
