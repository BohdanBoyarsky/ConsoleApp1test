namespace ConsoleApp1test
{
internal class Program
    {
        static void Main()
        {
            //Это должно было помочь с киррилицей, но вместо ответа пустота, я устал это чинить, так что всё будет на английском
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.InputEncoding = System.Text.Encoding.UTF8;

        string fullname = "";
        while (true)//почему так? чтобы бесконечно запрашивать цикл, не известно сколько извилин имеет пользователь и будет ошибаться, и можем обойтись без перезапуска
        {
            Console.Write("Fullname: ");
            fullname = Console.ReadLine()?.Trim() ?? "";//До сих выглядит как заклинание из фентези, но насколько я понял, это надо чтобы всё прочитать и причесать 
            if (!string.IsNullOrEmpty(fullname))//Это консольное приложение, а не YandereSimulator, тут if-else к месту
                break;//а тут пользователь смог рещить непосильную задачу и ввёл всё правильно, теперь мы можем завершить цикл и двигаться дальше
            else
                Console.WriteLine("Fullname can't be empty, please enter your Fullname");//если чудо не произошло, напомнить пока не произойдёт
        }

        int age;
        while (true)
        {
            Console.Write("Age: ");
            string ageInput = Console.ReadLine()?.Trim() ?? "";
            if (int.TryParse(ageInput, out age) && age > 0)//я не знаю отрицательный возраст и система не будет знать тоже
                break;
            else
                Console.WriteLine("Wrong, please enter a positive number");
        }
        //тут была команда чтобы не ругалось на double, куда она пропала? я сам задаюсь этим вопросом, но теперь почему-то оно и без неё работает
        double height;
        while (true)
        {
            Console.Write("Enter Height: ");
            string heightImput = Console.ReadLine()?.Trim().Replace(",", ".") ?? "";
            if (double.TryParse(heightImput, out height) && height > 0)
                break;
            else
                Console.WriteLine("Please enter positive height");
        }

        Console.Write("Enter address (Apartment/house, street, city): ");
        string address = Console.ReadLine()?.Trim() ?? "";

        string phone = "";
        while (true)
        {
            Console.Write("Enter Phone number: ");
            phone = Console.ReadLine()?.Trim() ?? "";
            if (phone.Length == 10)
                break;
            else
                Console.WriteLine("Phone suppose to have 10 numbers");
        }

        Console.WriteLine("\nEntered data: ");
        Console.WriteLine($"Fullname: {fullname}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"Phone: {phone}");
        }
    }
}
//уже за час ночи, я устал, я ухожу сделав только одно задание из...мне страшно представить, на сайте было 6 и 2pdf файла