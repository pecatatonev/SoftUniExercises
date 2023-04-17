using RobotService.Models.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Models
{
    public abstract class Robot : IRobot
    {
        public Robot(string model, int batteryCapacity, int conversionCapacityIndex)
        {
            Model= model;
            BatteryCapacity= batteryCapacity;
            BatteryLevel = BatteryCapacity;
            ConvertionCapacityIndex= conversionCapacityIndex;
            interfaceStandards = new List<int> { };
        }
        private string model;

        public string Model
        {
            get { return model; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ModelNullOrWhitespace);
                }
                model = value; 
            }
        }


        private int batteryCapacity;

        public int BatteryCapacity
        {
            get { return batteryCapacity; }
            private set
            {
                //check it later
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.BatteryCapacityBelowZero);
                }
                batteryCapacity = value;
            }
        }


        private int batteryLevel;

        public int BatteryLevel
        {
            get { return batteryLevel; }
            private set { batteryLevel = value; }
        }


        private int convertionCapacityIndex;

        public int ConvertionCapacityIndex
        {
            get { return convertionCapacityIndex; }
            private set { convertionCapacityIndex = value; }
        }
        //The ability of the Robot to convert food into energy.

        private List<int> interfaceStandards;
        public IReadOnlyCollection<int> InterfaceStandards => interfaceStandards.AsReadOnly();

        public void Eating(int minutes)
        {
            for (int i = 0; i < minutes; i++)
            {
                int produceEnergy = ConvertionCapacityIndex * minutes;

                if (BatteryLevel >= BatteryCapacity)
                {
                    BatteryLevel= BatteryCapacity;
                    return;
                }

                BatteryLevel += produceEnergy;
            }
        }

        public void InstallSupplement(ISupplement supplement)
        {
            interfaceStandards.Add(supplement.InterfaceStandard);
            BatteryCapacity -= supplement.BatteryUsage;
            BatteryLevel -= supplement.BatteryUsage;
        }

        public bool ExecuteService(int consumedEnergy)
        {
            if (BatteryLevel >= consumedEnergy)
            {
                BatteryLevel-=consumedEnergy;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name} {Model}:"); //check it later
            sb.AppendLine($"--Maximum battery capacity: {BatteryCapacity}");
            sb.AppendLine($"--Current battery level: {BatteryLevel}");
            if (InterfaceStandards.Count == 0)
            {
                sb.AppendLine("--Supplements installed: none");
            }
            else
            {
                sb.AppendLine($"--Supplements installed: {String.Join(" ", interfaceStandards)}");
            }
            return sb.ToString().Trim();
        }
    }
}
