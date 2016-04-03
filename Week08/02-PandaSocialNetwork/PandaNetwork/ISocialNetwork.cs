using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaNetwork
{
    public interface ISocialNetwork
    {
        void AddPanda(Panda panda);
        bool HasPanda(Panda panda);

        void MakeFriends(Panda panda1,Panda panda2);
        bool AreFriends(Panda panda1, Panda panda2);
        List<Panda> FriendsOf(Panda panda);

        int ConnectionLevel(Panda panda1, Panda panda2);
        bool AreConnected(Panda p1, Panda p2);

        int HowManyGenderInNetwork(int level, Panda panda, GenderType gender);

    }
}
