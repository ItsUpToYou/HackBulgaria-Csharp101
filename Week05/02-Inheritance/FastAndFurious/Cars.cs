using FastAndFurious;

namespace FastandFurious
{

    public abstract class Cars
    {

        public virtual bool IsEcoFriendly(bool test)
        {
            return false;
        }

    }

    public class Audi : Cars, IGerman
    {
        public int Mileage()
        {
            return 5;
        }

        public override bool IsEcoFriendly(bool test)
        {
            return IsEcoFriendly();
        }

        public bool IsEcoFriendly()
        {
            return true;
        }
    }

    public class VolksWagen : Cars, IGerman
    {
        public int Mileage()
        {
            return 6;
        }

        public override bool IsEcoFriendly(bool test)
        {
            return true;
        }
    }

    public class BMW : Cars, IGerman
    {
        public int Mileage()
        {
            return 7;
        }

    }

    public class Honda : Cars
    {

    }

    public class Skoda : Cars
    {

    }
}
