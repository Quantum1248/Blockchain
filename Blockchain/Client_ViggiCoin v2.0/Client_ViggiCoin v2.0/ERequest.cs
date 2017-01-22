using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain
{
    enum ERequest
    {
        UpdatePeers,
        SendPeersList,
        LastBlockNumber,
        UpdateBlockchain,
        DownloadMissingBlock,
        LastValidBlock,
        DownloadMissingValidBlock,
        DownloadSixtyBlock,
    }
}
