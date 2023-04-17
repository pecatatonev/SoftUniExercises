using RobotService.Core.Contracts;
using RobotService.Models;
using RobotService.Models.Contracts;
using RobotService.Repositories;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Core
{
    public class Controller : IController
    {
        private SupplementRepository supplements;
        private RobotRepository robots;

        public Controller()
        {
            supplements= new SupplementRepository();
            robots= new RobotRepository();
        }
        public string CreateRobot(string model, string typeName)
        {
            if (typeName != "DomesticAssistant" && typeName != "IndustrialAssistant")
            {
                return String.Format(OutputMessages.RobotCannotBeCreated,typeName);
            }
            IRobot robot;
            switch (typeName)
            {
                case "DomesticAssistant":
                    robot = new DomesticAssistant(model);
                    robots.AddNew(robot);
                    break;
                case "IndustrialAssistant":
                    robot = new IndustrialAssistant(model);
                    robots.AddNew(robot);
                    break;
            }

            return String.Format(OutputMessages.RobotCreatedSuccessfully, typeName, model);
        }

        public string CreateSupplement(string typeName)
        {
            //SpecializedArm
            if (typeName != "SpecializedArm" && typeName != "LaserRadar")
            {
                return String.Format(OutputMessages.SupplementCannotBeCreated, typeName);
            }

            ISupplement supplement;
            switch (typeName)
            {
                case "SpecializedArm":
                    supplement = new SpecializedArm();
                    supplements.AddNew(supplement);
                    break;
                case "LaserRadar":
                    supplement = new LaserRadar();
                    supplements.AddNew(supplement);
                    break;
            }

            return String.Format(OutputMessages.SupplementCreatedSuccessfully, typeName);
        }

        public string UpgradeRobot(string model, string supplementTypeName)
        {
            ISupplement supplement = supplements.Models().FirstOrDefault(s => s.GetType().Name == supplementTypeName);
            int supplementInterfaceValue = supplement.InterfaceStandard;

            List<IRobot> rob = robots.Models().Where(v => !v.InterfaceStandards.Contains(supplementInterfaceValue)).ToList();
            rob = rob.Where(r => r.Model == model).ToList();

            if (rob.Count == 0)
            {
                return String.Format(OutputMessages.AllModelsUpgraded,model);
            }
            else
            {
                rob[0].InstallSupplement(supplement);
                supplements.RemoveByName(supplement.GetType().Name);
                return String.Format(OutputMessages.UpgradeSuccessful, model, supplementTypeName);
            }


        }
        public string PerformService(string serviceName, int intefaceStandard, int totalPowerNeeded)
        {
            List<IRobot> rob = robots.Models().Where(v => v.InterfaceStandards.Contains(intefaceStandard)).ToList();
            if (rob.Count == 0)
            {
                return String.Format(OutputMessages.UnableToPerform,intefaceStandard);
            }
            rob = rob.OrderByDescending(b => b.BatteryLevel).ToList();
            int sum = rob.Sum(b => b.BatteryLevel);
            int counter = 0;
            if (sum < totalPowerNeeded)
            {
                return String.Format(OutputMessages.MorePowerNeeded, serviceName, totalPowerNeeded - sum);
            }
            else if (sum >= totalPowerNeeded)
            {
                foreach (var robot in rob)
                {
                    
                    if (robot.BatteryLevel >= totalPowerNeeded)
                    {
                        robot.ExecuteService(totalPowerNeeded);
                        counter++;
                        break;
                    }
                    else if (robot.BatteryLevel < totalPowerNeeded)
                    {
                        totalPowerNeeded -= robot.BatteryLevel;
                        robot.ExecuteService(robot.BatteryLevel);
                        counter++;
                    }
                }
            }

            return String.Format(OutputMessages.PerformedSuccessfully, serviceName, counter);
        }

        public string RobotRecovery(string model, int minutes)
        {
            List<IRobot> robs = robots.Models().Where(p => p.Model == model).Where(b => b.BatteryLevel < 50).ToList();
            if (robs.Count == 0) return String.Format(OutputMessages.RobotsFed, robs.Count);
            foreach (var robot in robs)
            {
                robot.Eating(minutes);
            }

            return String.Format(OutputMessages.RobotsFed, robs.Count);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var robot in robots.Models().OrderByDescending(b => b.BatteryLevel).OrderBy(c => c.BatteryCapacity))
            {
               sb.AppendLine(robot.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
