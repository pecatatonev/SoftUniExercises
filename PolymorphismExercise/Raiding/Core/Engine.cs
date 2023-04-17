using Raiding.Core.Intefaces;
using Raiding.Factories;
using Raiding.Factories.Interfaces;
using Raiding.IO.Interfaces;
using Raiding.Models.Interfaces;

public class Engine : IEngine
{
    private IReader reader;
    private IWriter writer;
    private IHeroFactory heroFactory;

    private readonly ICollection<IBaseHero> heroes;
    public Engine(IReader reader, IWriter writer, IHeroFactory heroFactory)
    {
        this.reader = reader;
        this.writer = writer;
        this.heroFactory = heroFactory;

        heroes = new List<IBaseHero>();
    }

    public void Run()
    {
        int n = int.Parse(reader.ReadLine());

        while (n > 0)
        {
            string name = reader.ReadLine();
            string type = reader.ReadLine();
            try
            {
                heroes.Add(heroFactory.Create(name, type));
                n--;
            }
            catch (ArgumentException ex)
            {
                writer.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
 
        foreach (var hero in heroes)
        {
            writer.WriteLine(hero.CastAbility());
        }

        int bossHealth = int.Parse(reader.ReadLine());

        if (heroes.Sum(h => h.Power) >= bossHealth)
        {
            writer.WriteLine("Victory!");
        }
        else
        {
            writer.WriteLine("Defeat...");
        }
    }
}