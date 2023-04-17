using NUnit.Framework;
using System.Diagnostics;
using System.Reflection;

namespace RobotFactory.Tests
{
    public class Tests
    {
        Supplement supplement;
        Robot robot;
        Factory factory;
        [SetUp]
        public void Setup()
        {
            supplement = new Supplement("Test", 3);
            robot = new Robot("RobotGPT", 50.5, 3);
            factory = new Factory("GPTFactory", 100);
        }

        [Test]
        public void CheckConstructorWorksCorrectSupplements()
        {
           Assert.AreEqual(supplement.Name , "Test");
           Assert.AreEqual(supplement.InterfaceStandard , 3);

        }

        [Test]
        public void SupplementsToStringMethodWorksCorrectly() 
        {
            Assert.AreEqual(supplement.ToString(), $"Supplement: { supplement.Name} IS: {supplement.InterfaceStandard}");
        }

        [Test]
        public void CheckConstructorWorksCorrectRobot()
        {
            Assert.AreEqual(robot.Model, "RobotGPT");
            Assert.AreEqual(robot.Price, 50.5);
            Assert.AreEqual(robot.InterfaceStandard, 3);
            Assert.AreEqual(robot.Supplements.Count, 0);

        }

        [Test]
        public void RobotToStringMethodWorksCorrectly()
        {
            Assert.AreEqual(robot.ToString(), $"Robot model: {robot.Model} IS: {robot.InterfaceStandard}, Price: {robot.Price:f2}");
        }

        [Test]
        public void CheckConstructorWorksCorrectFactory()
        {
            Assert.AreEqual(factory.Name, "GPTFactory");
            Assert.AreEqual(factory.Capacity, 100);
            Assert.AreEqual(factory.Supplements.Count, 0);
            Assert.AreEqual(factory.Robots.Count, 0);

        }

        [Test]
        public void CheckFactoryMethodProduceRobot()
        {
            factory = new Factory("test", 1);

            Assert.AreEqual(factory.ProduceRobot("model", 2, 1), $"Produced --> {$"Robot model: model IS: 1, Price: 2.00"}");
            Assert.AreEqual(factory.Robots.Count, 1);

            Assert.AreEqual(factory.ProduceRobot("gpt", 1, 1), $"The factory is unable to produce more robots for this production day!");
        }

        [Test]
        public void CheckFactoryMethodProduceSupplement()
        {
            factory = new Factory("test", 1);

            Assert.AreEqual(factory.ProduceSupplement("Test",1), $"Supplement: Test IS: 1");
            Assert.AreEqual(factory.Supplements.Count, 1);
        }

        [Test]
        public void CheckFactoryMethodUpgradeRobot()
        {
            factory = new Factory("test", 1);
            Robot robot1 = new Robot("test2", 2, 1);
            Supplement supplement1 = new Supplement("Test2", 2);

            Assert.AreEqual(factory.UpgradeRobot(robot, supplement), true);
            Assert.AreEqual(robot.Supplements.Count, 1);
            Assert.AreEqual(factory.UpgradeRobot(robot, supplement), false);
            Assert.AreEqual(factory.UpgradeRobot(robot1, supplement1), false);
        }

        [Test]
        public void CheckFactoryMethodSellRobot()
        {
            factory = new Factory("test", 2);
            Robot robot1 = new Robot("test2",2, 1);
            Supplement supplement1 = new Supplement("Test2", 2);

            factory.ProduceRobot("test2",2,1);
            factory.ProduceRobot("gpt",1,1);

            Assert.AreEqual($"{factory.SellRobot(2)}", robot1.ToString());
            Assert.AreEqual(factory.SellRobot(0.5), null);

        }
    }
}