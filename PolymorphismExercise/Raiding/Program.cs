
using Raiding.Core.Intefaces;
using Raiding.Factories;
using Raiding.Factories.Interfaces;
using Raiding.IO;
using Raiding.IO.Interfaces;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
IHeroFactory factory = new HeroFactory();

IEngine engine = new Engine(reader, writer, factory);
engine.Run();