using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wimo.Core.Interfaces;
using Wimo.Data.Entities;

namespace WimoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class TasksController : ControllerBase
    {
        private ITasksCore _tasksCore;

        public TasksController(ITasksCore tasksCore)
        {
            _tasksCore = tasksCore;
        }

        // GET: api/Tasks
        [HttpGet]
        public IEnumerable<Task> Get(int sortingTypeId = 0)
        {
            return _tasksCore.GetTasks(sortingTypeId);
        }

        // GET: api/Tasks/5
        [HttpGet("{key}", Name = "Get")]
        public Task Get(string key)
        {
            return _tasksCore.GetTaskByTaskKey(key);
        }

        // POST: api/Tasks
        [HttpPost]
        public Task Post([FromBody] Task task)
        {
            return _tasksCore.CreateTask(task);
        }

        // PUT: api/Tasks/5
        [HttpPut("{key}")]
        public void Put(string key, [FromBody] string status)
        {
             _tasksCore.UpdateStatus(key, status);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{key}")]
        public Task Delete(string key)
        {
            return _tasksCore.DeleteTask(key);
        }
    }
}
