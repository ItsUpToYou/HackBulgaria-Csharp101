using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaNetwork
{
    public class SocialNetwork : ISocialNetwork
    {

        Dictionary<Panda, List<Panda>> pandaFriends = new Dictionary<Panda, List<Panda>>();

        public void AddPanda(Panda panda)
        {
            if (!pandaFriends.ContainsKey(panda))
            {                           // not null!!!
                pandaFriends.Add(panda, new List<Panda>());
            }
            else
            {
                throw new PandaException("This panda exist in the friends network");
            }
        }

        public bool HasPanda(Panda panda)
        {
            if (this.pandaFriends.ContainsKey(panda))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MakeFriends(Panda panda1, Panda panda2)
        {
            if (pandaFriends.ContainsKey(panda1) && pandaFriends.ContainsKey(panda2) == false)
            {
                AddPanda(panda2);
            }
            else if (pandaFriends.ContainsKey(panda1) == false && pandaFriends.ContainsKey(panda2))
            {
                AddPanda(panda1);
            }
            else if (pandaFriends.ContainsKey(panda1) == false && pandaFriends.ContainsKey(panda2) == false)
            {
                AddPanda(panda1);
                AddPanda(panda2);
            }

            if (pandaFriends[panda1].Contains(panda2) == false)
            {
                pandaFriends[panda1].Add(panda2);
            }
            else
            {
                throw new PandaException("This panda exist");
            }

            if (pandaFriends[panda2].Contains(panda1) == false)
            {
                pandaFriends[panda2].Add(panda1);
            }
            else
            {
                throw new PandaException("Existing Panda");
            }
        }

        public bool AreFriends(Panda panda1, Panda panda2)
        {
            if (pandaFriends[panda1].Contains(panda2) && pandaFriends[panda2].Contains(panda1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Panda> FriendsOf(Panda panda)
        {
            if (this.HasPanda(panda))
            {
                return this.pandaFriends[panda].ToList();
            }
            else
            {
                throw new PandaException("Panda not existing in the SocialNetwork");
            }
        }

        public bool AreConnected(Panda panda1, Panda panda2)
        {
            if (!HasPanda(panda1) || !HasPanda(panda2))
            {
                return false;
            }

            var visited = new List<Panda>();
            var queue = new Queue<Panda>();

            queue.Enqueue(panda1);
            while (queue.Count > 0)
            {
                var pandaContainer = queue.Dequeue();
                visited.Add(pandaContainer);

                if (pandaFriends[pandaContainer].Contains(panda2))
                {
                    return true;
                }

                foreach (var neighbor in pandaFriends[pandaContainer])
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }
            return false;
        }

        public int ConnectionLevel(Panda panda1, Panda panda2)
        {
            var visited = new List<Panda>();
            var queue = new Queue<ConnectionLevelNode>();

            queue.Enqueue(new ConnectionLevelNode()
            {
                Node = panda1,
                Level = 0
            });


            while (queue.Count > 0)
            {
                var nodeLevel = queue.Dequeue();
                visited.Add(nodeLevel.Node);

                if (pandaFriends[nodeLevel.Node].Contains(panda2))
                {
                    return nodeLevel.Level + 1;
                }

                foreach (var neighbor in pandaFriends[nodeLevel.Node])
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(new ConnectionLevelNode()
                        {
                            Node = neighbor,
                            Level = nodeLevel.Level + 1
                        });
                    }
                }
            }
            return -1;
        }

        public int HowManyGenderInNetwork(int level, Panda panda, GenderType gender)
        {
            var visited = new List<Panda>();
            var queue = new Queue<ConnectionLevelNode>();
            int genderResult = 0;

            queue.Enqueue(new ConnectionLevelNode()
            {
                Node = panda,
                Level = 0
            });

            while (queue.Count > 0)
            {
                var pandaContainer = queue.Dequeue();
                visited.Add(pandaContainer.Node);

                if (pandaContainer.Level <= level)
                {
                    if (pandaContainer.Node.Gender == gender)
                    {
                        genderResult = genderResult + 1;
                    }
                }
                else
                {
                    break;
                }

                foreach (var neighbor in pandaFriends[pandaContainer.Node])
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(new ConnectionLevelNode()
                        {
                            Node = neighbor,
                            Level = pandaContainer.Level + 1
                        });
                    }
                }
            }
            return genderResult;
        }
    }
    public class ConnectionLevelNode
    {
        public Panda Node { get; set; }
        public int Level { get; set; }
    }
}
