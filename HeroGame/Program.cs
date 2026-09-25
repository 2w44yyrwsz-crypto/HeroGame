using System;

class Hero
{
    public string Name;
    public int Health;
    public int BaseAttack;

    public void PrintStatus()
    {
        Console.WriteLine($"[СТАТУС] {Name} | HP: {Health}");
    }

    public void Hit(Hero target)
    {
        target.Health -= BaseAttack;
        Console.WriteLine($"⚔️ {Name} атакує {target.Name} на {BaseAttack} шкоди!");
    }
}

class Program
{
    static void Main()
    {
        Hero hero = new Hero { Name = "Артур", Health = 100, BaseAttack = 20 };
        Hero monster = new Hero { Name = "Орк", Health = 60, BaseAttack = 15 };

        Console.WriteLine("--- ПОЧАТОК БОЮ ---");
        hero.PrintStatus();
        monster.PrintStatus();
        Console.WriteLine();

        while (hero.Health > 0 && monster.Health > 0)
        {
            hero.Hit(monster);
            monster.PrintStatus();

            if (monster.Health <= 0)
            {
                Console.WriteLine($"\n🏆 {hero.Name} перемiг!");
                break;
            }

            monster.Hit(hero);
            hero.PrintStatus();

            if (hero.Health <= 0)
            {
                Console.WriteLine($"\n☠️ {monster.Name} перемiг!");
                break;
            }

            Console.WriteLine();
        }
    }
}