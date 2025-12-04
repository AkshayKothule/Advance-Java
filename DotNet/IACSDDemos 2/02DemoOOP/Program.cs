namespace _02DemoOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IX obj = new Maths();
            Console.WriteLine(obj.Add(10, 20));

            IY obj2 = new Maths();
            Console.WriteLine(obj2.Add(10,20));
           
            IY obj3 = new Maths();
            Console.WriteLine(obj3.Mult(10,20));
            
            Console.ReadLine();
        }
    }

    /*
     * Service-Oriented Architecture (SOA) is a stage in the evolution of application development and/or
     * integration. It defines a way to make software components reusable using the interfaces. 
     */
    // ineterface 1
    public interface IX
    {
        int Add (int x, int y);
        int Sub(int x, int y);
    }

     //interface 11 
    public interface IY
    {
        int Add(int x, int y);
        int Mult(int x, int y);
    }


    //implementataion class 
    public class Maths : IX, IY
    {
        int IX.Add(int x, int y)
        {
            return x + y;
        }

        int IY.Add(int x, int y)
        {
            return x + y + 100;
        }

        int IY.Mult(int x, int y)
        {
            return x * y;
        }

        int IX.Sub(int x, int y)
        {
            return x - y;
        }
    }


}
