using PolymorphismExercise.Core.Intefaces;
using PolymorphismExercise.Factories;
using PolymorphismExercise.Factories.Interfaces;
using PolymorphismExercise.IO;
using PolymorphismExercise.IO.Interfaces;
using PolymorphismExercise.Models;
using PolymorphismExercise.Models.Interfaces;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
IVehicleFactory factory = new VehicleFactory();

IEngine engine = new Engine(reader, writer,factory);
engine.Run();