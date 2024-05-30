using LAB_12_4;
using ClassLibrary1;
using LAB_12_2;

internal class Program
{
    static void Main(string[] args)
    {
        MyCollection<Car> cars1 = new MyCollection<Car>();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t1) cars1 = MyCollection<Car>()");
        Console.WriteLine("\tcars1.Print()");
        Console.ResetColor();
        cars1.Print();

        int lenght = 2;
        MyCollection<Car> cars2 = new MyCollection<Car>(lenght);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n\n\t2) cars2 = MyCollection<Car>({lenght})");
        Console.WriteLine("\tcars2.Print()");
        Console.ResetColor();
        cars2.Print();


        MyCollection<Car> cars3 = new MyCollection<Car>(cars2);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n\t3) cars3 = MyCollection<Car>(cars2)");
        Console.WriteLine("\tcars3.Print()");
        Console.ResetColor();
        cars3.Print();

        Car car1 = new Car();
        car1.Brend = "Добавляемый_элемент";
        cars3.Add(car1);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n\t4) car1 = new Car()");
        Console.WriteLine("\tcar1.Brend = Добавляемый_элемент");
        Console.WriteLine("\tcars3.Add(car1)");
        Console.WriteLine("\tcars3.Print()");
        Console.ResetColor();
        cars3.Print();

        cars3.Remove(car1);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n\t5) cars3.Remove(car1)");
        Console.WriteLine("\tcars3.Print()");
        Console.ResetColor();
        cars3.Print();

        Car[] array = new Car[cars3.Capacity];
        cars3.CopyTo(array, 0);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n\t6) cars3.CopyTo(array, 0)");
        Console.WriteLine("\tarray.Print()");
        Console.ResetColor();
        foreach (Car el in array)
        {
            if (el is null)
            {
                Console.WriteLine("null");
            }
            else
            {
                Console.WriteLine($"{el.ToString()}");
            }
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n\t7) foreach (Car el in cars3)");
        Console.ResetColor();
        foreach (Car el in cars3)
        {
            if (el is null)
            {
                Console.WriteLine("null");
            }
            else
            {
                Console.WriteLine(el.ToString());
            }
        }

        cars3.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n\t8) cars3.Clear()");
        Console.WriteLine("\tcars3.Print()");
        Console.ResetColor();
        cars3.Print();
    }
}