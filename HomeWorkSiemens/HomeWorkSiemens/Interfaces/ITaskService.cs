using HomeWorkSiemens.Models;

namespace HomeWorkSiemens.Interfaces
{
    public interface ITaskService
    {
        public List<TaskDTO> GetTasks();
        public List<StepDTO> GetSteps(int parentId);
    }
}
