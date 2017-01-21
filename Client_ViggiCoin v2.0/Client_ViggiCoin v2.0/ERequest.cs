using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_ViggiCoin_v2._0
{
    enum ERequest
    {
        UpdatePeers,
        SendPeersList,
        LastBlockNumber,
        UpdateBlockchain,
        DownloadMissingBlock,
        CheckBlockchainValidity
    }
}
