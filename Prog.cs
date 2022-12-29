using System.Xml.Linq;


Items[] all_dish = new Items[] {new Coffee(1, 20, 2, 10, 5), new Coffee(2, 15, 7, 5, 10), new Coffee(3, 10, 5, 0, 5),
    new Pies(1, 5, 7, 3), new Pies(2, 3, 6, 5), new Pies(3, 7, 12, 6) };



Worker[] all_workers = new Worker[] { new Worker("Толя"), new Worker("Светлана"), new Worker("Евгения") };



Cafe[] all = new Cafe[all_dish.Length + all_workers.Length];
for (int i = 0; i < all.Length; i++)
{
    if(i < all_dish.Length) { all[i] = all_dish[i]; }
    if(i >= all_dish.Length) { all[i] = all_workers[i - all_dish.Length];}
}


static void Out(Cafe[] all)
{
    Console.WriteLine("Информация о Кафе");
    Console.WriteLine("-----------------");
    for (int i = 0; i < all.Length; i++)
    {
        all[i].Print();
    }
    Console.WriteLine("-----------------");
}
Out(all);

/*
static void Calculate(Items[] all)
{
    int most = 0, less = 999, average = 0, current = 0;

    for (int i = 0; i < all.Length; i++)
    {
        if (all[i].Most() > most)
        {
            most = all[i].Most();
        }
        if (less > all[i].Most())
        {
            less = all[i].Most();
        }
        average += all[i].Most();

    }
    average /= all.Length;
    Console.WriteLine($"Самый прибыльный продукт -  {most}  Наимение прибыльный продукт {less}  Средняя прибыль продукта {average}");
}

Calculate(all);
*/
 class Pies : Items
{
    public int id, self_price, pirce, count, stonks, all_stonks;

    public Pies()
    {
        id = 0;
        self_price = 0;
        pirce = 0;
        count = 0;
        stonks = 0;
        stonks = 0;
    }



    public Pies(int id, int self_price, int pirce, int count)
    {
        this.id = id;
        this.self_price = self_price;
        this.pirce = pirce;
        this.count = count;
        this.stonks = pirce - self_price;
        this.all_stonks = stonks*count;
    }

    public override void Print()
    {
        Console.WriteLine($"Пирог {id}, единичная прибыль - {stonks}, прибыль с партии {all_stonks}");
    }
    public override int Most()
    {
        return all_stonks;
    }
}
class Coffee : Items
{
    public int id, price, water, beans, count, stonks, all_stonks;
    public Coffee(int id, int price, int water, int beans, int count)
    {
        this.id = id;
        this.price = price;
        this.water = water;
        this.beans = beans;
        this.count = count;
        this.stonks = price - beans - water;
        this.all_stonks = stonks * count;
    }

    public override void Print()
    {
        Console.WriteLine($"Кофе {id}, единичная прибыль - {stonks}, прибыль с партии {stonks * count}");
    }
    public override int Most()
    {
        return all_stonks;
    }
}

class Items : Cafe
{
    public object[] item;

    public virtual int Most()
    {
        return 0;
    }
}

class Worker: Cafe
{
    public string name;
    public Worker(string name)
    {
        this.name = name;
    }
    public override void Print()
    {
        Console.WriteLine($"Работник кафе - {name}");
    }
}


class Cafe 
{
    public object[] info;
    public virtual void Print()
    {

    }
}








