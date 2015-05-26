using BackboneLearnProject.Models;
using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BackboneLearnProject.Controllers
{
    [RoutePrefix("api/agents/{agentId}/tasks")]
    public class TasksController : ApiController
    {
        [HttpPost]
        [Route]
        public Task AddTask(int agentId, Task newTask)
        {
            Agent agent = Database.Agents.SingleOrDefault(a => a.AgentID == agentId);
            // Create the task and attach it to the agent entity
            newTask = Database.AddTask(newTask);
            agent.Tasks.Add(newTask);
            return newTask;
        }
        [HttpPut]
        [Route("{taskId}")]
        public void UpdateTask(int agentId, int taskId, Task updatedTask)
        {
            Agent agent = Database.Agents.SingleOrDefault(a => a.AgentID == agentId);
            Task task = agent.Tasks.Where(t => t.TaskID == taskId).SingleOrDefault();
            // Update the task from the database
            task.Description = updatedTask.Description;
            task.IsComplete = updatedTask.IsComplete;
        }
    }
}

