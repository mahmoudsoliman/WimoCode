using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wimo.Core.Interfaces;
using Wimo.Dal.Interfaces;
using Wimo.Data.Entities;
using Wimo.Models;

namespace Wimo.Core
{
    public class TasksCore : ITasksCore
    {
        private ITasksDal _tasksDal;
        public TasksCore(ITasksDal tasksDal)
        {
            _tasksDal = tasksDal;
        }

        public bool CreateTask(Task task)
        {
            task.TaskKey = Helpers.GenerateUniqueKey();
            task.CreatedOn = DateTime.Now;
            task.Status = TaskStatus.PENDING;
            return _tasksDal.CreateTask(task);
        }

        public Task DeleteTask(string taskKey)
        {
            return _tasksDal.DeleteTask(taskKey);
        }

        public Task GetTaskByTaskKey(string taskKey)
        {
            return _tasksDal.GetTaskByTaskKey(taskKey);
        }

        public IEnumerable<Task> GetTasks(int sortingTypeId = 0)
        {
            IEnumerable<Task> tasks = _tasksDal.GetTasks();
            switch (sortingTypeId)
            {
                case (int)Enums.SortingType.None:
                    return tasks;
                case (int)Enums.SortingType.ByDate:
                    return tasks.OrderByDescending(task => task.CreatedOn);
                case (int)Enums.SortingType.ByStatus:
                    return tasks.OrderBy(task => task.Status);
                default:
                    return tasks;
            }
        }

        public bool UpdateStatus(string taskKey, string status)
        {
            Task task = GetTaskByTaskKey(taskKey);
            //if(task.Status == TaskStatus.PENDING || task.Status == TaskStatus.STARTED)
            return _tasksDal.UpdateStatus(taskKey, status);
        }
    }
}
