using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PandaNetwork
{
    public class PandaSocialNetworkStorageProvider : IPandaSocialNetworkStorageProvider
    {
        private IFormatter formatter;

        public PandaSocialNetworkStorageProvider()
        {
            this.formatter = new BinaryFormatter();
        }

        public SocialNetwork Load(string fileName)
        {
            using (Stream stream = new FileStream(fileName + ".bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                SocialNetwork network = (SocialNetwork)formatter.Deserialize(stream);
                return network;
            }
        }

        public void Save(SocialNetwork network, string fileName)
        {
            using (Stream stream = new FileStream(fileName + ".bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, network);
            }
        }
    }
}
