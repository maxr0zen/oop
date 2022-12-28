using System.Xml.Linq;







Coffee[] coffee_one = new Coffee[] { new Coffee(1, 20, 2, 10, 5), new Coffee(2, 15, 7, 5, 10), new Coffee(3, 10, 5, 0, 5) };
coffee_one[0].Print(); coffee_one[1].Print(); coffee_one[2].Print();
int[] all_coffee_stonks = { coffee_one[0].Most(), coffee_one[1].Most(), coffee_one[2].Most() };


Pies[] pie_one = new Pies[] { new Pies(1, 5, 7, 3), new Pies(2, 3, 6, 5), new Pies(3, 7, 12, 6) };
pie_one[0].Print_pies(); pie_one[1].Print_pies(); pie_one[2].Print_pies();
int[] all_pie_stonks = { pie_one[0].Most(), pie_one[1].Most(), pie_one[2].Most() };


static void Calculate(int[] all_coffee_stonks, int[] all_pie_stonks)
{
    int most_coffee = 0, less_coffee = 999, average_coffee = 0;
    int most_pie = 0, less_pie = 999, average_pie = 0;

    for (int i = 0; i < 3; i++)
    {
        if(most_coffee < all_coffee_stonks[i])
        {
            most_coffee = all_coffee_stonks[i];
        }
        if(most_pie < all_pie_stonks[i])
        {
            most_pie = all_pie_stonks[i];
        }
        if(less_coffee > all_coffee_stonks[i])
        {
            less_coffee = all_coffee_stonks[i];
        }
        if (less_pie > all_pie_stonks[i])
        {
            less_pie = all_pie_stonks[i];
        }
        average_coffee += all_coffee_stonks[i];
        average_pie += all_pie_stonks[i];
    }
    average_pie /= 3;
    average_coffee /= 3;
    Console.WriteLine($"Самый прибыльный кофе -  {most_coffee}  Наимение прибыльный кофе {less_coffee}  Средняя прибыль кофе {average_coffee}");
    Console.WriteLine($"Самый прибыльный пирог - {most_pie}, Наимение прибыльный пирог - {less_pie}, Средняя прибыль пирожков - {average_pie}");
}

Calculate(all_coffee_stonks, all_pie_stonks);

class Pies
{
    public int pie_id, pie_self_price, pie_pirce, pie_count, pie_stonks, all_stonks;

    public Pies()
    {
        pie_id = 0;
        pie_self_price = 0;
        pie_pirce = 0;
        pie_count = 0;
        all_stonks = 0;
        pie_stonks = 0;
    }



    public Pies(int pie_id, int pie_self_price, int pie_pirce, int pie_count)
    {
        this.pie_id = pie_id;
        this.pie_self_price = pie_self_price;
        this.pie_pirce = pie_pirce;
        this.pie_count = pie_count;
        this.pie_stonks = pie_pirce - pie_self_price;
        this.all_stonks = pie_stonks*pie_count;
    }

    public void Print_pies()
    {
        Console.WriteLine($"Пирог {pie_id}, единичная прибыль - {pie_stonks}, прибыль с партии {all_stonks}");
    }
    public int Most()
    {
        return all_stonks;
    }
}
class Coffee
{
    public int coffee_id, coffee_price, coffee_water, coffee_beans, offres_count, single_stonks, coffee_ctonks;
    public Coffee(int coffee_id, int coffee_price, int coffee_water, int coffee_beans, int offres_count)
    {
        this.coffee_id = coffee_id;
        this.coffee_price = coffee_price;
        this.coffee_water = coffee_water;
        this.coffee_beans = coffee_beans;
        this.offres_count = offres_count;
        this.single_stonks = coffee_price - coffee_beans - coffee_water;
        this.coffee_ctonks = single_stonks * offres_count;
    }

    public void Print()
    {
        Console.WriteLine($"Кофе {coffee_id}, единичная прибыль - {single_stonks}, прибыль с партии {single_stonks * offres_count}");
    }
    public int Most()
    {
        return coffee_ctonks;
    }
}







