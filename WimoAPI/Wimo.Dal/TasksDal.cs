using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wimo.Dal.Interfaces;
using Wimo.Data;
using Wimo.Data.Entities;

namespace Wimo.Dal
{
    public class TasksDal : ITasksDal
    {
        private WimoDbContext _dbContext;
        public TasksDal(WimoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool CreateTask(Task task)
        {
            _dbContext.Tasks.Add(task);
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public Task DeleteTask(string taskKey)
        {
            Task taskToDelete = _dbContext.Tasks.Where(task => task.TaskKey == taskKey).FirstOrDefault();
            if (taskToDelete != null)
                _dbContext.Tasks.Remove(taskToDelete);
            return taskToDelete;
        }

        public Task GetTaskByTaskKey(string taskKey)
        {
            return _dbContext.Tasks.Where(task => task.TaskKey == taskKey).FirstOrDefault();
        }

        public IEnumerable<Task> GetTasks()
        {
            return _dbContext.Tasks.ToList();
        }

        public bool UpdateStatus(string taskKey, string status)
        {
            Task taskToUpdate = _dbContext.Tasks.Where(task => task.TaskKey == taskKey).FirstOrDefault();
            if (taskToUpdate == null)
                return false;
            taskToUpdate.Status = status;
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }
}
