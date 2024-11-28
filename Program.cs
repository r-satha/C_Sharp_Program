// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
namespace consoleApp1
{
    public class program
    {
        static double DoDivision(double x, double y)
        {
            if (y==0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }

        //Creating a structure 
       /* struct Rectangle
        {
            public double length;
            public double width;
            public Rectangle(double l = 1, double w = 1)
            {
                length = l;
                width = w;
            }
            public double Area()
            {
                return length * width;
            }*/
            static void Main(string[] args)
        {

            /*Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Hello, World!");
            Console.Clear();*/
            Console.Write("What is your name ? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            Console.WriteLine("Biggest byte value {0}", byte.MaxValue);
            Console.WriteLine("Smallest byte value {0}", byte.MinValue);
            Console.WriteLine("Biggest sbyte value {0}", sbyte.MaxValue);
            Console.WriteLine("Smallest sbyte value {0}", sbyte.MinValue);
            Console.WriteLine("Biggest char value {0}", char.MaxValue);
            Console.WriteLine("Smallest char value {0}", char.MinValue);
            Console.WriteLine("Biggest short value {0}", short.MaxValue);
            Console.WriteLine("Smallest short value {0}", short.MinValue);
            Console.WriteLine("Biggest ushort value {0}", ushort.MaxValue);
            Console.WriteLine("Smallest ushort value {0}", ushort.MinValue);
            Console.WriteLine("Biggest int value {0}", int.MaxValue);
            Console.WriteLine("Smallest int value {0}", int.MinValue);
            Console.WriteLine("Biggest uint value {0}", uint.MaxValue);
            Console.WriteLine("Smallest uint value {0}", uint.MinValue);
            Console.WriteLine("Biggest long value {0}", long.MaxValue);
            Console.WriteLine("Smallest long value {0}", long.MinValue);
            Console.WriteLine("Biggest ulong value {0}", ulong.MaxValue);
            Console.WriteLine("Smallest ulong value {0}", ulong.MinValue);
            Console.WriteLine("Biggest decimal value {0}", Decimal.MaxValue);
            Console.WriteLine("Smallest Decimal value {0}", Decimal.MinValue);
            Console.WriteLine("Biggest double value {0}", double.MaxValue);
            Console.WriteLine("Smallest double value {0}", double.MinValue);

            int[] favNums = new int[3];
            favNums[0] = 31;
            Console.WriteLine("FavNum 0 : {0}", favNums[0]);
            string[] customers = { "bob", "Sally", "Rich" };
            var employee = new[] { "mike", "Paul", "Rick" };
            object[] randomArray = { "paul", 45, 1.245 };
            Console.WriteLine("randomArray 0 : {0}",
                     randomArray[0].GetType());
            //Random number 
            /*Random rnd = new Random();
            int secretNum = rnd.Next(1, 11);
            int numGues = 0;
            Console.WriteLine("Random Num : ", secretNum);
            int count = 0;
            do
            {
                Console.WriteLine("Enter The number between 1 to 10 :");   
                numGues = Convert.ToInt32(Console.ReadLine());
                count++;
            }while(secretNum != numGues);
            Console.WriteLine("You have guessed it correctly after nth time {0}", count);*/

            //Example of exception handling .
            try
            {
                double num1 = 5;
                double num2 = 0;
                Console.WriteLine(" check divide by zero  : {0}", DoDivision(num1, num2));

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            }
            finally
            {
                Console.WriteLine("Cleaning up ");
            }

            StringBuilder sb = new StringBuilder("Random Text");
            StringBuilder sb1 = new StringBuilder("To Confuse all with more data", 256);
            sb1.AppendLine(sb.ToString());
            Console.WriteLine(" Capacity of Sb1 {0} ", sb1.Capacity);
            Console.WriteLine(" Length of Sb1 {0} ", sb1.Length);
            sb1.Append("\n newly some more line to be append");
            CultureInfo enUs = CultureInfo.CreateSpecificCulture("en-US");
            string bestCust = "Bob Smith";
            sb1.AppendFormat(enUs, "Best Customer : {0}", bestCust);
            Console.WriteLine(sb1.ToString());
            sb1.Replace("text", "characters");
            Console.WriteLine(sb1.ToString());
            sb1.Clear();
            sb1.Append("Random Text");
            Console.WriteLine(sb.Equals(sb1));
            sb1.Insert(11, " Thats a great work");
            Console.WriteLine(sb1.ToString());
            sb1.Remove(11, 7);
            Console.WriteLine(sb1.ToString());


            //out keyword of argument as part of function will reflect the value change.
            //ref is used in the argument for pass by reference method.
            //Params to be used in function argument so n number of arguments can be passed . 
            //function overload. same function name with different arguments.
            //DateTime
            //TimeSpan

              /*  Rectangle rect1;
                rect1.length = 100;
                rect1.width = 50;

                Console.WriteLine("Area of rect1 : {0}",
                    rect1.Area());
                Rectangle rect2 = new Rectangle(200, 100);
                Console.WriteLine("Area of rect1 : {0}",
                    rect2.Area());
                rect2 = rect1;
                rect1.length = 300;
                Console.WriteLine("rect2.Length {0}", rect2.length);*/

                
                Console.WriteLine("Area of Rectangle : {0}",
                    ShapeMath.GetArea("Rectangle", 50, 4));

                Animal fox = new Animal();
                fox.SetName("Red");
                fox.Sound = "Raaaaw";
                
                Console.WriteLine("Get Animal detail {0} {1} {2} {3}",
                    fox.GetName(), fox.sound, fox.Owner, fox.idNum);
                Console.WriteLine("Number of Animal {0}",
                    Animal.NumOfAnimals);

                Animal cat = new Animal();
                cat.SetName("Whisker");
                cat.Sound = "Meeow";
                Console.WriteLine("Get Animal detail {0} {1} {2} {3}",
                    cat.GetName(), cat.sound, cat.Owner, cat.idNum);
                Console.WriteLine("# of Animals {0} ", Animal.NumOfAnimals);
                
                Shape[] shapes = {new Circle(5),
                                   new Rectangle(4,5)};
                foreach (Shape s in shapes)
                {
                    s.GetInfo();
                    Console.WriteLine("{0} Area :{1:f2}",
                        s.Name, s.Area());
                    Circle testCric = s as Circle;
                    if (testCric == null)
                    {
                        Console.WriteLine("This is not a Circle");
                    }
                    if (s is Circle)
                    {
                        Console.WriteLine("This is not a Rectangle");
                    }
                }
                object circ1 = new Circle(10);

                Circle circ2 = (Circle) circ1;
                Console.WriteLine("The {0} Area is {1:f2}",
                    circ2.Name, circ2.Area());
            }
        
    }
}
