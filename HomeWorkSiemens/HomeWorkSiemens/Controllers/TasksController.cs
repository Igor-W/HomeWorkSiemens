using HomeWorkSiemens.Interfaces;
using HomeWorkSiemens.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWorkSiemens.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        ITaskService _taskService;
        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public List<TaskDTO> GetTasks()
        {
                return _taskService.GetTasks();
        }

        [HttpPost]
        public List<StepDTO> GetSteps([FromBody] int parentId)
        {
            return _taskService.GetSteps(parentId);
        }
    }
}