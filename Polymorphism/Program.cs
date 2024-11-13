using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Polymorphism.car;

namespace Polymorphism
{
    public class Transformer
    {
        public virtual void Transform()
        {
            Console.WriteLine("The transformer is trasforming");
        }
    }
    public class car : Transformer
    {
        public override void Transform()
        {
            {
                Console.WriteLine("Robot transform into Car");
            }
        }
        public class Boat:Transformer
        {
            public override void Transform()
            {

                Console.WriteLine("Jet transform into Robot.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Transformer myTransformer=new Transformer();
            Transformer mycar = new car();
            Transformer myboat = new Boat();
            myTransformer.Transform();
            mycar.Transform();
            myboat.Transform();
            Console.ReadKey();
        }
    }
}
