// See https://aka.ms/new-console-template for more information

namespace Pratice1
{
    class Program
    {
        static void Main(string[] args)
        {

            IInterface1 obj1 = new calculator();
            
            Console.WriteLine(obj1.add(10 , 20));
           Console.WriteLine(obj1.sub(10 , 20)); 
           IInterface2 obj2 = new calculator();
           Console.WriteLine(obj2.mul(100 , 5));


        }
    }

    interface IInterface1
    {
        public int add(int a, int b);
        public int sub(int a, int b);

    }

    interface IInterface2
    {
         void add(int a, int b);
        public void sub(int a, int b);
        public int  mul(int a, int b);
        public void div(int a, int b);
    }

    public class calculator : IInterface1, IInterface2
    {
        int  IInterface1.add(int a, int b)
        {
            return a + b;
           
        }

        void IInterface2.sub(int a, int b)
        {
            throw new NotImplementedException();
        }
        
        int IInterface2.mul(int a, int b)
        {
            return a * b;
        }

         void IInterface2.div(int a, int b)
        {
            throw new NotImplementedException();
        }

        void IInterface2.add(int a, int b)
        {
            throw new NotImplementedException();
        }

        int IInterface1.sub(int a, int b)
        {
            return a - b;
        }
    }
};

