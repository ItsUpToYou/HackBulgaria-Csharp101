using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public interface IMammals
    {

    }

    public interface IReptiles
    {
        void NoTemp();
    }

    public interface IFish
    {
        void Swim();
    }

    public interface IBirds
    {
        void Nests();
    }

    public abstract class Animals
    {
        public int Birth { get; set; }

        public Animals(int birth)
        {
            this.Birth = birth;
        }

        public virtual int Move()
        {
            return 0;
        }

        public abstract string Eat();
        //{
        //    b = "waw";
        //    return b;
        //}

        public virtual string Greet()
        {
            return ("default sound");
        }
    }

    public class Dog : Animals, IMammals
    {
        public Dog(int b) : base(b)
        {
        }

        public override string Eat()
        {
            return "Dog";
        }

        public override string Greet()
        {
            return "Bay";
        }

        public override int Move()
        {
            return 20;
        }
    }

    public class Cat : Animals, IMammals
    {
        public Cat(int b) : base(b)
        {
        }

        public override string Greet()
        {
            return "Miayy";
        }

        public override int Move()
        {
            return 15;
        }
        public override string Eat()
        {
            return "mouse";
        }
    }

    public class Crocodile : Animals, IReptiles, IMammals
    {
        public Crocodile(int b) : base(b)
        {
        }

        public override string Eat()
        {
            return "croco";
        }

        public override int Move()
        {
            return 19;
        }

        public void NoTemp()
        {
            Console.WriteLine("no temp");
        }
    }

    public class Owl : Animals
    {
        public Owl(int b) : base(b)
        {
        }

        public override string Eat()
        {
            return "mouse";
        }

        public override string Greet()
        {
            return "buhu";
        }

        public override int Move()
        {
            return 13;
        }
    }


    public class Shark : Animals, IMammals, IFish
    {
        public Shark(int b) : base(b)
        {
        }
        public override int Move()
        {
            return 22;
        }

        public override string Greet()
        {
            return "No Greet";
        }

        public override string Eat()
        {
            return "meat";
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
