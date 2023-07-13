// See https://aka.ms/new-console-template for more information


using Shape;
int choice = 0;
do
{
    Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+");
    Console.WriteLine("| 1. Circle               |");
    Console.WriteLine("+ 2. Rectangle            +");
    Console.WriteLine("| 3. Square               |");
    Console.WriteLine("+ 4. Exit                 +");
    Console.WriteLine("| Enter Your Choice...    |");
    Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter Radius");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Color");
            string c = Console.ReadLine();
            Circle cr = new Circle(r, c);
            var area = 3.14 * r * r;
             Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
             Console.WriteLine("| Circle : ["+"Radius : "+cr.Radius+ " , Color : "+cr.Color+" , Area : "+area+" ] |");
             Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
            break;
        case 2:
            Console.WriteLine("Enter width");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Length");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Color");
            c = Console.ReadLine();
            area = l * w;
            Rectangle rect = new Rectangle(w, l, c);
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("| Rectangle : [ Length : "+rect.Length + " , Width : " + rect.Width + " , Color : " + rect.Color + " , Area :" + area+" ] |");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            break;
        case 3:
            Console.WriteLine("Enter width");
            w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Color");
            c = Console.ReadLine();
            area = w * w;
            Square sq = new Square(w, c);
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("| Square : [ Width : "+sq.Width + " , Color : " + sq.Color + " , Area :" + area+" ] |");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            break;
            case 4:
              Console.WriteLine("Thank you for visiting...");
            break;
        default:
           Console.WriteLine("Invalid Input");
            break;
    }
    }while (choice != 4);

    