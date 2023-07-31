namespace InterfaceWithCore
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Shape s = new Shape();
            s.Insert();
            s.Delete();
            s.Update();
            // s.Display();  if default  method is not override in class then we cannot access directly to access

            IDbFunction idb = s;
            idb.Display();      //to access interface method ....//and now if we override method in shape class then it will call shape class Display method 

            IDbFunction idb1 = new Size();
            idb1.Insert();             // here we will call these method because refernce is interface
            idb1.Update();
            idb1.Display();



        }

    }

    public interface IDbFunction
    {
        void Insert();
        void Delete();
        void Update();

        //in .NET Core we can add default method inside interface
        public void Display()
        {
            Console.WriteLine("inside default display method inside interface");
        }

    }

    public class Shape : IDbFunction
    {
     
        public void Insert()
        {
            Console.WriteLine("inside Insert function");
        }

        public void Delete()
        {
            Console.WriteLine("inside Delete function");

        }

        public void Update()
        {
            Console.WriteLine("inside update function");

        }

        public void Display()
        {
            Console.WriteLine("inside Display function of shape class");

        }


    }
    public class Size : IDbFunction
    {
        void IDbFunction.Delete()
        {
        }

        void IDbFunction.Insert()
        {
        }

        void IDbFunction.Update()
        {

        }

        public void Display()
        {
            Console.WriteLine("inside Display function of size class");

        }
    }
}