using RobotService.Models.Contracts;
using RobotService.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Repositories
{
    public class SupplementRepository : IRepository<ISupplement>
    {
        List<ISupplement> supplements;

        public SupplementRepository()
        {
            supplements= new List<ISupplement>();
        }
        public IReadOnlyCollection<ISupplement> Models()
        {
            return supplements.AsReadOnly();
        }
        public void AddNew(ISupplement model)
        {
            supplements.Add(model);
        }

        public bool RemoveByName(string typeName)
        {
            ISupplement supplementToRemove = supplements.FirstOrDefault(p => p.GetType().Name == typeName);
            if (supplementToRemove != null)
            {
                supplements.Remove(supplementToRemove);
                return true;
            }

            return false;
        }
        public ISupplement FindByStandard(int interfaceStandard)
        {
            return supplements.FirstOrDefault(p => p.InterfaceStandard == interfaceStandard);
        }

        

        
    }
}
