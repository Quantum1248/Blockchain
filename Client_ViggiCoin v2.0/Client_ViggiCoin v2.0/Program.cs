using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_ViggiCoin_v2._0
{
    class Program
    {
        public static bool DEBUG = true;
        static void Main(string[] args)
        {

            //List<CPeer> lp = GenPeersList();
            List<CPeer> lp = new List<CPeer>();
            lp.Add(CPeer.CreatePeer("100.100.100.100", 1));

            CServer s = CServer.StartNewServer(lp);


        }
    }
}
