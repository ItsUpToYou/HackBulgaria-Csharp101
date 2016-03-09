using FastandFurious;

namespace FastAndFurious
{
    class Program
    {
        static void Main(string[] args)
        {
            VolksWagen vw = new VolksWagen();
            Cars c = vw;
            c.IsEcoFriendly(true);
            vw.IsEcoFriendly(false);
            vw.Mileage();
        }
    }
}
