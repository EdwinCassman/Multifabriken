using System.ComponentModel;

class Program 
{
    static List<object> orders = new List<object>();

    static void Main(string[] args)
    {
        bool procede = true;
        while(procede)
        {
            Console.WriteLine("Välkommen till Multifabriken.");
            Console.WriteLine("1. Beställ Bil");
            Console.WriteLine("2. Beställ Godis");
            Console.WriteLine("3. Beställ Rör");
            Console.WriteLine("4. Beställ Havremjölk");
            Console.WriteLine("5. Lista alla beställningar");
            Console.WriteLine("6. Avsluta");
            Console.WriteLine("Välj ett alternativ");

            switch(Console.ReadLine())
            {
                case "1":
                    OrderCar();
                    break;

                case "2":
                    OrderCandy();
                    break;

                case "3":
                    OrderPipe();
                    break;

                case "4":
                    OrderMilk();
                    break;
                
                case "5":
                    ListOfOrders();
                    break;
                
                case "6":
                    procede = false;
                    break;
                
                default:
                    Console.WriteLine("Ogiltigt val. Tryck valfri knapp för att fortsätta.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void OrderCar()
    {
        Console.WriteLine("Ange registreringsnummer (tex: ABC 123): ");
        string regNumber = Console.ReadLine();
        Console.WriteLine("Ange färg: ");
        string carColor = Console.ReadLine();
        Console.WriteLine("Ange bilmärke: ");
        string carBrand = Console.ReadLine();

        Car car = new Car(regNumber, carColor, carBrand);
        orders.Add(car);

        Console.WriteLine("Bil beställd, tryck valfri knapp för att fortsätta.");
        Console.ReadKey();
    }

    static void OrderCandy()
    {
        Console.WriteLine("Ange smak: ");
        string flavor = Console.ReadLine();
        Console.WriteLine("Ange antal: ");
        int amount = int.Parse(Console.ReadLine());
        

        Candy candy = new Candy(flavor, amount);
        orders.Add(candy);

        Console.WriteLine("Godis beställt, tryck valfri knapp för att fortsätta.");
        Console.ReadKey();
    }

    static void OrderPipe()
    {
        Console.WriteLine("Ange Diameter (cm): ");
        double diameter = double.Parse(Console.ReadLine());
        Console.WriteLine("Ange Längd (m): ");
        double pipeLength = double.Parse(Console.ReadLine());
        

        Pipe pipe = new Pipe(diameter, pipeLength);
        orders.Add(pipe);

        Console.WriteLine("Rör beställt, tryck valfri knapp för att fortsätta.");
        Console.ReadKey();
    }

    static void OrderMilk()
    {
        Console.WriteLine("Ange Fetthalt (%): ");
        double fatPercentage = double.Parse(Console.ReadLine());
        Console.WriteLine("Ange Litermängd: ");
        double litres = double.Parse(Console.ReadLine());
        

        Milk milk = new Milk(fatPercentage, litres);
        orders.Add(milk);

        Console.WriteLine("Havremjölk beställt, tryck valfri knapp för att fortsätta.");
        Console.ReadKey();
    }

    static void ListOfOrders()
    {
        Console.WriteLine("Alla beställningar");

        foreach( var order in orders)
        {
            Console.WriteLine(order.ToString());
        }

        Console.WriteLine("Tryck på valfri knapp för att gå tillbaka till menyn.");
        Console.ReadKey();
    }

}
