using HomeWorkSiemens.Interfaces;
using HomeWorkSiemens.Models;

namespace HomeWorkSiemens.Services
{
    public class Store : IStore
    {
        public List<HomeWorkSiemens.Models.Task> Tasks { get; set; } = new List<HomeWorkSiemens.Models.Task>
        {
            new HomeWorkSiemens.Models.Task
            {
                Id = 1,
                Name = "One",
                Steps = new List<Step>
                {
                    new Step {
                        Name = "1.1",
                        Id = 11,
                        Owner = "Owner 1.1",
                        ParentId = 1,
                        Steps = new List<Step>{
                        new Step{
                            Name= "1.1.1",
                            Id = 111,
                            Owner="Owner 1.1.1",
                            ParentId = 11
                        } }


                    },
                    new Step { Name = "1.2", Id = 12, Owner = "Owner 1.2" , ParentId = 1},
                }
            },
            new HomeWorkSiemens.Models.Task
            {
                Id = 2,
                Name = "Two",
                Steps = new List<Step>
                {
                    new Step { Name = "2.1", Id = 21, Owner = "Owner 2.1" , ParentId = 2},
                    new Step { Name = "2.2", Id = 22, Owner = "Owner 2.2" , ParentId = 2},
                }
            },
        };
    }
}
