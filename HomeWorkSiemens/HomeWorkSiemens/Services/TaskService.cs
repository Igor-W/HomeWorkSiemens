using HomeWorkSiemens.Interfaces;
using HomeWorkSiemens.Models;
using System.Linq;

namespace HomeWorkSiemens.Services
{
    public class TaskService : ITaskService
    {
        private readonly IStore _store;
        public TaskService(IStore store)
        {
            _store = store;
        }

        public List<StepDTO> GetSteps(int parentId)
        {
            List<StepDTO> steps = new List<StepDTO>();

            foreach (var task in _store.Tasks)
            {
                FindSteps(task.Steps, parentId, steps);
            }

            return steps;
        }

        public List<TaskDTO> GetTasks()
        {
            return _store.Tasks.Select(t =>
            new TaskDTO
            {
                Id = t.Id,
                Name = t.Name
            }

            ).ToList();
        }
        private void FindSteps(List<Step> steps, int parentId, List<StepDTO> result)
        {
            foreach (var step in steps)
            {
                if (step.ParentId == parentId)
                {
                    result.Add(new StepDTO
                    {
                        Id = step.Id,
                        ParentId = step.ParentId,
                        Name = step.Name,
                        Owner = step.Owner
                    });
                }

                if (step.Steps.Count > 0)
                {
                    FindSteps(step.Steps, parentId, result);
                }
            }
        }
    }
}
