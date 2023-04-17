using System.Xml;
using WidlFarm.Models.Interfaces;
using WildFarm.Core.Intefaces;
using WildFarm.Factories.Interfaces;
using WildFarm.IO.Interfaces;


public class Engine : IEngine
{
    private IReader reader;
    private IWriter writer;

    private IAnimalFactory animalFactory;
    private IFoodFactory foodFactory;

    private readonly ICollection<IAnimal> animals;
    public Engine(IReader reader, IWriter writer, IAnimalFactory animalFactory, IFoodFactory foodFactory)
    {
        this.reader = reader;
        this.writer = writer;
        this.animalFactory = animalFactory;
        this.foodFactory = foodFactory;

        animals = new List<IAnimal>();
    }

    public void Run()
    {
        string command;
        while ((command = reader.ReadLine()) != "End")
        {
            IAnimal animal = null;
            try
            {
                animal = CreateAnimal(command);

                IFood food = CreateFood();

                writer.WriteLine(animal.ProduceSound());

                animal.Eat(food);
            }
            catch(ArgumentException ex)
            {
                writer.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                throw;
            }

            animals.Add(animal);
        }

        foreach (IAnimal animal in animals)
        {
            writer.WriteLine(animal.ToString());
        }
    }

    private IAnimal CreateAnimal(string command) 
    {
        string[] animalTokens = command
            .Split(" ",StringSplitOptions.RemoveEmptyEntries);

        return animalFactory.CreateAnimal(animalTokens);
    }

    private IFood CreateFood()
    {
        string[] foodTokens = reader.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string type = foodTokens[0];
        int quantity = int.Parse(foodTokens[1]);

        return foodFactory.CreateFood(type,quantity);
    }
}