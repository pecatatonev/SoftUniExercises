using RobotService.Models;
using RobotService.Models.Contracts;
using RobotService.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Repositories
{
    public class RobotRepository : IRepository<IRobot>
    {
        private List<IRobot> robots;
        public RobotRepository()
        {
            robots= new List<IRobot>();
        }

        public IReadOnlyCollection<IRobot> Models()
        {
            return robots.AsReadOnly();
        }
        public void AddNew(IRobot model)
        {
            robots.Add(model);
        }

        public bool RemoveByName(string robotModel)
        {
            IRobot robotToRemove = robots.FirstOrDefault(p => p.Model == robotModel);
            if (robotToRemove != null)
            {
                robots.Remove(robotToRemove);
                return true;
            }

            return false;
        }
        public IRobot FindByStandard(int interfaceStandard)
        {
            return robots.FirstOrDefault(p => p.InterfaceStandards.Contains(interfaceStandard));
        }

       

        
    }
}
